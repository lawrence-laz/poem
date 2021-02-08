using AutoFixture.Xunit2;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Poem.Tests.System.Collections.Generic
{
    public class ForEachWithAggregatedExceptionsTests

    {
        [Theory]
        [InlineAutoData(0)]
        [InlineAutoData(1)]
        [InlineAutoData(2)]
        [InlineAutoData(3)]
        public void Calling_ForEachWithAggregatedException_visits_all_items_regardless_of_exceptions(int exceptionsToThrow, IEnumerable<object> expected)
        {
            // Arrange
            var actual = new List<object>();

            // Act
            try
            {
                expected.ForEachWithAggregatedExceptions(x =>
                {
                    actual.Add(x);
                    if (exceptionsToThrow-- > 0)
                    {
                        throw new Exception();
                    }
                });
            }
            catch (Exception) { }

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [InlineAutoData(1)]
        [InlineAutoData(2)]
        [InlineAutoData(3)]
        public void Calling_ForEachWithAggregatedException_throws_AggregateException_when_there_are_exceptions(int exceptionsToThrow, IEnumerable<object> enumerable)
        {
            // Arrange
            var expected = new List<Exception>();
            AggregateException actual = null;

            // Act
            try
            {
                enumerable.ForEachWithAggregatedExceptions(x =>
                {
                    if (exceptionsToThrow-- > 0)
                    {
                        expected.Add(new Exception());
                        throw expected.Last();
                    }
                });
            }
            catch(AggregateException e)
            {
                actual = e;
            }

            // Assert
            actual.Should().NotBeNull();
            actual.InnerExceptions.Should().BeEquivalentTo(expected);
        }

        [Theory, AutoData]
        public void Calling_ForEachWithAggregatedException_with_action_returns_same_enumerable(IEnumerable<object> expected, Action<object> action)
        {
            // Act
            var actual = expected.ForEachWithAggregatedExceptions(action);

            // Assert
            actual.Should().BeSameAs(expected);
        }

        [Theory, AutoData]
        public void Calling_ForEachWithAggregatedException_on_null_throws(Action<object> action)
        {
            // Arrange
            IEnumerable<object> enumerable = null;
            
            // Act & Assert
            enumerable.Invoking(x => x.ForEachWithAggregatedExceptions(action)).Should().Throw<ArgumentException>();
        }

        [Theory, AutoData]
        public void Calling_ForEachWithAggregatedException_with_null_throws(IEnumerable<object> enumerable)
        {
            // Arrange
            Action<object> action = null;

            // Act & Assert
            enumerable.Invoking(x => x.ForEachWithAggregatedExceptions(action)).Should().Throw<ArgumentException>();
        }
    }
}

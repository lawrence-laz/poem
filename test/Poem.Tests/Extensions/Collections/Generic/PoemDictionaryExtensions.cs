using FluentAssertions;
using System;
using System.Collections.Generic;
using Xunit;

namespace Poem.Tests.System.Collections.Generic
{
    public class PoemDictionaryExtensionsTests
    {
        [Fact]
        public void GetOrAdd_with_existing_key_returns_existing_value()
        {
            var key = new object();
            var expected = new object();
            var sut = new Dictionary<object, object>() { [key] = expected };

            var actual = sut.GetOrAdd(key, () => null);

            actual.Should().Be(expected);
        }

        [Fact]
        public void GetOrAdd_with_new_key_returns_new_value()
        {
            var newKey = new object();
            var sut = new Dictionary<object, object>();
            var factoryCallCount = 0;

            var actual = sut.GetOrAdd(newKey, () =>
            {
                ++factoryCallCount;
                return new object();
            });

            actual.Should().Be(sut[newKey]);
            factoryCallCount.Should().Be(1);
        }

        [Fact]
        public void GetOrAdd_with_null_dictionary_throws()
        {
            ((Dictionary<object, object>)null)
                .Invoking(x => x.GetOrAdd(new(), () => null))
                .Should()
                .Throw<ArgumentNullException>();
        }

        [Fact]
        public void GetOrAdd_with_null_factory_throws()
        {
            new Dictionary<object, object>()
                .Invoking(x => x.GetOrAdd(new(), null))
                .Should()
                .Throw<ArgumentNullException>();
        }

        [Fact]
        public void GetOrAdd_with_null_key_throws()
        {
            new Dictionary<object, object>()
                .Invoking(x => x.GetOrAdd(null, () => null))
                .Should()
                .Throw<ArgumentNullException>();
        }
    }
}

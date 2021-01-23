[![NuGet Version](https://img.shields.io/nuget/v/Poem?label=NuGet)](https://www.nuget.org/packages/Poem/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Poem?label=Downloads)](https://www.nuget.org/packages/Poem/)
[![Build](https://github.com/lawrence-laz/poem/workflows/Build/badge.svg)](https://github.com/lawrence-laz/poem/actions?query=workflow%3ABuild)

# Poem
*Poem* is a selection of useful extension methods that can be used to write fluent code. All *Poem* methods return one of the parameters to allow creating a chain of method calls.

# How to get started?
Download from [nuget.org](https://www.nuget.org/packages/Poem/):
```powershell
PS> Install-Package Poem
```

Start using it right away!
```csharp
Enumerable
    .Range(1, 4)
    .ForEach(Console.WriteLine); // <-- this comes from Poem!

// Output:
// 1
// 2
// 3
```

# Improvements

Do you have an idea for a fluent extension method that would fit this package? 

Great! 

You can either:

1. Fork this repo, add the method and raise a pull request. We will work together to get it merged! :wink:
2. Create an issue explaining the extension method, where and how it would be used. We will work together on designing it and then someone (probably I) will implement the method.

---
Icon by [smashicons](https://www.flaticon.com/authors/smashicons).
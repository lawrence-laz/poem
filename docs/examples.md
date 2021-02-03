# String methods

<table>
<tr>
<th> Before </th>
<th> After </th>
</tr>

<tr>
<td>

```csharp
if (string.IsNullOrEmpty(someString))
{
    ...
}
```

</td>

<td>

```csharp
if (someString.IsNullOrEmpty())
{
    ...
}
```

</td>
</tr>

<tr>
<td>

```csharp
if (string.IsNullOrWhiteSpace(someString))
{
    ...
}
```

</td>

<td>

```csharp
if (someString.IsNullOrWhiteSpace())
{
    ...
}
```

</td>
</tr>

<tr>
<td>

```csharp
var names = customers.Select(x => x.Name);
string.Join(", ", names);
// "Marry, John, Peter"
```

</td>

<td>

```csharp
customers
    .Select(x => x.Name)
    .Join(", ");
// "Marry, John, Peter"
```

</td>
</tr>

<tr>
<td>

```csharp
"FooBarBar".TrimEnd('B');
// Can't trim string 🤷‍♂️
```

</td>

<td>

```csharp
"FooBarBar".TrimEnd("Bar");
// Foo
```

</td>
</tr>

</table>

# Float methods

<table>
<tr>
<th> Before </th>
<th> After </th>
</tr>

<tr>
<td>

```csharp
var numberString = "length: 0.5".Split(' ')[1];
float.Parse(numberString);
// 0.5f
```

</td>

<td>

```csharp
"length: 0.5"
    .Split(' ')[1]
    .ParseFloat();
// 0.5f
```

</td>
</tr>

</table>

# Convert methods

<table>
<tr>
<th> Before </th>
<th> After </th>
</tr>

<tr>
<td>

```csharp
var bytes = File.ReadAllBytes("someFile.data");
Convert.ToBase64String(bytes);
// SGVsbG8gdGhlcmUg8J+YivCfkY0=
```

</td>

<td>

```csharp
File.ReadAllBytes("someFile.data");
    .ToBase64String();
// SGVsbG8gdGhlcmUg8J+YivCfkY0=
```

</td>
</tr>

</table>

# Enumerable methods

<table>
<tr>
<th> Before </th>
<th> After </th>
</tr>

<tr>
<td>

```csharp
var adultNames = customers
    .Where(x => x.Age >= 18)
    .Select(x => x.Name);
foreach (var name in adultNames)
{
    Console.WriteLine($"Customer: {name}")
}
// Marry
// John
```

</td>

<td>

```csharp
customers
    .Where(x => x.Age >= 18)
    .Select(x => x.Name)
    .ForEach(x => Console.WriteLine(x));
// Marry
// John
```

</td>
</tr>

</table>
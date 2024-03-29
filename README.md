# CalculateArraySum for <0-9>
``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.829 (1803/April2018Update/Redstone4)
Intel Core i7-8850H CPU 2.60GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview7-012821
  [Host]     : .NET Core 3.0.0-preview7-27912-14 (CoreCLR 4.700.19.32702, CoreFX 4.700.19.36209), 64bit RyuJIT
  DefaultJob : .NET Core 3.0.0-preview7-27912-14 (CoreCLR 4.700.19.32702, CoreFX 4.700.19.36209), 64bit RyuJIT


```
|      Method |     Mean |     Error |    StdDev | Ratio | RatioSD |
|------------ |---------:|----------:|----------:|------:|--------:|
|    WithSpan | 16.28 ns | 0.3585 ns | 0.5990 ns |  1.00 |    0.00 |
| WithoutSpan | 14.34 ns | 0.3110 ns | 0.2597 ns |  0.87 |    0.04 |


# SelectAndUpdateArrayItem for 10 Items
``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.829 (1803/April2018Update/Redstone4)
Intel Core i7-8850H CPU 2.60GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview7-012821
  [Host]     : .NET Core 3.0.0-preview7-27912-14 (CoreCLR 4.700.19.32702, CoreFX 4.700.19.36209), 64bit RyuJIT
  DefaultJob : .NET Core 3.0.0-preview7-27912-14 (CoreCLR 4.700.19.32702, CoreFX 4.700.19.36209), 64bit RyuJIT


```
|      Method |      Mean |     Error |    StdDev | Ratio | RatioSD |
|------------ |----------:|----------:|----------:|------:|--------:|
|    WithSpan | 10.717 ns | 0.3671 ns | 0.4370 ns |  1.00 |    0.00 |
| WithoutSpan |  8.474 ns | 0.1594 ns | 0.1491 ns |  0.78 |    0.03 |

# SerializeObject With System.Text.Json vs Newtonsoft.Json
``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.829 (1803/April2018Update/Redstone4)
Intel Core i7-8850H CPU 2.60GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview7-012821
  [Host]     : .NET Core 3.0.0-preview7-27912-14 (CoreCLR 4.700.19.32702, CoreFX 4.700.19.36209), 64bit RyuJIT
  DefaultJob : .NET Core 3.0.0-preview7-27912-14 (CoreCLR 4.700.19.32702, CoreFX 4.700.19.36209), 64bit RyuJIT


```
|         Method |     Mean |     Error |    StdDev |   Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------- |---------:|----------:|----------:|---------:|------:|--------:|-------:|------:|------:|----------:|
| SystemTextJson | 1.225 us | 0.0243 us | 0.0480 us | 1.206 us |  1.00 |    0.00 | 0.1106 |     - |     - |     527 B |
| NewtonsoftJson | 1.346 us | 0.0258 us | 0.0253 us | 1.332 us |  1.10 |    0.04 | 0.3338 |     - |     - |    1575 B |
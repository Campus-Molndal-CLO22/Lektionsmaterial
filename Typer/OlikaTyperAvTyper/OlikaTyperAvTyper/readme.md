# Typer i .net

Null är något vi inte behövt tänka på (annat än vid hantering av objekt) innan, men nu kan alla typer bli null. Detta gör att vi måste bredda vårt tänkande lite.

Man kan få null exempelvis
+ När en databas saknar information returnerar den null
+ När ett API saknar fält eller information får vi null tillbaka
+ När vi kopplingen till routern bryts kan vi få null
+ När datan är felstrukturerad i en datafil...

med mera...

## Nullable
Nullable taggen i projekt gör att variabler som annars inte kan vara null, nu kan hantera null genom ? markering.
```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net6.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>

    <Nullable>enable</Nullable>

  </PropertyGroup>

</Project>
```
### Exempel
```csharp
bool isNull = null; // Error
bool? isNull = null; // Ok
```

## 
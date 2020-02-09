# Side-by-side error for .NET core is incorrect

![An assembly with the same simple name 'Dependency' has already been imported. Try removing one of the references (e.g. 'C:\Users\Aida\Source\repos\DotNetRuntimeLoadingDifference\WeakNamedDependencyV1\bin\Debug\netstandard2.0\DependencyV1.dll') or sign them to enable side-by-side.](https://github.com/psibernetic/DotNetRuntimeLoadingDifference/raw/master/sign-to-enable-side-by-side.PNG)

When one of the assemblies is strong-named, the error goes away, but the runtime will load the latest version on .NET Core 3.1. On .NET 4.8 the runtime will try to find both versions and fail locating one of them (FileNotFoundException).

If .NET Core doesn't support side-by-side, then this error should state that instead of hinting it is possible.

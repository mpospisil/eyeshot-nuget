# eyeshot-nuget

How to create nuget from a convention-based working directory
https://learn.microsoft.com/en-us/nuget/create-packages/creating-a-package#from-a-convention-based-working-directory


## Create a package using the nuget.exe CLI

inastall [nuget.exe](https://www.nuget.org/downloads) on your PC and run 

```
nuget.exe pack IdeaStatiCa.devDept.nuspec -Version 23.0.1.0 -Properties "PackageVersion=23.0.1.0"
```

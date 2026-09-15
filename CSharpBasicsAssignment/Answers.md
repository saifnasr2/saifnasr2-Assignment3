# content of csproj
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>

# Do #region / #endregion change the compiled output? Why might you still use them?
Ans: no. #region and #endregion do not change the compiled output
    you might still use them to organize large sections of code

# When would you reach for /// XML doc comments instead of a plain //?
Ans: use /// XML documentation comments for document a public class, method, property, or field
     use // for normal notes or explanations inside your code

# Why does C# have no true global variables, and what's the closest equivalent?
Ans: because variables must belong to a type or a specific scope rather than existing   independently at the program level
     the closest equivalent is a static field inside a class

# leetcode
https://leetcode.com/problems/single-number/submissions/2143091411
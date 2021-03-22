# BrendensStoreSln
This is a build of the demo MVC app from Adam Freeman's ASP.NET Core 3 textbook. This is for building fundamentals.

## Build Script

    dotnet new globaljson --sdk-version 5.0.103 --output BrendensStoreSln/Products
    dotnet new web --no-https --output BrendensStoreSln/Products --framework net5.0
    dotnet new sln -o BrendensStoreSln
    dotnet sln BrendensStoreSln add BrendensStoreSln/Products 
    dotnet new xunit -o BrendensStoreSln/Products.Tests --framework net5.0
    dotnet sln BrendensStoreSln add BrendensStoreSln/Products.Tests 
    dotnet add BrendensStoreSln/Products.Tests reference BrendensStoreSln/Products

# BrendensStoreSln
This is a build of the demo MVC app from Adam Freeman's ASP.NET Core 3 textbook. This is for building fundamentals.

## Link to the Book
[Book Link](https://www.apress.com/gp/book/9781484254394)

## Build Script

    dotnet new globaljson --sdk-version 5.0.103 --output BrendensStoreSln/Products
    dotnet new web --no-https --output BrendensStoreSln/Products --framework net5.0
    dotnet new sln -o BrendensStoreSln
    dotnet sln BrendensStoreSln add BrendensStoreSln/Products 
    dotnet new xunit -o BrendensStoreSln/Products.Tests --framework net5.0
    dotnet sln BrendensStoreSln add BrendensStoreSln/Products.Tests 
    dotnet add BrendensStoreSln/Products.Tests reference BrendensStoreSln/Products
    

## Progress Pictures 

![one](https://github.com/BrendenWisnewski/BrendensStoreSln/blob/master/images/SportStore%201.jpg)


![two](https://github.com/BrendenWisnewski/BrendensStoreSln/blob/master/images/SportStore2.jpg)


![three](https://github.com/BrendenWisnewski/BrendensStoreSln/blob/master/images/SportStore%20ProductPage%202.jpg)


![final](https://github.com/BrendenWisnewski/BrendensStoreSln/blob/master/images/SportStore%20Final.jpg)

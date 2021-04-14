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

### Seed Data
![two](https://github.com/BrendenWisnewski/BrendensStoreSln/blob/master/images/SportStore2.jpg)

### Page Links
![three](https://github.com/BrendenWisnewski/BrendensStoreSln/blob/master/images/SportStore%20ProductPage%202.jpg)

### Add Bootstrap
![final](https://github.com/BrendenWisnewski/BrendensStoreSln/blob/master/images/SportStore%20Final.jpg)


## Navigation and Cart

### Highlighting the Category
![highlight](https://github.com/BrendenWisnewski/BrendensStoreSln/blob/master/images/Lab%202A%20first%20Screenshot.jpg)

### The Cart
![Cart](https://github.com/BrendenWisnewski/BrendensStoreSln/blob/master/images/Lab%202A%20Third%20Screenshot.jpg)

### Tests
![test](https://github.com/BrendenWisnewski/BrendensStoreSln/blob/master/images/Passing%20tests.jpg)


## Checkout

### Checkout Button
![checkout](https://github.com/BrendenWisnewski/BrendensStoreSln/blob/master/images/Lab%203A%20screen%201.jpg)

### Checkout Screen
![completed](https://github.com/BrendenWisnewski/BrendensStoreSln/blob/master/images/Lab%203A%20screen%202.jpg)

### Checkout Complete
![yay](https://github.com/BrendenWisnewski/BrendensStoreSln/blob/master/images/Lab%203A%20screen%203.jpg)


## Blazor Pages

### Initial Page
![start](https://github.com/BrendenWisnewski/BrendensStoreSln/blob/master/images/lab%204a%20first.jpg)

### Display Products
![prodcuts](https://github.com/BrendenWisnewski/BrendensStoreSln/blob/master/images/lab%204a%20second.jpg)

### Details of Each Product
![deets](https://github.com/BrendenWisnewski/BrendensStoreSln/blob/master/images/lab%204a%20third.jpg)

### Adding in the Delete Button
1[delete](https://github.com/BrendenWisnewski/BrendensStoreSln/blob/master/images/lab%204a%20fourth.jpg)

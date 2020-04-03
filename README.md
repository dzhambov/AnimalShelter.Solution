# Animal Shelter API Project - April 3, 2020

### _Hristo Dzhambov_

## _Description_

_This is an API project for a local animal shelter. The API will list all vailable animals in the shelter or the user can also search an animal by Id, name, type, age or gender._

## _Behavior Driven Development Specifications_

| Specification             | Input 	|     Output      |
|-------------------------	|-------	|----------------	|
|A user enters an animal search | GET "http://localhost:5000/api/animals"   | User sees a list of all animals in the shelter |
|A user enters an animal search by details | GET "http://localhost:5000/api/animals?name=Lulu"   | User sees the animal with name Lulu |
|A user is able to post animal | POST "http://localhost:5000/api/animals/3"   | User sees the animal under Id #3 |
|A user is able to put animal | PUT "http://localhost:5000/api/animals/3"   | User sees the animal under Id #3 |
|A user is able to delete animal | DELETE "http://localhost:5000/api/animals/3"   | User deletes animal under Id #2 and it can't see it any more |





## _Setup/Installation Requirements_

Clone this repository via Terminal using the following commands:
* ```$ cd desktop```
* ```$ git clone https://github.com/dzhambov/AnimalShelter.Solution```
* ```$ cd AnimalShelter.Solution```

To run the program, first navigate to the AnimalShelter production folder by typing the following into the terminal: 

* ```$ cd AnimalShelter```

Then restore dependencies by typing:
* ```$ dotnet restore```

Then update your MySQL database by typing: 
* ```$ dotnef ef database update```

You can now run the program by typing:
* ```$ dotnet run```

## _Known Bugs_

_No known bugs at this time._

## _Support and contact details_

_Have a bug or an issue with this application? [Open a new issue](https://github.com/dzhambov/PierreBakery/issues) here on GitHub._

## _Technologies Used_

This program was created with:

* C#
* ASP.NET Core MVC 2.2
* Entity Framework
* Identity 
* MySQL
* MySQL Workbench 
* Postman

## _License_

This code is licensed under MIT permissive free software license

Copyright &copy; 2020 Hristo Dzhambov
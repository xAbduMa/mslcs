// Declare variables using an explicit type
string favoriteFood = "pizza";
int slicesEaten = 3;
bool isHungry = false;

// Declare a variable using var
var favoriteColor = "blue";

// Display the values of your variables
Console.WriteLine($"Favorite food: {favoriteFood}");
Console.WriteLine($"Slices eaten: {slicesEaten}");
Console.WriteLine($"Is hungry: {isHungry}");
Console.WriteLine($"Favorite color: {favoriteColor}");

// Reassign a variable to a new value
Console.WriteLine($"Slices eaten before dessert: {slicesEaten}");
slicesEaten = 5;
Console.WriteLine($"Slices eaten after dessert: {slicesEaten}");

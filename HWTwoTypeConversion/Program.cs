

//Get User's age
Console.WriteLine("Hello Welcome to the age app");
Console.Write("What is your age: ");
string? ageText = Console.ReadLine();

bool isValidInt = int.TryParse(ageText, out int age);
//user's age + 25
int oldAge  = age + 25;

//user's age halved
double halfAge = age / 2.0;

//respond in natural language

Console.WriteLine($"You will be {oldAge} in 25 years, half a life ago you were {halfAge}");
Console.WriteLine($"Hope to see you when you're {oldAge}");
Console.ReadLine();
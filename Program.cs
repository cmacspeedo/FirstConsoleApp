// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

// TASK 1
Console.WriteLine("What is your name?");
string name = Console.ReadLine();

Console.WriteLine($"Hi {name}, Where are you from?");
string location = Console.ReadLine();

Console.WriteLine($"I have never been to {location}. I bet it is nice. Press any key to continue...");


// TASK 2
Console.WriteLine("Please input a Width:");
double width = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please input a Height:");
double height = Convert.ToDouble(Console.ReadLine());

double wood = 2*(width + height) / 3.25;
//if (double.TryParse(wood, out width) == false)
//{
//    Console.WriteLine("Not a double");
//    return;
//}

double glass = 2 * height * width;
//if (double.TryParse(glass, out width) == false)
//{
//    Console.WriteLine("Not a double");
//    return;
//}


Console.WriteLine($"The length of wood is {wood} feet.");
Console.WriteLine($"The area of glass is {glass} square meters.");


// TASK 3
Console.WriteLine("What is today's date? mm/dd/yyyy");
DateTime inputDate = DateTime.Parse(Console.ReadLine());

Console.WriteLine($"You have entered today's date as {inputDate}.");
int currentYear = DateTime.Now.Year;

DateTime xmas = new DateTime(currentYear, 12, 25);
double daysUntilChristmas = xmas.Subtract (inputDate).TotalDays;
Console.WriteLine($"There are {daysUntilChristmas} days until Christmas.");

Console.WriteLine("Press any key to Continue...");












public class Person
{
    public string name;
    public string location;
}

public class Measure
{
    static Measure() { }

    public double width;
    public double height;
    public double woodLength;
    public double glassArea;
}



// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// exercise 5
Console.WriteLine("Good Day");


// exercise 6
Console.WriteLine("Elroy Kanye");


// exercise 7
for (int i = 0; i <= 2; i++)
{
    if(i == 0)
    {
        Console.WriteLine("1");
        continue;
    }
    var zeros = "";
    for (int j = 1; j <= i; j++) zeros += "0";
    Console.WriteLine("1" + zeros + "1");
}


// exercise 8
var now = DateTime.Now;
var date = now.ToShortDateString();
var time = now.ToShortTimeString();
Console.WriteLine("Current Date: " + date);
Console.WriteLine("Current Time: " + time);


// exercise 9
Console.WriteLine(Math.Sqrt(12345));


// exercise 10
for (int i = 2; i <= 100; i++)
{
    Console.WriteLine(i % 2 == 0 ? i : i * -1);
}


// exercise 11
Console.WriteLine("Enter age");
var age = Console.ReadLine();
Console.WriteLine("Age in 10 years = " + Int16.Parse(age) + 10);
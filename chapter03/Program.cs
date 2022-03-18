// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int num1 = 8;
// 1.  Write an expression that checks whether an integer is odd or even.
bool isEven = num1 % 2 == 0;

// 2. Write a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder.
bool isEx2Valid = num1 % 5 == 0 && num1 % 7 == 0;

// 3. Write an expression that looks for a given integer if its third digit (right to left) is 7.
bool isEx3Valid = num1.ToString().Length > 3 ? num1.ToString().ToArray()[2] == '7' : false;

// 4. Write an expression that checks whether the third bit in a given integer is 1 or 0.
bool isEx4Valid = (num1 & 8) == 0;

//5. Write an expression that calculates the area of a trapezoid by given sides a, b and height h.
float a = 2.4F, b = 4, h = 5.4F;
double S = (a + b) * h / 2;

/*

*/
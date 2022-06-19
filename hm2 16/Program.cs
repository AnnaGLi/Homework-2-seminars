Console.WriteLine ("To check if one of the numbers is a square of another one");
Console.WriteLine ("input the first number: ");
int firstNumber = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("input second number: ");
int secondNumber =Convert.ToInt32 (Console.ReadLine());
int X = firstNumber*firstNumber;
int Y = secondNumber*secondNumber;

if ((X == secondNumber) || (Y == firstNumber))
{
    Console.WriteLine ("yes, one of the numbers is a square of another");
}
else {
    Console.WriteLine ("non of those numbers is the square of another");
}
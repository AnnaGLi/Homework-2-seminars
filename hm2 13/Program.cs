Console.Write ("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

string numberX = Convert.ToString(number);
if (numberX.Length > 2)
{
    Console.WriteLine ("the third digit is: " + numberX[2]);
}
else
{
    Console.WriteLine("there is no third digit");
}


Console.Write ("Input three digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if ((number <1000) && (number >100))
{
string X = Convert.ToString (number);
if (number > 2)
{
    Console.WriteLine ("second number is: " +X [1]);
} 
}




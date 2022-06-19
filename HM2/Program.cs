// Exercise 15
Console.Write ("Input day of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine ());
void checkingDay (int dayNumber) {
    if (dayNumber == 6 || dayNumber == 7) {
        Console.WriteLine ("that is weekend");
    }
    else if (dayNumber < 1 || dayNumber > 7) {
        Console.WriteLine ("That is not a valid day of a week");
    }
    else Console.WriteLine ("That is a working day");
}
checkingDay (dayNumber);


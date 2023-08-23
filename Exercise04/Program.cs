Console.WriteLine($"Hello");
Console.WriteLine($"In this space you will know if a year is a leap year or not");
do
{
    Console.WriteLine($"=============");
    Console.WriteLine($"Please enter the year and press enter");
    int year = Convert.ToInt32(Console.ReadLine());
    
    DateTime dateTime = DateTime.Now;
    string aux;
    if (dateTime.Year == year) aux = "is";
    else if (dateTime.Year > year) aux = "was";
    else aux = "will";
    
    if (IsLeapYear(year))
    {
        Console.WriteLine($"The year {year} {aux} a leap year");
    }
    else
    {
        Console.WriteLine($"The year {year} {aux} not a leap year");
    }
} while (true);

static bool IsLeapYear(int year)
{
    if (year % 4 == 0)
    {
        if (year % 100 == 0)
        {
            if (year % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return true;
        }
    }
    else
    {
        return false;
    }
}

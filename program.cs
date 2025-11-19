class Course01
{
    public void CalculateAge(int YearOfBirth)
    {
        int TodayYear = DateTime.Now.Year;
        int CurrentYear = TodayYear - YearOfBirth;

        if (CurrentYear >= 18)
        {
            Console.WriteLine($"The User has {CurrentYear} years old, is of legal age");
        }
        else
        {
            Console.WriteLine($"The User has {CurrentYear} years old, is a minor");
        }
    }

    public void Donations(decimal ValueDonation, bool Anonimous, char Account)
    {
        if (Account != 'P' && Account != 'C')
        {
            Console.WriteLine("Invalid account type");
            return;
        }

        if (ValueDonation <= 0)
        {
            Console.WriteLine("The donation cannot be completed, value incompatible!");
        }
        else
        {
            Console.WriteLine($"Amount received: ${ValueDonation}");
            Console.WriteLine($"Anonymous donation: {Anonimous}");
            Console.WriteLine($"Account type: {Account}");
        }
    }

    public void ConversionMiles(double Miles)
    {
        double Kilometrers = 1.60934;
        double Consersor = Miles * Kilometrers;

        Console.WriteLine($"{Miles} Miles are equivalent to {Consersor} kilometrers");
    }

    public void ConversionTime(int MinutesToHours)
    {
        int Hours = MinutesToHours / 60;
        int Minutes = MinutesToHours % 60;

        Console.WriteLine($"Time is {Hours} hours and {Minutes} minutes");
    }

    public void AreaConverter(double Width, double Length)
    {
        double Area = Width * Length;

        Console.WriteLine($"The area of the land is {Area:F2} square meters.");
    }

    public void AverageNote(double Note1, double Note2, double Note3)
    {
        List<double> Notes = new List<double>();
        Notes.Add(Note1);
        Notes.Add(Note2);
        Notes.Add(Note3);
        double StudentAverage = Notes.Average();

        Console.WriteLine($"The average grade is: {StudentAverage:F1}");
    }

    public void TruckForCargo(decimal Cargo)
    {
        int vehicles = (int)Cargo;

        Console.WriteLine($"Vehicles necessary: {vehicles}");
    }     

    public void LivesControl(int initial)
    {
        int changes = 3;
        string password = "OK";

        Console.WriteLine($"Welcome you has {changes} changes");

        do
        {
            string userChoose = Console.ReadLine();

            if (userChoose == password)
            {
                Console.WriteLine("Great");
                initial++;
                changes--;
                Console.WriteLine($"You has {changes} changes");
            } else
            {
                Console.WriteLine("Oh no!");
                initial--;
                changes--;
                Console.WriteLine($"You has {changes} changes");
            }
            
        }
        while (changes > 0);

        Console.WriteLine($"Final Live: {initial}");
    }

    public void SalaryIncrease(decimal salary, decimal percentage)
    {
        decimal newSalary = ( salary + (salary * (percentage / 100)));

        Console.WriteLine($"New salary is: ${newSalary:F2}");
    }

    public void CircunferenceCalc(double radius)
    {
        decimal PI = 3.14159M;
        decimal circleArea = PI * (decimal)radius * (decimal)radius;
        decimal circlePerimeter = 2 * PI * (decimal)raduis;

        Console.WriteLine($"Radius: {radius:F2}");
        Console.WriteLine($"Circle Area: {circleArea:F2}");
        Console.WriteLine($"Circle Perimeter: {circlePerimeter:F2}");
    }
}

class Course02
{

}
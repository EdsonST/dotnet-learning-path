using System.Net.Security;

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
        decimal circlePerimeter = 2 * PI * (decimal)radius;

        Console.WriteLine($"Radius: {radius:F2}");
        Console.WriteLine($"Circle Area: {circleArea:F2}");
        Console.WriteLine($"Circle Perimeter: {circlePerimeter:F2}");
    }
}

class Course02
{
    public void BalanceAnalysis(decimal balance)
    {
        if (balance > 0.0m) 
        {
            Console.WriteLine($"Your ballance is positive !");
        } else if (balance == 0.0m)
        {
            Console.WriteLine($"Your ballance is zero");
        } else
        {
            Console.WriteLine($"Your ballance is negative !");
        }
    }

    public void ProductClassification()
    {
        Console.Write("Enther the product code (1 or 2): ");
        int code = int.Parse(Console.ReadLine());

        if (code == 1)
        {
            Console.WriteLine("Product Perishable");
        } else if (code == 2)
        {
            Console.WriteLine("Product Non-perishable");
        } else
        {
            Console.WriteLine("Invalid Code");
        }
    }

    public void StuentAvaliation()
    {
        Console.WriteLine("Please provide the student's final grade:");
        double note = double.Parse(Console.ReadLine());

        switch (note)
        {
            case >= 9: Console.WriteLine("A");
                break;
            case >= 7: Console.WriteLine("B");
                break;
            case >= 5: Console.WriteLine("C");
                break;
            default: Console.WriteLine("D");
                break;
        }
    }

    public void CredentialValidation()
    {
        Console.WriteLine("Enter your password: ");
        int password = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your access level: ");
        int level = int.Parse(Console.ReadLine());

        int corretpass = 42;

        if (password == corretpass && level >= 5)
        {
            Console.WriteLine("Access released");
        } else
        {
            Console.WriteLine("Access denied");
        }

    }

    public void EtharialClassification()
    {
        Console.WriteLine("Enter the age:");
        int age = int.Parse(Console.ReadLine());

        switch (age)
        {
            case >= 60: Console.WriteLine("Classification: Elderly");
                break;
            case >= 18: Console.WriteLine("Classification: Adult");
                break;
            case >= 13: Console.WriteLine("Classification: Teenager");
                break;
            default: Console.WriteLine("Classification: Children");
                break;
        }
    }

    public void Calculator()
    {
        Console.WriteLine("Enter the first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the operator (+, -, *, /):");
        string operatorMode = Console.ReadLine();

        switch (operatorMode)
        {
            case "+": Console.WriteLine($"Result: {firstNumber + secondNumber}");
                break;
            case "-": Console.WriteLine($"Result: {firstNumber - secondNumber}");
                break;
            case "*": Console.WriteLine($"Result: {firstNumber * secondNumber}");
                break;
            case "/": Console.WriteLine($"Result: {firstNumber / secondNumber}");
                break;
            default:Console.WriteLine("Operator not found");
                break;
        }
    }

    public void Greetings()
    {
        Console.WriteLine("1 - Morning\r\n2 - Afternoon\r\n3 - Evening\n\nWhat time of day is it now?");
        int chooseTime = int.Parse(Console.ReadLine());

        Console.WriteLine("What's your name?");
        string name = Console.ReadLine();

        switch (chooseTime)
        {
            case 1: Console.WriteLine($"Good Morning, {name}.");
                break;
            case 2: Console.WriteLine($"Good Afternoon, {name}.");
                break;
            case 3: Console.WriteLine($"Good Evening, {name}.");
                break;
            default: Console.WriteLine("Option Invalid");
                break;
        }

    }

    public void CodeRewards()
    {
        Console.WriteLine("Enter the reward code (DOUBLE, HEAL, GOLD, SPECIAL)");
        string rewardCode = Console.ReadLine();

        string earned;

        earned = rewardCode switch
        {
            "DOUBLE" => "Earn 2x EXP for 1 hour unlocked !",
            "HEAL" => "Healing potion unlocked !",
            "GOLD" => "1000 gold coins unlocked !",
            "SPECIAL" => "Legendary item unlocked !",
            _ => "Reward unavailable"
        };

        Console.WriteLine(earned);
    }

    public void BookClassification()
    {
       Console.WriteLine("Enter the book code:");
       string codeBook = Console.ReadLine();

       char typeShelf = char.ToUpper(codeBook[0]);

       switch (typeShelf)
        {
            case '1': Console.WriteLine("Science Fiction");
                break;
            case '2': Console.WriteLine("Classical Literature");
                break;
            case '3': Console.WriteLine("Fantasy");
                break;
            case '4': Console.WriteLine("Romance");
                break;
            case '5': Console.WriteLine("Suspense/Mystery");
                break;
            case '6': Console.WriteLine("Non-Fiction");
                break;
            case '7': Console.WriteLine("Biography/Memoirs");
                break;
            case '8': Console.WriteLine("Distopia");
                break;
            case '9': Console.WriteLine("Children and Youth");
                break;
            default: Console.WriteLine("Invalid code"); 
                break;
        }
    }

    public void AutenticationAcess()
    {
        Console.WriteLine("Sistema de Autenticação\r\n-----------------------");
        Console.Write("Digite seu nome de usuário: ");
        string userName = Console.ReadLine();

        string admin = "Edson";

        if (userName == admin)
        {
            Console.WriteLine($"Bem vindo, {userName}.");
        }
        else
        {
            Console.WriteLine($"\nUsuário não cadastrado.\n");
            Console.WriteLine("Opções disponíveis:\r\n[1] Cadastrar novo usuário\r\n[2] Acessar como convidado\r\n[3] Sair");
            int newAccess = int.Parse(Console.ReadLine());

            string newUser;

            switch (newAccess)
            {
                case 1:
                    Console.WriteLine("Informe o nome do novo usuário:");
                    newUser = Console.ReadLine();
                    Console.WriteLine($"Novo usuário {newUser} cadastrado com sucesso!");
                    break;
                case 2: Console.WriteLine("Acesso concedido como convidado.");
                    break;
                default: break;
            }
        }  

    }
}
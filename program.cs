class Course01
{
    public void CalculateAge(int YearOfBirth)
    {
        int TodayYear = DateTime.Now.Year;
        int CurrentYear = TodayYear - YearOfBirth;

        if (CurrentYear >= 18)
        {
            Console.WriteLine($"The User has {CurrentYear} years old, is of legal age");
        } else
        {
            Console.WriteLine($"The User has {CurrentYear} years old, is a minor");
        }
      
    }

    public void Donations(decimal ValueDonation, bool Anonimous, char Account )
    {

        if (Account != 'P' &&  Account != 'C')
        {
            Console.WriteLine("Invalid account type");
            return;
        }
        
        if (ValueDonation <= 0)
        {
            Console.WriteLine("The donation cannot be completed, value incompatible!");
        } else
        {
            Console.WriteLine($"Amount received: ${ValueDonation}");
            Console.WriteLine($"Anonymous donation: {Anonimous}");
            Console.WriteLine($"Account type: {Account}");
        }
    }
}
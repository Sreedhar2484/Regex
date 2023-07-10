using RegexExample;
using System.Text.RegularExpressions;

internal class Program
{

    public static bool IsValidName(string name)
    {
        
        string pattern = @"^[A-Za-z]{2,}$";

        
        Regex regex = new Regex(pattern);

       
        Match match = regex.Match(name);


        return match.Success;
    }
    public static bool IsValidMobileNumber(string phoneNumber)
    {
        
        string pattern = "^[6-9]{1}[0-9]{9}$";


        Regex regex = new Regex(pattern);

        
        Match match = regex.Match(phoneNumber);

        
        return match.Success;
    }
    public static bool IsValidEmailAddress(string emailAddress)
    {
        
        string pattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";

        
        Regex regex = new Regex(pattern);

        
        Match match = regex.Match(emailAddress);

        
        return match.Success;
    }
    public static bool IsValidPassword(string password)
    {
        
        string pattern = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@#$%^&+=])[A-Za-z\d@#$%^&+=]{8,}$";


        Regex regex = new Regex(pattern);

        
        Match match = regex.Match(password);

        
        return match.Success;
    }


    private static void Main(string[] args)



    {


        Console.WriteLine("Enter your first name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter your last name:");
        string lastName = Console.ReadLine();

        if (IsValidName(firstName) && IsValidName(lastName))
        {
            Console.WriteLine("Valid first name and last name.");
        }
        else
        {
            Console.WriteLine("Invalid first name or last name.");
        }

        Console.ReadLine();

        Console.WriteLine("Enter a mobile number:");
        string phoneNumber = Console.ReadLine();

        Regex1 myMobileNum = new Regex1();

        if (!IsValidMobileNumber(phoneNumber))
        {
            Console.WriteLine("Invalid mobile number.");
        }
        else
        {
            Console.WriteLine("Valid mobile number.");
        }


        Console.WriteLine("Enter an email address:");
        string emailAddress = Console.ReadLine();

        if (IsValidEmailAddress(emailAddress))
        {
            Console.WriteLine("Valid email address.");
        }
        else
        {
            Console.WriteLine("Invalid email address.");
        }

        Console.ReadLine();


        Console.WriteLine("Enter a password:");
        string password = Console.ReadLine();

        if (IsValidPassword(password))
        {
            Console.WriteLine("Valid password.");
        }
        else
        {
            Console.WriteLine("Invalid password.");
        }

        Console.ReadLine();
    }
}
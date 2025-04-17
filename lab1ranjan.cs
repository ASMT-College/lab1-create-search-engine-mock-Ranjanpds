
using System;

class Program
{
    static void Main()
    {
        // Step 1: Define a variable fullName and assign some name
        string fullName = "Yogesh Gurung";
        Console.WriteLine(fullName);
        
        // Step 2: Convert fullName to uppercase and print in format "Hello, [YourName] Ji!"
        string cFullName = fullName.ToUpper();
        Console.WriteLine($"Hello, {cFullName} Ji!");

        // Step 3: Get fullName from user
        Console.Write("Enter your full name: ");
        fullName = Console.ReadLine();
        
        // Step 4: Get Date of Birth from user and display formatted date
        Console.Write("Enter your Date of Birth (YYYY/MM/DD): ");
        string dobInput = Console.ReadLine();
        DateTime dob;
        if (DateTime.TryParse(dobInput, out dob))
        {
            Console.WriteLine($"Hello, {fullName} Ji!");
            Console.WriteLine($"Your DOB: {dob:dddd, dd MMMM yyyy}");
        }
        else
        {
            Console.WriteLine("Invalid date format. Please enter in YYYY/MM/DD format.");
            return;
        }

        // Step 5: Calculate and display age in years, months, weeks, and days
        DateTime today = DateTime.Now;
        TimeSpan ageSpan = today - dob;
        int totalDays = (int)ageSpan.TotalDays;
        int years = totalDays / 365;
        int remainingDays = totalDays % 365;
        int months = remainingDays / 30;
        int weeks = (remainingDays % 30) / 7;
        int days = (remainingDays % 30) % 7;
        
        Console.WriteLine($"Age as of now: {years} Years {months} Months {weeks} Weeks {days} Days");
    }
}

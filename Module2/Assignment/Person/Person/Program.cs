using System;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {

            //Access these things from Console Application in the Main Function. Accept this data for 5 person and display the same.
            //Means create an object Array of 5 size and accept these details and display these details in tabular format.


            PersonDetails[] person = new PersonDetails[5];

            for(int p = 0; p<5; p++)
            {
                Console.WriteLine($"Enter Person {p+1} Details : \n");
                Console.WriteLine("First Name: ");
                var FirstName = Console.ReadLine();
                Console.WriteLine("Last Name: ");
                var LastName = Console.ReadLine();
                Console.WriteLine("Email Address: ");
                var EmailAddress = Console.ReadLine();
                Console.WriteLine("Date Of Birth: ");
                var DateOfBirth = Convert.ToDateTime(Console.ReadLine());

                person[p] = new PersonDetails(FirstName,LastName,EmailAddress,DateOfBirth);
            }

            foreach (var i in person)
            {
                Console.WriteLine(String.Format("{0,10} {1,10} {2,20} {3,10} {4,10} {5,10} {6,10} {7,30}", 
                    $"{i.FirstName} {i.LastName} {i.EmailAddress} {i.DateOfBirth.ToShortDateString()} {i.Adult()} {i.WesternSunSign()} {i.ChineseSign()} {i.ScreenName()}"));

            }
        }
    }
}

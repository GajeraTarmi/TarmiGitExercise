using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    class PersonDetails
    {
        //Create a reference type called Person. Populate the Person class with the following properties to store the following information: - First name - Last name - Email address - Date of birth
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; }


        //Add constructors that accept the following parameter lists: - All four parameters - First, Last, Email - First, Last, Date of birth
        public PersonDetails(string fName,string lName,string email,DateTime dob)
        {
            FirstName = fName;
            LastName = lName;
            EmailAddress = email;
            DateOfBirth = dob;
        }


        //Add read-only properties that return the following computed information: - Adult – whether or not the person is over 18 
        public string Adult()
        {
            if ((DateTime.Now.Year - DateOfBirth.Year) > 18)
            {
                return "Adult";
            }
            else
                return "Not Adult";
        }

        //Sun sign – the traditional western sun sign of this person 
        public string WesternSunSign()
        {
            string sign="";

            int[] fromDate = { 21, 20, 21, 21, 22, 22, 23, 23, 22, 23, 22, 22 };
            string[] signs = { "Capricorn", "Aquarius", "Pisces", "Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius", "Capricorn" };
            if (DateOfBirth.Day < fromDate[DateOfBirth.Month - 1])
                return signs[DateOfBirth.Month - 1];
            sign = signs[DateOfBirth.Month];
            return sign;
        }

        //Chinese sign – the chinese astrological sign (animal) of this person 
        enum ChineseSigns
        {
              Monkey ,Rooster ,Dog ,Pig ,Rat ,Ox ,Tiger ,Rabbit ,Dragon ,Snake ,Horse ,Goat  
        }
        public string ChineseSign()
        {
            return ((ChineseSigns)(DateOfBirth.Year % 12)).ToString();
        }

        //Screen name – a default screen name that you might see being offered to a first time user of AOL or Yahoo (e.g. John Doe born on Feburary 25th, 1980 might be jdoe225 or johndoe022580)

        public string ScreenName()
        {
            string screenName = FirstName + LastName + DateOfBirth.ToString("MM") + DateOfBirth.ToString("dd") + DateOfBirth.ToString("yy");
            return screenName;
        }
    }
}

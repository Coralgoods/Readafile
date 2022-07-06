using System;
namespace ReadAFile
{
    public class Person
    {
        //Constructor
        public Person(string userName, string firstName, string URL)
        {

            this.UserID = userName;
            this.FirstName = firstName;
            this.URL = URL;

        }

        public string UserID { get; set; }
        public string FirstName { get; set; }
        public string URL { get; set; }

        public override string ToString()
        {
            return "UserID: " + UserID + "FirstName: " + FirstName + "URL: " + URL; 
        }
    }
}

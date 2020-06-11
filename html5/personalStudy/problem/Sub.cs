using System;
namespace problem
{
    public class Sub
    {
        private string firstName; 
        private string lastName;

        private int num;

        public Sub(string firstName, string lastName, int num)
        {
            FirstName = firstName;
            LastName = lastName;
            Num = num;
        }

        public string FirstName
        {
            
            get {return firstName;}
            
            set 
            {
                firstName = value;
                if (value == "")
                {
                    
                    Console.WriteLine("Input your first name");
                }
                
            }

        }

         public string LastName
        {
            get {return lastName;}

            set 
            {
                lastName = value;
                if (value == "")
                {
                   
                    Console.WriteLine("Input your last name");
                }
                 
            }

        }

        



         public int Num
        {
            get {
                return num;
               }

            set 
            {

                if (value > 0)
                {
                    num = value;

                }
            }
        }

    public string Grade{
        get{
             string number = "";
               if (Num >= 70)
                {
                    number = "A";
                }
                else if (Num >= 60 && Num < 70)
                {
                   number = "A";
                }
                else if (Num >= 50 && Num < 60)
                {
                   number = "A";
                }
                if (Num >= 40 && Num < 50)
                {
                   number = "A";
                }
                if (Num <= 40)
                {
                    number = "A";
                }
               return number;
        }

    }
        
    }
}
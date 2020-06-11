using System;

namespace LoginScreen
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userName = {"Mike", "John", "Mark", "Ela"};
            string[] password = {"453d", "Sh86", "de32", "jhgf"};

            Console.Write("Enter your username: ");
            string UserName = Console.ReadLine();

            Console.Write("Enter your password: ");
            string Password = Console.ReadLine();

            int count = 0;
            for( int i = 0; i < userName.Length; i++)
            {
                count++;

                if(userName[i] == UserName && password[i] == Password)
                {
                    Console.WriteLine("Login successful");
                    break;
                }

                if (count == userName.Length)
                {
                     Console.WriteLine("Wrong username or password");
                }       
                
            } 



        }
    }
}

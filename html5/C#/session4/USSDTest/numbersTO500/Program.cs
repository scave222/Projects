using System;

namespace numbersTO500
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            // do{
            //     if(num < 500)
            //     {
            //         num++;
            //         if(num % 3 == 0 && num % 5 == 0)
            //         {
            //             Console.WriteLine("CatFish ");
            //         }

            //         else if (num % 3 == 0)
            //         {
            //              Console.WriteLine("Cat");
            //         }

            //         else if (num % 5 == 0)
            //         {
            //              Console.WriteLine("Fish");
            //         }

            //         else {
            //             Console.WriteLine(num);
            //         }
            //     }
            // }
            // while(num != 500);

            while(num < 500)
            {
                num++;
                
                if(num % 3 == 0 && num % 5 == 0)
                    {
                        Console.WriteLine("CatFish ");
                    }

                    else if (num % 3 == 0)
                    {
                         Console.WriteLine("Cat");
                    }

                    else if (num % 5 == 0)
                    {
                         Console.WriteLine("Fish");
                    }

                    else {
                        Console.WriteLine(num);
                    }
            }
        }
    }
}

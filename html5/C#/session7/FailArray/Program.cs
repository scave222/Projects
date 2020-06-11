using System;

namespace FailArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Pass pass = new Pass();
            pass.fail();
           
        }

class Pass{
        string[] array = {"pass", "fail", "pass", "fail"};
            public void fail(){
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] == "pass"){
                    continue;
                }
                if(array[i] == "fail")
                {
                    Console.Write("fail");
                    break;
                    
                }
                
            }
            }
        }
    }
}

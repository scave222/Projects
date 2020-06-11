using System;

namespace PassFail
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fail = {"pass", "fail", "fail", "pass", "fail"};

            for(int i = 0; i < fail.Length; i++)
            {
                if(fail[i] == "fail")
                {
                    fail[i] = "**";
                }
                Console.Write($"{fail[i]}, ");
            }
        }
    }
}

using System;
using System.Diagnostics.PerformanceData;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Collections;

namespace PassFail
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList myArray = new ArrayList();
            
            myArray.Add ("fail");
            myArray.Add ("pass");
            myArray.Add ("fail");
            myArray.Add ("pass");

            string star= "**";
            string fail = "fail";

            for(int i = 0; i < myArray.Count; i++)
            {
                 if(Convert.ToString(myArray[i]) == fail)
                 {
                     myArray[i] = star;
                 }
                 
             }
             Console.Write($"{myArray}");
        }
    }
}

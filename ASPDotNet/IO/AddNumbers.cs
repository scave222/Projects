using System;
namespace Add_Nums 
{

	class AddNumbers 
	{
 		public static void Adding_Numbers(int number1, int number2)
   		{
			try
      			{
    				int res = number1/number2;
    				Console.WriteLine(res);
      			}
  			catch (Exception e) //Exception- //handler
     			{
  				Console.WriteLine("Exception caught. {0} ", e);
            		}
  			//This executes after the catch block
			Console.WriteLine("After handling the exception");
      		}
      		public static void Main()
        	{
            		AddNumbers.Adding_Numbers(10, 0);
            		Console.ReadLine();
        	}	
    	}
}


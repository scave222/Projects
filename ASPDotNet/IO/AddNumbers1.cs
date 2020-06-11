using System;
   namespace Add_Nums 
{
    class AddNumbers 
    {
        int result;
        AddNumbers()
        {
            result = 0;
        }
        public void Divide(int number1, int number2)
        {
		try
   		{
    			result = number1 / number2;
   		}
   		catch (DivideByZeroException e)
   		{
   			Console.WriteLine("Exception caught.{0} ", e);
   		}
		finally
 		{
   			Console.WriteLine("Result is {0}", result);
 		}
	}
public static void Main(string[] args)
  {
   AddNumbers Division = new AddNumbers();
   Division.Divide(10, 0);
   Console.ReadLine();
  }
 }
}


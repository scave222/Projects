using System;
using System.IO;

class FileRead 
{
	public void ReadData()
	{
		FileStream fs = new FileStream("Studentreport.txt", FileMode.Open, FileAccess.Read);
		StreamReader sr = new StreamReader(fs); 

		/*Position the file pointer at the beginning of the file*/
        	sr.BaseStream.Seek(0, SeekOrigin.Begin);

		//Read till the end of the file is encountered 
        	string str = sr.ReadLine(); 

        	while (str != null) 
       	 	{ 
          		Console.WriteLine("{0}", str); 
          		str = sr.ReadLine(); 
        	}
		// close the writer and file  
		sr.Close();
		fs.Close(); 
	}
 
	public static void Main(String[] args)
        {
            FileRead fr = new FileRead();
            fr.ReadData();
        }
} 


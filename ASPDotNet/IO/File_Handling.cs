using System;
using System.IO;

namespace File_Handling 
{
	
	class Tester
	{
		public static void Main()
		{
			//Creating an instance of DirectoryInfo class 
			DirectoryInfo MydirInfo = new DirectoryInfo(@"D:\Java eBooks");

			//DirectoryInfo MydirInfo = new DirectoryInfo(@"c:\WINDOWS");

			// get all the files in the directory and
			// print their name, and size

			FileInfo [] FilesInDir = MydirInfo.GetFiles();

			foreach (FileInfo file in FilesInDir)
			{
 				Console.WriteLine ("File Name :{0} Size: {1} bytes",file.Name, file.Length);
			}
		}
 	}
}


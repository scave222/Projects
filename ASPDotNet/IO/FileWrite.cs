using System; 
using System.IO; 

class FileWrite 
{ 
        public void WriteData() 
        { 
          	//object of filestream class is created 
         	FileStream fs = new FileStream("StudentReport.txt", FileMode.Append, FileAccess.Write); 
		StreamWriter w = new StreamWriter(fs); 

  		//Prompting user to enter the string which //needs to be stored in the file 
      		Console.WriteLine("Enter the comment for student");
       		string strComment = Console.ReadLine(); 

      		Console.WriteLine("Enter the name of student");
       		string strName = Console.ReadLine(); 

	    	//Writes the string entered by the user in //the file Myfile.txt 
       		w.WriteLine(strComment);
       		w.WriteLine(strName);
 
      		Console.WriteLine("Data written successful");
		// Clears all buffer of the current writer 
        	w.Flush();
 
		//Closes the current StreamWriter object 

        	w.Close(); 
		fs.Close(); 
        }
 
        public static void Main(String[] args) 
        { 
            FileWrite fw = new FileWrite(); 
            fw.WriteData(); 
        } 
}     

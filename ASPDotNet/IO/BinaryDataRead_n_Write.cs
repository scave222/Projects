using System;
using System.IO;

namespace BinaryData 
{
    public class RWData 
    {
        public static void Main()
        {
            BinaryWriter dataout;
            BinaryReader datain;

		int i = 10;
                double d = 1023.56;
      		bool b = true;

		dataout = new	BinaryWriter(new FileStream("testdata",FileMode.Create));
	Console.WriteLine("Writing " + i);
	dataout.Write(i);
	Console.WriteLine("Writing " + d);
	dataout.Write(d);
	Console.WriteLine("Writing " + b);
	dataout.Write(b);
	Console.WriteLine("Writing " + 12.2 * 7.4);
	dataout.Write(12.2 * 7.4);
	dataout.Close();
	Console.WriteLine();

	// Now, read them back
	datain = new BinaryReader(new FileStream("testdata",FileMode.Open));
	i = datain.ReadInt32();
       Console.WriteLine("Reading " + i);

	d = datain.ReadDouble();
       Console.WriteLine("Reading " + d);

       b = datain.ReadBoolean();
       Console.WriteLine("Reading " + b);

       d = datain.ReadDouble();
       Console.WriteLine("Reading " + d);

       Console.ReadLine();
       datain.Close();
       }
    }
}


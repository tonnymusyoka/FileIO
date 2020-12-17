using System;
using System.IO;
using FileIOLibrary;

namespace FileIOClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "ReadFile.txt";
            int lineNumber = 1;

            string lineContents = null;

            try
            {
                FileIO fileIO = new FileIO();
                lineContents = fileIO.ReadLine(filePath, lineNumber);
            }
            catch (IOException e)
            {
                Console.WriteLine("There was an error reading the file: ");
                Console.WriteLine(e.Message);
            }

            if (lineContents != null) {
                Console.WriteLine(lineContents);
                Console.ReadLine();
            }
               
        }
    }
}

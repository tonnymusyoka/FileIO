using System;
using System.IO;

namespace FileIOLibrary
{
    public class FileIO
    {
        public string ReadLine(string filePath, int lineNumber)
        {
            return ReadSpecificLine(filePath, lineNumber);
        }

        private string ReadSpecificLine(string filePath, int lineNumber)
        {
            using (StreamReader file = new StreamReader(filePath))
            {
                string content = null;
                for (int i = 1; i < lineNumber; i++)
                {
                    file.ReadLine();

                    if (file.EndOfStream)
                    {
                        break;
                    }
                }
                content = file.ReadLine();
                return content;
            }
        }
    }
}
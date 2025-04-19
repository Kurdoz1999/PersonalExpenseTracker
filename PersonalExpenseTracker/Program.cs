using System;
using System.IO;

namespace PersonalExpenseTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FileReader:
            string readerFilePath = "C:\\Users\\robin\\Documents\\Zealand\\Projekter (ikke-studierelateret)\\PersonalExpenseTrackerProject.txt";

            if (File.Exists(readerFilePath))
            {
                string readerString = File.ReadAllText(readerFilePath);
                Console.WriteLine(readerString);
            }

            //FileWriter:
            string writerFilePath = "C:\\Users\\robin\\Documents\\Zealand\\Projekter (ikke-studierelateret)\\PersonalExpenseTracker";
            string fileName = "Diyar";

            string newWriterFilePath = Path.Combine(writerFilePath + fileName + ".txt");        // Combining the filepath and the chosen name for the txt file
            string readerFileWriterString = File.ReadAllText(newWriterFilePath);                // Saves the file as it is before writing in it again

            File.Create(newWriterFilePath).Close();                                             // Creating a new file/Overwriting existing file
                                                                                                // (depends on whether or not the text from the file is saved or not)

            if (File.Exists(newWriterFilePath))
            {
                File.AppendAllText(newWriterFilePath, readerFileWriterString + "Hi there Diyar\nHow are you?\n");   // Combining the file as it was before,with the new text
            }
            Console.WriteLine("File created and written successfully :D");

            Console.ReadKey();
        }
    }
}
using System;
using System.IO;

namespace PersonalExpenseTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FileReader:
            string data;
            StreamReader reader = null;

            try
            {
                reader = new StreamReader("C:\\Users\\robin\\Documents\\Zealand\\Projekter (ikke-studierelateret)\\PersonalExpenseTrackerProject.txt");
                data = reader.ReadLine();

                while (data != null)
                {
                    Console.WriteLine(data);
                    data = reader.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                reader.Close();
            }


            //FileWriter:



            Console.ReadKey();
        }
    }
}
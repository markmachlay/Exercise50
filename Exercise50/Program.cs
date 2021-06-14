using System;
using System.Collections.Generic;

namespace Exercise50
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> ageOfStudent = new Dictionary<string, int>();
            ageOfStudent.Add("Darion", 92);
            ageOfStudent.Add("Mark", 36);
            ageOfStudent.Add("Rachel", 31);
            ageOfStudent.Add("Steve", 38);
            ageOfStudent.Add("Megan", 32);
            ageOfStudent.Add("Audrey", 29);
            ageOfStudent.Add("Raff", 36);
            ageOfStudent.Add("Morgan", 26);
            ageOfStudent.Add("Laurie", 65);
            ageOfStudent.Add("Lisa", 28);

            char continueFlag;
            do
            {
                Console.WriteLine("Please enter a student's name:");
                var name = Console.ReadLine();

                string nameKey = null;
                int ageValue = 0;

                foreach(KeyValuePair<string, int> kvp in ageOfStudent)
                {
                    if(name == kvp.Key)
                    {
                        nameKey = kvp.Key;
                        ageValue = kvp.Value;
                    }
                }
                
                if (name == nameKey)
                {
                    Console.WriteLine($"{nameKey} is {ageValue} years old.");
                }
                else
                {
                    Console.WriteLine($"Sorry ,{name} is not a student here.");
                }

                Console.WriteLine("Would you like to continue? (y/n)");
                continueFlag = Console.ReadLine().ToLower()[0];
            } while (continueFlag == 'y');

        }
    }
}

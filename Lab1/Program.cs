using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double lengthClass, heightClass, widthClass;
            bool repeat = true;

            while (repeat)
            {
                Console.Write("Enter the Length of the Classroom: ");

                lengthClass = ValidationOfDec();

                Console.Write("Enter the Height of the Classroom: ");

                heightClass = ValidationOfDec();

                Console.Write("Enter the Width of the Classroom: ");

                widthClass = ValidationOfDec();

                double areaOfClassroom = widthClass * lengthClass;
                double perimeterOfClassroom = 2 * widthClass + 2 * lengthClass;
                double volumeOfClassroom = heightClass * widthClass * lengthClass;

                Console.WriteLine("The area of the room is: " + areaOfClassroom);
                Console.WriteLine("The perimeter of the room is: " + perimeterOfClassroom);
                Console.WriteLine("The volume of the room is: " + volumeOfClassroom);

                bool validAnswer = true;


                Console.Write("Would the user like to find the measurements of another room (y/n)?: ");

                //repeat prompt for a valid answer
                while (validAnswer)
                {
                    string repeatPrompt = Console.ReadLine();
                    if (repeatPrompt == "y" || repeatPrompt == "Y" || repeatPrompt == "yes")
                    {
                        repeat = true;
                        validAnswer = false;
                    }
                    else if (repeatPrompt == "n" || repeatPrompt == "N" || repeatPrompt == "no")
                    {
                        Console.WriteLine("Okay exiting the program now.");
                        repeat = false;
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Didn't enter a valid answer. Do you want to find the measurements of another room (y/n)?: ");
                        validAnswer = true;
                    }
                }
            }
        }
        private static double ValidationOfDec() //validates a double was entered for the dimension
        {
            while (true)
            {
                string dimension = Console.ReadLine();
                bool success = double.TryParse(dimension, out double dimensionDec);

                if (success)
                {
                    return dimensionDec;
                }
                else
                {
                    Console.Write("Please enter a valid measurement: ");
                }

            }
        }
    }
}

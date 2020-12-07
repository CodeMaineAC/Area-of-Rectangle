using System;

namespace Area_of_Rectangle
{
    /*
     * Area of Rectangle
     * 12/7/2020
     * Finds the area of a room in square feet when given the lengths of the sides
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length of Side A(ft): "); //Prompt user for length of Side A
            string sideA = Console.ReadLine();

            Console.Write("Length of Side B(ft): "); //Prompt user for length of Side B
            string sideB = Console.ReadLine();

            double area = Convert.ToDouble(sideA) * Convert.ToDouble(sideB);

            Console.WriteLine("The area of the room is " + Convert.ToString(area)
                + " square feet");

            
        }
    }
}

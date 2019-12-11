using System;

namespace TheRover
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int query = Convert.ToInt32(Console.ReadLine());
                for (int item = 0; item < query; item++)
                {
                    string intialPosition = Console.ReadLine();
                    string commands = Console.ReadLine();
                    PositionDetector positionDetector = new PositionDetector();
                    try
                    {
                        string finalPosition = positionDetector.GetFinalPosition(intialPosition, commands);
                        Console.WriteLine(finalPosition);
                        Console.ReadKey();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

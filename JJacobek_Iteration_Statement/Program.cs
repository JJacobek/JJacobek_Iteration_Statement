using System;

namespace JJacobek_Iteration_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a value between 1 and 100");

            try
            {
                String input = Console.ReadLine();
                int Input_Value = int.Parse(input);

                if (Input_Value > 0 && Input_Value <= 100)
                {
                    do
                    {
                        Console.WriteLine("you have entered " + Input_Value.ToString() + ". This is the current integer value in the loop: " + Input_Value.ToString());
                        Input_Value--;
                    } while (Input_Value > 0);
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer");
                }
            }
            catch
            {
                
            }
            
           
        }
    }
}

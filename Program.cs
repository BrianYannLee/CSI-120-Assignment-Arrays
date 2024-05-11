//Programmer: Brian Lee
//Date: 05/07/2024

//Title: CSI 120 Assignment Array
namespace CSI_120_Assignment_Array
{
    internal class Program
    {

        //delegate void Menu();

        static double[] number;
        static int size;

        static void Main(string[] args)
        {
            try
            {
                ArraySize();
                ArrayRand();
                ArrayCalc();
                ArrayDisp();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An Error has occured in Main: {ex.Message}");
            }
        }//end of main
        public static void ArraySize()
        {
            Console.WriteLine("Array Size");
            Console.WriteLine();
            try
            {
                Console.WriteLine("Enter the size of the array.");
                while (!int.TryParse(Console.ReadLine(), out size))
                    Console.WriteLine("Invalid Input. Try Again");
                number = new double[size];
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An Error has occured in Array Size: {ex.Message}");
            }
            Console.WriteLine();
        }//end of ArraySize
        public static void ArrayRand()
        {
            Console.WriteLine("Array Declaration and Randomization");
            Console.WriteLine();
            try
            {
                Random random = new Random();
                for (int i = 0; i < size; i++)
                {
                    number[i] = random.Next(1, 101);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An Error has occured in Array Rand: {ex.Message}");
            }
            Console.WriteLine();
        }//end of ArrayRand
        public static void ArrayCalc()
        {
            Console.WriteLine("Array Calculation");
            Console.WriteLine();
            try
            {
                Console.WriteLine($"The Sum of the Array is: {number.Sum()}");
                Console.WriteLine($"The Average of the Array is: {number.Average()}");
                Console.WriteLine($"The Max of the Array is: {number.Max()}");
                Console.WriteLine($"The Min of the Array is: {number.Min()}");
                Console.WriteLine($"The Number of Even of the Array is: {number.Count(num => num % 2 ==0)}");
                Console.WriteLine($"The Number of Odd of the Array is: {number.Count(num => num % 2 != 0)}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An Error has occured in Array Calculation: {ex.Message}");
            }
            Console.WriteLine();
        }//end of ArrayCalc
        public static void ArrayDisp()
        {
            Console.WriteLine("Array Display");
            Console.WriteLine();
            try
            {
                foreach(int num in number)
                    Console.WriteLine(num);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An Error has occured in Array Display: {ex.Message}");
            }
            Console.WriteLine();
        }//end of ArrayDisp

    }//end of class
}//end of namespace

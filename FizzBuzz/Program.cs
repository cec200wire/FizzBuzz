namespace FizzBuzz
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i <= 105; i++)
            {
                string display = "";
                if (i % 3 == 0)
                {
                    display += "Fizz";
                }
                if (i % 5 == 0)
                {
                    display += "Buzz";
                }
                if (i % 7 == 0)
                {
                    display += "Bang";
                }
                
                if (display == "")
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(display);
                }
            }
        }
    }
}
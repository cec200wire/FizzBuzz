namespace FizzBuzz
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i <= 100; i++)
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
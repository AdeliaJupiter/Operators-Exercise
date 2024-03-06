namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //-----------------------EXERCISE 1--------------------
            Console.WriteLine($"EXERCISE 1");
            //declare and initialize variables
            int a = 17;
            int b = 4;

            //declare and initialize but make it math
            int sum = a + b;
            int diff = a - b;
            int prod = a * b;

            int quotient = a / b;
            int remainder = a % b;

            //tell the people what we got
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            Console.WriteLine();


            //----------------------EXERCISE 2------------------------
            Console.WriteLine($"EXERCISE 2");
            //get the radius
            Console.WriteLine($"Radius of circle:");
            double radius = double.Parse(Console.ReadLine());

            double area = AreaOfCircle(radius);

            Console.WriteLine($"The area of that circle is {area}");

            Console.WriteLine();


            //-----------------THOUGHT EXERCISE------------------
            Console.WriteLine($"THOUGHT EXERCISE");
            var i = 3;
            var j = 4;
            var k = ++i * j++;

            Console.WriteLine($"i = 3, j = 4, ++i * j++ equals k. What's k?");
            Console.WriteLine($"Order of operations would say we do the multiplication first but the ++ before the i tells us to do that first.");
            Console.WriteLine($"So, I'm thinking we're doing 4 * 4 + 1 which would be 17. Let's find out.");

            Console.WriteLine(k);

            if (k == 17)
            {
                Console.WriteLine($"Ayyy! We got it right!");
            }
            else
            {
                Console.WriteLine($"And this is how we learn!");
            }

        }

        //Area of a Circle function
        public static double AreaOfCircle (double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);

            return area;
        }
    }
}

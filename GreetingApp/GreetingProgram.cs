namespace GreetingApp
{
    class GreetingProgram
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();


            Console.Write("Enter the number of enrolled courses: ");
            int numCourses = int.Parse(Console.ReadLine());


            Console.Write("Enter the price of your favorite book: ");
            double bookPrice = double.Parse(Console.ReadLine());

             

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Number of enrolled courses: " + numCourses);
            Console.WriteLine("Price of favorite book: $" + bookPrice);


            Console.WriteLine("\nPress Any key to exit...");
            Console.ReadLine(); 
        }
    }
}
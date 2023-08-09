// As I am new to C# I will be adding some practice commentary
// and explanations so I can study a new language whilst working
// through this assignment. 

// To begin a project in C#, there are a few things you need to do.
// The first is to tell the program that we will be using the 
// System library. This gives us access to useful classes like
// console, or function methods like write-line.
// I do not believe we are using these add ons or
// libraries in this course, so we will skip this step.

// Next, we move onto the namespace project-name.
// This is what is used to identify and encapsulate your
// code within a said namespace.
// Curly braces are used to represent scope.
// Each chunk of code between curly braces is a 
// "block."
namespace prove_01
{
    // Class program is the name of your entrypoint class. 
    // This is essentially the "main" entry point class 
    // you would find in other languages. The difference,
    // in C# is that you get to name your "main" class. 
    class Program
    {
        
        // "static void Main(string[] args)," is the entry
        // point method of your program. It mus be called 
        // before anything else in your program. 
        static void Main(string[] args)
        {
            // At this point, we will be asking the user to enter
            // a number. In order to store that number, we need a 
            // variable. To declare the variable, we will use int as
            // we are only using integers for this example.
            // We will call the variable number.
            // We need to store a second variable to 
            // store the number which will be used to
            // multiply the number entered by the user.
            // We must separate each variable with a comma.
            // We will call the second variable multiplier.
            // Semicolons represent end statements.
            int number, multiplier;
            
            // To display the message to prompt for a users input,
            // we must use console.writeline.
            Console.WriteLine("Enter the Number");
            
            // Once the user is able to read our message and
            // enter a number, we want to be able to read the 
            // number inside the program. To do this, we need to use
            // console.readline.
            // However, this will only return number as string form, 
            // we need to convert number to integer form. 
            // To do that, we will use Convert.ToInt32.
            // We will set the integer equal to number variable.
            number = Convert.ToInt32(Console.ReadLine());

            // Because we will be repeating the multiples of 10 
            // over and over until we have done it 10 times, we will
            // use a for loop. 
            // Start multiplying the number from the user, starting from 1
            // up to 10.
            // Lastly we need to increment the value of the multiplier variable.
            for (multiplier = 1; multiplier <= 10; multiplier++)
            {

                // Now we want to display our values. 
                // We need to format the multiplication using placeholders.
                Console.WriteLine("{0} * {1} = {2},",number,multiplier,(number * multiplier));
            }
            
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
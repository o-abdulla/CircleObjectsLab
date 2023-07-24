// Circle Objects Lab

using CircleObjectsLab;

Console.WriteLine("Welcome to the Circle Tester\n");



double radius = -1;
while (true)
{

    //The application prompts the user to enter a radius; the user may enter a number with decimals (double).
    //The application displays an error if the user enters invalid data and asks the user again for a radius.
    try
    {
        Console.WriteLine("Enter radius:");
        radius = double.Parse(Console.ReadLine().Trim());
        if (radius <= 0)
        {
            throw new Exception("Error: Invalid data. Please try again");
        }
        else
        {
            break;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }

}




//When the user enters valid data,
//the application creates an instance of a Circle
//and then uses its methods to display the Diameter, Circumference and Area.

Circle shapeCircle = new Circle(radius);
bool runMethods = true;
while (runMethods)
{
    Console.WriteLine($"Diameter: {shapeCircle.CalculateDiameter()}");
    Console.WriteLine($"Circumference: {shapeCircle.CalculateCircumference()}");
    Console.WriteLine($"Area: {shapeCircle.CalculateArea()}");


    //The application asks the user if the circle should grow.
    //If the user says yes, call the grow method and then loop back to the method calls for the formulas. 
    //The grow method will adjust radius to double its value.

    Console.WriteLine("Should the circle grow?");
    while (true)
    {
        string response = Console.ReadLine().ToLower().Trim();

        if (response == "yes" || response == "y")
        {
            shapeCircle.Grow();
            break;

        }

        else if (response == "no" || response == "n")
        {
            Console.WriteLine($"Goodbye. The circle's final radius is {shapeCircle.GetRadius()}");
            runMethods = false;
            break;

        }
        else
        {
            Console.WriteLine("Invalid input, please enter either a y/n");
        }
    }

}
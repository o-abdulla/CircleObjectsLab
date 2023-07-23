// Circle Objects Lab

using CircleObjectsLab;

Console.WriteLine("Welcome to the Circle Tester\n");

bool runProgram = true;
while (runProgram)
{
    double radius = 0;
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
    Console.WriteLine($"Diameter: {shapeCircle.CalculateDiameter(radius)}");
    Console.WriteLine($"Circumference: {shapeCircle.CalculateCircumference(radius)}");
    Console.WriteLine($"Area: {shapeCircle.CalculateArea(radius)}");


    //The application asks the user if the circle should grow.
    //If the user says yes, call the grow method and then loop back to the method calls for the formulas. 
    //The grow method will adjust radius to double its value.
    while (true)
    {
        Console.WriteLine("Should the circle grow?");
        string response = Console.ReadLine().ToLower().Trim();

        if (response == "yes" || response == "y")
        {
            shapeCircle.Grow();
            //shapeCircle.GetRadius(radius);
            Console.WriteLine($"The radius grew to {shapeCircle.GetRadius(radius)}");
            break;

        }

        else if (response == "no" || response == "n")
        {
            Console.WriteLine($"Goodbye. The circle's final radius is {radius}");
            runProgram = false;
            break;

        }
        else
        {
            Console.WriteLine("Invalid input, please enter either a y/n");
        }
    }

}
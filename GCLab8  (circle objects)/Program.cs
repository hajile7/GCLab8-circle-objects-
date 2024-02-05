using GCLab8___circle_objects_;

//welcome
Console.WriteLine("Welcome to the Circle Tester!");

//get user input + validate it
Console.Write("Enter radius: ");
double tempRadius = -1;
while(!double.TryParse(Console.ReadLine(), out tempRadius) || tempRadius <= 0)
{
    Console.WriteLine("Invalid input. Please try again. Number must be greater than 0.");
}


Circle choice = new Circle(tempRadius);

//loop calcluations if user wants
bool runCalcs = true;
while (runCalcs)
{

    //output calculations
    Console.Write($"Diameter: {choice.CalculateDiameter()}\n");
    Console.Write($"Circumference: {choice.CalculateCircumference()}\n");
    Console.Write($"Area: {choice.CalculateArea()}\n");

    //check & see if user would like to circle to grow
    Console.WriteLine("Would you like the circle to grow? y/n");
    string growChoice = Console.ReadLine().ToLower().Trim();
    if (growChoice == "y")
    {
        choice.Grow();
    }
    else
    {
        Console.WriteLine($"Your circle's radius is {choice.GetRadius()}");
        Console.WriteLine("Goodbye!");
        break;
    }

}
// See https://aka.ms/new-console-template for more information
double valueOne, valueTwo, shapeOne, shapeTwo;
double shape1 = 0, shape2 = 0;
int degree = 1;
bool error = false;

shapeOne = Convert.ToDouble(Console.ReadLine());
valueOne = Convert.ToDouble(Console.ReadLine());
shapeTwo = Convert.ToDouble(Console.ReadLine());
valueTwo = Convert.ToDouble(Console.ReadLine());

double ProcessShape(double shapeNumber, double shapeValue)
{
    if (shapeNumber == 1)
    {
        double side = shapeValue;
        if (side > 0)
        {
            double areaSquare = side * side;
            return areaSquare;
        }
    }
    else if (shapeNumber == 2)
    {
        double radius = shapeValue;
        if (radius > 0)
        {
            double areaCircle = 3.14 * radius * radius;
            return areaCircle;
        }
    }
    return 0.0;
}

// Validate 1st Shape and Value
if (shapeOne > 2 || shapeOne < 1)
{
    Console.WriteLine("Invalid Shape " + degree + ".");
    error = true;
}

if (valueOne < 0)
{
    Console.WriteLine("Invalid Shape " + degree + " value.");
    error = true;
}

if (!error)
{
    shape1 = ProcessShape(shapeOne, valueOne);
}

degree++;

//Validate 2nd Shape and Value
if (shapeTwo > 2 || shapeTwo < 1)
{
    Console.WriteLine("Invalid Shape " + degree + ".");
    error = true;
}

if (valueTwo < 0)
{
    Console.WriteLine("Invalid Shape " + degree + " value.");
    error = true;
}

if (!error)
{
    shape2 = ProcessShape(shapeTwo, valueTwo);
}

// If no error per input 
if (!error)
{
    if (shape2 > shape1)
    {
        Console.WriteLine("Shape 2 has more area!");
    }
    else
    {
        Console.WriteLine("Shape 1 has more area!");
    }
}
// C# Labb2 – Bibliotek för hantering av geometiska figurer. 
// David Almvkvist - Sep 2022

using Shapes_Library;
using System.Data.SqlTypes;
using System.Numerics;

Console.WriteLine("Labb 2 - Bibliotek för hantering av geometiska figurer.\n");

float totalAreaSize = 0;
float sumOFTrianglesCircumference = 0;

int circleCount = 0;
int rectangleCount = 0;
int squareCount = 0;
int triangleCount = 0;
int sphereCount = 0;
int CubidCount = 0;
int cubeCount = 0;


Shape[] shapesArray = new Shape[20];

for (int i = 0; i < shapesArray.Length; i++)
{
    shapesArray[i] = Shape.GenerateShape();
    totalAreaSize += shapesArray[i].Area;
}

PrintResults();

void PrintResults()
{

    for (int i = 0; i < shapesArray.Length; i++)
    {
        Console.WriteLine($"Shape{i}\tis a {shapesArray[i]}");
    }

    Console.WriteLine();
    CalculateArea();

    CalculateCircumferenceOfTrianglesAndPrint();
    CalculateWhoHasBiggestVolume();

    Console.WriteLine();
    CountTheShapes();
    Console.WriteLine($"Of our shapes we have: \n" +
        $"{circleCount} Circles");
    Console.WriteLine($"{rectangleCount} Rectangles and {squareCount} Squares");
    Console.WriteLine($"{triangleCount} Triangles");
    Console.WriteLine($"{sphereCount} Spheres");
    Console.WriteLine($"{CubidCount} Cuboids and {cubeCount} Cubes");
}

void CalculateArea()
{
    Console.WriteLine("\t - Area - ");

    Console.WriteLine($"And our Total area is : {totalAreaSize:f1}");
    Console.WriteLine($"Which gives us average area of: {(totalAreaSize / shapesArray.Length):f1} per shape");
    Console.WriteLine();
}

void CalculateCircumferenceOfTrianglesAndPrint()
{
    foreach (var shape in shapesArray)
    {
        if (shape is Triangle)
        {
            Triangle tempTriangle = (Triangle)shape;
            sumOFTrianglesCircumference += tempTriangle.Circumference;
        }
    }

    Console.WriteLine($"The Total Circumference of the Triangles is: {sumOFTrianglesCircumference}");
}

void CalculateWhoHasBiggestVolume()
{
    int indexBiggest = -1;
    float biggestVolume = 0;
    for (int i = 0; i < shapesArray.Length; i++)
    {
        if (shapesArray[i] is Shape3D)
        {
            Shape3D currentShape = (Shape3D)shapesArray[i];
            float currentVolume = currentShape.Volume;

            if (currentVolume > biggestVolume)
            {
                indexBiggest = i;
                biggestVolume = currentVolume;
            }
        }
    }
    if (indexBiggest == -1)
    {
        Console.WriteLine("Of our 20 shapes, non was a 3D Shape");
    }
    else
    {
        Console.WriteLine($"The Biggest Volume Found was: {biggestVolume} and was from array nr {indexBiggest} ");

    }
}

void PrintCountResults()
{

}

void CountTheShapes()
{
    foreach (Shape shape in shapesArray)
    {
        if (shape is Circle) { circleCount++; }
        else if (shape is Rectangle) 
        {
            Rectangle currentShape = (Rectangle)shape;
            if (currentShape.IsSquare)
            {
                squareCount++;
            }
            else
            {
                rectangleCount++;
            }
        }
        else if (shape is Triangle) { triangleCount++; } 
        else if (shape is Sphere) { sphereCount++; }
        else if (shape is Cuboid) 
        {
            Cuboid currentShape = (Cuboid)shape;
            if (currentShape.IsCube)
            {
                cubeCount++;
            }
            else
            {
                CubidCount++;
            }
        }
    }
}
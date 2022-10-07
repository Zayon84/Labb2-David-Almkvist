// C# Labb2 – Bibliotek för hantering av geometiska figurer. 
// David Almvkvist - Sep 2022

using Shapes_Library;
using System.Numerics;

Console.WriteLine("Labb 2 - Bibliotek för hantering av geometiska figurer.\n");

//Circle myCircle = new Circle(new Vector2(3.0f, 4.0f), 2.0f);

//Console.WriteLine($"This is a {myCircle} @ ({myCircle.Center}: r = {myCircle.Radius})");

//Console.WriteLine(new Circle(new Vector2(3.0f, 4.0f), 2.0f));
//Console.WriteLine(new Rectangle(new Vector2(3.0f, 4.0f),new Vector2(4.0f, 5.0f)));
//Console.WriteLine(new Triangle(new Vector2(3.0f, 4.0f),new Vector2(4.0f, 5.0f),new Vector2(2,2)));
//Console.WriteLine(new Cuboid(new Vector3(3.0f, 4.0f, 5.0f),new Vector3(4.0f, 5.0f,2.0f)));
//Console.WriteLine(new Sphere(new Vector3(3.0f, 4.0f, 5.0f),5.0f));

float totalAreaSize = 0;

Shape[] shapesArray = new Shape[20];

for (int i = 0; i < shapesArray.Length; i++)
{
    shapesArray[i] = Shape.GenerateShape();
    totalAreaSize += shapesArray[i].Area;
}

PrintResults();

void PrintResults()
{
    //String placeHolderNumber = "4";

    //Console.WriteLine($"We have a total of {shapesArray.Length} Shapes!");
    //Console.WriteLine();
    //Console.WriteLine($"Of our shapes we have {placeHolderNumber} Circles");
    //Console.WriteLine($"Of our shapes we have {placeHolderNumber} Rectangles");
    //Console.WriteLine($"Of our shapes we have {placeHolderNumber} Triangles");
    //Console.WriteLine($"Of our shapes we have {placeHolderNumber} Spheres");
    //Console.WriteLine($"Of our shapes we have {placeHolderNumber} Cuboids");

    //Console.WriteLine("Our shapes are:");

    for (int i = 0; i < shapesArray.Length; i++)
    {
        Console.WriteLine($"Shape{i}\tis a {shapesArray[i]}");
    }
    Console.WriteLine();
    CalculateArea();

    Console.WriteLine("\t- - - VG - Uppgifter: - - -");
    CalculateCircumferenceOfTriangles();
    CalculateWhoHasBiggestVolume();
}

void CalculateArea()
{
    Console.WriteLine("\t - Area - ");

    Console.WriteLine($"And our Total area is : {totalAreaSize:f1}");
    Console.WriteLine($"Which gives us average area of: {(totalAreaSize / shapesArray.Length):f1} per shape");
    Console.WriteLine();
}

void CalculateCircumferenceOfTriangles()
{
    Console.WriteLine("\t - Circumference -  TO DO !!!");
                                                                // TO DO:
}

void CalculateWhoHasBiggestVolume()
{
    Console.WriteLine("\t - Volume -  TO DO !!!");
    //                                                                                            //  TO DO:
    int indexBiggest = -1;
    float biggestVolume = 0;
    for (int i = 0; i < shapesArray.Length; i++)
    {
        if (shapesArray[i] is Shape3D)
        {
            
        }
    }

    //foreach (Shape3D shape in shapesArray)
    //{
    //    if (shape.Volume > biggestVolume)
    //    {
    //        biggestVolume = shape.Volume;
    //    }
    //}
}
// C# Labb2 – Bibliotek för hantering av geometiska figurer. 
// David Almvkvist - Sep 2022

using Shapes_Library;
using System.Numerics;

Console.WriteLine("Labb 2 - Bibliotek för hantering av geometiska figurer.\n");

Circle myCircle = new Circle(new Vector2(3.0f, 4.0f), 2.0f);

//Console.WriteLine($"This is a {myCircle} @ ({myCircle.Center}: r = {myCircle.Radius})");

Console.WriteLine(new Circle(new Vector2(3.0f, 4.0f), 2.0f));
Console.WriteLine(new Rectangle(new Vector2(3.0f, 4.0f),new Vector2(4.0f, 5.0f)));
Console.WriteLine(new Cuboid(new Vector3(3.0f, 4.0f, 5.0f),new Vector3(4.0f, 5.0f,2.0f)));

Console.WriteLine();




Shape[] shapesArray = new Shape[20];

for (int i = 0; i < shapesArray.Length; i++)
{
    shapesArray[i] = Shape.GenerateShape2(); ;


    ////ShapesForm myShape = (shShape.GenerateShape();
    //int number = 2;
    //shapesArray[i] = number switch
    //{
    //    0 => new Circle(new Vector2(5.0f, 2.0f), 3) ,
    //    1 => new Rectangle(new Vector2(3.0f,4.0f),new Vector2(4.0f, 5.0f)),
    //    2 => new Rectangle(new Vector2(3.0f, 4.0f), 5),
    //    3 => new Triangle(new Vector2(3.0f, 5.0f), new Vector2( 7.0f, 3.2f), new Vector2(9.0f, 2.0f)), 
    //    4 => new Sphere(new Vector3(3.0f, 3.0f, 3.0f), 7.0f),
    //    5 => new Cuboid(new Vector3(5.0f,5.0f,5.0f), new Vector3 (3.0f, 2.0f, 4.0f)),
    //    6 => new Cuboid(new Vector3(4.0f,4.0f,4.0f), 5.0f),
        
    //};
}

PrintResults();



void PrintResults()
{
    String placeHolderNumber = "4";

    Console.WriteLine($"We have a total of {shapesArray.Length} Shapes!");
    Console.WriteLine();
    Console.WriteLine($"Of our shapes we have {placeHolderNumber} Circles");
    Console.WriteLine($"Of our shapes we have {placeHolderNumber} Rectangles");
    Console.WriteLine($"Of our shapes we have {placeHolderNumber} Triangles");
    Console.WriteLine($"Of our shapes we have {placeHolderNumber} Spheres");
    Console.WriteLine($"Of our shapes we have {placeHolderNumber} Cuboids");

    Console.WriteLine();

    for (int i = 0; i < shapesArray.Length; i++)
    {
        Console.WriteLine(shapesArray[i]);
    }
}
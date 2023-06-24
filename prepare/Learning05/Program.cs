using System;

class Program
{
    static void Main(string[] args)
    {
     
        List<Shape> shapes = new List<Shape>();

        Square cuadrado = new Square("blue",5);  
        shapes.Add(cuadrado);
        Rectangle rectangulo = new Rectangle("red",5,10);
        shapes.Add(rectangulo);
        Circle circulo = new Circle("Yellow",7);
        shapes.Add(circulo);

        foreach (Shape forma in shapes){
            Console.WriteLine($"The {forma.GetColor()} shape has an area of {forma.GetArea()}.");
        }

    }
}
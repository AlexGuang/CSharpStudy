using System;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Cube(3), new Sphere(4) };
            foreach (Shape shape in shapes)
            {
                shape.ShoeInfor();
                Console.WriteLine("{0} has a volumn which is {1}",shape.Name,shape.GetVolumn());

                Cube cube1 = shape as Cube; // keywords: "as"  if shape is not a cube, shape as Cube would return a null.
                if (cube1 == null)
                {
                    Console.WriteLine("This shape is not a cube.");
                }
                if (cube1 is Cube)// keyword: "is"
                {
                    Console.WriteLine(" This shape is a cube.");
                }

            }
            object cube2 = new Cube(8);
            Cube cube3 = (Cube)cube2;// CAST object to a Cube data type
            Console.WriteLine("{0} has a volumn: {1}",cube3.Name,cube3.GetVolumn());
        }
    }
}

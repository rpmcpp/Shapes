using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Polymorphism *****\n");

            // Make an array of Shape compatible objects
            Shape[] myShapes =
            {
                new Hexagon(), new Circle(), new Hexagon("Mick"), new Circle("Beth"),
                new Hexagon("Linda")
            };

            // Loop over each item and interact with the polymorphic interface
            foreach (Shape s in myShapes)
            {
                s.Draw();
            }
            Console.ReadLine();

            // Make 3D circle and Draw
            ThreeDCircle o = new ThreeDCircle("Spheria");
            o.Draw();

            // BEWARE, using explicit on child object can trigger parent method
            // when child method uses shadowing instead of overriding
            ((Circle)o).Draw();
            Console.ReadLine();



        }
    }
}

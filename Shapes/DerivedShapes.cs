using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
     class Circle : Shape
    {
        // FIELD DATA ------------------------------------------------------------------------------



        // CTORs -----------------------------------------------------------------------------------


        public Circle(){}
        public Circle(string name)
             :base(name){}
         
         
         

        // METHODS --------------------------------------------------------------------------------

         
         public override void Draw()        // Override parent abstract method
         {
             Console.WriteLine("Drawing {0} the Circle", PetName);
         }
    }

    class ThreeDCircle : Circle
    {
        
        // FIELD DATA ----------------------------------------------------------------------------

        public new string PetName { get; set; }


        
        // CTORs ----------------------------------------------------------------------------------

        public ThreeDCircle(){}
        public ThreeDCircle(string name) 
            : base(name)
        {
            PetName = name; // Must assign here as base field is shadowed
        }
        
        // METHODS -------------------------------------------------------------------------------

        public new void Draw()
        {
            // creating"new" method overrides parent abstract method with no base access.
            // known as shadowing
            Console.WriteLine("Drawing 3-D Circle named {0}", PetName);
        }
    }
    class Hexagon : Shape
    {

        // CTORs ------------------------------------------------------------------------------------
        
        public Hexagon(){}
        public Hexagon(string name)
            :base(name){}

        
        // METHODS -----------------------------------------------------------------------------------
        
        
        public override void Draw()
        {
            Console.WriteLine("Drawing the {0} Hexagon", PetName);
        }
    }
}
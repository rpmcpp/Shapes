using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape
    {
        // FIELD DATA -------------------------------------------------------------------------------

        public string PetName { get; set; }

        // CTORs -------------------------------------------------------------------------------------

        public Shape(string name = "NoName")
        {
            PetName = name;
        }


        // METHODS -----------------------------------------------------------------------------------

        public abstract void Draw();


    }
}

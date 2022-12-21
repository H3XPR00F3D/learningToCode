using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldTut
{
    public class ItalianChef : Chef
    {

        public override void MakeSpecialDish()
        {
            Console.WriteLine("This Chef makes Chicken Parm");
        }
        public void MakePasta()
        {
            Console.Write("This Chef can make Pasta");
        }

    }
}

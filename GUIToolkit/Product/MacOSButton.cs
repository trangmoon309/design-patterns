using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIToolkit.Product
{
    public class MacOSButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("MacOS Button Clicked");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIToolkit.Product
{
    internal class WindowButton : IButton
    {
        void IButton.Click()
        {
            Console.WriteLine("Window Button Clicked");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIToolkit.Product
{
    internal class LinuxButton : IButton
    {
        void IButton.Click()
        {
            Console.WriteLine("Linux Button Clicked");
        }
    }
}

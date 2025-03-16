using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIToolkit.Product
{
    internal class WindowTextField : ITextField
    {
        void ITextField.SetText(string text)
        {
            Console.WriteLine($"WindowTextField: {text}");
        }
    }
}

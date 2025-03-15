﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIToolkit.Product
{
    internal class MacOSTextField : ITextField
    {
        void ITextField.SetText(string text)
        {
            Console.WriteLine($"MacOSTextField: {text}");
        }
    }
}

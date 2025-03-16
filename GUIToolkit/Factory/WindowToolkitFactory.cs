using GUIToolkit.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIToolkit.Factory
{
    internal class WindowToolkitFactory : IGUIToolkitFactory
    {
        IButton IGUIToolkitFactory.CreateButton()
        {
            return new WindowButton();
        }

        ITextField IGUIToolkitFactory.CreateTextField()
        {
            return new WindowTextField();
        }
    }
}

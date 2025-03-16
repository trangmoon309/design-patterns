using GUIToolkit.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIToolkit.Factory
{
    internal class MacOSToolkitFactory : IGUIToolkitFactory
    {
        IButton IGUIToolkitFactory.CreateButton()
        {
            return new MacOSButton();
        }

        ITextField IGUIToolkitFactory.CreateTextField()
        {
            return new MacOSTextField();
        }
    }
}

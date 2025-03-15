using GUIToolkit.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIToolkit.Factory
{
    internal class LinuxToolkitFactory : IGUIToolkitFactory
    {
        IButton IGUIToolkitFactory.CreateButton()
        {
            return new LinuxButton();
        }

        ITextField IGUIToolkitFactory.CreateTextField()
        {
            return new LinuxTextField();
        }
    }
}

using GUIToolkit.Factory;
using GUIToolkit.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIToolkit
{
    public class Application(IGUIToolkitFactory factory)
    {
        private IButton button = factory.CreateButton();
        private ITextField textField = factory.CreateTextField();

        public void Paint()
        {
            button.Click();
            textField.SetText("Hello World!");
        }
    }
}

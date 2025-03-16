
using GUIToolkit.Product;

namespace GUIToolkit.Factory
{
    public interface IGUIToolkitFactory
    {
        public IButton CreateButton();
        public ITextField CreateTextField();
    }
}

using GUIToolkit;
using GUIToolkit.Factory;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("----------- GUI Toolkit Experiment! -----------");
        Application app = ConfigureApplication();
        app.Paint();
    }

    private static Application ConfigureApplication()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            return new Application(new LinuxToolkitFactory());
        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            return new Application(new MacOSToolkitFactory());

        return new Application(new WindowToolkitFactory());
    }
}
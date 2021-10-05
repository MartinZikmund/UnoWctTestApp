using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace App39.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new App39.App(), args);
            host.Run();
        }
    }
}

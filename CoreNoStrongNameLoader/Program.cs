extern alias v1;
extern alias v3;

using System;

namespace Loader
{
    class Program
    {
        static void Main(string[] args)
        {
            var v1 = new v1::DependencyNamespace.Class1();
            var v3 = new v3::DependencyNamespace.Class1();

            if(v1.GetType() == v3.GetType()) 
                Console.WriteLine("Suprise upgrade of dependency occured silently.");
            else
                Console.WriteLine("Dependency classes were properly different.");
        }
    }
}

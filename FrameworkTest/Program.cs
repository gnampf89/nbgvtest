using System;
using System.Diagnostics;
using System.Reflection;

namespace FrameworkTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            Console.WriteLine(fvi.ProductVersion);
        }
    }
}

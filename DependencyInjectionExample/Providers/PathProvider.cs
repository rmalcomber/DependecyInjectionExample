using System;
using System.Collections.Generic;
using System.Text;
using DependencyInjectionExample.Interfaces;

namespace DependencyInjectionExample.Providers
{
    public class PathProvider : IPathProvider
    {
        public string GetPath => "TestFile.txt";
    }
}

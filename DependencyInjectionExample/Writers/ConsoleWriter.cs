using System;
using System.Collections.Generic;
using System.Text;
using DependencyInjectionExample.Interfaces;

namespace DependencyInjectionExample.Writers
{
    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }

        public void Write(string text)
        {
            Console.Write(text);
        }
    }
}

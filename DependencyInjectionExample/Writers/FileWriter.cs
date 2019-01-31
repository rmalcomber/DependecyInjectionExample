using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using DependencyInjectionExample.Interfaces;

namespace DependencyInjectionExample.Writers
{
    public class FileWriter : IWriter
    {
        private readonly IPathProvider _pathProvider;

        public FileWriter(IPathProvider pathProvider) {
            _pathProvider = pathProvider;
        }

        public void WriteLine(string text) {
            using (var writer = GetTextWriter(_pathProvider.GetPath)) {
                writer.WriteLine(text);
            }
        }

        public void Write(string text) {
            using (var writer = GetTextWriter(_pathProvider.GetPath)) {
                writer.Write(text);
            }
        }

        private static TextWriter GetTextWriter(string filePath)
        {
            CheckFilePath(filePath);

            return new StreamWriter(filePath, true);
        }

        private static void CheckFilePath(string filePath)
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Dispose();
            }
        }
    }
}

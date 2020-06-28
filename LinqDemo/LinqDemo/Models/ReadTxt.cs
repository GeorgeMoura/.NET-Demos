using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LinqDemo.Models
{
    class ReadTxt : IRead
    {
        public char delimiter { get; set; }
        public string Path { get; set; }

        public ReadTxt(string path, char delimiter)
        {
            this.Path = path;
            this.delimiter = delimiter;
        }

        public List<string[]> read()
        {
            List<string[]> funcionarios = new List<string[]>();

            using(StreamReader sr = File.OpenText(this.Path))
            {
                while (!sr.EndOfStream)
                {
                    string[] lines = sr.ReadLine().Split(this.delimiter);
                    funcionarios.Add(lines);
                }
            }
            return funcionarios;
        }
    }
}

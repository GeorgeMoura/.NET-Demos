using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EventsDelegatesSample
{
    class WriteSubscriber
    {
        public WriteSubscriber()
        {

        }

        public void OnWriteToFile(object obj, EventArgs args)
        {

            //Reflection
            //Reflection PODE ser usada nesse contexto pra que seja possível
            //acessar a instância de FileStream dentro dos argumentos passados para
            //a função de subescrita. Como estamos usando polimorfismo, a instância de
            //EventArgs não conhece o que estamos passando como argumento (que é uma classe que herda de EventArgs).

            //implementação usando REFLECTION
            /*
            var tipo = args.GetType();
            var dict = tipo.GetProperties().ToDictionary(p => p.Name);
            FileStream file = dict["data"].GetValue(args) as FileStream;
            */

            var file = args as WriteFileEventArgs<FileStream>;

            try
            {
                using (StreamReader sr = new StreamReader(file.data.Name)) 
                {
                    string line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}

using System;
using System.IO;

namespace EventsDelegatesSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração da classe PUBLIHSER, dentro dessa classe vai exister um método responsável por PUBLICAR o evento
            Write<string> writeObj = new Write<string>();
            //Declaração da classe SUBSCRIBER
            WriteSubscriber writeSubscriber = new WriteSubscriber();

            //Associação do método subscriber (direita) ao evento da classe publisher (esquerda)
            writeObj.WriteTo += writeSubscriber.OnWriteToFile;

            //chamada do método publiser. Ele vai executar sua funcionalidade e ao final chamar a classe responsável por publicar o evento.
            writeObj.WriteToFile("Hello World");

        }
    }
}

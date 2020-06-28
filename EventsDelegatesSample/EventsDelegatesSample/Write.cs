using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EventsDelegatesSample
{
    //Implementação da classe que carrega os argumentos do evento, que serão tratados na classe subscriber.
    public class WriteFileEventArgs<T> : EventArgs
    {
        public T data { get; set; }

        public WriteFileEventArgs(T data)
        {
            this.data = data;
        }
    }

    public class Write<T>
    {
        //definir o delegate que irá receber a referência para os métodos 'subscribers', que devem ter a mesma assinatura do delegate
        //public delegate void WriteEventHandler(object source, EventArgs args);
        //define o evento baseado no delegate
        //public event WriteEventHandler WriteTo;

        //Maneira Bult-in de declarar um evento sem precisar declarar um delegate, os argumentos são passados com generics
        public EventHandler<EventArgs> WriteTo;

        public FileStream fs;
        public StreamWriter sw;

        public Write()
        {
        }

        //esse método irá executar uma função e publicar para os subscribers quando essa função for finalizada
        public void WriteToFile(T arg)
        {     
            fs = new FileStream("C:\\Users\\Pichau\\Documents\\Projetos\\Curso C#\\EventsDelegatesSample\\EventFile.txt",
            FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(arg);
            sw.Flush();
            sw.Close();
            fs.Close();

            //publicando o evento
            OnWriteToFile();
        }

        //método responsável por publicar o evento para os subscribers, por conveção deve ser um protected virtual void
        protected virtual void OnWriteToFile()
        {
            //se WriteTo(o evento) não for nulo, invoque o delegate pra executar o métoque que o tiver sub-escrito
            WriteTo?.Invoke(this, new WriteFileEventArgs<FileStream>(fs));
        }
    }
}

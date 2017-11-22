using System;

namespace ExemploDelegate1
{
    class Program
    {
        public delegate void Cortador(string Queijo);
        static void Main(string[] args)
        {
            Cortador delegado = new Cortador(Data);
            delegado("Ola, eu sou um delegate e ");
            Cortador delegado2 = new Cortador(DataCompleta);
            delegado2("Eita peste ");
        }
        static void Data(string texto)
        {
            System.Console.WriteLine(texto+"hoje e " + DateTime.Now.ToShortDateString());
        }
        static void DataCompleta(string nome) 
        {
            System.Console.WriteLine("Ola " + nome + " hoje e " + DateTime.Now.ToLongDateString());
        }
    }
}

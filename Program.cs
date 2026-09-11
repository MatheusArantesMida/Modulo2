using System;

namespace Modulo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cachorro meuCachorro = new Cachorro("Rex", "Labrador");
            meuCachorro.Comer();
            meuCachorro.Latir();

            Gato meuGato = new Gato("Davi", "Siamês");
            meuGato.Comer();
            meuGato.Miado();
        }
    }
}
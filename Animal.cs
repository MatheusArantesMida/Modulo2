using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo2
{
    public class Animal
    {
        public string Nome { get; set; }
        public Animal(string Nome)
        {
            Nome = Nome;
        }

        public void Comer()
        {
            Console.WriteLine($"{Nome} está comendo.");
        }
    }
    public class Cachorro : Animal
    {
        public string Raca { get; set; }

        public Cachorro(string Nome, string Raca) : base(Nome)
        {
            Raca = Raca;
        }

        public void Latir()
        {
            Console.WriteLine($"{Nome} está latindo: AU AU!");
        }
    }

    public class Gato : Animal
    {
        public string Cor { get; set; }
        public Gato(string Nome, string Cor) : base(Nome)
        {
            Cor = Cor;
        }
        public void Miado()
        {
            Console.WriteLine($"{Nome} está miando: MIAU!");
        }
    }
}
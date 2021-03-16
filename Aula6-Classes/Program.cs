/*
 * lufer
 * LP2
 * Classes e Objetos: Fundamentos e Conceitos base
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();
            c.motor=2.3F;
            c.tipo = TipoCarro.Eletrico;
            c.Rodas = 4;
            c.marca = "Ford";

            int aux = c.Rodas;

            Carro d = new Carro(2.4F, TipoCarro.Eletrico);

            Console.WriteLine($"Tot: {Veiculo.Tot}");

            Console.ReadKey();
        }
    }
}

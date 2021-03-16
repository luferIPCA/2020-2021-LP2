using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6_Classes
{
    public enum TipoCarro { Eletrico, Gasoleo, Outro};
    class Carro : Veiculo
    {
        public float motor;
        public TipoCarro tipo;

        public Carro(){
            motor = 1200;
            tipo = TipoCarro.Gasoleo;
        }
        public Carro(float m, TipoCarro t)
        {
            motor = m;
            tipo = t;
        }
    }

    class Bicicleta : Veiculo
    {
        string quadro;
    }

    public class Trator : Veiculo
    {
        //string matricula;
        //int ano;
        public int eixos;

    }
}

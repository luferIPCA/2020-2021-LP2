using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HerancaDLL;

namespace Aula12_UsaHerancaDLL
{

    class Quadrado : Areas
    {
        double lado;

        public Quadrado()
        {
            nomeObjeto = "Quadrado";
        }
        public double Lado
        {
            get => lado;
            set => lado = value;
        }
        public override double GetArea()
        {
            return lado * lado;
        }

        //public string Nome
        //{
        //    get => nomeObjeto;
        //}
    }

    class Triangulo : Areas
    {
        double @base;       //base é palavra reservada...obrigar usar "@"
        double altura;


        public Triangulo()
        {
            nomeObjeto = "Triangulo";
        }
        public double Base
        {
            get => @base;
            set => @base = value;
        }

        public double Altura
        {
            get => altura;
            set => altura = value;
        }

        public override double GetArea()
        {
            return (@base * altura / 2);
        }

        //public string Nome
        //{
        //    get => nomeObjeto;
        //}
    }
}

/*
 * Algum conjunto de "outras coisas" que podem interessar: C# >=6
 * Analisar com calma
 * 
 * operador @
 * 
 * strings interpoladas
 * 
 * Operador => 
 *      Expression body definition
 *      Lambda Functions (mais tarde)
 * 
 * ! (null-forgiving) operator
 * 
 * ?? and ??= operators
 * 
 * 
 * Consultar: https://www.w3schools.com/cs/default.asp
 * */
using System;

namespace Extra
{
    struct Pessoa
    {
        public string nome;
    }
    class Program
    {
        Pessoa p;
        static void Main(string[] args)
        {
            //uso de @ em variáveis com nomes iguais a palavras chave

            int @for = 23;      //for é palavra chave do ciclo for(;;)
            @for++;


            //string Interpoladas
            Pessoa p;
            p.nome = "André";
            Console.WriteLine($"A variavel @for tem o valor {@for} e pessoa chama-se {p.nome}");
            Console.ReadKey();          


        }

        public override string ToString() => $"{p.nome}".Trim();
        //ou
        //public override string ToString()
        //{
        //    return $"{p.nome}".Trim();
        //}
    }

    class Person
    {
        string nome;
        int idade;

        public string Nome
        {
            get { return $"{nome}".Trim(); }
            set { if (value.Length > 0) nome = value; }
        }

        //public int Idade
        //{
        //    get ;
        //    set ;
        //}

        public int Idade
        {
            get => idade;
            set => idade = value;
        }

        public Person(string n) => nome = n;
        public Person(int i) => idade = i;
        public Person(string n, int i)
        {
            nome = n; idade = i;
        }
    }
}

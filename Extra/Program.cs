/*
 * Algum conjunto de "outras coisas" que podem interessar: C# >=6
 * - Analisar com calma - 
 * 
 * operador @
 * 
 * strings interpoladas
 * 
 * Operador => 
 *      Expression body definition
 *      Lambda Functions
 * 
 * ! (null-forgiving) operator
 * 
 * ?? and ??= operators
 * 
 * Nullable value types T? = T +  null
 * 
 * Documentação de código
 * 
 * https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/documentation-comments
 * 
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

    
}

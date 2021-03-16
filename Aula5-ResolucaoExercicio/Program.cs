/*
 * Paula Rodrigues nº21133
 * Ficha de trabalho nº5
 * exercicio 1
 * LP2
 * 09/03/2021
 */
using System;

namespace Aula4_Fichaex1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array Multidimensional

            #region Declação de variaveis
            int nPessoas;
            //declaração do array auditorio1
            Auditorio.Pessoa[,] auditorio1 = new Auditorio.Pessoa[10, 10];          //criar auditorio 1 - 100 lugares

            //declacarção de uma pessoa
            Auditorio.Pessoa p = new Auditorio.Pessoa();                            //definir uma pessoa para entrar 
            p.nome = "Paula";
            p.ncartCidadao = "1452133";
            p.hEntr = DateTime.Now;
            p.hSaida = DateTime.Now;
            #endregion


            #region Medotos

            Auditorio.InicializarArrays(auditorio1);

            bool registado = Auditorio.RegistarPessoas(p, auditorio1, 7, 8);            //registar uma pessoa

            if(registado == true)
            {
                Console.WriteLine("pessoa registada "); 
            }else
            {
                Console.WriteLine("nao se pode registar");
            }


            nPessoas=Auditorio.PessoasPres(auditorio1);

            Console.WriteLine("tem {0} pessoas", nPessoas);

            #endregion

            #endregion



            #region Jagged array

            #region Declaração do array jagged
            Auditorio.Pessoa[][] auditorio2 = new Auditorio.Pessoa[3][];        // criar auditorio 2 - 57 lugares
            auditorio2[0] = new Auditorio.Pessoa[15];
            auditorio2[1] = new Auditorio.Pessoa[20];
            auditorio2[2] = new Auditorio.Pessoa[22];

            #endregion

            #region Medotos

            Auditorio.InicializarArrays(auditorio2);

            bool regista = Auditorio.RegistarPessoas(p, auditorio2, 2, 8);            //registar uma pessoa

            if (regista == true)
            {
                Console.WriteLine("pessoa registada ");
            }
            else
            {
                Console.WriteLine("nao se pode registar");
            }


            nPessoas=Auditorio.PessoasPres(auditorio2);
            Console.WriteLine("tem {0} pessoas", nPessoas);

            #endregion

            #endregion
            Console.ReadKey();

        }
    }
}


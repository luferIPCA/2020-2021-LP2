/**
 * Manipular Exceções
 * lufer
 */
using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            x = 10;

            try
            {
                bool aux = TrataDados();
            }
            catch (MyException m)
            {
                Console.WriteLine("MESG: " + m.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Main Formato: " + e.Message + " ...Contacte o seu admin");
            }
            catch (Exception e)
            {
                Console.WriteLine("Main Geral : " + e.Message + " ...Contacte o seu admin");
            }

        }


        static bool TrataDados()
        {
            int x;
            try
            {
                Console.Write("Valor: ");
                x = int.Parse(Console.ReadLine());      //pode gerar
                Console.WriteLine("Valor Lido: " + x.ToString());


                DateTime d;
                Console.Write("Data: ");
                d = DateTime.Parse(Console.ReadLine()); //pode gerar
                Console.WriteLine("Data Lida: " + d.ToString());

                int[] valores = new int[10];

                Console.Write("Índice (<10): ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine($"Valor da posição {x}: {++valores[x]}");  //gera exception!!!
            }
            catch (IndexOutOfRangeException i)
            {
                Console.WriteLine($"Erro Índice: {i.Message}");
                //return false;
            }
            catch (FormatException f)
            {
                //Suportar de imediato o problema
                //enviar email ao admin

                //Console.WriteLine($"Erro Formato Dados: {f.Message}");
                //return false;

                //reportar o problema
                //throw new FormatException($"Erro Formato Dados: {f.Message}");
                //throw new MyException("Aconteceu algo com os dados...");
                throw new MyException(f);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro Geral: {e.Message}");
                //return false;
            }
            finally
            {
                Console.WriteLine("Seguro...");
               
            }
            return true;
        }
    }
}

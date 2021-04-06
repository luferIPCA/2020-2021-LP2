/*
 * lufer
 * LP2
 * Herança de Classes
 * Classes Abstratas
 * Interfaces
 * */

namespace Aula11_Heranca
{
    /// <summary>
    /// "Implementação" de Múltipla Herança
    /// </summary>
    public class Z1 : Y, IX
    {
        public Z1() { }
        public Z1(int c) { }
        public override int Prod(int x, int y)
        {
            return (x * y);
        }

        public bool Maior(int x, int y)
        {
            return (x > y);
        }
    }

    /// <summary>
    /// Implementação de Interface
    /// </summary>
    public class Z2 : IX
    {
        public int Soma(int x, int y)
        {
            return x + y;
        }

        public int Soma(int x, int y, int z)
        {
            return x + y+z;
        }

        public int Prod(int x, int y)
        {
            return (2*(x + y));
        }

        public bool Maior(int x, int y)
        {
            return (x > y);
        }
    }

    /// <summary>
    /// Aplicação de Interfaces
    /// </summary>
    class Auxiliar
    {
        public static int DoSomething(IX a)
        {
            return (a.Prod(2, 3));
        }
    }
}

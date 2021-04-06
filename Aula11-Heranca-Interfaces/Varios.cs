/*
 * lufer
 * LP2
 * Herança de Classes
 * Classes Abstratas
 * Interfaces
 * */

namespace Aula11_Heranca
{
    public abstract class X
    {
        int v;

        public X() { }
        public X(int v)
        {
            this.v = v;
        }

        public int Soma(int x, int y)
        {
            return x + y;
        }

        public abstract int Prod(int x, int y);
    }

    public abstract class Y : X
    {
        int k;

        public Y() { }
        public Y(int x, int y):base(y)
        {
            k = x;
        }
        //public override int Prod(int x, int y)
        //{
        //    return (x * y);
        //}

        public int K
        {
            get => k;
            set => k = value;
        }
    }  

}

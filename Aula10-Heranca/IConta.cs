/**
 * 
 **/

namespace Heranca
{
    interface IConta
    {
        bool Deposito(double x);
        double Levantamento(double x);
        string Extrato();
    }
}

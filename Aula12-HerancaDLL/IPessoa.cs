
namespace HerancaDLL
{
    /// <summary>
    /// Descreve uma pessoa
    /// </summary>
    public interface IPessoa
    {
        /// <summary>
        /// 
        /// </summary>
        string Nome
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        string UserID
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string GetPass();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string GetUserId();

    }

    /// <summary>
    /// Descreve um Itilizador (User)
    /// </summary>
    public interface IUser
    {
        bool Login(IPessoa p);
    }

    //TPC:
    //class Pessoa : IPessoa
    //class User : IUser
} 

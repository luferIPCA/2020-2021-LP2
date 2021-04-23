using System;
using System.Collections.Generic;
using System.Text;

namespace MyCollections
{
    interface IOperacoes
    {
        bool InsertElement(object x);
        bool RemoveElement(object x);
        bool UpdateElement(object x);
        object SelectElements(Type typeValue);
    }


    abstract class AbsPessoa
    {
        public virtual string Nome { get; set; }
        public virtual string NC { set; get; }
    }
}

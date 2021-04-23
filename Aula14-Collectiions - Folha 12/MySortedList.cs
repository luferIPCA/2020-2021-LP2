/**
 * lufer
 * SortedLists
 */
using System;
using System.Collections;

namespace MyCollections
{
    /// <summary>
    /// Classe normal para gerir uma sortedlist
    /// </summary>
    class MySortedList
    {
        private SortedList st;
        const int CAPACITY = 100;

        public MySortedList()
        {
            st = new SortedList(CAPACITY);
        }

        public MySortedList(int n)
        {
            if (n > CAPACITY) n = CAPACITY;
            st = new SortedList(n);
        }

    }

    /// <summary>
    /// SortedList de Pessoas
    /// Implementa interface IOperacoes
    /// Exercício Folha 12
    /// </summary>
    class MySortedListPessoas : IOperacoes
    {
        SortedList st;
        const int CAPACITY = 100;

        public MySortedListPessoas()
        {
            st = new SortedList(CAPACITY);
        }

        public MySortedListPessoas(int n)
        {
            if (n > CAPACITY) n = CAPACITY;
            st = new SortedList(n);
        }

        /// <summary>
        /// Insere elemento na sortedlist
        /// Método do interface
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool InsertElement(object x)
        {
            //Evita objetos repetidos
            if (st.ContainsValue(x)) return false;        
            Pessoa p = x as Pessoa;
            //Cuidado, pode haver colisões na chave!!!
            //evita chaves repetidas
            if (st.ContainsKey(p.nome)) return false;
            st.Add(p.nome, p);
            return true;
        }

        /// <summary>
        /// Remove elemento da SortedList
        /// Método do interface
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool RemoveElement(object x)
        {
            if (!st.ContainsValue(x)) return false;
            Pessoa p = x as Pessoa;
            st.Remove(p.nome);
            return true;
        }

        /// <summary>
        /// Se não existir, insere
        /// Se existir altera todos os dados nome e idade
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool UpdateElement(object x)
        {
            Pessoa p = x as Pessoa;
            //evita repetidos e colisões
            if (!st.ContainsValue(x) && !st.ContainsKey(p.nome))
                st.Add(((Pessoa)x).nome, x);
            else
            {
                st.Remove(((Pessoa)x).nome);
                st[((Pessoa)x).nome] = x;
            }
            return true;
        }

        /// <summary>
        /// Devolve uma Sub SortedList
        /// </summary>
        /// <param name="typeValue"></param>
        /// <returns></returns>
        public object SelectElements(Type typeValue)
        {
            SortedList aux = new SortedList();
            ICollection allValues = st.Values;
            foreach (object o in allValues)
            {
                if (o.GetType() == typeValue)
                {
                    aux.Add(((Pessoa)o).nome, o);
                }
            }
            return aux;
        }
    }
}

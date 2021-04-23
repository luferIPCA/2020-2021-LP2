/*
*	<copyright file="Product.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>5/8/2020 11:07:11 AM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics_II
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 5/8/2020 11:07:11 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    /// <summary>
    /// 
    /// </summary>
    public class ProductII : IComparer<Product>
    {
        public string name;      //sou preguiçoso!
        string url;
        int stock;

        public ProductII() { }
        public ProductII(string d, int s) { name = d; stock = s; }

        /// <summary>
        /// Comparador
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>

        public bool Equals(Product other)
        {
            if (other == null) return false;
            return (this.name.Equals(other.name));
        }

        // Deve fazer override == e != .

        public int Compare(Product p1, Product p2)
        {
            if (p1 == null) return 0;
            if (p2 == null) return 0;
            return (string.Compare(p1.name, p2.name));
        }
    }

    public class Product :  IComparer<Product>, IComparable
    {
        public string name;      //sou preguiçoso!
        string url;
        int stock;

        public Product() { }
        public Product(string d, int s) { name = d; stock = s; }

        /// <summary>
        /// Comparador
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>

        public bool Equals(Product other)
        {
            if (other == null) return false;
            return (this.name.Equals(other.name));
        }

        // Deve fazer override == e != .

            /// <summary>
            /// Para usar com Sort(IComparer T)
            /// </summary>
            /// <param name="p1"></param>
            /// <param name="p2"></param>
            /// <returns></returns>
        public int Compare(Product p1, Product p2)
        {
            if (p1 == null) return 0;
            if (p2 == null) return 0;
            return (string.Compare(p1.name, p2.name));
        }

        /// <summary>
        /// Para usar apenas Sort()
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int CompareTo(Object x)
        {
            if (!(x is Product))
            {
                throw new ArgumentException("Impossible to compare with Product...argument is of invalid type!");
            }
            Product aux = x as Product;
            return (this.name.CompareTo(aux.name));
        }
    }

    class CompareProduct : IComparer<Product>
    {
        /// <summary>
        /// Devolde 0, 1, -1
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public int Compare(Product p1, Product p2)
        {
            if (p1 == null) return 0;
            if (p2 == null) return 0;
            return (string.Compare(p1.name, p2.name));
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Product aux = obj as Product;
            if (aux == null) return false;
            else return Equals(aux);
        }

    }

}

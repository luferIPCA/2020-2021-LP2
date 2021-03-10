//
// lufer
// Auxiliar Data
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyArrays
{
    /// <summary>
    /// Data about coordinates for a point
    /// </summary>
    public struct Coords
    {
        public Coords(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; }
        public double Y { get; }

        public override string ToString() => $"({X}, {Y})";
    }

    /// <summary>
    /// Data about any student
    /// </summary>
    public struct Student
    {
        public int number;
        public string name;
        /// <summary>
        /// Construtor de Struct
        /// </summary>
        /// <param name="n"></param>
        /// <param name="s"></param>
        public Student(int n, string s)
        {
            number = n;
            name = s;
        }
    }

    /// <summary>
    /// Data about a Person
    /// </summary>
    public struct Pessoa
    {
        public int idade;
        public string nome;
    }

}

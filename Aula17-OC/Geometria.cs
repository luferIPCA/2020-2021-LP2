/*
*	<copyright file="Aula17_SRP.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>5/4/2021 9:38:57 AM</date>
*	<description>
*	
 *  SOLID Design principles
 *  -   SRP: Single Responsibility Principle
 *  -   IOC: Inversion of Control
 *  -   OCP: Open Close Principle
 *  
 *  Ver: 
 *  - https://medium.com/@mirzafarrukh13/solid-design-principles-c-de157c500425
 *  - https://www.digitalocean.com/community/conceptual_articles/s-o-l-i-d-the-first-five-principles-of-object-oriented-design
 *  
*   </description>
**/
using System;
using System.Collections;

namespace Aula17_OC
{
    #region No_OCP
    public class Circulo
    {
        public double raio;

        public Circulo(double raio)
        {
            this.raio = raio;
        }
    }

    public class Quadrado
    {
        public double lado;

        public Quadrado(double lado)
        {
            this.lado = lado;
        }

    }

    /// <summary>
    /// Apenas calcula a soma das áreas
    /// Mas apresenta também no ecrã???
    /// </summary>
    class CalculaArea
    {
        protected static ArrayList shapes = new ArrayList();

        public CalculaArea()
        {
        }

        public static int AddShape(object shape)
        {
            ///Atenção
            shapes.Add(shape);
            return 1;
        }

        public static ArrayList CalcAreas()
        {
            ArrayList tot = new ArrayList();

            foreach (object s in shapes)
            {
                if (typeof(Quadrado) == s.GetType())
                {
                    tot.Add(Math.Pow(((Quadrado)s).lado, 2));              //lado^2   
                }
                else
                        if (typeof(Circulo) == s.GetType())
                {
                    tot.Add(Math.PI * Math.Pow(((Circulo)s).raio, 2));    //PI*r^2
                }
            }
            return tot;
        }

        /// <summary>
        /// Mais uma tarefa???
        /// </summary>
        public static void ShowAreasScreen()
        {

            foreach (object s in CalcAreas())
            {
                Console.WriteLine("Area:" + s.ToString());
            }

        }
    }

    #endregion

    #region OCP

    /// <summary>
    /// Suportar a abstração
    /// </summary>
    public interface IShape
    {
        double Area();
    }

    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 5/4/2021 9:38:57 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class CirculoOCP: IShape
    {
        public double raio;

        public CirculoOCP(double raio)
        {
         this.raio = raio;
        }

        public double Area()
        {
            //Pi*r*r
            return 0;
        }
    }

  
    public class QuadradoOCP: IShape
    {
        public double lado;

        public QuadradoOCP(double lado)
        {
            this.lado = lado;
        }

        public double Area()
        {
            //lado * lado
            return 0;
        }
    }

    

    class CalculaAreaOCP
    {
        protected static ArrayList shapes = new ArrayList();

        public CalculaAreaOCP()
        {
        }

        public static int AddShape(object shape)
        {
            ///Atenção
            shapes.Add(shape);
            return 1;
        }

        public static ArrayList CalcAreas()
        {
            ArrayList tot = new ArrayList();

            foreach (IShape s in shapes) 
            {
               s.Area();
            }
            return tot;
        }

        /// <summary>
        /// Mais uma tarefa???
        /// </summary>
        public static void ShowAreasScreen()
        {

            foreach (object s in CalcAreas())
            {
                Console.WriteLine("Area:" + s.ToString());
            }

        }
    }

    //E se se pretendesse enviar output para ficheiro XML, JSON ou HTML

    //class OutputResults
    //{
    //    public static void SendHTML(ArrayList shapes) { }
    //    public static void SendXML(ArrayList shapes) { }
    //    public static void SendJson(ArrayList shapes) { }
    //}
    #endregion



}

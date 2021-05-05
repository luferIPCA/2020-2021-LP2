/*
 * SOLID Design principles
 *  -  SRP: Single Responsibility Principle
 *  -  IOC: Inversion of Controll
 *  
 *  Ver: 
 *  - https://medium.com/@mirzafarrukh13/solid-design-principles-c-de157c500425
 *  - https://www.digitalocean.com/community/conceptual_articles/s-o-l-i-d-the-first-five-principles-of-object-oriented-design
 * lufer
 * */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula17_SRP
{
    class Program
    {
        static void Main(string[] args)
        {

            //SRP
            Circulo c = new Circulo(2);
            Quadrado q = new Quadrado(3);
            CalculaArea.AddShape(c);
            CalculaArea.AddShape(q);
            CalculaArea.ShowAreasScreen();
            //OutputResults.SendHTML(shapes);


        }
    }
}

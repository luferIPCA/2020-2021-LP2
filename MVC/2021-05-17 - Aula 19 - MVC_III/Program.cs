using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aulas.Controllers;
using Aulas.Models;
using Aulas.View;

namespace Aulas
{
    class Program
    {
        
        static void Main(string[] args)
        {
            PlataformaView plataformaView = new PlataformaView();
            plataformaView.InicializarPlataformaView();
        }
    }
}

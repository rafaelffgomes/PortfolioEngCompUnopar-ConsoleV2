using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PortfolioEngCompUnopar_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Integrantes integ = new Integrantes();
            integ.DadosCurso();
            integ.DadosIntegrantes();
            integ.Continuar();
        }
    }
}
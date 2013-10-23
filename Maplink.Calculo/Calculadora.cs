using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maplink.Calculo.BLL
{
    public class Calculadora : ICalculadora
    {
        public BE.Rota CustearRota(BE.Calculo calculo)
        {
            Hub.Calculo hubCalculo = new Hub.Calculo();

            return hubCalculo.CalcularRota(calculo);
        }
    }
}

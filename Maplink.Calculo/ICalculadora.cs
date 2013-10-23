using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

using Maplink.Calculo.BE;

namespace Maplink.Calculo.BLL
{
    [ServiceContract]
    public interface ICalculadora
    {
        [OperationContract]
        Rota CustearRota(BE.Calculo calculo);
    }
}

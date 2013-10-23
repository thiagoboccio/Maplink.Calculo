using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
using Maplink.Calculo.BE.Constantes;

namespace Maplink.Calculo.BE
{
    [DataContract]
    public class Calculo
    {
        [DataMember]
        public List<Endereco> Endereco { get; set; }
        [DataMember]
        public ETipoRota TipoRota { get; set; }
    }
}

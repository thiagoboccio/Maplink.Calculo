using Client.CalculoService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var Retorno = new Rota();
            List<Endereco> Enderecos = new List<Endereco>();

            Enderecos.Add(new Endereco 
            { 
                Cidade = "São Paulo",
                Estado = "SP",
                Logradouro = "Avenida Paulista",
                Numero = "1000"
            });

            Enderecos.Add(new Endereco
            {
                Cidade = "São Paulo",
                Estado = "SP",
                Logradouro = "Avenida Rebouças",
                Numero = "100"
            });

            using (CalculoService.CalculadoraClient calculo = new CalculoService.CalculadoraClient())
            {
                Retorno = calculo.CustearRota(new CalculoService.Calculo 
                { 
                    Endereco = Enderecos,
                    TipoRota = ETipoRota.Padrao
                });
            }

            Console.WriteLine("Custo combustível: " + Retorno.CustoCombustivel);
            Console.WriteLine("Distância total: " + Retorno.DistanciaTotal);
            Console.WriteLine("Tempo total: " + Retorno.TempoTotal);
            Console.WriteLine("Custo total: " + Retorno.CustoTotal);
            Console.ReadKey();
        }
    }
}

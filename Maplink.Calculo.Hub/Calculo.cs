using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Maplink.Calculo.BE;
using Maplink.Calculo.Hub.RouteService;
using Maplink.Calculo.Hub.AddressFinderService;

namespace Maplink.Calculo.Hub
{
    public class Calculo
    {
        public BE.Rota CalcularRota(BE.Calculo calculo)
        {
            const string token  = "c13iyCvmcC9mzwkLd0LCbmYC5mUF5m2jNGNtNGt6NmK6NJK=";
            var Rotas           = new List<RouteStop>();
            var TotalRota       = new RouteTotals();
            var RetornoRota     = new Rota();
            var Enderecos       = new List<AddressInfo>();
            var Informacao      = new AddressInfo();
            var OpcoesEndereco  = new AddressOptions();
            var OpcoesRota      = new RouteOptions();

            OpcoesEndereco = EncontrarEndereco(calculo, token, Enderecos, OpcoesEndereco);

            DefinirRotas(Rotas, Enderecos);

            OpcoesRota = DefinirOpcoesRota(calculo, OpcoesRota);

            using (var routeSoapClient = new RouteSoapClient())
            {
                TotalRota = routeSoapClient.getRouteTotals(Rotas, OpcoesRota, token);
            }

            RetornoRota = new Rota
            {
                CustoCombustivel = TotalRota.totalFuelUsed,
                CustoTotal       = TotalRota.totalCost,
                DistanciaTotal   = TotalRota.totalDistance,
                TempoTotal       = TotalRota.totalTime
            };

            return RetornoRota;
        }

        private static RouteOptions DefinirOpcoesRota(BE.Calculo calculo, RouteOptions OpcoesRota)
        {
            OpcoesRota = new RouteOptions
            {
                language = "portugues",
                routeDetails = new RouteDetails { descriptionType = 0, routeType = (int)calculo.TipoRota, optimizeRoute = true },
                vehicle = new Vehicle
                {
                    tankCapacity = 20,
                    averageConsumption = 9,
                    fuelPrice = 3,
                    averageSpeed = 60,
                    tollFeeCat = 2
                }
            };
            return OpcoesRota;
        }

        private static void DefinirRotas(List<RouteStop> Rotas, List<AddressInfo> Enderecos)
        {
            Enderecos.ForEach(o =>
            {
                o.addressLocation.ForEach(location =>
                {
                    Rotas.Add(new RouteStop
                    {
                        description = location.address.street,
                        point = new RouteService.Point
                        {
                            x = location.point.x,
                            y = location.point.y
                        }
                    });
                });
            });
        }

        private static AddressOptions EncontrarEndereco(BE.Calculo calculo, string token, List<AddressInfo> Enderecos, AddressOptions OpcoesEndereco)
        {
            calculo.Endereco.ForEach(o =>
            {
                var Endereco = new Address
                {
                    street = o.Logradouro,
                    houseNumber = o.Numero,
                    city = new AddressFinderService.City { name = o.Cidade, state = o.Estado }
                };

                OpcoesEndereco = new AddressOptions
                {
                    usePhonetic = true,
                    searchType = 2,
                    resultRange = new ResultRange { pageIndex = 1, recordsPerPage = 10 }
                };

                using (var addressFinderSoapClient = new AddressFinderSoapClient())
                {
                    Enderecos.Add(addressFinderSoapClient.findAddress(Endereco, OpcoesEndereco, token));
                }
            });
            return OpcoesEndereco;
        }
    }
}

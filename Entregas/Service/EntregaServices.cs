using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entregas.EntregaService
{
    public class EntregaServices : IEntregaServices
    {

        public int CalcularDistanciaCidadeGoogleMaps(string Cidade)
        {
            // Consome API do googleMaps e retorna uma distancia em km 
            
            if ( Cidade == "Maceio") // rota de 200 km
            {
                return 72;
            }
            else if ( Cidade == "Garanhus" ) // rota de 100 km
            {
                return 36;
            } 

            if ( Cidade == "Agrestina") // rota de 0 km 
            {
                return 0;
            }
            else
            {
                return 0;
            }

        }
        
        
    }
}

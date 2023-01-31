using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entregas.EntregaService
{
    public interface IEntregaServices
    {
        int CalcularDistanciaCidadeGoogleMaps(string cidade);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entregas.EntregaService;
namespace Entregas.Service
{
    public class Exclui
    {
        public int Test()
        {
            Entrega Fds = new Entrega("Maceio");
            int esperado = Fds.ValorFinalMotorista();

            return esperado;
        }

    }
}

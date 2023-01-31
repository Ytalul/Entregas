using Entregas.EntregaService;

namespace Entregas
{
    public class Entrega
    {

        private int ValorPadrao { get; set; }
        private int ValorAdicional { get; set; }
        protected int ValorFinal { get; set; }
        public string CidadeEntrega { get; set; }
        public IEntregaServices _EntregaService;

        public Entrega(string cidade)
        {
            this.CidadeEntrega = cidade;
            this.ValorPadrao = 50;
        }

        public int GetValorFinal()
        {
            return ValorFinal;
        }

        public void SetEntregaService(IEntregaServices entrega)
        {
            this._EntregaService = entrega;
        }
        public int ValorFinalMotorista()
        {
            if ( string.IsNullOrEmpty(this.CidadeEntrega))
            {
                throw new ArgumentNullException();
            }
           this.ValorAdicional = _EntregaService.CalcularDistanciaCidadeGoogleMaps(this.CidadeEntrega);
            ValorFinal = ValorPadrao + ValorAdicional;
            return ValorFinal;
        }


    }
}
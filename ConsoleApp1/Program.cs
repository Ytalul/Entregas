using Entregas;
using Entregas.EntregaService;
using Entregas.Service;

// confirmar e visualizar os valores 

Entrega NovaEntrega = new Entrega("Garanhus");
NovaEntrega.SetEntregaService(new EntregaServices());

int Valor = NovaEntrega.ValorFinalMotorista();
int GetValor = NovaEntrega.GetValorFinal();

Console.WriteLine(Valor);
Console.WriteLine(GetValor);
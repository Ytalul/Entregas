using Entregas;
using Entregas.EntregaService;
using Moq;
using NUnit.Framework;
namespace TestesEntrega
{
    public class TestesEntrega
    {
        private Entrega _Entrega;

        [SetUp]
        public void Setup()
        {
            this._Entrega = new Entrega("Maceio");
        }
        [TearDown]
        public void Teardown() 
        {
            _Entrega.CidadeEntrega = "Agrestina";
        }

        [Test]
        [Category("Sucess")]
        public void TestValorFinalMotoristaRotaDe200()
        {

            var Replica = new Mock<IEntregaServices>();
            Replica.Setup( reply => reply.CalcularDistanciaCidadeGoogleMaps("Maceio")).Returns(72);
            _Entrega.SetEntregaService(Replica.Object);

            int Resultado = _Entrega.ValorFinalMotorista();

            Assert.AreEqual(122, Resultado);
        }

        [Test]
        [Category("Sucess")]
        public void TestValorFinalMotoristaRotaDe100()
        {
            Entrega NovaEntrega = new Entrega("Garanhus");

            var Moc = new Mock<IEntregaServices>();
            Moc.Setup( replica => replica.CalcularDistanciaCidadeGoogleMaps("Garanhus")).Returns(36);
            NovaEntrega.SetEntregaService(Moc.Object);
            int ResulEsperado = 86;
            int Resultado =  NovaEntrega.ValorFinalMotorista();

            Assert.AreEqual(ResulEsperado, NovaEntrega.GetValorFinal());

        }

        [Test]
        public void TestValorFinalMotoristaRotaDe0()
        {
            Entrega NovaEntrega = new Entrega("Agrestina");
            var Moc = new Mock<IEntregaServices>();
            Moc.Setup( Replica => Replica.CalcularDistanciaCidadeGoogleMaps("Agrestina")).Returns(0);
            NovaEntrega.SetEntregaService(Moc.Object);

            int ResulEsperado = 50;
            int Resultado = NovaEntrega.ValorFinalMotorista();

            Assert.AreEqual(ResulEsperado, NovaEntrega.GetValorFinal());
        }

        [Test]
        [Category("Exception")]
        public void TestValorFinalMotoristaExceptionCidadeNula()
        {
            Entrega NovaEntrega = new Entrega("");
            NovaEntrega.SetEntregaService(new EntregaServices());
            Assert.Throws<ArgumentNullException>(delegate { NovaEntrega.ValorFinalMotorista(); });
        }

        [Test]
        public void TestValorFinalMotoristaVerify()
        {
            Entrega NovaEntrega = new Entrega("Maceio");

            var Moc = new Mock<IEntregaServices>();
            NovaEntrega.SetEntregaService(Moc.Object);

            NovaEntrega.ValorFinalMotorista();

            Moc.Verify( Replica => Replica.CalcularDistanciaCidadeGoogleMaps("Maceio"), Times.Once());

        }
        



    }
}
using PadraoPattem;

namespace PattemTest
{
    public class Regra04Teste
    {
        [Fact]
        public void SudesteScoreMenorRetornaTrue()
        {
            bool esperado = true;
            Conta mockConta = new Conta();
            mockConta.Score = 199;
            TransferenciaBancaria transacao = new TransferenciaBancaria();
            transacao.AgenciaTransacao = "MG";


            IBloquearConta processarBloqueo = new Regra4Bloqueo();

            bool resultado = processarBloqueo.analiseBloqueo(mockConta, transacao);



            Assert.True(resultado);
        }
        [Fact]
        public void NaoSudesteScoreMenorRetornaFalse()
        {
            bool esperado = false;
            Conta mockConta = new Conta();
            mockConta.Score = 100;
            TransferenciaBancaria transacao = new TransferenciaBancaria();
            transacao.AgenciaTransacao = "SE";


            IBloquearConta processarBloqueo = new Regra4Bloqueo();

            bool resultado = processarBloqueo.analiseBloqueo(mockConta, transacao);



            Assert.False(resultado);
        }
    }
}
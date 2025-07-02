namespace Troco
{
    internal class Troco1
    {
        //Atributos;
        public double PrecoUnitarioProduto;
        public int QuantidadeProduto;
        public double DinheiroRecebido;

        //Construtor;
        public Troco1(double precoUnitarioProduto, int quantidadeProduto, double dinheiroRecebido)
        {
            PrecoUnitarioProduto = precoUnitarioProduto;
            QuantidadeProduto = quantidadeProduto;
            DinheiroRecebido = dinheiroRecebido;
        }

        //Método que verifica se o cliente possui dinheiro suficiente e retorna o troco que será devolvido ao cliente.
        public void Troco()
        {
            if (DinheiroRecebido >= (PrecoUnitarioProduto * QuantidadeProduto))
            {
                double troco = DinheiroRecebido - PrecoUnitarioProduto * QuantidadeProduto;
                Console.WriteLine($"TROCO = {troco:F2}");
            }
            else
            {
                double resto = PrecoUnitarioProduto * QuantidadeProduto - DinheiroRecebido;
                Console.WriteLine($"DINHEIRO INSUFICIENTE. FALTAM {resto:F2} REAIS");
            }
        }
    }
}

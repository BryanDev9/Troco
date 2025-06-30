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

        //Método que retorna o troco que será devolvido ao cliente.
        public double Troco()
        {
            return DinheiroRecebido - PrecoUnitarioProduto * QuantidadeProduto;
        }
    }
}

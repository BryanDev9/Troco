//Namespace;
using Troco;

//Entrada de dados;
Console.Write("Preço unitário do produto: ");
double precoUnitarioProduto = double.Parse(Console.ReadLine());
Console.Write("Quantidade comprada: ");
int quantidadeProduto = int.Parse(Console.ReadLine());
Console.Write("Dinheiro recebido: ");
double dinheiroRecebido = double.Parse(Console.ReadLine());

//Instânciação do construtor;
Troco1 troco = new Troco1(precoUnitarioProduto, quantidadeProduto, dinheiroRecebido);

//Método que verifica se o cliente possui dinheiro suficiente e retorna o troco que será devolvido ao cliente.
troco.Troco();

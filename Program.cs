double cotacao = 5.13;

Console.WriteLine($"A cotação do euro hoje é: R$ {cotacao}");
Console.WriteLine($"Quantos euros você irá comprar?");
int compraeuro = Convert.ToInt32(Console.ReadLine());

double vcompra = cotacao * compraeuro;

Console.WriteLine($"O valor da compra de {compraeuro} euros em reais são: R$ {vcompra}");
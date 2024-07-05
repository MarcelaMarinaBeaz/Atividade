using Atividade;
using System.Security.AccessControl;

//Atividade 1

Console.WriteLine("Digite uma quantidade mínima");
int quant_min = int.Parse(Console.ReadLine());

Console.WriteLine("Digite uma quantidade máxima");
int quant_max = int.Parse(Console.ReadLine());

int estoque = (quant_min + quant_max) / 2;
Console.WriteLine($"Estoque : {estoque}");


//Atividade 2
int acao = -1;
Console.WriteLine("Digite um valor em dolar");
double valor_dolar = double.Parse(Console.ReadLine());

while (acao < 0 || acao > 2)
{
    Console.WriteLine("Deseja saber qual e esse valor em reais?");
    Console.WriteLine("1 - Sim" +
                      "\n2 - Não");
    acao = int.Parse(Console.ReadLine());
    if (acao == 1)
    {
        //Valor real do dolar 
        double V_dolar = 5.50;
        double resultado = valor_dolar * V_dolar;
        Console.WriteLine($"Valor: {resultado}");
    }
    else if (acao < 0 || acao > 2)
    {
        Console.WriteLine("Ação invalida");
        Console.WriteLine("Digite uma ação valida");
    }
}

//Atividade 3 

int acaosolicitada = -1;


Console.WriteLine("Qual o nome do vendedor?");
string Nome_Vendedor = Console.ReadLine();

Console.WriteLine("Qual o codico da peça?");
string cod_peca = Console.ReadLine();

Console.WriteLine("Qual Valor da peça?");
double valor_peca = double.Parse(Console.ReadLine());

Console.WriteLine("Quantidade de peças vendidas?");
int quant_vendida = int.Parse(Console.ReadLine());



while (acaosolicitada < 0 || acaosolicitada > 2)
{

    Console.WriteLine("Deseja saber qual e sua comição?");
    Console.WriteLine("1 - sim" +
                      "\n2 - não");
    acaosolicitada = int.Parse(Console.ReadLine());
    if (acaosolicitada == 1)
    {
        comissao c = new comissao(quant_vendida, valor_peca, Nome_Vendedor);
        c.Soma_Comissao();
    }
    else if (acaosolicitada < 0 || acaosolicitada > 2)
    {
        Console.WriteLine("Ação invalida");
        Console.WriteLine("Digite uma ação valida");
    }
}
//Atividade 4


Console.WriteLine("Informe um valor?");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Informe um segundo Valor?");
int B = int.Parse(Console.ReadLine());

if (A == 0 || B == 0)
{

}
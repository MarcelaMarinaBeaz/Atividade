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
//Atividade 5






//Atividade 6
int numero = 0;
int numero1 = 0;
Console.WriteLine($"Escolha Uma das açoes abaixo:" +
                  $"\n1 - Adiçao" +
                  $"\n2 - Subtraçao" +
                  $"\n3 - Multiplicaçao" +
                  $"\n4 - Divisão" +
                  $"\n------------------------------");
    if(numero == 1)
    {
    int resultado = numero + numero1;
    }
    else if(numero == 2)
    {
    int resultado = numero - numero1;
}
    else if(numero == 3)
    {
    int resultado = numero * numero1;
}
    else if(numero == 4)
    {
    int resultado = numero / numero1;
}
    else
    {
    Console.WriteLine("Digite uma acao valida!!!!!!!!!");
    }

//Atividade 7



Console.WriteLine($"\n-----------------------------------------------------------------" +
                  $"\nEscreva Qual acao deseja realizar" +
                  $"\n1 - Verificar se um dos numeros lidos é ou não multiplo do outro" +
                  $"\n2 - Verificar se os numeros lidos sao pares" +
                  $"\n3 - Verificar se a média dos dois numeros é maior ou igual a 7" +
                  $"\n4 - Sair" +
                  $"\n----------------------------------------------------------------");

int num = 0;
num= int.Parse(Console.ReadLine());


if (num == 1)
{
    int num1 = 0;
    int num2 = 0;
    int Resultado = num1 % num2;
}
else if (num == 2)
{
    int numeroo = 0;
    int numerooo= 0;
    if(numeroo % 2 == 0 && numerooo % 2 == 0)
    {
        Console.WriteLine("Os numeros informados serao Pares");
    }
    else
    {
        Console.WriteLine("Os numeros informados serao impares");
    }
    return;

}
else if (num == 3)
{
    int num3=0;
    int num4= 0;
    if(num3 >= 7 && num4 >= 7)
    {
        Console.WriteLine($"{num3} é maior que 7 e {num4} tbm");
    }
    
}
else if (num == 4)
{
   
}
// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection.Metadata;
using System.Threading;
Console.OutputEncoding = System.Text.Encoding.UTF8;


Random random = new Random();

bool Func(int usr, int comp)
{
    // true: usuario ganha
    // false: computador ganha

    var meuDicionario = new Dictionary<int, int>
    {
        { 0, 2 },
        { 1, 0 },
        { 2, 1 },
    };

    if (comp == meuDicionario[usr])
    {
        return true;
    }
    else
    {
        return false;
    }
};

var Elementos = new Dictionary<int, string>
    {
        { 0,  "pedra"},
        { 1, "papel" },
        { 2, "tesoura" },
    };


Console.WriteLine("😀 Olá! Vamos jogar Jokempo?");
Console.WriteLine("1 - Sim ou 0 - Não");
if(Console.ReadKey().KeyChar == '1')
{
    Console.WriteLine("Então vamos começar...");
    Console.WriteLine("Escolha uma opção: 0 - Pedra ✊, 1 - Papel ✋ ou 2 - Tesoura ✌");
    int opcao = Convert.ToInt32(Console.ReadLine());
    var jogada = random.Next(0, 2);
    Console.WriteLine($"Você jogou {Elementos[opcao]}");
    Console.WriteLine($"O computador jogou {Elementos[jogada]}");
    Console.WriteLine($"Jogando {Elementos[opcao]} contra {Elementos[jogada]} em uma arena");
    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine(". ");
        Thread.Sleep(500);
    }

    if (opcao == jogada || jogada == opcao)
    {
        Console.WriteLine("Empate mate");
    }
    if (Func(opcao, jogada))
    {
        Console.WriteLine("VOCE GANHOU!!! (mesmo que não vale nada)");
    }
    else
    {
      Console.WriteLine($"Desculpa! Não foi dessa vez lixo. 😕 ");
    }
   
}
Console.WriteLine("👋 Tchau! Até a próxima");


 
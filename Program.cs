Random random = new Random();
int numeroSecreto = random.Next(1, 101);
int tentativas = 0;
bool acertou = false;

Console.Clear();

Console.WriteLine("--- Jogo de Adivinhação ---\n");
Console.WriteLine("Tente adivinhar o número secreto entre 1 e 100.");
Console.WriteLine("Você tem no máximo 7 tentativas.\n");

while (tentativas < 7 && !acertou)
{
    Console.Write("Digite o seu palpite: ");
    int palpite;

    if (!int.TryParse(Console.ReadLine(), out palpite)){
        Console.WriteLine("Entrada inválida. Tente novamente.\n");
        continue;
    }

    tentativas++;

    if (palpite == numeroSecreto){
        acertou = true;
        Console.WriteLine("\nParabéns! Você acertou o número secreto!");
        Console.WriteLine($"Número de tentativas: {tentativas}\n");
    }
    else {
    string dica;
    int diferenca = Math.Abs(palpite - numeroSecreto);

    if (diferenca <= 3){
        dica = "Está pelando!";
    }
    else if (diferenca <= 10){
        dica = "Está quente!";
    }
    else if (diferenca >= 30){
        dica = "Está congelando!";
    }
    else{
        dica = "Está frio!";
    }

        Console.WriteLine($"{dica} O número secreto é {(palpite < numeroSecreto ? "maior" : "menor")} do que o palpite.\n");
    }
}

if (!acertou)
{
    Console.WriteLine("\nVocê excedeu o número máximo de tentativas. Você perdeu o jogo!");
    Console.WriteLine($"O número secreto era: {numeroSecreto}\n");
}

Console.WriteLine("Fim do jogo. Obrigado por jogar!\n");
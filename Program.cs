 Console.Clear();

        Console.WriteLine("--- Esperto Contra Sabido ---");
        Console.Write("\nQuantos alimentos serão distribuídos? ");

int totalAlimentos = int.Parse(Console.ReadLine());
int picaPau = 0;
int raposinha = 0;
 int rodada = 1;
 int restante = totalAlimentos;
       
     Console.WriteLine();
while (restante > 0)
{
    // Pica-Pau recebe apenas 1 item por rodada
    int paraPicaPau = Math.Min(1, restante);
    Console.Write($"{paraPicaPau} para você. ");
    picaPau += paraPicaPau;
    restante -= paraPicaPau;

    if (restante <= 0) break;

    int paraRaposinha = Math.Min(rodada, restante);
    Console.Write("1");
    for (int i = 2; i <= paraRaposinha; i++)
    {
        Console.Write($", {i}");
    }
    Console.WriteLine($" para mim.");
    raposinha += paraRaposinha;
    restante -= paraRaposinha;

    rodada++;

}
Console.WriteLine("\nPica-pau recebeu {0} alimento(s).", picaPau);
Console.WriteLine("Raposinha recebeu {0} alimento(s).", raposinha);

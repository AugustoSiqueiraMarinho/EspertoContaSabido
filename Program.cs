using System;
 
class Program

{

    static void Main()

    {

        Console.WriteLine("--- Esperto Contra Sabido ---\n");
 
        Console.Write("Quantos alimentos serão distribuídos? ");

        int total = Convert.ToInt32(Console.ReadLine());
 
        Console.WriteLine();
 
        int picaPau = 0;

        int raposinha = 0;

        int restantes = total;
 
        int numero = 1; // 1 para você, 2 para você, 3 para você...
 
        while (restantes > 0)

        {

            // Entrega para o Pica-Pau

            if (restantes > 0)

            {

                Console.Write($"{numero} para você. ");

                picaPau++;

                restantes--;

            }
 
            // Agora a Raposinha pega a mesma quantidade

            Console.Write("1");

            raposinha++;

            restantes--;
 
            // Se ainda houver comida, continua 2, 3, 4...

            for (int i = 2; i <= numero && restantes > 0; i++)

            {

                Console.Write($", {i}");

                raposinha++;

                restantes--;

            }
 
            Console.WriteLine(" para mim.");
 
            numero++;

        }
 
        Console.WriteLine();

        Console.WriteLine($"Pica-pau recebeu {picaPau} alimento(s).");

        Console.WriteLine($"Raposinha recebeu {raposinha} alimento(s).");

    }

}

 

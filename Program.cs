const double constanteConversao = 1.609;
double milhas, quilometros;

Console.Write("Por favor, insira a distância em milhas: ");
milhas = Convert.ToDouble(Console.ReadLine()!);

quilometros = milhas * constanteConversao;

Console.WriteLine($"\nO equivalente em quilômetros é {quilometros} Km");
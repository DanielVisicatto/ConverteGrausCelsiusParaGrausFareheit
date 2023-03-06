Console.Write("Digite a temperatura em ºC: ");

double temperaturaCelsius = double.Parse(Console.ReadLine());
double temperaturaFareheit = (double)(temperaturaCelsius * 1.8) + 32;

Console.WriteLine("O equivalente em Farenheit é: {0}ºF", temperaturaFareheit);

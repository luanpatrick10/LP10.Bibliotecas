using Biblioteca.Matematica;

double notaA = Convert.ToDouble(Console.ReadLine());
double notaB = Convert.ToDouble(Console.ReadLine());
double notaC = Convert.ToDouble(Console.ReadLine());

double[] pesoDaNota = new double [3];
pesoDaNota[0] = 2;
pesoDaNota[1] = 3;
pesoDaNota[2] = 5;

double[] notas = new double[3];
notas[0] = notaA;
notas[1] = notaB;
notas[2] = notaC;

Console.WriteLine($"MEDIA = {Calculos.CalcularMediaPonderadaDeNotas(notas, pesoDaNota, 1).ToString("N1")}");
using System.Globalization;

int numeroDoFuncionario, horasTrabalhadas;
double valorDaHora, salario;

numeroDoFuncionario = int.Parse(Console.ReadLine());
horasTrabalhadas = int.Parse(Console.ReadLine());

valorDaHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
salario = horasTrabalhadas * valorDaHora;

Console.WriteLine("NUMBER = "+numeroDoFuncionario);
Console.WriteLine("SALARY = R$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
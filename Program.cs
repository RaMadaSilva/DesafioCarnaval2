using System.Globalization;
namespace DesafioCarnaval2;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Informe sua altura:", CultureInfo.InvariantCulture);
            double.TryParse(Console.ReadLine(), out double altura);
            Console.Write("Informe seu peso:", CultureInfo.InvariantCulture);
            double.TryParse(Console.ReadLine(), out double peso);
            var imc = CalcularIMC(peso, altura);
            Console.WriteLine($"> seu IMC é {imc.ToString("F2", CultureInfo.InvariantCulture)}");
            if (imc < 16)
            {
                Console.WriteLine("> Magresa grau III");
            }
            else if (imc >= 16 && imc < 17)
            {
                Console.WriteLine("> Magresa grau II");
            }
            else if (imc >= 17 && imc < 18.5)
            {
                Console.WriteLine("> Magresa grau I");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("> Estrofia");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("> Sobrepeso");
                Console.WriteLine("> Risco: Aumentado");
            }
            else if (imc >= 30 && imc < 35)
            {
                Console.WriteLine("> Obeisdade Grau I");
                Console.WriteLine("> Risco: Moderado");
            }
            else if (imc >= 35 && imc <= 40)
            {
                Console.WriteLine("> Obeisdade Grau II");
                Console.WriteLine("> Risco: Grave");
            }
            else if (imc > 40)
            {
                Console.WriteLine("> Obeisdade Grau III");
                Console.WriteLine("> Risco: Muito Grave");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("erro de conversão: " + ex.Message);
        }
    }

    public static double CalcularIMC(double peso, double altura)
        => peso / (altura * altura);
}

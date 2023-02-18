using System.Globalization;
namespace DesafioCarnaval2;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Informe sua altura (m): ", CultureInfo.InvariantCulture);
            double.TryParse(Console.ReadLine(), out double altura);
            Console.Write("Informe seu peso (Kg): ", CultureInfo.InvariantCulture);
            double.TryParse(Console.ReadLine(), out double peso);
            Console.WriteLine("------------------------------------------");
            var imc = CalcularIMC(peso, altura);
            var classif = Classficador(imc);
            var risco = Risco(classif);
            Console.WriteLine($"> seu IMC é {imc.ToString("F2", CultureInfo.InvariantCulture)}\n> {classif}\n> Risco: {risco}");

        }
        catch (Exception ex)
        {
            Console.WriteLine("erro de conversão: " + ex.Message);
        }
    }

    public static double CalcularIMC(double peso, double altura)
        => peso / (altura * altura);

    static string Classficador(double imc)
    {
        if (imc < 16)
            return "Magresa grau III";
        else if (imc >= 16 && imc < 17)
            return "Magresa grau II";
        else if (imc >= 17 && imc < 18.5)
            return "Magresa grau I";
        else if (imc >= 18.5 && imc < 25)
            return "Estrofia";
        else if (imc >= 25 && imc < 30)
            return "Sobrepeso";
        else if (imc >= 30 && imc < 35)
            return "Obeisdade Grau I";
        else if (imc >= 35 && imc <= 40)
            return "Obeisdade Grau II";
        else
            return "Obeisdade Grau III";
    }

    static string Risco(string classificacao)
    {
        if (classificacao == "Sobrepeso")
            return "Aumentado";
        if (classificacao == "Obeisdade Grau I")
            return "Moderado";
        if (classificacao == "Obeisdade Grau II")
            return "Grave";
        if (classificacao == "Obeisdade Grau III")
            return "Muito Grave";
        return string.Empty;
    }
}

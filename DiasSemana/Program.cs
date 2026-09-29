using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    public static void Main()
    {
        try
        {



            Dictionary<string, int> diasSemana = new Dictionary<string, int>() {
                { "lunes", 1 },
                { "martes", 2 },
                { "miercoles", 3 },
                { "jueves", 4 },
                { "viernes", 5 },
                { "sabado", 6 },
                { "domingo", 7 }
            };

            
            DeDiaANum(diasSemana);
            DeNumADia(diasSemana);
        }
        catch (Exception error)
        {
            Console.WriteLine($"Se ha producido el siguiente error: {error.Message}");
        }
    }

    public static void DeDiaANum(Dictionary<string, int> diasSemana)
    {

        string diaEscogido = "";

        do
        {
            Console.Write("Introduce el dia de la semana: ");
            string? resposta = Console.ReadLine();

            if (resposta == null)
            {
                Console.WriteLine("El texto introducido no es válido");
                continue;
            }

            diaEscogido = resposta.ToLower();

            if (!diasSemana.ContainsKey(diaEscogido))
            {
                Console.WriteLine("El texto introducido no es un dia de la semana");
                continue;
            }

            Console.WriteLine($"El {resposta} es el dia {diasSemana[diaEscogido]} de la semana");
            break;


        } while (true);
    }

    public static void DeNumADia(Dictionary<string, int> diasSemana)
    {
        
        int diaEscogido = 0;


        do
        {
            Console.Write("Introduce un múmero del 1 al 7: ");
            string? resposta = Console.ReadLine();

            if (!int.TryParse(resposta, out diaEscogido))
            {
                Console.WriteLine("El texto introducido no es válido");
                continue;
            }
            if (diaEscogido < 1 || diaEscogido > 7)
            {
                Console.WriteLine("El número introducido no es válido");
                continue;
            }
            if (!diasSemana.ContainsValue(diaEscogido))
            {
                Console.WriteLine("El texto introducido no es un dia de la semana");
                continue;
            }
            
            foreach (var dia in diasSemana)
            {
                if (dia.Value == diaEscogido)
                {
                    Console.WriteLine($"El dia {resposta} de la semana es {dia.Key}");
                    break;
                }
            }

            break;

        } while (true);
    }


}
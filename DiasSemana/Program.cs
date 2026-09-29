class Program
{
    public static void Main()
    {
        try
        {
            DeDiaANum();
            DeNumADia();
        }
        catch (Exception error)
        {
            Console.WriteLine($"Se ha producido el siguiente error: {error.Message}");
        }
    }

    public static void DeDiaANum()
    {
        var diasSemana = new Dictionary<string, int>
        {
            ["lunes"] = 1,
            ["martes"] = 2,
            ["miercoles"] = 3,
            ["jueves"] = 4,
            ["viernes"] = 5,
            ["sabado"] = 6,
            ["domingo"] = 7
        };

        do
        {
            Console.Write("Introduce el dia de la semana: ");
            string? resposta = Console.ReadLine();

            if (!diasSemana.TryGetValue(resposta.ToLower(), out int numDia))
            {
                Console.WriteLine("El texto introducido no es un dia de la semana");
                continue;
            }

            Console.WriteLine($"El {resposta} es el dia {numDia} de la semana");
            break;


        } while (true);
    }

    public static void DeNumADia()
    {
        string[] diasSemana = {"", "lunes", "martes", "miércoles", "jueves", "viernes", "sábado", "domingo"};
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

            Console.WriteLine($"El dia {resposta} de la semana es {diasSemana[diaEscogido]}");
            break;

        } while (true);
    }


}
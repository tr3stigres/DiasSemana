using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{

    public enum semanaDias
    {
        lunes = 1,
        martes = 2,
        miercoles = 3,
        jueves = 4,
        viernes = 5,
        sabado = 6,
        domingo = 7
    };

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

            


            DeDiaANumDiccionari(diasSemana);
            DeNumADiaDiccionari(diasSemana);

            DeDiaANumEnum();
            DeNumADiaEnum();


        }
        catch (Exception error)
        {
            Console.WriteLine($"Se ha producido el siguiente error: {error.Message}");
        }
    }


    

    public static void DeDiaANumDiccionari(Dictionary<string, int> diasSemana)
    {

        string diaEscogido = "";

        do
        {
            diaEscogido = recogerDia();
            if (!diasSemana.ContainsKey(diaEscogido))
            {
                Console.WriteLine("El texto introducido no es un dia de la semana");
                continue;
            }
            break;

        } while (true);

        Console.WriteLine($"El dia {diaEscogido} de la semana es {diasSemana[diaEscogido]}");

    }

    

    public static void DeNumADiaDiccionari(Dictionary<string, int> diasSemana)
    {
        
        int diaEscogido = 0;


        do
        {
            diaEscogido = recogerNumero();
            

            if (!diasSemana.ContainsValue(diaEscogido))
            {
                Console.WriteLine("El texto introducido no es un día de la semana");
                continue;
            }
            
            foreach (var dia in diasSemana)
            {
                if (dia.Value == diaEscogido)
                {
                    Console.WriteLine($"El día {diaEscogido} de la semana es {dia.Key}");
                    break;
                }
            }

            break;

        } while (true);
    }



    public static void DeDiaANumEnum()
    {
        string diaEscogido = "";
        
        do
        {
            diaEscogido = recogerDia();

            if(!Enum.IsDefined(typeof(semanaDias), diaEscogido)) 
            {
                Console.WriteLine("El texto introducido no es un dia de la semana");
                continue;
            }

            foreach (var dia in Enum.GetValues(typeof(semanaDias)))
            {
                if (dia.ToString() == diaEscogido)
                {
                    Console.WriteLine($"El dia {diaEscogido} de la semana es {(int)dia}");
                    break;
                }
            }

            break;
        } while (true);
        
    }


    public static void DeNumADiaEnum()
    {

        int diaEscogido = 0;

        do
        {
            diaEscogido = recogerNumero();            
            if (diaEscogido < 1 || diaEscogido > 7)
            {
                Console.WriteLine("El texto introducido no es un dia de la semana");
                continue;
            }

            foreach (var dia in Enum.GetValues(typeof(semanaDias)))
            {
                if ((int)dia == diaEscogido)
                {
                    Console.WriteLine($"El dia {diaEscogido} de la semana es {dia}");
                    break;
                }
            }

            break;            
        } while (true);
    }


    public static string recogerDia()
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

            break;


        } while (true);

        return diaEscogido;
    }

    public static int recogerNumero()
    {
        int diaEscogido = 0;

        do
        {
            Console.Write("Introduce el número del día de la semana: ");
            string? resposta = Console.ReadLine();

            if (!int.TryParse(resposta, out diaEscogido))
            {
                Console.WriteLine("El texto introducido no es un dia de la semana");
                continue;
            }
            break;
        } while (true);

        return diaEscogido;
    }


}
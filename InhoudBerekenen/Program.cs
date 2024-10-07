internal class Program
{
    private static void Main(string[] args)
    {
        bool run = true;

        while (run)
        {
            double lengteNum = getInput("lengte");
            double hoogteNum = getInput("hoogte");
            double breedteNum = getInput("breedte");       
            
            double inhoudCM = lengteNum * hoogteNum * breedteNum;
            double inhoudL = inhoudCM / 1000;

            Console.Clear();
            Console.WriteLine($"De inhoud van de bak is {inhoudL} L\n");
            Console.WriteLine($"Druk op X om af te sluiten of een andere toets om door te gaan\n");

           string input = Console.ReadLine();

            if (input?.ToLower() == "x")
            {
                run = false;
            }
        }
    }

    static double getInput(string dimension)
    {
        double result;

        while (true)
        {
            Console.WriteLine($"\nGeef de {dimension} in centimeters");
            string input = Console.ReadLine();

            if (double.TryParse(input, out result))
            {
                return result;
            }

            Console.WriteLine("Ongeldige invoer!");
            Console.ReadLine();
        }
    }
}
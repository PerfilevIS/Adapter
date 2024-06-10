using PGGame;

namespace AddapterPatern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            ComputerGame game1 = new ComputerGame(
                "Grand Theft Auto VI", PegiAgeRating.P18,100.0,8192,100, 16, 8, 3.5
            );
            // адаптер ComputerGameAdapter
            PCGame adaptedGame1 = new ComputerGameAdapter(game1);

            // Демонстрация использования адаптера
            Console.WriteLine($"Title: {adaptedGame1.getTitle()}");
            Console.WriteLine($"Pegi Allowed Age: {adaptedGame1.getPegiAllowedAge()}");
            Console.WriteLine($"Is Triple-A Game: {adaptedGame1.isTripleAGame()}");
            Requirements requirements = adaptedGame1.getRequirements();
            Console.WriteLine($"GPU Memory: {requirements.getGpuGb()} GB");
            Console.WriteLine($"Disk Space: {requirements.getHDDGb()} GB");
            Console.WriteLine($"RAM: {requirements.getRAMGb()} GB");
            Console.WriteLine($"CPU Speed: {requirements.getCpuGhz()} GHz");
            Console.WriteLine($"CPU Cores: {requirements.getCoresNum()}");

        }

    }


}

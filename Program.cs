using System.Text.Json;
using Newtonsoft.Json;
//using ConsumingAPIs;


namespace Lab4_API_Jayden
{
    public class Program
    {

        public static async Task Main(string[] args)
        {
            await ZeldaCall();

            // Load JSON data from a file or use the JSON data as a string
            string jsonData = File.ReadAllText("ZeldaGames.json"); // Replace with your JSON file path

            // Deserialize JSON data into a list of Game objects
            List<ZeldaData> dataList = JsonConvert.DeserializeObject<List<ZeldaData>>(jsonData);

            // Display a menu to look up games
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Search for a game by name");
                Console.WriteLine("2. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":

                        Console.Write("Enter the name of the game: ");
                        string gameName = Console.ReadLine();
                        SearchGameByName(dataList, gameName);
                        break;
                    case "2":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void SearchGameByName(List<ZeldaData> games, string name)
        {
            foreach (var game in games)
            {
                if (game.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Game Name: " + game.Name);
                    Console.WriteLine("Description: " + game.Description);
                    Console.WriteLine("Developer: " + game.Developer);
                    Console.WriteLine("Publisher: " + game.Publisher);
                    Console.WriteLine("Released Date: " + game.ReleasedDate.ToShortDateString());
                    Console.WriteLine();
                    return;
                }
            }

            Console.WriteLine("Game not found.");
        }

        public static async Task ZeldaCall()
        {
            https://docs.zelda.fanapis.com/docs/games

            var client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync("https://docs.zelda.fanapis.com/docs/games");

            string json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

            ZeldaData p = JsonSerializer.Deserialize<ZeldaData>(json, options);
            Console.WriteLine(p + "\n");
        }



    }

}
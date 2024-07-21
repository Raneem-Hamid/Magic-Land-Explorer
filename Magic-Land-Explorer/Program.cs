using Magic_Land_Explorer.Tasks;
using Newtonsoft.Json;

namespace Magic_Land_Explorer
{
    public class Program
    {
        public delegate void TaskDelegate(List<Category> categories);
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Magic Land Explorer!");
            Console.WriteLine("Explore the enchanting world of Magic Land through various categories of attractions.");
            Console.WriteLine("You can filter destinations by duration, sort them alphabetically, and find the top three longest-duration attractions.");
            Console.WriteLine("Let's get started with exploring the magical destinations!");


            string json = File.ReadAllText("../../../data/MagicLandData.json");
            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(json);

            Dictionary<int, TaskDelegate> tasks = new Dictionary<int, TaskDelegate>
        {
            { 1, FilterDestinations.Filter_Destinations },
            { 2, LongestDuration.Longest_Duration },
            { 3, SortByName.Sort_By_Name },
            { 4, Top3Duration.Top3_Duration }
        };

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1- Show filtered destinations");
                Console.WriteLine("2- Show destination with longest duration");
                Console.WriteLine("3- Sort destinations by name");
                Console.WriteLine("4- Show top 3 longest durations");
                Console.WriteLine("5- Exit");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 5)
                {
                    if (choice == 5)
                    {
                        break;
                    }

                    if (tasks.ContainsKey(choice))
                    {
                        tasks[choice].Invoke(categories);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please choose a number between 1 and 5.");
                }
            }



        }
    }
}

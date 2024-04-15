

using Newtonsoft.Json;

List<Youtube> youtubes = new List<Youtube>();
string filename = "youtube.json";

while(true)
{
    //load the file if it exist
    if(youtubes.Count == 0 && File.Exists(filename)) {
        StreamReader reader = new StreamReader(filename);
        string youtubeJson = reader.ReadToEnd();
        youtubes = JsonConvert.DeserializeObject<List<Youtube>>(youtubeJson);
        reader.Close();
        Console.WriteLine("File loaded\n");

    }
    Console.WriteLine("Youtube history menu");
    Console.WriteLine("1. Add a new history");
    Console.WriteLine("2. Show all watched list");
    Console.WriteLine("3. Save watchlist");
    Console.Write("Selection:");
    string selection = Console.ReadLine();

    switch(selection)
    {
        case "1":
            Console.Write("url:");
            string url = Console.ReadLine();
            Console.Write("Date Watched:");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Category:");
            string category = Console.ReadLine();

            Youtube tube = new Youtube(url, date, category);
            youtubes.Add(tube);
            Console.WriteLine("New watch history added\n\n");
            break;

        case "2":
            foreach(Youtube youtube in youtubes)
            {
                Console.WriteLine(youtube);
            }
            Console.WriteLine();
            break;
        case "3":
            StreamWriter writer = new StreamWriter(filename);
            string youtubeToJson =JsonConvert.SerializeObject(youtubes);
            writer.WriteLine(youtubeToJson);
            Console.WriteLine("Watchlist saved to file!!\n");
            writer.Close();
            break;
        default:
            Console.WriteLine("Really bruh?\n");
            break;
    }
}

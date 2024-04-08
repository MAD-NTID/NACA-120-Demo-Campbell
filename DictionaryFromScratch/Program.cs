Dictionary<string, int> dictionary = new Dictionary<string, int>();

for(int i = 0; i< 5; i++) {
    dictionary.Add($"{i}",i);
}

// dictionary.Add("5", 1);

Console.WriteLine(dictionary.Count);
Console.WriteLine(dictionary.Get("4"));

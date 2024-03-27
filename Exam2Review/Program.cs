// PlayListMediaQueue<string> playListQueue = new PlayListMediaQueue<string>();
// playListQueue.Add("Harry Potter");
// playListQueue.Add("Lost");

// Console.WriteLine(playListQueue.ShowNextMedia());
// Console.WriteLine(playListQueue.Play());
// Console.WriteLine(playListQueue.TotalMedia);

IPlayListMedia<Video> playListQueue = new PlayListMediaQueue<Video>();
IPlayListMedia<Video> playListStack = new PlayListMediaStack<Video>();

string filename = "movies.txt";
StreamReader reader = new StreamReader(filename);
bool skipHeader = true;
while(!reader.EndOfStream) {
    string[] content = reader.ReadLine().Split(",");

    //skip the header
    if(skipHeader){
        skipHeader = false;
        continue;
    }

    Video video = new Video(content[0], content[1], content[2]);
    Console.WriteLine($"Adding {video} to stack");
    Console.WriteLine($"Adding {video} to queue\n");
    playListQueue.Add(video);
    playListStack.Add(video);
}

Console.WriteLine("All videos are loaded in the stack and queue!\n");
reader.Close();

Console.WriteLine("Stack playlist:" + playListStack);
Console.WriteLine("Queue playlsit:" + playListQueue);
Console.WriteLine();

//write to file
filename = "results.txt";
StreamWriter writer = new StreamWriter(filename);
writer.WriteLine("Stack\n===================");
for(int i = 0; i < playListStack.TotalMedia; i++) {
    writer.WriteLine("Next:" + playListStack.ShowNextMedia());
    writer.WriteLine("Play:" + playListStack.Play());
}

Console.WriteLine("Stack record written to file!");
writer.Close();
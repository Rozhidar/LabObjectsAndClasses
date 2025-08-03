int numberOfSongs = int.Parse(Console.ReadLine());

List<Song> songs = new List<Song>();

int i = 0;
while (i < numberOfSongs)
{
    string[] data = Console.ReadLine().Split("_");

    string type = data[0];
    string name = data[1];
    string time = data[2];

    Song song = new Song();

    song.typeList = type;
    song.name = name;
    song.time = time;

    songs.Add(song);

    i++;
}

string typeList = Console.ReadLine();

if (typeList == "all")
{
    foreach (Song song in songs)
    {
        Console.WriteLine(song.name);
    }
}
else
{
    foreach (Song song in songs)
    {
        if (song.typeList == typeList)
        {
            Console.WriteLine(song.name);
        }
    }
}

//List<Song> filtered = songs.Where(s => s.typeList == typeList).ToList();

//foreach(Song song in filtered)
//{
//    Console.WriteLine(song.name);
//}


public class Song
{
    public string typeList { get; set; }
    public string name { get; set; }
    public string time { get; set; }
}
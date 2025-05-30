namespace Lab9p3;

public class SongCollection
{
    private Song[] songs;
    private int count;

    public SongCollection(int capacity)
    {
        songs = new Song[capacity];
        count = 0;
    }

    public bool AddSong(Song song)
    {
        if (count >= songs.Length)
            return false; 
        songs[count++] = song;
        return true;
    }

    public bool RemoveSong(string title)
    {
        for (int i = 0; i < count; i++)
        {
            if (string.Equals(songs[i].Title, title, StringComparison.OrdinalIgnoreCase))
            {
                for (int j = i; j < count - 1; j++)
                {
                    songs[j] = songs[j + 1];
                }
                songs[count - 1] = null;
                count--;
                return true;
            }
        }
        return false;
    }

    public Song[] FindByTitle(string title)
    {
        Song[] results = new Song[count];
        int foundCount = 0;

        for (int i = 0; i < count; i++)
        {
            if (songs[i].Title.IndexOf(title, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                results[foundCount++] = songs[i];
            }
        }
        
        Song[] trimmed = new Song[foundCount];
        Array.Copy(results, trimmed, foundCount);
        return trimmed;
    }

    public Song[] FindByPerformer(string performer)
    {
        Song[] results = new Song[count];
        int foundCount = 0;

        for (int i = 0; i < count; i++)
        {
            if (songs[i].Performers != null && songs[i].Performers.Any(p => p.Equals(performer, StringComparison.OrdinalIgnoreCase)))
            {
                results[foundCount++] = songs[i];
            }
        }

        Song[] trimmed = new Song[foundCount];
        Array.Copy(results, trimmed, foundCount);
        return trimmed;
    }

    public bool UpdateSong(string title, Song updatedSong)
    {
        for (int i = 0; i < count; i++)
        {
            if (string.Equals(songs[i].Title, title, StringComparison.OrdinalIgnoreCase))
            {
                songs[i] = updatedSong;
                return true;
            }
        }
        return false;
    }

    public void ShowAll()
    {
        if (count == 0)
        {
            Console.WriteLine("Колекція порожня.");
            return;
        }
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(songs[i]);
            Console.WriteLine(new string('-', 30));
        }
    }

    public void SaveToFile(string path)
    {
        using StreamWriter writer = new(path);
        for (int i = 0; i < count; i++)
        {
            var s = songs[i];
            writer.WriteLine($"{s.Title}|{s.Author}|{s.Composer}|{s.Year}|{s.Lyrics.Replace('\n', ' ')}|{string.Join(",", s.Performers)}");
        }
    }

    public void LoadFromFile(string path)
    {
        if (!File.Exists(path))
        {
            Console.WriteLine("Файл не знайдено.");
            return;
        }

        count = 0;
        foreach (string line in File.ReadLines(path))
        {
            var parts = line.Split('|');
            if (parts.Length >= 6)
            {
                Song s = new()
                {
                    Title = parts[0],
                    Author = parts[1],
                    Composer = parts[2],
                    Year = int.TryParse(parts[3], out int y) ? y : 0,
                    Lyrics = parts[4],
                    Performers = parts[5].Split(',', StringSplitOptions.RemoveEmptyEntries)
                };
                if (!AddSong(s))
                {
                    Console.WriteLine("Дійшли до максимального розміру колекції.");
                    break;
                }
            }
        }
    }
}


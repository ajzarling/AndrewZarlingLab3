using System;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace Lab2Solution
{
    /*
    public class DatabaseStars
    {
        private ObservableCollection<Entry> movies = new ObservableCollection<Entry>();

        Entry[] initialFavorites = { new Entry("Spiderman", 4.0),
                                     new Entry("Rogue One", 3.0) };


        String path = "";
        public ObservableCollection<Entry> AllMovies
        {
            get { return movies; }
            set { movies = value; }
        }


        /**
[
  {
    "Title": "Spiderman",
    "NumStars": 4
  },
  {
    "Title": "Rogue One",
    "NumStars": 3
  }
] 
         */

    /*
        public DatabaseStars()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            path = $"{appDataPath}/clues.json"; // /data/user/0/com.companyname.basicdotnetmauiproject/files/clues.json
            Console.WriteLine($"We've got your path right here: {path}");
            FetchAllMovies();

        }
        // methods to add a movie, delete a movie, find a movie, etc.

        public void AddMovie(Entry movie)
        {
            movies.Add(movie); // added a movie ... now write it out to disk

            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };

            string jsonString = JsonSerializer.Serialize(movies, options);
            File.WriteAllText(path, jsonString); // obliterates existing file
        }

        public bool DeleteMovie(Entry movie)
        {
            for (int i = 0; i < movies.Count; i++)
            {
                if (movies.ElementAt(i).Title == movie.Title)
                {
                    movies.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public void ClearAllMovies()
        {
            while (movies.Count > 0)
            {
                movies.RemoveAt(0);
            }

            WriteAllMovies();
        }

        public void FetchAllMovies()
        {
            if (File.Exists(path))
            { // always a good idea to check first ...
                String jsonString = File.ReadAllText(path);
                movies = JsonSerializer.Deserialize<ObservableCollection<Entry>>(jsonString);
                Console.WriteLine(movies);
            }
        }

        public void WriteAllMovies()
        {
            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };

            string jsonString = JsonSerializer.Serialize(movies, options);
            File.WriteAllText(path, jsonString); // obliterates existing file
        }
    }
*/
}


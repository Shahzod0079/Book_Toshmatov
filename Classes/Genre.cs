using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Toshmatov.Classes
{
    public class Genre
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Genre(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static List<Genre> AllGenres()
        {
            return new List<Genre>
            {
                new Genre(1, "Современная русская литература"),
                new Genre(2, "Современные детективы"),
                new Genre(3, "Любовное фэнтези"),
                new Genre(4, "Попаданцы"),
                new Genre(5, "Юмористическое фэнтези")
            };
        }
    }
}
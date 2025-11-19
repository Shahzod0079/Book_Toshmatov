using System;

public class Class1
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Genre> Genres { get; set; }

        public List<Author> Authors { get; set; }

        public int Year { get; set; }

        public Book(int id, string name, List<Genre> genres, List<Author> authors, int year)
        {
            this.Id = id;
            this.Name = name;
            this.Genres = genres;
            this.Authors = authors;
            this.Year = year;
        }
        public static List<Book> AllBooks()
        {
            return new List<Book>
    {
        new Book(
            1, "Путешествие в Элевсин",
            Genre.AllGenres().FindAll(x => x.Id == 1),
            Author.AllAuthors().FindAll(x => x.Id == 1), 2023),
        new Book(
            2, "Чапаев и Пустота",
            Genre.AllGenres().FindAll(x => x.Id == 1),
            Author.AllAuthors().FindAll(x => x.Id == 1), 2008),
        new Book(
            3, "Дебютная постановка. Том 1",
            Genre.AllGenres().FindAll(x => x.Id == 2),
            Author.AllAuthors().FindAll(x => x.Id == 2), 2023),
        new Book(
            4, "Дебютная постановка. Том 2",
            Genre.AllGenres().FindAll(x => x.Id == 2),
            Author.AllAuthors().FindAll(x => x.Id == 2), 2023),
        new Book(
            5, "Охота на попаданку. Бракованная жена",
            Genre.AllGenres().FindAll(x => x.Id == 2 || x.Id == 3 || x.Id == 4),
            Author.AllAuthors().FindAll(x => x.Id == 3), 2022)

        return AllBook;
    };
        }
    public string ToGenres()
    {
        string toGenres = "";
        for (int iGenre = 0; iGenre < this.Genres.Count; iGenre++)
        {

            toGenres += this.Genres[iGenre].Name;

            if (iGenre < this.Genres.Count - 1)
                toGenres += ",";
        }

        return toGenres;
    }
    public string ToAuthors()
    {
        string toAuthors = "";
        for (int iAuthor = 0; iAuthor < this.Authors.Count; iAuthor++)
        {
            toAuthors += this.Authors[iAuthor].FIO;
            if (iAuthor < this.Authors.Count - 1)
                toAuthors += ",";
        }
        return toAuthors;
    }
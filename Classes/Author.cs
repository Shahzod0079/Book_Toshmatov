using System;

public class Class1
{
    public class Author
    {
        public int Id { get; set; }

        public string FIO { get; set; }

        public Author(int id, string fio)
        {
            Id = id;
            FIO = fio;
        }

        public static List<Author> AllAuthors()
        {
            return new List<Author>
            {
                new Author(1, "Виктор Пелевин"),
                new Author(2, "Александра Маринина"),
                new Author(3, "Ольга Герр")
            };
        }
    }
}
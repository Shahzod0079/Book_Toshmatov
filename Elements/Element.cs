using System.Windows.Controls;
using Book_Toshmatov.Classes;

namespace Book_Toshmatov.Elements
{
    public partial class Element : UserControl
    {
        public Element(Book book)
        {
            InitializeComponent();

            tbName.Text = $"Наименование: {book.Name} ({book.Year} г.)";
            tbGenre.Text = $"Жанр: {book.ToGenres()}";
            tbAuthor.Text = $"Автор: {book.ToAuthors()}";
        }
    }
}
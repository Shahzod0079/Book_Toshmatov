using System.Windows.Controls;

namespace Book_Toshmatov.Elements
{
    public partial class Element : UserControl
    {
        public Element(Classes.Book book)
        {
            InitializeComponent();

            tbName.Text = $"Наименование: {book.Name} ({book.Year} г.)";

            tbGenre.Text = $"Жанр: {book.ToGenres()}";

            tbAuthor.Text = $"Автор: {book.ToAuthors()}";
        }
    }
}
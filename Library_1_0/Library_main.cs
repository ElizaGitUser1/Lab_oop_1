using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_1_0
{
    public partial class Library_main : Form
    {
        public Library_main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private Library library = new Library();
        private void CustomizeDataGridView()
        {
            dataGridBooks.Columns["Title"].HeaderText = "Назва книги";
            dataGridBooks.Columns["Author"].HeaderText = "Автор";
            dataGridBooks.Columns["Year"].HeaderText = "Рік видання";
            dataGridBooks.Columns["ISBN"].HeaderText = "ISBN";
            dataGridBooks.Columns["ISBN"].ReadOnly = true;
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            int year = int.Parse(txtYear.Text);
            string isbn = txtISBN.Text;
            Book newBook = new Book(title, author, year, isbn);
            library.AddBook(newBook);
            UpdateBookList();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtYear.Clear();
            txtISBN.Clear();
        }
        private void UpdateBookList()
        {
            dataGridBooks.DataSource = null;
            dataGridBooks.DataSource = library.GetAllBooks();
        }
        private void btdel_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text;
            library.DeleteBook(isbn);
            UpdateBookList();
        }
        private void btsa_Click(object sender, EventArgs e)
        {
            string author = txtAuthor.Text;
            var foundBooks = library.SearchByAuthor(author);
            dataGridBooks.DataSource = null;
            if (foundBooks.Count > 0)
            {
                dataGridBooks.DataSource = foundBooks;
            }
            else
            {
                MessageBox.Show("Книги з таким автором не знайдено.", "Пошук", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btst_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            var foundBooks = library.SearchByTitle(title);
            dataGridBooks.DataSource = null;
            if (foundBooks.Count > 0)
            {
                dataGridBooks.DataSource = foundBooks;
            }
            else
            {
                MessageBox.Show("Книги з такою назвою не знайдено.", "Пошук", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btShowAll_Click(object sender, EventArgs e)
        {
            UpdateBookList();
        }
    }
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string ISBN { get; set; }
        public Book(string title, string author, int year, string isbn)
        {
            Title = title;
            Author = author;
            Year = year;
            ISBN = isbn;
        }
        public override string ToString()
        {
            return $"Книга {Title} написана {Author}, {Year} - ISBN: {ISBN}";
        }
    }
    public class Library
    {
        private List<Book> books;
        public Library()
        {
            books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void DeleteBook(string isbn)
        {
            Book bookToDelete = books.FirstOrDefault(b => b.ISBN == isbn);
            if (bookToDelete != null)
            {
                books.Remove(bookToDelete);
            }
        }
        public List<Book> SearchByAuthor(string author)
        {
            return books.Where(b => b.Author.ToLower().Contains(author.ToLower())).ToList();
        }
        public List<Book> SearchByTitle(string title)
        {
            return books.Where(b => b.Title.ToLower().Contains(title.ToLower())).ToList();
        }
        public List<Book> GetAllBooks()
        {
            return books;
        }
    }
}

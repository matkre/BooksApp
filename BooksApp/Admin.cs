using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;

namespace BooksApp
{
    public partial class AdminWindow : Form
    {
        public AdminWindow()
        {
            InitializeComponent();
        }
        private void UpdateBook(BooksTable books, string id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://webapibooks.azurewebsites.net/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    HttpResponseMessage response = client.PutAsJsonAsync($"api/Books/" + id, books).Result;
                    //response.Content.ReadAsStringAsync();
                    response.EnsureSuccessStatusCode();
                    books = response.Content.ReadAsAsync<BooksTable>().Result;
                    messageLab.ForeColor = Color.Green;
                    messageLab.Text = "Książka została zaaktualizowana";
                }
                catch (Exception e)
                {
                    messageLab.ForeColor = Color.Green;
                    messageLab.Text = e.Message;
                }
            }
        }
        private void DelBook(string id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://webapibooks.azurewebsites.net/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    HttpResponseMessage response = client.DeleteAsync("api/Books/" + id).Result;
                    response.Content.ReadAsStringAsync();
                    messageLab.ForeColor = Color.Green;
                    messageLab.Text = "Książka została usunięta z bazy";
                }
                catch (Exception e)
                {
                    messageLab.ForeColor = Color.Green;
                    messageLab.Text =  e.Message;
                }
            }
        }
        private void GetBooks()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://webapibooks.azurewebsites.net/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    HttpResponseMessage response = client.GetAsync("api/Books").Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var book = response.Content.ReadAsAsync<IEnumerable<BooksTable>>().Result;
                        dataGridView.BackgroundColor = Color.White;
                        dataGridView.DataSource = book;
                    }
                }
                catch (Exception e)
                {
                    messageLab.Text = null;
                    messageLab.Text = e.Message.ToString();
                }
            }

        }
        private void GetPicture(string path)
        {
            Bitmap photo = null;
            pictureField.SizeMode = PictureBoxSizeMode.StretchImage;
            photo = new Bitmap(path);
            pictureField.Image =(Image) photo;
        }
        private string GetIdRow(DataGridViewCellEventArgs e)
        {
            string id = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            return id;
        }
        private void AddBook(BooksTable books)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://webapibooks.azurewebsites.net/");
                var response = client.PostAsJsonAsync("api/Books", books).Result;
                if (response.IsSuccessStatusCode)
                {
                    idText.Clear();
                    titleText.Clear();
                    verText.Clear();
                    authText.Clear();
                    genText.Clear();
                    yearText.Clear();
                    messageLab.ForeColor = Color.Green;
                    messageLab.Text = "Książka została dodana do bazy";
                }
                else
                {
                    messageLab.ForeColor = Color.Red;
                    messageLab.Text = "Wystąpił błąd !";
                }
            }
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            //FormBorderStyle = FormBorderStyle.None;
            //WindowState = FormWindowState.Maximized;
            GetBooks();
            pictureField.BackColor = Color.Black;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            BooksApp firstWindow = new BooksApp();
            firstWindow.Show();
        }

        private void OnClickCell(object sender, DataGridViewCellEventArgs e)
        {  
            try
            {
                string id = GetIdRow(e);
                GetPicture(@"C:\Users\krenca.m\Documents\Projekty\BooksApp\BooksApp\books_picture\" + id + ".jpg");
            }catch(Exception ex)
            {
                messageLab.ForeColor = Color.Red;
                messageLab.Text = ex.Message.ToString();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            BooksTable books = new BooksTable()
            {
                ID = int.Parse(idText.Text),
                TITLE = titleText.Text.ToString(),
                VERSION = verText.Text.ToString(),
                AUTHOR = authText.Text.ToString(),
                GENRE = genText.Text.ToString(),
                YEAR = int.Parse(yearText.Text)
            };
            AddBook(books);
            GetBooks();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            string id = delTextBox.Text;
            DelBook(id);
            GetBooks();
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            BooksTable books = new BooksTable()
            {
                ID = int.Parse(idText.Text),
                TITLE = titleText.Text.ToString(),
                VERSION = verText.Text.ToString(),
                AUTHOR = authText.Text.ToString(),
                GENRE = genText.Text.ToString(),
                YEAR = int.Parse(yearText.Text)
            };
            UpdateBook(books, idText.Text);
            GetBooks();
        }
    }
}

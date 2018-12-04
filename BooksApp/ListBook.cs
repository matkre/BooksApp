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
using System.Timers;
using Timer = System.Timers.Timer;

namespace BooksApp
{
    public partial class BooksApp : Form
    {
        public BooksApp()
        {
            InitializeComponent();
        }
        private void OnLoad(object sender, EventArgs e)
        {
            //FormBorderStyle = FormBorderStyle.None;
           // WindowState = FormWindowState.Maximized;
            GetBooks();
            pictureBox.BackColor = Color.Black;
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
                    if(response.IsSuccessStatusCode)
                    {
                        var book = response.Content.ReadAsAsync<IEnumerable<BooksTable>>().Result;
                        dataGridView.BackgroundColor = Color.White;
                        dataGridView.DataSource = book;
                    }
                }catch(Exception e)
                {
                    messageViewField.Text = "";
                    messageViewField.Text = e.Message.ToString() + " ."+ e.HResult + " ." + e.InnerException;
                }
            }
            
        }
        private void GetPicture(string path)
        {
            Bitmap photo = null;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            photo = new Bitmap(path);
            pictureBox.Image = (Image)photo;
        }
        private string GetIdRow(DataGridViewCellEventArgs e)
        {
            string id = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            return id;
        }
        Timer timer = new Timer();
        private void OnClickCell(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = GetIdRow(e);
                GetPicture(@"C:\Users\krenca.m\Documents\Projekty\BooksApp\BooksApp\books_picture\" + id + ".jpg");
            }catch(Exception ex)
            {
                timer.Interval = 5000;
                timer.Elapsed += new ElapsedEventHandler(this.TimerStop);
                timer.Start();
                messageViewField.Text = "Brak obrazu. " + ex.Message;
            }
        }
        private void TimerStop(object sender, EventArgs e)
        {
            messageViewField.Text = "";
            timer.Stop();
        }
        private void LogAsAdmin_Click(object sender, EventArgs e)
        {
            AdminLogin login = new AdminLogin();
            login.Show();
            this.Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}

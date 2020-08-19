using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
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
        private static string usrName = Environment.UserName;
        private string sourcePath = @"C:\Users\" + usrName + @"\Documents\BooksApp\Pictures";
        private void CopyPicture()
        {
            string pathDir = @"C:\Users\"+usrName+@"\Desktop\BooksApp\Pictures";
            string startPath = Application.StartupPath;
            string exPath = Application.ExecutablePath;
            string path = System.Environment.CurrentDirectory;
            messageViewField.Text = startPath;
            try
            {
                if (Directory.Exists(sourcePath)==false)
                {
                    DirectoryInfo crDir = Directory.CreateDirectory(sourcePath);
                }
                string[] pictures = Directory.GetFiles(pathDir);
                foreach(string file in pictures)
                {
                    string picName = Path.GetFileName(file);
                    string dest = Path.Combine(pathDir, picName);
                    File.Copy(pathDir, sourcePath); //sourcePath==dest
                }

            }
            catch(Exception e) { messageViewField.Text = e.Message; }
        }
        private void OnLoad(object sender, EventArgs e)
        {
            CopyPicture();
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
               // GetPicture(@"\books_picture\" + id + ".jpg");
                GetPicture(sourcePath); //@"C:\Users\"+usrName+@"\Documents\Projekty\BooksApp\BooksApp\books_picture\" + id + ".jpg"
            }
            catch(Exception ex)
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

        private void downloadBook_Click(object sender, DataGridViewCellEventArgs e)
        {

           /**/
        }

        private void downloadBook_Click(object sender, EventArgs e)
        {
            /*DataGridViewCellEventArgs arg;
            string id = GetIdRow(arg);
            var req = (FtpWebRequest)WebRequest.Create($"ftp://waws-prod-par-003.ftp.azurewebsites.windows.net/site/wwwroot/pliki/books/1.mobi");
            req.Proxy = null;
            req.Credentials = new NetworkCredential(@"WebApiBooks\$WebApiBooks", @"PMh4mpXtYkSv1Mt1mlviFeyEzKYc6x7etwdy8JRSoYyusTiwie41raGFTTjw");
            try
            {
                req.Method = WebRequestMethods.Ftp.DownloadFile;
                FtpWebResponse response = (FtpWebResponse)req.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                reader.Close();
                req.GetResponse().Close();
            }catch(Exception ex)
            {
                messageViewField.Text = ex.Message.ToString();
            }*/
            messageViewField.Text = "Przycisk nie jest aktywny";
        }
    }
}

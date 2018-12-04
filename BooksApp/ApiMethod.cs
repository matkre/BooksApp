using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp
{
    class ApiMethod
    {
        private object messageLab;

        private void GetBooks()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:59745/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    HttpResponseMessage response = client.GetAsync("api/Books").Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var book = response.Content.ReadAsAsync<IEnumerable<BooksTable>>().Result;
                        //dataGridView.BackgroundColor = Color.White;
                        //dataGridView.DataSource = book;
                    }
                }
                catch (Exception e)
                {
                    /*messageLab.Text = null;
                    messageLab.Text = e.Message.ToString();*/
                }
            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp
{
    public partial class BooksTable
    {
        public int ID { get; set; }
        public string TITLE { get; set; }
        public string VERSION { get; set; }
        public string AUTHOR { get; set; }
        public string GENRE { get; set; }
        public Nullable<int> YEAR { get; set; }
    }
}

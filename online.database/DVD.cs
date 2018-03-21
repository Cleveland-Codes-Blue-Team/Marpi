using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online.database
{
    public class DVD
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Rating { get; set; }
        public int RunTime { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Price { get; set; }
        public string Plot { get; set; }
        
    }
}

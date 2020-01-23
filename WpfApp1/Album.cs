using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Album
    {
        public string AlbumName { get; set; }
        public int AlbumYear { get; set; }
        public string AlbumMembers { get; set; }


        public override string ToString()
        {
            return string.Format("{0}", "{1}", "{2}", AlbumName, AlbumYear, AlbumMembers); 
        }



    }
}

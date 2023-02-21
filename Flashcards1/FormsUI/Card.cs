using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUI
{
    public class Card
    {
        public int Id { get; set; }
        public string BandName { get; set; }
        public string SongName { get; set; }


        public string fullInfo
        {

            get
            {
                //this will return the bandname followed by the song name - this is a readonly property
                return $"{Id}: {BandName} : {SongName}";
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraCarros {
    struct Localizacao {

        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string Altitude { get; set; }

        public Localizacao(string longitude, string latitude, string altitude) : this(){
            Longitude = longitude;
            Latitude = latitude;
            Altitude = altitude;
        }
    }
}

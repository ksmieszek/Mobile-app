using MobilneHotelWCF3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MobilneHotelWCF3.ViewModels
{
    [DataContract]
    public class RodzajPokojuForView
    {

        [DataMember]
        public int IdRodzajuPokoju { get; set; }
        [DataMember]
        public string Nazwa { get; set; }
        [DataMember]
        public string Opis { get; set; }

        public RodzajPokojuForView() { }

        public RodzajPokojuForView(RodzajePokojow rodzajPokoju)
        {
            IdRodzajuPokoju = rodzajPokoju.IdRodzajuPokoju;
            Nazwa = rodzajPokoju.Nazwa;
            Opis = rodzajPokoju.Opis;
        }
    }
}
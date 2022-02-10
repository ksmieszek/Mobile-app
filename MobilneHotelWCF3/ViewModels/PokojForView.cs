using MobilneHotelWCF3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MobilneHotelWCF3.ViewModels
{
    [DataContract]
    public class PokojForView
    {
        [DataMember]
        public int IdPokoju { get; set; }
        [DataMember]
        public int? IdRodzajuPokoju { get; set; }
        [DataMember]
        public string NrPokoju{ get; set; }
        [DataMember]
        public int? Pietro { get; set; }
        [DataMember]
        public string Nazwa { get; set; }
        [DataMember]
        public decimal? Cena { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string RodzajPokojuDane { get; set; }
        public PokojForView(Pokoje pokoj)
        {
            IdPokoju = pokoj.IdPokoju;
            IdRodzajuPokoju = pokoj.IdRodzajuPokoju;
            NrPokoju = pokoj.NrPokoju;
            Pietro = pokoj.Pietro;
            Nazwa = pokoj.Nazwa;
            Cena = pokoj.Cena;
            Status = pokoj.Status;
            RodzajPokojuDane = pokoj.RodzajePokojow != null ? $"{pokoj.RodzajePokojow.Nazwa}" : string.Empty;
        }
    }
}
using System.Runtime.Serialization;
using MobilneHotelWCF3.Model;

namespace MobilneHotel.Models
{
    [DataContract]
    public class KlientForView
    {
        [DataMember]
        public int IdKlienta { get; set; }
        [DataMember]
        public string Imie { get; set; }
        [DataMember]
        public string Nazwisko { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Telefon { get; set; }
        [DataMember]
        public string KlientNazwa { get; set; }
        public KlientForView() { }

        public KlientForView(Klienci klient)
        {
            IdKlienta = klient.IdKlienta;
            Imie = klient.Imie;
            Nazwisko = klient.Nazwisko;
            Email = klient.Email;
            Telefon = klient.Telefon;
            KlientNazwa = $"{klient.Imie} {klient.Nazwisko}";
        }
    }
}

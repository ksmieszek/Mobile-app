using MobilneHotelWCF3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MobilneHotelWCF3.ViewModels
{
    [DataContract]
    public class RezerwacjaForView
    {
        [DataMember]
        public int IdRezerwacji { get; set; }
        [DataMember]
        public int? IdKlienta { get; set; }
        [DataMember]
        public int? IdPracownika { get; set; }
        [DataMember]
        public int? IdPokoju { get; set; }
        [DataMember]
        public DateTime? DataRozpoczecia { get; set; }
        [DataMember]
        public DateTime? DataZakonczenia { get; set; }
        [DataMember]
        public decimal? Razem { get; set; }
        [DataMember]
        public string KlientDane { get; set; }
        [DataMember]
        public string PracownikDane { get; set; }
        [DataMember]
        public string PokojDane { get; set; }
        public RezerwacjaForView(Rezerwacje rezerwacja)
        {
            IdRezerwacji = rezerwacja.IdRezerwacji;
            IdKlienta = rezerwacja.IdKlienta;
            IdPracownika = rezerwacja.IdPracownika;
            IdPokoju = rezerwacja.IdPokoju;
            DataRozpoczecia = rezerwacja.DataRozpoczecia;
            DataZakonczenia = rezerwacja.DataZakonczenia;
            Razem = rezerwacja.Razem;
            KlientDane = rezerwacja.Klienci != null ? $"{rezerwacja.Klienci.Imie} {rezerwacja.Klienci.Nazwisko}" : string.Empty;
            PracownikDane = rezerwacja.Pracownicy != null ? $"{rezerwacja.Pracownicy.Imie} {rezerwacja.Pracownicy.Nazwisko}" : string.Empty;
            PokojDane = rezerwacja.Pokoje != null ? $"{rezerwacja.Pokoje.Nazwa}" : string.Empty;
        }
    }
}
using MobilneHotelWCF3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MobilneHotelWCF3.ViewModels
{
    [DataContract]
    public class PracownikForView
    {
        [DataMember]
        public int IdPracownika { get; set; }
        [DataMember]
        public string Imie { get; set; }
        [DataMember]
        public string Nazwisko { get; set; }
        [DataMember]
        public string Pesel { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Telefon { get; set; }
        [DataMember]
        public string Miasto { get; set; }
        [DataMember]
        public string KodPocztowy { get; set; }
        [DataMember]
        public string Ulica { get; set; }
        [DataMember]
        public string NumerDomu { get; set; }
        [DataMember]
        public string NumerLokalu { get; set; }
        [DataMember]
        public string PracownikNazwa { get; set; }

        public PracownikForView() { }

        public PracownikForView(Pracownicy pracownik)
        {
            IdPracownika = pracownik.IdPracownika;
            Imie = pracownik.Imie;
            Nazwisko = pracownik.Nazwisko;
            Pesel = pracownik.Pesel;
            Email = pracownik.Email;
            Telefon = pracownik.Telefon;
            Miasto = pracownik.Miasto;
            KodPocztowy = pracownik.KodPocztowy;
            Ulica = pracownik.Ulica;
            NumerDomu = pracownik.NumerDomu;
            NumerLokalu = pracownik.NumerLokalu;
            PracownikNazwa = $"{pracownik.Imie} {pracownik.Nazwisko}";
        }
    }
}
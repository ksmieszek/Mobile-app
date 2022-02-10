using MobilneHotel.Models;
using MobilneHotelWCF3.Model;
using MobilneHotelWCF3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;


namespace MobilneHotelWCF3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<KlientForView> GetAllKlienci()
        {
            var list = new List<KlientForView>();
            var db = new HotelMobilneEntities();

            var listFromDb =
                (from klient in db.Klienci
                 select klient).ToList();

            list.AddRange(from klient
                          in listFromDb
                          select new KlientForView(klient));
            return list;
        }
        public bool AddModifyKlient(KlientForView klient)
        {
            var db = new HotelMobilneEntities();
            try
            {
                if (klient.IdKlienta > 0)
                {
                    if (db.Klienci.Any(x => x.IdKlienta == klient.IdKlienta))
                    {
                        var klientToChange = db.Klienci.Find(klient.IdKlienta);
                        klientToChange.Imie = klient.Imie;
                        klientToChange.Nazwisko = klient.Nazwisko;
                        klientToChange.Email = klient.Email;
                        klientToChange.Telefon = klient.Telefon;
                        db.Entry(klientToChange).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        return true;
                    }
                }

                var id = db.Klienci.Count() + 1;

                var klientToAdd = new Klienci
                {
                    IdKlienta = id,
                    Imie = klient.Imie,
                    Nazwisko = klient.Nazwisko,
                    Email = klient.Email,
                    Telefon = klient.Telefon,
                };
                db.Klienci.Add(klientToAdd);
                db.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool DeleteKlient(int IdKlienta)
        {
            var db = new HotelMobilneEntities();
            try
            {
                db.Klienci.Remove(db.Klienci.First(x => x.IdKlienta == IdKlienta));
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                HandleException(e);
                return false;
            }
        }

        //pracownik
        public List<PracownikForView> GetAllPracownicy()
        {
            var list = new List<PracownikForView>();
            var db = new HotelMobilneEntities();

            var listFromDb =
                (from pracownik in db.Pracownicy
                 select pracownik).ToList();

            list.AddRange(from pracownik
                          in listFromDb
                          select new PracownikForView(pracownik));
            return list;
        }

        public bool AddModifyPracownik(PracownikForView pracownik)
        {
            var db = new HotelMobilneEntities();
            try
            {
                if (pracownik.IdPracownika > 0)
                {
                    if (db.Pracownicy.Any(x => x.IdPracownika == pracownik.IdPracownika))
                    {
                        var pracownikToChange = db.Pracownicy.Find(pracownik.IdPracownika);
                        pracownikToChange.Imie = pracownik.Imie;
                        pracownikToChange.Nazwisko = pracownik.Nazwisko;
                        pracownikToChange.Pesel = pracownik.Pesel;
                        pracownikToChange.Email = pracownik.Email;
                        pracownikToChange.Telefon = pracownik.Telefon;
                        pracownikToChange.Miasto = pracownik.Miasto;
                        pracownikToChange.KodPocztowy = pracownik.KodPocztowy;
                        pracownikToChange.Ulica = pracownik.Ulica;
                        pracownikToChange.NumerDomu = pracownik.NumerDomu;
                        pracownikToChange.NumerLokalu = pracownik.NumerLokalu;
                        db.Entry(pracownikToChange).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        return true;
                    }
                }

                var id = db.Pracownicy.Count() + 1;

                var pracownikToAdd = new Pracownicy
                {
                    IdPracownika = id,
                    Imie = pracownik.Imie,
                    Nazwisko = pracownik.Nazwisko,
                    Pesel = pracownik.Pesel,
                    Email = pracownik.Email,
                    Telefon = pracownik.Telefon,
                    Miasto = pracownik.Miasto,
                    KodPocztowy = pracownik.KodPocztowy,
                    Ulica = pracownik.Ulica,
                    NumerDomu = pracownik.NumerDomu,
                    NumerLokalu = pracownik.NumerLokalu,
                };
                db.Pracownicy.Add(pracownikToAdd);
                db.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool DeletePracownik(int IdPracownika)
        {
            var db = new HotelMobilneEntities();
            try
            {
                db.Pracownicy.Remove(db.Pracownicy.First(x => x.IdPracownika == IdPracownika));
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                HandleException(e);
                return false;
            }
        }


        //rezerwacje
        public List<RezerwacjaForView> GetAllRezerwacje()
        {
            var list = new List<RezerwacjaForView>();
            var db = new HotelMobilneEntities();

            var listFromDb =
                (from rezerwacja in db.Rezerwacje
                 select rezerwacja).ToList();

            list.AddRange(from rezerwacja
                          in listFromDb
                          select new RezerwacjaForView(rezerwacja));
            return list;
        }

        public bool AddModifyRezerwacja(RezerwacjaForView rezerwacja)
        {
            var db = new HotelMobilneEntities();
            try
            {
                if (rezerwacja.IdRezerwacji > 0)
                {
                    if (db.Rezerwacje.Any(x => x.IdRezerwacji == rezerwacja.IdRezerwacji))
                    {
                        var rezerwacjaToChange = db.Rezerwacje.Find(rezerwacja.IdRezerwacji);
                        rezerwacjaToChange.IdRezerwacji = rezerwacja.IdRezerwacji;
                        rezerwacjaToChange.IdKlienta = rezerwacja.IdKlienta;
                        rezerwacjaToChange.IdPracownika = rezerwacja.IdPracownika;
                        rezerwacjaToChange.IdPokoju = rezerwacja.IdPokoju;
                        rezerwacjaToChange.DataRozpoczecia = rezerwacja.DataRozpoczecia;
                        rezerwacjaToChange.DataZakonczenia = rezerwacja.DataZakonczenia;
                        rezerwacjaToChange.Razem = rezerwacja.Razem;
                        db.Entry(rezerwacjaToChange).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        return true;
                    }
                }

                var id = db.Rezerwacje.Count() + 1;

                var rezerwacjaToAdd = new Rezerwacje
                {
                    IdRezerwacji = id,
                    IdKlienta = rezerwacja.IdKlienta,
                    IdPracownika = rezerwacja.IdPracownika,
                    IdPokoju = rezerwacja.IdPokoju,
                    DataRozpoczecia = rezerwacja.DataRozpoczecia,
                    DataZakonczenia = rezerwacja.DataZakonczenia,
                    Razem = rezerwacja.Razem,
                };
                db.Rezerwacje.Add(rezerwacjaToAdd);
                db.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool DeleteRezerwacja(int IdRezerwacji)
        {
            var db = new HotelMobilneEntities();
            try
            {
                db.Rezerwacje.Remove(db.Rezerwacje.First(x => x.IdRezerwacji == IdRezerwacji));
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                HandleException(e);
                return false;
            }
        }

        //rodzaje pokojow
        public List<RodzajPokojuForView> GetAllRodzajePokojow()
        {
            var list = new List<RodzajPokojuForView>();
            var db = new HotelMobilneEntities();

            var listFromDb =
                (from rodzajPokoju in db.RodzajePokojow
                 select rodzajPokoju).ToList();

            list.AddRange(from rodzajPokoju
                          in listFromDb
                          select new RodzajPokojuForView(rodzajPokoju));
            return list;
        }

        public bool AddModifyRodzajPokoju(RodzajPokojuForView rodzajPokoju)
        {
            var db = new HotelMobilneEntities();
            try
            {
                if (rodzajPokoju.IdRodzajuPokoju > 0)
                {
                    if (db.RodzajePokojow.Any(x => x.IdRodzajuPokoju == rodzajPokoju.IdRodzajuPokoju))
                    {
                        var rodzajPokojuToChange = db.RodzajePokojow.Find(rodzajPokoju.IdRodzajuPokoju);
                        rodzajPokojuToChange.Nazwa= rodzajPokoju.Nazwa;
                        rodzajPokojuToChange.Opis = rodzajPokoju.Opis;
                        db.Entry(rodzajPokojuToChange).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        return true;
                    }
                }

                var id = db.RodzajePokojow.Count() + 1;

                var rodzajPokojuToAdd = new RodzajePokojow
                {
                    IdRodzajuPokoju = id,
                    Nazwa = rodzajPokoju.Nazwa,
                    Opis = rodzajPokoju.Opis,
                    
                };
                db.RodzajePokojow.Add(rodzajPokojuToAdd);
                db.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool DeleteRodzajPokoju(int IdRodzajuPokoju)
        {
            var db = new HotelMobilneEntities();
            try
            {
                db.RodzajePokojow.Remove(db.RodzajePokojow.First(x => x.IdRodzajuPokoju == IdRodzajuPokoju));
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                HandleException(e);
                return false;
            }
        }

        //pokoje
        public List<PokojForView> GetAllPokoje()
        {
            var list = new List<PokojForView>();
            var db = new HotelMobilneEntities();

            var listFromDb =
                (from pokoj in db.Pokoje
                 select pokoj).ToList();

            list.AddRange(from pokoj
                          in listFromDb
                          select new PokojForView(pokoj));
            return list;
        }

        public bool AddModifyPokoj(PokojForView pokoj)
        {
            var db = new HotelMobilneEntities();
            try
            {
                if (pokoj.IdPokoju > 0)
                {
                    if (db.Pokoje.Any(x => x.IdPokoju == pokoj.IdPokoju))
                    {
                        var pokojToChange = db.Pokoje.Find(pokoj.IdPokoju);
                        pokojToChange.IdPokoju = pokoj.IdPokoju;
                        pokojToChange.IdRodzajuPokoju = pokoj.IdRodzajuPokoju;
                        pokojToChange.NrPokoju = pokoj.NrPokoju;
                        pokojToChange.Pietro = pokoj.Pietro;
                        pokojToChange.Nazwa = pokoj.Nazwa;
                        pokojToChange.Cena = pokoj.Cena;
                        pokojToChange.Status = pokoj.Status;
                        db.Entry(pokojToChange).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        return true;
                    }
                }

                var id = db.Pokoje.Count() + 1;

                var pokojToAdd = new Pokoje
                {
                    IdPokoju = id,
                    IdRodzajuPokoju = pokoj.IdRodzajuPokoju,
                    NrPokoju = pokoj.NrPokoju,
                    Pietro = pokoj.Pietro,
                    Nazwa = pokoj.Nazwa,
                    Cena = pokoj.Cena,
                    Status = pokoj.Status,
                };
                db.Pokoje.Add(pokojToAdd);
                db.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool DeletePokoj(int IdPokoju)
        {
            var db = new HotelMobilneEntities();
            try
            {
                db.Pokoje.Remove(db.Pokoje.First(x => x.IdPokoju == IdPokoju));
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                HandleException(e);
                return false;
            }
        }

        public decimal? UtargWDniach(DateTime odDaty, DateTime doDaty)
        {
            var db = new HotelMobilneEntities();
            return
                (
                    from rezerwacja in db.Rezerwacje
                    where rezerwacja.DataRozpoczecia >= odDaty && rezerwacja.DataRozpoczecia <= doDaty
                    select rezerwacja.Razem
                  ).Sum();
        }


        public decimal? WartoscRezerwacjiKlienta(int idKlienta)
        {
            var db = new HotelMobilneEntities();
            return
                (
                    from rezerwacja in db.Rezerwacje
                    where rezerwacja.IdKlienta == idKlienta
                    select rezerwacja.Razem
                  ).Sum();
        }

        private void HandleException(Exception e)
        {
            Console.WriteLine($"Wystąpił błąd: {e.Message} StackTrace: {e.StackTrace}");
            if (e.InnerException != null)
            {
                Console.WriteLine($"Błąd wewnętrzny: {e.InnerException.Message} StackTrace: {e.InnerException.StackTrace}");
            }
        }
    }
}

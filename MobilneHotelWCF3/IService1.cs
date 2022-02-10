using MobilneHotel.Models;
using MobilneHotelWCF3.Model;
using MobilneHotelWCF3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MobilneHotelWCF3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        //raporty
        [OperationContract]
        decimal? WartoscRezerwacjiKlienta(int idKlienta);

        [OperationContract]
        decimal? UtargWDniach(DateTime odDaty, DateTime doDaty);

        //klient
        [OperationContract]
        List<KlientForView> GetAllKlienci();
        [OperationContract]
        bool AddModifyKlient(KlientForView klient);
        [OperationContract]
        bool DeleteKlient(int IdKlienta);
        
        
        //pracownik
        [OperationContract]
        List<PracownikForView> GetAllPracownicy();
        [OperationContract]
        bool AddModifyPracownik(PracownikForView pracownik);
        [OperationContract]
        bool DeletePracownik(int IdPracownika);

        //rezerwacja
        [OperationContract]
        List<RezerwacjaForView> GetAllRezerwacje();
        [OperationContract]
        bool AddModifyRezerwacja(RezerwacjaForView rezerwacja);
        [OperationContract]
        bool DeleteRezerwacja(int IdRezerwacji);


        //rodzaje pokoju
        [OperationContract]
        List<RodzajPokojuForView> GetAllRodzajePokojow();

        [OperationContract]
        bool AddModifyRodzajPokoju(RodzajPokojuForView rodzajPokoju);
        [OperationContract]
        bool DeleteRodzajPokoju(int IdRodzajPokoju);


        //pokoj
        [OperationContract]
        List<PokojForView> GetAllPokoje();

        [OperationContract]
        bool AddModifyPokoj(PokojForView pokoj);
        [OperationContract]
        bool DeletePokoj(int IdPokoju);
    }
    
}

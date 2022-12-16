using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FleetManagment.Domain.Entities
{
    public class Customer
    {
        public Customer()
        {
            //Addresses = new List<Address>();
        }
        public int Id { get; set; }

        /// <summary>
        /// Nazwa klienta indywidualnego lub firmy
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Data rejestracji użytkownika
        /// </summary>
        public DateTime RegistrationDate { get; set; }

        /// <summary>
        /// Wiek klienta indywidualnego, wymagany do wyporzyczenia niektórych aut
        /// </summary>
        public int AgeCustomer { get; set; }

        /// <summary>
        /// Status informujący czy użytkownik może wypożyczać produkty
        /// </summary>
        public int CustomerStatusId { get; set; }

        /// <summary>
        /// NIP firmy wypożyczającej
        /// </summary>
        public string NIP { get; set; }

        /// <summary>
        /// Regon firmy wypożyczającej
        /// </summary>
        public string REGON { get; set; }

        /// <summary>
        /// Czy klient jest aktywny
        /// </summary>
        public bool IsActiv { get; set; }

        //#region Relacje
        ///// <summary>
        ///// Relacja 1:1 
        ///// </summary>
        //public ContactPerson CustomerContactPerson { get; set; }



        //// Relacja do ItemType 1 ItemType może mieć w kolekcji wiele Itemów

        ///// <summary>
        ///// int? CustomertypeId - mówi o tym, że jest to property nie obowiązkowe
        ///// </summar>
        //public int? CustomerTypeId { get; set; }
        ///// <summary>
        ///// Służy do stworzenia relacji
        ///// </summary>
        //public CustomerType CustomerType { get; set; }

        //// Relacja 1 : N relacja jeden Customer wiele adresów
        //public List<Address> Addresses { get; set; }

        //public List<ContactDetail> ContactDetails { get; set; }
        //#endregion
    }
}
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManagment.Application.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommand : IRequest<int>
    {
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


        public string ContactPersonFirstName { get; set; }
        public string ContactPersonSecondName { get; set; }
        public string ContactPersonLastName { get; set; }


        /// <summary>
        /// Pozycja jaką zajmuje użytkownik w firmie
        /// </summary>
        public string Position { get; set; }


        #region Adress

        /// <summary>
        /// Jaki adres domowy, do korespondencji, zamieszkanaia, wykonywania działalności
        /// </summary>
        public string AddressType { get; set; }

        /// <summary>
        /// Nazwa ulicy
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Numer Bloku, Domu
        /// </summary>
        public string BuildingNumber { get; set; }

        /// <summary>
        /// Numer mieszkania
        /// </summary>
        public string FlatNumber { get; set; }

        /// <summary>
        /// Kod pocztowy
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// Nazwa miasta, Wsi
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Nazwa Kraju
        /// </summary>
        public string Country { get; set; }
        #endregion

        #region Contact detail Information

        /// <summary>
        /// Przechowuje telefony, emil
        /// </summary>
        public string ContactDetailInformation { get; set; }

        /// <summary>
        /// klucz obcy 
        /// </summary>
        public int ContactDetailTypeId { get; set; }

        #endregion

        #region Contact detail type
        /// <summary>
        /// Przechowuje informacje czy tel, faksu czy adres email są: prywatne, firmowe itp
        /// </summary>
        public string ContactDetailTypeName { get; set; }

        #endregion
    }
}


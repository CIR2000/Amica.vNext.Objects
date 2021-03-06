﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Amica.Models.Resources;

namespace Amica.Models
{
    /// <summary>
    /// Contact information.
    /// </summary>
    /// <seealso cref="Amica.Models.BaseModelWithCompanyId" />
    public class Contact : BaseModelWithCompanyId
    {
        private string _name;
        private string _vatIdNumber;
        private string _marketArea;
        private string _idCode;
        private string _taxIdNumber;

        private AddressEx _address;
        private Currency _currency;
        private Relationship _relationship = new Relationship();
        private SalesSettings _salesSettings = new SalesSettings();
        private PurchaseSettings _purchaseSettings = new PurchaseSettings();
        private string _bankId;

        private List<ShippingAddress> _otherAddresses = new List<ShippingAddress>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class.
        /// </summary>
        public Contact()
        {
            var defaultCurrency = CurrencyHelpers.Currencies["EUR"];
            Currency = new Currency
            {
                Code = defaultCurrency.Code,
                Name = defaultCurrency.Name,
                Symbol = defaultCurrency.Symbol
            };
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Display(Name = nameof(Properties.Name), ResourceType = typeof(Properties))]
        public string Name
        {
            set { SetProperty(ref _name, value); }
            get { return _name; }
        }

        /// <summary>
        /// Gets or sets the identifier code.
        /// </summary>
        /// <value>
        /// The identifier code.
        /// </value>
        [Display(Name = nameof(Properties.IdCode), ResourceType = typeof(Properties))]
        public string IdCode
        {
            set { SetProperty(ref _idCode, value); }
            get { return _idCode; }
        }

        /// <summary>
        /// Gets or sets the tax identification number.
        /// </summary>
        /// <value>
        /// The tax identification number.
        /// </value>
        [Display(Name = nameof(Properties.TaxIdentificationNumber), ResourceType = typeof(Properties))]
        public string TaxIdentificationNumber
        {
            set { SetProperty(ref _taxIdNumber, value); }
            get { return _taxIdNumber; }
        }

        /// <summary>
        /// Gets or sets the vat identification number.
        /// </summary>
        /// <value>
        /// The vat identification number.
        /// </value>
        [Display(Name = nameof(Properties.VatIdentificationNumber), Prompt = nameof(Properties.VatIdentificationNumberPrompt), ResourceType = typeof(Resources.Properties))]
        public string VatIdentificationNumber
        {
            set { SetProperty(ref _vatIdNumber, value); }
            get { return _vatIdNumber; }
        }

        /// <summary>
        /// Gets or sets the market area.
        /// </summary>
        /// <value>
        /// The market area.
        /// </value>
        [Display(Name = nameof(Properties.MarketArea), ResourceType = typeof(Properties))]
        public string MarketArea
        {
            set { SetProperty(ref _marketArea, value); }
            get { return _marketArea; }
        }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>
        /// The currency.
        /// </value>
        [Display(Name = nameof(Properties.Currency), ResourceType = typeof(Properties))]
        public Currency Currency
        {
            set { SetProperty(ref _currency, value); }
            get { return _currency; }
        }

        /// <summary>
        /// Gets or sets the kind of relationship we have with the contact.
        /// </summary>
        /// <value>
        /// The is.
        /// </value>
        [Display(Name = nameof(Properties.Relationship), Description = nameof(Properties.RelationshipDescription), ResourceType = typeof(Properties))]
        public Relationship Relationship
        {
            set { SetProperty(ref _relationship, value); }
            get { return _relationship; }
        }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>The address.</value>
        [Display(Name = nameof(Properties.Address), Description = nameof(Properties.AddressDescription), ResourceType = typeof(Properties))]
        public AddressEx Address
        {
            set { SetProperty(ref _address, value); }
            get { return _address; }
        }

        /// <summary>
        /// Gets or sets the bank identifier.
        /// </summary>
        /// <value>
        /// The bank.
        /// </value>
        public string BankId
        {
            set { SetProperty(ref _bankId, value); }
            get { return _bankId; }
        }

        /// <summary>
        /// Gets or sets the other addresses.
        /// </summary>
        /// <value>
        /// The other addresses.
        /// </value>
        [Display(Name = nameof(Properties.OtherAddresses), ResourceType = typeof(Properties))]
        public List<ShippingAddress> OtherAddresses
        {
            set { SetProperty(ref _otherAddresses, value); }
            get { return _otherAddresses; }
        }

        /// <summary>
        /// Gets or sets the sales settings for the contact.
        /// </summary>
        /// <value>The sales settings.</value>
        [Display(Name = nameof(Properties.SalesSettings), Description = nameof(Properties.SalesSettingsDescription), ResourceType = typeof(Properties))]
        public SalesSettings SalesSettings
        {
            set { SetProperty(ref _salesSettings, value); }
            get { return _salesSettings; }
        }

        /// <summary>
        /// Gets or sets the purchase settings for the contact.
        /// </summary>
        /// <value>The purchase settings.</value>
        [Display(Name = nameof(Properties.PurchaseSettings), Description = nameof(Properties.PurchaseSettingsDescription), ResourceType = typeof(Properties))]
        public PurchaseSettings PurchaseSettings
        {
            set { SetProperty(ref _purchaseSettings, value); }
            get { return _purchaseSettings; }
        }
    }
}

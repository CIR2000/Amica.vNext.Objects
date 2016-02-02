﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Amica.vNext.Models
{
	public class Document : BaseModelWithCompanyId
	{

		private DateTime _date;
	    private decimal _total;
	    private DocumentType _type;

	    private  ContactMinimal _contact = new ContactMinimal();
		private  List<DocumentItem> _items = new List<DocumentItem>();

		public Document()
        {

        }
		/// <summary>
		/// Gets or sets the document date.
		/// </summary>
		/// <value>The document date.</value>
		public DateTime Date {
			set { SetProperty (ref _date, value); }
			get { return _date; }
		}

		/// <summary>
		/// Gets or sets the document contact.
		/// </summary>
		/// <value>The document contact.</value>
		public ContactMinimal Contact {
			set { SetProperty (ref _contact, value); }
			get { return _contact; }
		}

		/// <summary>
		/// Gets or sets the total amount.
		/// </summary>
		/// <value>The total amount.</value>
		public decimal Total {
			set { SetProperty (ref _total, value); }
			get { return _total; }
		}

		/// <summary>
		/// Gets or sets the document type.
		/// </summary>
		/// <value>The total amount.</value>
		public DocumentType Type {
			set { SetProperty (ref _type, value); }
			get { return _type; }
		}
		public List<DocumentItem> Items
        {
			set { SetProperty (ref _items, value); }
			get { return _items; }

        }
	}

	// TODO complete english translation 
    public enum DocumentType
    {
		// DDT
		DeliveryNote = 1,
		// Fattura accompagnatoria
		ShippingInvoice = 2,
		// Fattura di acconto
		DepositInvoice = 3,
		// Fattura differita
		Invoice = 4,
		FatturaProfessionista = 5,
		RicevutaFiscale = 6,
		NotaCredito = 7,
		NotaDebito = 8,
		Scontrino = 9,
		OrdineCliente = 10,
		Preventivo = 11,
		DdtFornitore = 12,
		FatturaAccompagnatoriaFornitore = 13,
		FatturaDifferitaFornitore = 14,
		FatturaProfessionistaFornitore = 15,
		NotaCreditoFornitore = 16,
		NotaDebitoFornitore = 17,
		PreventivoFornitore = 18,
		OrdineFornitore = 19,
		ResoCliente = 20,
		FatturaAccontoFornitore = 21,
		// Fattura proforma
		ProFormaInvoice = 22
    }
}

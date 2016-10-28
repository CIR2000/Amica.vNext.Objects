﻿using Newtonsoft.Json;

namespace Amica.Models
{
    public class ContactDetailsEx : ContactDetails, IContactDetailsEx
    {
        private string _uniqueId;
        private string _name;

		[JsonProperty("contact_id")]
        public string UniqueId
        {
            get { return _uniqueId; }
            set { SetProperty(ref _uniqueId, value); }
        }
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }
    }
}

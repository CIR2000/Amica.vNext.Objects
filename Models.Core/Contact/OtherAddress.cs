﻿namespace Amica.vNext.Models
{
    public class OtherAddress : AddressEx
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PTM.Models
{
    public class ClientsModel
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string ContactPerson { get; set; }
        public string ContactEmail { get; set; }
        public string SkypeAccount { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string OtherContactChannelName { get; set; }
        public string OtherContactChannelValue { get; set; }
    }
}

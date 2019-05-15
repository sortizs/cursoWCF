using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Pacagroup.Comercial.Credits.Domain
{
    [DataContract]
    public class Client
    {
        [DataMember]
        public int IdClient { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Lastname { get; set; }
        [DataMember]
        public string SecondLastname { get; set; }
        [DataMember]
        public string DocumentType { get; set; }
        [DataMember]
        public string DocumentNumber { get; set; }
        [DataMember]
        public string Gender { get; set; }
        [DataMember]
        public DateTime BornDate { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string PostalCode { get; set; }
        [DataMember]
        public string CivilStatus { get; set; }
    }
}

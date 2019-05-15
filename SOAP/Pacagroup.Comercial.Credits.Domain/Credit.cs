using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Pacagroup.Comercial.Credits.Domain
{
    [DataContract]
    class Credit
    {
        [DataMember]
        public int IdCredit { get; set; }
        [DataMember]
        public int CreditType { get; set; }
        [DataMember]
        public int IdClient { get; set; }
        [DataMember]
        public DateTime CreditDate { get; set; }
        [DataMember]
        public decimal Amount { get; set; }
        [DataMember]
        public DateTime PaymentDate { get; set; }
        [DataMember]
        public decimal Rate { get; set; }
        [DataMember]
        public decimal Commission { get; set; }
    }
}

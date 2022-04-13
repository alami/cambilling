using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public enum EPersonType
    {
        Individual = 1,

        Organization = 2
    }
    public class Account : BaseModel
    {
        public string Number { get; set; }

        public EPersonType PersonType { get; set; } = EPersonType.Individual;
    }
}

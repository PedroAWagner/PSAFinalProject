using System;
using System.Text;

namespace IPRF.Models
{
    public class Declaration
    {
        public int declarationId { get; set; }
        public double incomme { get; set; }
        public int dependents { get; set; }
        public double socialSecurity { get; set; }
        public bool status { get; set; }
        public string date { get; set; }
        public int userID { get; set; }
        public User user { get; set; }
        public virtual IEnumerable<Deducao> Deducoes { get; set; }
    }
}
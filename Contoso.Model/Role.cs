using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model.Common;

namespace Contoso.Model
{
    public class Role: AuditableEntity
    {
        public string RoleName { get; set; }
        public string Descroption { get; set; }
        
        //used for PersonRules table
        public ICollection<People> People { get; set; }
    }
}

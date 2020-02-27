using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AccountModel
    {
        public int AccountID { get; set; }
        public string AccountName { get; set; }
        public string AccountPassword { get; set; }
        public int RoleID { get; set; }
    }
}

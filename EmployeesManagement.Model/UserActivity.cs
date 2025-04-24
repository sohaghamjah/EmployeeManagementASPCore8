using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManagement.Model
{
    public class UserActivity
    {
        public long? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public long? UpdatedBy { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}

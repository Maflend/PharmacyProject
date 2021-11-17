using PharmacyForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyForms
{
    public static class CurrentUserStatic
    {
        public static int Id { get; set; }
        public static string Login { get; set; }
        public static string Password { get; set; }
        public static Roles Role { get; set; }

        public static bool EmergencyStart = false;
    }
}

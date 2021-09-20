using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyForms.Models
{
    public enum Roles
    {
        Guest,
        Client,
        Stuff,
        Director,
        Admin
    }
    public enum FieldsError
    {
        Логин,
        Пароль
    }
    public enum Categories
    {
        Жаропонижающие,
        Болеутоляющие,
        Противовирусные,
        Антибиотики,
        Витамины
    }
}

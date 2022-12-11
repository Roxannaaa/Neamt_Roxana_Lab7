using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;


// Proprietatea ID este marcata ca fiind PrimaryKey si AutoIncrement pentru a ne asigura ca fiecare lista de cumparaturi
// din aplicatia noastra va avea un Id unic furnizat de SQLite.

namespace Neamt_Roxana_Lab7.Models
{
    public class ShopList
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [MaxLength(250), Unique]
        public string Description { get; set; }
        public DateTime Date { get; set; }

    }
}

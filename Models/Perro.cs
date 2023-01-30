using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace KevinRosero_ExamenFinal.Models
{
    [Table("perro")]
    public class Perro
    {
        [PrimaryKey, AutoIncrement]
        public int Id_KevinR { get; set; }
        [MaxLength(250), Unique]
        public string Name_KevinR { get; set; } 
        public string Raza_KevinR { get; set; }
        public string Edad_KevinR { get; set; }
        public bool Esta_Vacunado { get; set; }
    }
}

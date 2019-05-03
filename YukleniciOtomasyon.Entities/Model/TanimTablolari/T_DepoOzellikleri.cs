using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YukleniciOtomasyon.Entities.Model.Depo
{
    public class T_DepoOzellikleri : BaseEntity
    {
        public string Ad { get; set; }
        public string Boyutu { get; set; }
        public string Adres { get; set; }

        public int DepolarId { get; set; }

        //Navigation Property
        public virtual Depolar Depolar { get; set; }
    }
}

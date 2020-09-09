using System;
using System.Collections.Generic;

namespace memelation___backend.Models
{
    public partial class TbLogin
    {
        public int IdLogin { get; set; }
        public string DsLogin { get; set; }
        public string DsSenha { get; set; }
        public DateTime? DtInclusao { get; set; }
    }
}

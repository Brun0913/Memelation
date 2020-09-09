using System;
using System.Collections.Generic;

namespace memelation___backend.Models
{
    public partial class TbListaNegra
    {
        public int IdListaNegra { get; set; }
        public string NmPessoa { get; set; }
        public string DsMotivo { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string DsLocal { get; set; }
        public string DsFoto { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace memelation___backend.Models
{
    public partial class TbComentario
    {
        public int IdComentario { get; set; }
        public int IdMeme { get; set; }
        public string DsComentario { get; set; }

        public virtual TbMemelation IdMemeNavigation { get; set; }
    }
}

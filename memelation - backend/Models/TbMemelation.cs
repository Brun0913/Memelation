using System;
using System.Collections.Generic;

namespace memelation___backend.Models
{
    public partial class TbMemelation 
    {
        public TbMemelation()
        {
            TbComentario = new HashSet<TbComentario>();
        }

        public int IdMemelation { get; set; }
        public string NmAutor { get; set; }
        public string DsCategoria { get; set; }
        public string DsHashtags { get; set; }
        public bool BtMaior { get; set; }
        public DateTime DtInclusao { get; set; }
        public string ImgMeme { get; set; }

        public virtual ICollection<TbComentario> TbComentario { get; set; }
    }
}

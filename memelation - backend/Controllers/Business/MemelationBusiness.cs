using System;
using System.Collections;
using System.Collections.Generic;

namespace memelation___backend.Controllers.Business
{
    public class MemelationBusiness
    {
        Database.Memelationdatabase salvar = new Database.Memelationdatabase();
        Utils.MemelationUtils conversor = new Utils.MemelationUtils();
        public Models.TbMemelation verificar(Models.TbMemelation reg)
        {
            if(string.IsNullOrEmpty(reg.NmAutor))
                throw new ArgumentException("nome obrigatorio");
            if(string.IsNullOrEmpty(reg.DsHashtags))
                throw new ArgumentException("hashtags obrigatorio");
            if(string.IsNullOrEmpty(reg.DsCategoria))
                throw new ArgumentException("categoria obrigatorio");

            Models.TbMemelation ctx = salvar.salvar(reg);
            return ctx;

        }
    }
}
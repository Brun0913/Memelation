using System;
using System.Collections;
using System.Collections.Generic;

namespace memelation___backend.Controllers.Database
{
    public class Memelationdatabase
    {
        Models.mydbContext db = new Models.mydbContext();
        Utils.MemelationUtils conversor = new Utils.MemelationUtils();
        public Models.TbMemelation salvar(Models.TbMemelation reg)
        {
            db.TbMemelation.Add(reg);
            db.SaveChanges();
            return reg;
        }
    }
}
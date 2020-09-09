using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc;


namespace memelation___backend.Controllers.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class MemelationController : ControllerBase
    {
        Models.mydbContext db = new Models.mydbContext();
        Business.MemelationBusiness verificar = new Business.MemelationBusiness();
        Utils.MemelationUtils conversor = new Utils.MemelationUtils();
        GerenciarImagens.MemelationImage gerenciarfoto = new GerenciarImagens.MemelationImage();      


        [HttpPost]
        public Models.Response.MemelationResponse inserir( [FromForm] Models.Request.MemelationRequest reg)
        {
            Models.TbMemelation ctx = conversor.ReqParaTb(reg);
            ctx.ImgMeme = gerenciarfoto.gerarnomefoto(reg.imagem.FileName);

            verificar.verificar(ctx);
            gerenciarfoto.salvarfoto(ctx.ImgMeme,reg.imagem);

            Models.Response.MemelationResponse xx = conversor.TbParaRes(ctx);
            return xx;
        }

        [HttpGet]
        public List<Models.Response.MemelationResponse> consultar()
        {
            List<Models.TbMemelation> ctx = db.TbMemelation.ToList();
            List<Models.Response.MemelationResponse> lista = new List<Models.Response.MemelationResponse>();
            foreach(Models.TbMemelation item in ctx)
            {
                lista.Add(conversor.TbParaRes(item));
            }
            return lista;
        }

        [HttpGet("foto/{nome}")]
        public ActionResult buscarfoto(string nome)
        {
            
            byte[] foto = gerenciarfoto.letfoto(nome);
            string xx = gerenciarfoto.GerarContnttype(nome);
            return File(foto,xx);
        }
    }
}
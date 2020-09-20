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

        [HttpGet("comentario")]
        public List<Models.TbComentario> buscarcomentarios()
        {
            List<Models.TbMemelation> ctx = db.TbMemelation.ToList();
            List<Models.TbComentario> ctx2 = db.TbComentario.ToList();
            Models.TbMemelation lista2 = new Models.TbMemelation();
            List<Models.TbComentario> lista = new List<Models.TbComentario>();
            int id = 0;

            foreach(Models.TbComentario item in ctx2)
            {
                id = item.IdMeme;
            }
            foreach(Models.TbMemelation item in ctx)
            {
                if(item.IdMemelation == id)
                    lista2 = item;
            }
            foreach(Models.TbComentario item in ctx2)
            {
                if(item.IdMeme == lista2.IdMemelation)
                    lista.Add(item);
            }
            return lista;
        }

    }
}
using System;

namespace memelation___backend.Utils
{
    public class MemelationUtils
    {
        public Models.TbMemelation ResParaTb(Models.Response.MemelationResponse reg)
        {
            Models.TbMemelation ctx = new Models.TbMemelation();
            ctx.IdMemelation = reg.id;
            ctx.NmAutor = reg.autor;
            ctx.DsCategoria = reg.categoria;
            ctx.DsHashtags = reg.hashtags;
            ctx.BtMaior = reg.maior;
            ctx.ImgMeme = reg.imagem;
            ctx.DtInclusao = reg.inclusao;

            return ctx;   
        }

        public Models.Response.MemelationResponse ReqParaRes(Models.Request.MemelationRequest reg)
        {
            
            Models.Response.MemelationResponse ctx = new Models.Response.MemelationResponse();
            ctx.autor = reg.autor;
            ctx.categoria = reg.categoria;
            ctx.hashtags = reg.hashtags;
            ctx.maior = reg.maior;
            ctx.inclusao = reg.inclusao;

            return ctx;
        }

        public Models.Response.MemelationResponse TbParaRes(Models.TbMemelation reg)
        {
            Models.Response.MemelationResponse ctx = new Models.Response.MemelationResponse();
            ctx.id = reg.IdMemelation;
            ctx.autor = reg.NmAutor;
            ctx.categoria = reg.DsCategoria;
            ctx.hashtags = reg.DsHashtags;
            ctx.maior = reg.BtMaior;
            ctx.imagem = reg.ImgMeme;
            ctx.inclusao = reg.DtInclusao;

            return ctx;
        }

        public Models.TbMemelation ReqParaTb(Models.Request.MemelationRequest reg)
        {
            Models.TbMemelation ctx = new Models.TbMemelation();

            ctx.NmAutor = reg.autor;
            ctx.DsCategoria = reg.categoria;
            ctx.DsHashtags = reg.hashtags;
            ctx.BtMaior = reg.maior;
            ctx.DtInclusao = reg.inclusao;

            return ctx;
        }

        public Models.Response.ComentarioResponse TbComentparaResComent (Models.TbComentario reg)
        {
            Models.Response.ComentarioResponse ctx = new Models.Response.ComentarioResponse();
            ctx.idcomentario = reg.IdComentario;
            ctx.idmeme = reg.IdMeme;
            ctx.comentario = reg.DsComentario;

            return ctx;
        }
        public Models.TbComentario ReqComentparaTbComent(Models.Request.ComentarioRequest reg)
        {
            Models.TbComentario ctx = new Models.TbComentario();
            ctx.IdMeme = reg.idmeme;
            ctx.DsComentario = reg.comentario;

            return ctx;
        }
        public Models.Response.ComentarioResponse ReqComentparaResComent(Models.Request.ComentarioRequest reg)
        {
            Models.Response.ComentarioResponse ctx = new Models.Response.ComentarioResponse();
            ctx.idmeme = reg.idmeme;
            ctx.comentario = reg.comentario;

            return ctx;
        }
    }
}
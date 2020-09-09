using System;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace memelation___backend.Controllers.GerenciarImagens
{
    public class MemelationImage
    {
        public string gerarnomefoto(string nome){

	        string x = Guid.NewGuid().ToString();
	        x = x + Path.GetExtension(nome);
	        return x;
        }
        public void salvarfoto(string nome, IFormFile foto)
        {
	        string caminho = Path.Combine(AppContext.BaseDirectory,"Storage","Fotos",nome);
	        using(FileStream fs = new FileStream(caminho,FileMode.Create))
	        {
		        foto.CopyTo(fs);
	        }
        }
        public byte[] letfoto(string foto)
        {
	            string caminho = Path.Combine(AppContext.BaseDirectory,"Storage","Fotos",foto);
	            byte[] x = File.ReadAllBytes(caminho);
	            return x;	
        }

        public string GerarContnttype(string nome)
        {
            String extensao = Path.GetExtension(nome).Replace(".","");
            string x =  "application/" + extensao;
            return x;
        }
    }
}
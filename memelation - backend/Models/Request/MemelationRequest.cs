using System;
using Microsoft.AspNetCore.Http;

namespace memelation___backend.Models.Request
{
    public class MemelationRequest  
    {
            public string autor{get;set;}
            public string categoria{get;set;}
            public string hashtags {get;set;}
            public Boolean maior {get;set;}
            public IFormFile imagem{get;set;}
            public DateTime inclusao{get;set;}
    }
}
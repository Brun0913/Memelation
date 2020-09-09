using System;

namespace memelation___backend.Models.Response
{
    public class MemelationResponse
    {
            public int id{get;set;}
            public string autor{get;set;}
            public string categoria{get;set;}
            public string hashtags {get;set;}
            public Boolean maior {get;set;}
            public string imagem{get;set;}
            public DateTime inclusao{get;set;}
    }
}
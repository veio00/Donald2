using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Donald2.Models
{
   
    public class Maquina
    {
        [JsonProperty("idMaquina", Required = Required.Always)]
        public int IdMaquina { get; set; }

        [JsonProperty("Responsavel", Required = Required.Always)]
        public string Responsavel { get; set; }

        [JsonProperty("Nome_Maquina", Required = Required.Always)]
        public string NomeMaquina { get; set; }

        [JsonProperty("Adiquirida", Required = Required.Always)]
        public string Adiquirida { get; set; }

        [JsonProperty("Sistema", Required = Required.Always)]
        public string Sistema { get; set; }

        [JsonProperty("Keep_Alive", Required = Required.Always)]
        public int KeepAlive { get; set; }

        [JsonProperty("Grupo_Cliente", Required = Required.Always)]
        public int GrupoCliente { get; set; }
    }
}
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
    public partial class Leitura
    {
        [JsonProperty("idUso", Required = Required.Always)]
        public int IdUso { get; set; }

        [JsonProperty("Hd", Required = Required.Always)]
        public int Hd { get; set; }

        [JsonProperty("Mram", Required = Required.Always)]
        public int Mram { get; set; }

        [JsonProperty("Cpu", Required = Required.Always)]
        public int Cpu { get; set; }

        [JsonProperty("Maquina_Uso", Required = Required.Always)]
        public int MaquinaUso { get; set; }
    }
}
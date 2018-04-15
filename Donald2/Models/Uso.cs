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
    public partial class Uso
    {
        [JsonProperty("idUso", Required = Required.Always)]
        public long IdUso { get; set; }

        [JsonProperty("Hd", Required = Required.Always)]
        public long Hd { get; set; }

        [JsonProperty("Mram", Required = Required.Always)]
        public long Mram { get; set; }

        [JsonProperty("Cpu", Required = Required.Always)]
        public long Cpu { get; set; }

        [JsonProperty("Maquina_Uso", Required = Required.Always)]
        public long MaquinaUso { get; set; }
    }
}
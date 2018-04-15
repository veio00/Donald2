using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Donald2.Models
{
    [DataContract]
    public class Maquina
    {
        [DataMember]
        private int idMaquina;
        [DataMember]
        private string responsavel;
        [DataMember]
        private string nome_Maquina;
        [DataMember]
        private string adiquirida;
        [DataMember]
        private int keep_Alive;
        [DataMember]
        private int grupo_Cliente;

        public int IdMaquina { get => idMaquina; set => idMaquina = value; }
        public string Responsavel { get => responsavel; set => responsavel = value; }
        public string Nome_Maquina { get => nome_Maquina; set => nome_Maquina = value; }
        public string Adiquirida { get => adiquirida; set => adiquirida = value; }
        public int Keep_Alive { get => keep_Alive; set => keep_Alive = value; }
        public int Grupo_Cliente { get => grupo_Cliente; set => grupo_Cliente = value; }
    }
}
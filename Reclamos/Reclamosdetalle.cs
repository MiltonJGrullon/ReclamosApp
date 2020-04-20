using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reclamos
{
    public class Reclamosdetalle
    {
        public int idcompania { get; set; }
        public int id { get; set; }
        public int idtipo { get; set; }
        public int idcliente { get; set; }
        public string nomcli { get; set; }
        public string nomrec { get; set; }
        public string nota { get; set; }
        public DateTime fecha { get; set; }
    }
}

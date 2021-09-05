using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.WRC.Total.com.Models
{
    public class Noticia
    {

        public int Id { get; set; }
        public string ntc_titulo_noticia { get; set; }
        public string ntc_curta_descricao { get; set; }
        public string ntc_texto_noticia { get; set; }

        public string ntc_pais_rally { get; set; }
        public DateTime ntc_data_insercao { get; set; }
        public DateTime ntc_data_atualizacao { get; set; }
    }
}

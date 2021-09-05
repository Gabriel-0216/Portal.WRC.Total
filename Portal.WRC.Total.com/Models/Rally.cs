using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.WRC.Total.com.Models
{
    public class Rally
    {

        public int cld_id_rally { get; set; }
        public string cld_nome_curto_rally { get; set; }
        public string cld_nome_completo_rally { get; set; }
        public string cld_pais_rally { get; set; }
        public string cld_cidade_rally { get; set; }
        public int cld_quantidade_dias { get; set; }
        public DateTime cld_data_insercao { get; set; }
        public DateTime cld_data_atualizacao { get; set; }
        public DateTime cld_data_rally { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.WRC.Total.com.Models
{
    public class Rally
    {

        public int Id { get; set; }
        public string cld_nome_curto_rally { get; set; }
        public string cld_nome_completo_rally { get; set; }
        public string cld_pais_rally { get; set; }
        public string cld_cidade_rally { get; set; }   

        [DataType(DataType.Date)]
        public DateTime cld_data_insercao { get; set; }
        [DataType(DataType.Date)]
        public DateTime cld_data_atualizacao { get; set; }
        [DataType(DataType.Date)]
        public DateTime cld_data_inicio_rally { get; set; }
    }
}

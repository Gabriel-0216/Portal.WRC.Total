using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.WRC.Total.com.Models
{
    public class Equipes
    {
        public int Id { get; set; }
        public string eqp_nome_curto { get; set; }
        public string eqp_nome_completo { get; set; }
        public string eqp_url_site { get; set; }
        public string eqp_url_email { get; set; }
        public string eqp_nome_chefe_equipe { get; set; }
        public string eqp_pais_origem { get; set; }

        [DataType(DataType.Date)]
        public DateTime eqp_data_insercao { get; set; }
        [DataType(DataType.Date)]
        public DateTime eqp_data_atualizacao { get; set; }

    }
}

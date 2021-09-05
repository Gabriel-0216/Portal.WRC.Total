using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.WRC.Total.com.Models
{
    public class Piloto
    {
        public int Id { get; set; }
        public string plt_nome_curto { get; set; }
        public string plt_nome_completo { get; set; }
        public DateTime plt_data_nascimento { get; set; }
        public DateTime plt_data_insercao { get; set; }
        public DateTime plt_data_atualizacao { get; set; }
        public string plt_pais_nascimento { get; set; }
        public string plt_nome_equipe { get; set; }
        public string plt_nome_co_piloto { get; set; }
        public int plt_qtde_vitorias_wrc { get; set; }
        public int plt_qtde_titulos_wrc { get; set; }

    }
}

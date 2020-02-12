using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //Classe gerada automaticamente
    //
    //Para gerar copiar o Json (ctrl C) => Editar => Colar especial => Colar Json como Classe
    //public class Dados
    //{
    //    public DadosNomes[] Property1 { get; set; }
    //}

    public class Dados
    {
        public string nome { get; set; }
        public object sexo { get; set; }
        public string localidade { get; set; }
        public Res[] res { get; set; }
    }

    public class Res
    {
        public string periodo { get; set; }
        public int frequencia { get; set; }
    }

}

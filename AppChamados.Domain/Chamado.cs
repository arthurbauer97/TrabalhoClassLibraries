using System;

namespace AppChamados.Domain
{
    public class Chamado
    {
        public Chamado() { }

        public Chamado(int id,
                        DateTime dataChamado,
                        string descricao,
                        TimeSpan horaInicio,
                        Cliente cliente,
                        Situacao situacao)
        {
            this.id = id;
            this.dataChamado = dataChamado;
            this.descricao = descricao;
            this.horaInicio = horaInicio;
            this.cliente = cliente;
            this.situacao = situacao;
        }

        public int id { get; set; }
        public DateTime dataChamado { get; set; }
        public string descricao { get; set; }
        public DateTime? dataSolucao { get; set; }
        public TimeSpan horaInicio { get; set; }
        public TimeSpan? horaFim { get; set; }
        public TimeSpan? duracaoChamado { get; set; }
        public Situacao situacao { get; set; }
        public Cliente cliente { get; set; }
    }
}
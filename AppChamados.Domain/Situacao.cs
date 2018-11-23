namespace AppChamados.Domain
{
    public class Situacao
    {
        public Situacao() { }

        public Situacao(int id, string descricao)
        {
            this.id = id;
            this.descricao = descricao;
        }
        
        public int id { get; set; }
        public string descricao { get; set; }
    }
}
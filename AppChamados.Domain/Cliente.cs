namespace AppChamados.Domain
{
    public class Cliente
    {
        public Cliente() { }

        public Cliente(int id, string nome, string telefone, string email)
        {
            this.id = id;
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
        }

        public int id { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
    }
}
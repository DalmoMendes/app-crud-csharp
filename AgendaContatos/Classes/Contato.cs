using System;

namespace AgendaContatos
{ // Contato herda da classe abstrada PessoaBase
    public class Contato : PessoaBase
    {
        private string Fone { get; set; }
        private string Email { get; set; }
        private string Link { get; set; }
        private Grupo Grupo { get; set; }
        private bool Excluido { get; set; }

        // Método Construtor
        public Contato(int id, string nome, string fone, string email, string link, Grupo grupo)
        {
            this.Id = id;
            this.Nome = nome;
            this.Fone = fone;
            this.Email = email;
            this.Link = link;
            this.Grupo = grupo;
            this.Excluido = false;
        }

        // Outros métodos - ToString

        public override string ToString()
        {
            string retorno = "";
            retorno += "     Nome: " + this.Nome + Environment.NewLine;
            retorno += "     Fone: " + this.Fone + Environment.NewLine;
            retorno += "     Email: " + this.Email + Environment.NewLine;
            retorno += "     Link: " + this.Link + Environment.NewLine;
            retorno += "     Grupo: " + this.Grupo + Environment.NewLine;
            retorno += "     Excluido: " + this.Excluido;

            return retorno;
        }

        public string retornaNome()
        {
            return this.Nome;
        }

        public int retornaId()
        {
            return this.Id;
        }
        public bool RetornaExcluido()
        {
            return this.Excluido;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
    }


}

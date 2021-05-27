namespace guilh.OneDrive.Documentos.BootCamp_MRV.Entidade
{
    public class Serie: EntidadeModelo
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero" + this.Genero + Enviroment.NewLine;
            retorno += "Titulo" + this.Titulo + Enviroment.NewLine;
            retorno += "Descricao" + this.Descricao + Enviroment.NewLine;
            retorno += "Ano de Inicio" + this.Ano;
            return retorno;
        }
        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }
    }
}
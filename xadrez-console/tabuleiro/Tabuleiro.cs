namespace tabuleiro
{
    public class Tabuleiro
    {

        public int linha { get; set; }
        public int colunas { get; set; }
        private Pecas[,] pecas;

        public Tabuleiro(int linha, int colunas)
        {
            this.linha = linha;
            this.colunas = colunas;
            pecas = new Pecas[linha, colunas];
        }
    }
}
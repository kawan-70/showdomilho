namespace showdomilho
{
    public partial class MainPage : ContentPage
    {
        Gerenciador gerenciador;
        public MainPage()
        {
            InitializeComponent();
            gerenciador = new Gerenciador (labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05, labelPontuacao, labelNivel);
        }
        int pula = 0;
        private void Resposta1Clicked (object sender, EventArgs e)
        {
            gerenciador!.VerificaResposta(1);
        }
        private void Resposta2Clicked (object sender, EventArgs e)
        {
            gerenciador!.VerificaResposta(2);
        }
        private void Resposta3Clicked (object sender, EventArgs e)
        {
            gerenciador!.VerificaResposta(3);
        }
        private void Resposta4Clicked (object sender, EventArgs e)
        {
            gerenciador!.VerificaResposta(4);
        }
        private void Resposta5Clicked (object sender, EventArgs e)
        {
            gerenciador!.VerificaResposta(5);
 
        }
        void RetirarClicked (object s, EventArgs e)
        {
            var ajuda = new RetiraErrada();
            ajuda.ConfiguraDesenho (Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
            ajuda.RealizaAjuda(gerenciador.GetQuestaoAtual());
            (s as Button).IsVisible = false;
        }
        void PularClicked (object s, EventArgs e)
        {    
            if (pula == 2)    
            (s as Button).IsVisible = false;
            else
            {
                gerenciador.ProximaQuestao();
                pula++;
            }
              Pula.Text = "Pula "+(3-pula)+ "X";

        }
         void Buttonporcentagm(object s, EventArgs e)
        {
            var ajuda = new Universitarios();
        ajuda.ConfiguraDesenho(Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        ajuda.RealizaAjuda(gerenciador.GetQuestaoAtual());
        (s as Button).IsVisible=false;
        }
    }
}

﻿namespace showdomilho
{
    public partial class MainPage : ContentPage
    {
        Gerenciador gerenciador;
        public MainPage()
        {
            InitializeComponent();
            gerenciador = new Gerenciador (labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05, labelPontuacao, labelNivel);
        }

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
            gerenciador.ProximaQuestao();
            (s as Button).IsVisible = false;
        }
    }
}

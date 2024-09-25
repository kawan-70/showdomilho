namespace showdomilho;

public partial class MainPage : ContentPage
{
	
	Gerenciador gerenciador;

	public MainPage()

	{
		InitializeComponent();
		gerenciador = new Gerenciador (labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05, dica1, dica2, dica3, Labelpontuacao, labelnivel);

		gerenciador.ProximaQuestao();
	}

	void ClickdResposta01(object sender, EventArgs args)
	{
		gerenciador.VerificarSeEstaCorreta(1);
	}
	void ClickdResposta02(object sender, EventArgs args)
	{
		gerenciador.VerificarSeEstaCorreta(2);
	}
	void ClickdResposta03(object sender, EventArgs args)
	{
		gerenciador.VerificarSeEstaCorreta(3);
	}
	void ClickdResposta04(object sender, EventArgs args)
	{
		gerenciador.VerificarSeEstaCorreta(4);
	}
	void ClickdResposta05(object sender, EventArgs args)
	{
		gerenciador.VerificarSeEstaCorreta(5);
	}
}
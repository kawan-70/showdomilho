namespace showdomilho;

public class Questao:IEquatable<Questao>
{
public Questao()
{

}
//________________________________________________________________________________________________________________
    public string pergunta { get; set; }
    public string resposta1 { get; set; }
    public string resposta2 { get; set; }
    public string resposta3 { get; set; }
    public string resposta4 { get; set; }
    public string resposta5 { get; set; }
    public int nivelpergunta { get; set; }
    public int RespostaCerta { get; set;}
    public int Nivel { get; set;}
//________________________________________________________________________________________________________________ 
    public void desenhar()
    {
        labelPergunta.Text = pergunta;
        Resposta01.Text = resposta1;
        Resposta02.Text = resposta2;
        Resposta03.Text = resposta3;
        Resposta04.Text = resposta4;
        Resposta05.Text = resposta5;
//________________________________________________________________________________________________________________
      
        Resposta01.BackgroundColor = Colors.DarkBlue;
        Resposta01.TextColor       = Colors.White;
        Resposta02.BackgroundColor = Colors.DarkBlue;
        Resposta02.TextColor       = Colors.White;
        Resposta03.BackgroundColor = Colors.DarkBlue;
        Resposta03.TextColor       = Colors.White;
        Resposta04.BackgroundColor = Colors.DarkBlue;
        Resposta04.TextColor       = Colors.White;
        Resposta05.BackgroundColor = Colors.DarkBlue;
        Resposta05.TextColor       = Colors.White;
//________________________________________________________________________________________________________________
        
        Resposta01.IsVisible = true;
        Resposta02.IsVisible = true;
        Resposta03.IsVisible = true;
        Resposta04.IsVisible = true;
        Resposta05.IsVisible = true;
//________________________________________________________________________________________________________________
    }

    private Label labelPergunta;
    private Button Resposta01;
    private Button Resposta02;
    private Button Resposta03;
    private Button Resposta04;
    private Button Resposta05;
//________________________________________________________________________________________________________________
    
    public Questao(Label lp, Button button01, Button button02, Button button03, Button button04, Button button05)
    {
        labelPergunta = lp;
        Resposta01 = button01;
        Resposta02 = button02;
        Resposta03 = button03;
        Resposta04 = button04;
        Resposta05 = button05;
    }
//________________________________________________________________________________________________________________
    public void ConfiguraDesenho(Label lp, Button button01, Button button02, Button button03, Button button04, Button button05)
    {
        labelPergunta = lp;
        Resposta01 = button01;
        Resposta02 = button02;
        Resposta03 = button03;
        Resposta04 = button04;
        Resposta05 = button05;
    }
//________________________________________________________________________________________________________________
    public bool VerificaResposta(int Respostarepondida)
    {
    if (RespostaCerta == Respostarepondida)
        {
            var botao = QualBotao (Respostarepondida);
            botao.BackgroundColor = Colors.Green;
            return true;
        }
//________________________________________________________________________________________________________________
    else
        {
            var botaocorreto = QualBotao (RespostaCerta);
            var botaoincorreto = QualBotao (Respostarepondida);
            botaocorreto.BackgroundColor = Colors.Yellow;
            botaoincorreto.BackgroundColor = Colors.Red;
            return false;
        }
    } 
//________________________________________________________________________________________________________________
    private Button QualBotao (int Respostarepondida)
    {
        if (Respostarepondida == 1)
        return Resposta01;

        else if (Respostarepondida == 2)
        return Resposta02;

        else if (Respostarepondida == 3)
        return Resposta03;

        else if (Respostarepondida == 4)
        return Resposta04;

        else if (Respostarepondida == 5)
        return Resposta05;

        else
        return null;
//________________________________________________________________________________________________________________
    }
    public bool Equals(Questao questao)
    {
        return this.Nivel == questao.Nivel && this.pergunta==questao.pergunta;
    }
}
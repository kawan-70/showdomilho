namespace showdomilho;
{
    public class Questao 
 {
//________________________________________________________________________________________________________________
   public string Pergunta;
   public string Resposta0;
   public string Resposta1;
   public string Resposta2;
   public string Resposta4;
   public string Resposta5;
  //________________________________________________________________________________________________________________
   public int Nivel;
   public int RespostaCerta = 0;
   private Label labelPergunta; 
   private Button buttonResposta0;
   private Button buttonResposta1;
   private Button buttonResposta2;
   private Button buttonResposta3;
   private Button buttonResposta4;
//___________________________________________________________________________________________________________________
   public Questao ()
   {
   }
   //________________________________________________________________________________________________________________
   public void Desenhar ()
   {
     labelPergunta.Text = Pergunta;
     buttonResposta0.Text = Resposta0;
     buttonResposta1.Text = Resposta1;
     buttonResposta2.Text = Resposta2;
     buttonResposta3.Text = Resposta3;
     buttonResposta4.Text = Resposta4;

   }

   //________________________________________________
 
   public Questao (Label LP, Button bt01, Button bt02
   , Button bt03, Button bt04, Button bt05)
   {

     labelPergunta = LP;

    buttonResposta0 = bt00;
    buttonResposta1 = bt01;
    buttonResposta2 = bt02;
    buttonResposta3 = bt03;
    buttonResposta4 = bt04;
   }
   //________________________________________________________________________________________________________________
   public void ConfigurarDesenho (Label LP, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05)
   {
     labelPergunta = LP;
     buttonResposta0 = bt00;
     buttonResposta1 = bt01;
     buttonResposta2 = bt02;
     buttonResposta3 = bt03;
     buttonResposta4 = bt04;
   }
   //__________________________________________________________________________________________________________________
   public bool VerificaResposta (int RespostaCerta)
   {
     if ( RespostaCerta == RespostaCerta ) 
     {
        var b = QualBot (RespostaCerta);
            b.BackgroundColor = Color.black;
        return true;
     }
     else
     {
        return false;
     }
   }
   //___________________________________________________________________________________________________________________
   private Button QualBot (int RespostaCerta)
   {
    if (RespostaCerta == 0 )
        return buttonResposta0;

    else if (RespostaCerta == 1)
        return buttonResposta1;

    else if (RespostaCerta == 2)
        return buttonResposta2;

    else if (RespostaCerta == 3)
        return buttonResposta3;

    else if (RespostaCerta == 4)
        return buttonResposta4;
   }
   }
}
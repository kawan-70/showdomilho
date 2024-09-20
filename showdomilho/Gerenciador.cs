namespace showdomilho;
public class Gerenciador

{
    List<Questao>ListaQuestao=new List<Questao> ();
    List<int>quetaoResolvidas = new List<int>();
    Questao Questaoatual;
    
  public Gerenciador(Label LP, Button bt00, Button bt01, Button bt02, Button bt03, Button bt04 )
  {
    CriaPerguntas(LP, bt00, bt01, bt02, bt03, bt04);
  }
 void CriaPergunta(Button bt00, Button bt01, Button bt02, Button bt03, Button bt04);
 {
    var q1 = new Questao();
        q1.LP = "Vacas podem voar?";
        q1.Resposta0 = "sim";
        q1.Resposta1 = "não";
        q1.Resposta2 = "concerteza!";
        q1.Resposta3 = "com ajuda?";
        q1.Resposta4 = "todas estão corretas";
        q1.RespostaCerta = 2;
        q1.Desenhar(Label LP, Button bt00, Button bt01, Button bt02, Button bt03, Button bt04);
        ListasQuestao.Add(q1);
        ProximaQuestao();
 }
    void ProximaQuestao()
       {
          var NumAlert =Random.Shared.Next(0,ListasQuestao);
          while(quetaoResolvidas.Contains(NumAlert));
          NumAlert=Random.Shared.Next(0,ListasQuestao.Count);
          quetaoResolvidas.Add(NumAlert);
          Questaoatual=ListaQuestao[NumAlert];
          QuestaoAtual.Desenhar();

}
}

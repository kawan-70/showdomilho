using showdomilho;

public class Universitarios : Ajuda
{
    public override void RealizaAjuda(Questao questao)
    {
        var porcentagem = 100;
        for (int i = 0; i < 5; i++)
        {
            int NumAlet = 0;
            if ( porcentagem > 0)
            {
                NumAlet = Random.Shared.Next(0, porcentagem);
                porcentagem -= NumAlet;
            }
    switch (i)
    {
        case 0:
        Resposta01.Text+=" = " + NumAlet.ToString() + " %";
        break;
        case 1:
        Resposta02.Text+=" = " + NumAlet.ToString() + " %";
        break;
        case 2:
        Resposta03.Text+=" = " + NumAlet.ToString() + " %";
        break;
        case 3:
        Resposta04.Text+=" = " + NumAlet.ToString() + " %";
        break;
        case 4:
        Resposta05.Text+=" = " + NumAlet.ToString() + " %";
        break;
    }
  }
 }
}

        
    
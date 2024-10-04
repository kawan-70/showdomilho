using showdomilho;

public class Gerenciador
{
    
    List<Questao> listQuestao = new List<Questao>();
    List<Questao> QuestoesRespondidas = new List<Questao>();
    Questao QuestaoAtual;
    Label labelPontuacao;
    Label labelNivel;
    public Gerenciador(Label LabelPerg, Button Resposta01, Button Resposta02, Button Resposta03, Button Resposta04, Button Resposta05, Label labelPontuacao, Label labelNivel)
    {
        CriarPerguntas(LabelPerg, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        this.labelPontuacao = labelPontuacao;
        this.labelNivel = labelNivel;
    }
    public Questao GetQuestaoAtual()
    {
        return QuestaoAtual;
    }
    void CriarPerguntas(Label labelPergunta, Button Resposta01, Button Resposta02, Button Resposta03, Button Resposta04, Button Resposta05)
    {
        var Q1 = new Questao();
        Q1.Nivel = 1;
        Q1.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q1.pergunta = "Quem descobriu o Brasil?";
        Q1.resposta1 = "Neymar";
        Q1.resposta2 = "Pedro Álvares Cabral";
        Q1.resposta3 = "Napoleão Bonaparte";
        Q1.resposta4 = "Jair Bolsonaro";
        Q1.resposta5 = "Thiago Macedo";
        Q1.RespostaCerta = 2;
        listQuestao.Add(Q1);

        var Q2 = new Questao();
        Q2.Nivel = 1;
        Q2.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q2.pergunta = "Qual é a montanha mais alta do mundo?";
        Q2.resposta1 = "Monte Kilimanjaro";
        Q2.resposta2 = "Aconcágua";
        Q2.resposta3 = "Monte Everest";
        Q2.resposta4 = "K2";
        Q2.resposta5 = "Monte McKinley";
        Q2.RespostaCerta = 3;
        listQuestao.Add(Q2);

        var Q3 = new Questao();
        Q3.Nivel = 1;
        Q3.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q3.pergunta = " Quem é conhecido como o Pai da Psicanálise?";
        Q3.resposta1 = "Sigmund Freud";
        Q3.resposta2 = "Ivan Pavlov";
        Q3.resposta3 = "Erik Erikson";
        Q3.resposta4 = "Carl Jung";
        Q3.resposta5 = "Alfred Adler";
        Q3.RespostaCerta = 1;
        listQuestao.Add(Q3);

        var Q4 = new Questao();
        Q4.Nivel = 1;
        Q4.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q4.pergunta = "Quem pintou a Mona Lisa?";
        Q4.resposta1 = "Vincent van Gogh";
        Q4.resposta2 = "Pablo Picasso";
        Q4.resposta3 = "Leonardo da Vinci";
        Q4.resposta4 = "Claude Monet";
        Q4.resposta5 = "Salvador Dalí";
        Q4.RespostaCerta = 3;
        listQuestao.Add(Q4);

        var Q5 = new Questao();
        Q5.Nivel = 1;
        Q5.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q5.pergunta = "Qual é a fórmula química da água?";
        Q5.resposta1 = "H2O";
        Q5.resposta2 = "CO2";
        Q5.resposta3 = "O2";
        Q5.resposta4 = "H2O2";
        Q5.resposta5 = "CH4";
        Q5.RespostaCerta = 1;
        listQuestao.Add(Q5);

        var Q6 = new Questao();
        Q6.Nivel = 1;
        Q6.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q6.pergunta = "Qual é o continente onde está localizado o Egito?";
        Q6.resposta1 = "Ásia";
        Q6.resposta2 = "América";
        Q6.resposta3 = "África";
        Q6.resposta4 = "Europa";
        Q6.resposta5 = "Oceania";
        Q6.RespostaCerta = 3;
        listQuestao.Add(Q6);

        var Q7 = new Questao();
        Q7.Nivel = 1;
        Q7.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q7.pergunta = "Qual é a moeda do Japão?";
        Q7.resposta1 = "Yuan";
        Q7.resposta2 = "Won";
        Q7.resposta3 = "Dólar";
        Q7.resposta4 = "Iene";
        Q7.resposta5 = "Rupia";
        Q7.RespostaCerta = 4;
        listQuestao.Add(Q7);

        var Q8 = new Questao();
        Q8.Nivel = 1;
        Q8.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q8.pergunta = "Quem é conhecido como o 'Rei do Pop'?";
        Q8.resposta1 = "Elvis Presley";
        Q8.resposta2 = "Michael Jackson";
        Q8.resposta3 = "Prince";
        Q8.resposta4 = "David Bowie";
        Q8.resposta5 = "Freddie Mercury";
        Q8.RespostaCerta = 2;
        listQuestao.Add(Q8);

        var Q9 = new Questao();
        Q9.Nivel = 1;
        Q9.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q9.pergunta = "Qual é o órgão responsável por bombear o sangue no corpo humano?";
        Q9.resposta1 = "Fígado";
        Q9.resposta2 = "Coração";
        Q9.resposta3 = "Pulmão";
        Q9.resposta4 = "Rim";
        Q9.resposta5 = "Estômago";
        Q9.RespostaCerta = 2;
        listQuestao.Add(Q9);

        var Q10 = new Questao();
        Q10.Nivel = 1;
        Q10.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q10.pergunta = "Qual é a língua oficial do Brasil?";
        Q10.resposta1 = "Espanhol";
        Q10.resposta2 = "Inglês";
        Q10.resposta3 = "Francês";
        Q10.resposta4 = "Português";
        Q10.resposta5 = "Italiano";
        Q10.RespostaCerta = 4;
        listQuestao.Add(Q10);

        var Q11 = new Questao();
        Q11.Nivel = 2;
        Q11.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q11.pergunta = "Qual é o nome do famoso cientista que formulou a teoria da relatividade?";
        Q11.resposta1 = "Isaac Newton";
        Q11.resposta2 = "Albert Einstein";
        Q11.resposta3 = "Galileu Galilei";
        Q11.resposta4 = "Nikola Tesla";
        Q11.resposta5 = "Stephen Hawking";
        Q11.RespostaCerta = 2;
        listQuestao.Add(Q11);

        var Q12 = new Questao();
        Q12.Nivel = 2;
        Q12.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q12.pergunta = "Qual é o maior oceano do mundo?";
        Q12.resposta1 = "Oceano Atlântico";
        Q12.resposta2 = "Oceano Índico";
        Q12.resposta3 = "Oceano Pacífico";
        Q12.resposta4 = "Oceano Ártico";
        Q12.resposta5 = "Oceano Antártico";
        Q12.RespostaCerta = 3;
        listQuestao.Add(Q12);

        var Q13 = new Questao();
        Q13.Nivel = 2;
        Q13.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q13.pergunta = "Qual é a capital da Itália?";
        Q13.resposta1 = "Roma";
        Q13.resposta2 = "Milão";
        Q13.resposta3 = "Nápoles";
        Q13.resposta4 = "Florença";
        Q13.resposta5 = "Veneza";
        Q13.RespostaCerta = 1;
        listQuestao.Add(Q13);

        var Q14 = new Questao();
        Q14.Nivel = 2;
        Q14.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q14.pergunta = "Qual é o planeta mais próximo do sol?";
        Q14.resposta1 = "Terra";
        Q14.resposta2 = "Marte";
        Q14.resposta3 = "Mercúrio";
        Q14.resposta4 = "Vênus";
        Q14.resposta5 = "Júpiter";
        Q14.RespostaCerta = 3;
        listQuestao.Add(Q14);

        var Q15 = new Questao();
        Q15.Nivel = 2;
        Q15.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q15.pergunta = "Qual é o maior planeta do sistema solar?";
        Q15.resposta1 = "Terra";
        Q15.resposta2 = "Marte";
        Q15.resposta3 = "Júpiter";
        Q15.resposta4 = "Saturno";
        Q15.resposta5 = "Vênus";
        Q15.RespostaCerta = 3;
        listQuestao.Add(Q15);

        var Q16 = new Questao();
        Q16.Nivel = 2;
        Q16.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q16.pergunta = "Qual é a capital da França?";
        Q16.resposta1 = "Berlim";
        Q16.resposta2 = "Madrid";
        Q16.resposta3 = "Paris";
        Q16.resposta4 = "Roma";
        Q16.resposta5 = "Lisboa";
        Q16.RespostaCerta = 3;
        listQuestao.Add(Q16);

        var Q17 = new Questao();
        Q17.Nivel = 2;
        Q17.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q17.pergunta = "Quem escreveu 'Dom Casmurro'?";
        Q17.resposta1 = "Machado de Assis";
        Q17.resposta2 = "José de Alencar";
        Q17.resposta3 = "Joaquim Manuel de Macedo";
        Q17.resposta4 = "Clarice Lispector";
        Q17.resposta5 = "Carlos Drummond de Andrade";
        Q17.RespostaCerta = 1;
        listQuestao.Add(Q17);

        var Q18 = new Questao();
        Q18.Nivel = 2;
        Q18.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q18.pergunta = "Qual é o elemento químico representado pela letra 'O'?";
        Q18.resposta1 = "Ouro";
        Q18.resposta2 = "Oxigênio";
        Q18.resposta3 = "Ósmio";
        Q18.resposta4 = "Oganessônio";
        Q18.resposta5 = "Prata";
        Q18.RespostaCerta = 2;
        listQuestao.Add(Q18);

        var Q19 = new Questao();
        Q19.Nivel = 2;
        Q19.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q19.pergunta = "Qual é o maior deserto do mundo?";
        Q19.resposta1 = "Deserto do Saara";
        Q19.resposta2 = "Deserto da Antártida";
        Q19.resposta3 = "Deserto de Gobi";
        Q19.resposta4 = "Deserto da Arábia";
        Q19.resposta5 = "Deserto de Kalahari";
        Q19.RespostaCerta = 2;
        listQuestao.Add(Q19);

        var Q20 = new Questao();
        Q20.Nivel = 2;
        Q20.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q20.pergunta = "Quem pintou 'A Última Ceia'?";
        Q20.resposta1 = "Michelangelo";
        Q20.resposta2 = "Leonardo da Vinci";
        Q20.resposta3 = "Raphael";
        Q20.resposta4 = "Van Gogh";
        Q20.resposta5 = "Monet";
        Q20.RespostaCerta = 2;
        listQuestao.Add(Q20);

        var Q21 = new Questao();
        Q21.Nivel = 3;
        Q21.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q21.pergunta = "Qual é o maior planeta do sistema solar?";
        Q21.resposta1 = "Terra";
        Q21.resposta2 = "Marte";
        Q21.resposta3 = "Júpiter";
        Q21.resposta4 = "Saturno";
        Q21.resposta5 = "Vênus";
        Q21.RespostaCerta = 3;
        listQuestao.Add(Q21);

        var Q22 = new Questao();
        Q22.Nivel = 3;
        Q22.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q22.pergunta = "Quem é o autor de 'O Alquimista'?";
        Q22.resposta1 = "J.K. Rowling";
        Q22.resposta2 = "Paulo Coelho";
        Q22.resposta3 = "Gabriel García Márquez";
        Q22.resposta4 = "Ernest Hemingway";
        Q22.resposta5 = "F. Scott Fitzgerald";
        Q22.RespostaCerta = 2;
        listQuestao.Add(Q22);

        var Q23 = new Questao();
        Q23.Nivel = 3;
        Q23.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q23.pergunta = "Qual é a capital da Austrália?";
        Q23.resposta1 = "Sydney";
        Q23.resposta2 = "Melbourne";
        Q23.resposta3 = "Canberra";
        Q23.resposta4 = "Brisbane";
        Q23.resposta5 = "Perth";
        Q23.RespostaCerta = 3;
        listQuestao.Add(Q23);

        var Q24 = new Questao();
        Q24.Nivel = 3;
        Q24.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q24.pergunta = "Qual é o maior oceano do mundo?";
        Q24.resposta1 = "Oceano Atlântico";
        Q24.resposta2 = "Oceano Índico";
        Q24.resposta3 = "Oceano Pacífico";
        Q24.resposta4 = "Oceano Ártico";
        Q24.resposta5 = "Oceano Antártico";
        Q24.RespostaCerta = 3;
        listQuestao.Add(Q24);

        var Q25 = new Questao();
        Q25.Nivel = 3;
        Q25.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q25.pergunta = "Qual é o símbolo químico do ouro?";
        Q25.resposta1 = "Au";
        Q25.resposta2 = "Ag";
        Q25.resposta3 = "Pb";
        Q25.resposta4 = "Fe";
        Q25.resposta5 = "Hg";
        Q25.RespostaCerta = 1;
        listQuestao.Add(Q25);

        var Q26 = new Questao();
        Q26.Nivel = 3;
        Q26.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q26.pergunta = "Qual é a língua oficial do Brasil?";
        Q26.resposta1 = "Espanhol";
        Q26.resposta2 = "Português";
        Q26.resposta3 = "Inglês";
        Q26.resposta4 = "Francês";
        Q26.resposta5 = "Italiano";
        Q26.RespostaCerta = 2;
        listQuestao.Add(Q26);

        var Q27 = new Questao();
        Q27.Nivel = 3;
        Q27.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q27.pergunta = "Quem pintou a obra 'Guernica'?";
        Q27.resposta1 = "Pablo Picasso";
        Q27.resposta2 = "Vincent van Gogh";
        Q27.resposta3 = "Salvador Dalí";
        Q27.resposta4 = "Claude Monet";
        Q27.resposta5 = "Henri Matisse";
        Q27.RespostaCerta = 1;
        listQuestao.Add(Q27);

        var Q28 = new Questao();
        Q28.Nivel = 3;
        Q28.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q28.pergunta = "Qual é a montanha mais alta do mundo?";
        Q28.resposta1 = "K2";
        Q28.resposta2 = "Kilimanjaro";
        Q28.resposta3 = "Monte Everest";
        Q28.resposta4 = "Makalu";
        Q28.resposta5 = "Lhotse";
        Q28.RespostaCerta = 3;
        listQuestao.Add(Q28);

        var Q29 = new Questao();
        Q29.Nivel = 3;
        Q29.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q29.pergunta = "Qual é o famoso monumento em Paris?";
        Q29.resposta1 = "Torre Eiffel";
        Q29.resposta2 = "Coliseu";
        Q29.resposta3 = "Big Ben";
        Q29.resposta4 = "Estátua da Liberdade";
        Q29.resposta5 = "Cristo Redentor";
        Q29.RespostaCerta = 1;
        listQuestao.Add(Q29);

        var Q30 = new Questao();
        Q30.Nivel = 3;
        Q30.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q30.pergunta = "Qual é o maior mamífero do mundo?";
        Q30.resposta1 = "Elefante";
        Q30.resposta2 = "Baleia Azul";
        Q30.resposta3 = "Girafa";
        Q30.resposta4 = "Hipopótamo";
        Q30.resposta5 = "Orca";
        Q30.RespostaCerta = 2;
        listQuestao.Add(Q30);

        var Q31 = new Questao();
        Q31.Nivel = 4;
        Q31.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q31.pergunta = "Qual é a capital da França?";
        Q31.resposta1 = "Berlim";
        Q31.resposta2 = "Madrid";
        Q31.resposta3 = "Paris";
        Q31.resposta4 = "Lisboa";
        Q31.resposta5 = "Roma";
        Q31.RespostaCerta = 3;
        listQuestao.Add(Q31);

        var Q32 = new Questao();
        Q32.Nivel = 4;
        Q32.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q32.pergunta = "Qual é o elemento químico representado pela letra O?";
        Q32.resposta1 = "Ouro";
        Q32.resposta2 = "Oxigênio";
        Q32.resposta3 = "Osmônio";
        Q32.resposta4 = "Ósmio";
        Q32.resposta5 = "Oxônio";
        Q32.RespostaCerta = 2;
        listQuestao.Add(Q32);

        var Q33 = new Questao();
        Q33.Nivel = 4;
        Q33.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q33.pergunta = "Qual é a língua mais falada do mundo?";
        Q33.resposta1 = "Inglês";
        Q33.resposta2 = "Mandarim";
        Q33.resposta3 = "Espanhol";
        Q33.resposta4 = "Árabe";
        Q33.resposta5 = "Francês";
        Q33.RespostaCerta = 2;
        listQuestao.Add(Q33);

        var Q34 = new Questao();
        Q34.Nivel = 4;
        Q34.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q34.pergunta = "Qual é o planeta mais próximo do sol?";
        Q34.resposta1 = "Terra";
        Q34.resposta2 = "Vênus";
        Q34.resposta3 = "Mercúrio";
        Q34.resposta4 = "Marte";
        Q34.resposta5 = "Júpiter";
        Q34.RespostaCerta = 3;
        listQuestao.Add(Q34);

        var Q35 = new Questao();
        Q35.Nivel = 4;
        Q35.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q35.pergunta = "Qual é a moeda utilizada no Japão?";
        Q35.resposta1 = "Dólar";
        Q35.resposta2 = "Yuan";
        Q35.resposta3 = "Iene";
        Q35.resposta4 = "Won";
        Q35.resposta5 = "Rupia";
        Q35.RespostaCerta = 3;
        listQuestao.Add(Q35);

        var Q36 = new Questao();
        Q36.Nivel = 4;
        Q36.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q36.pergunta = "Quem escreveu 'Dom Casmurro'?";
        Q36.resposta1 = "José de Alencar";
        Q36.resposta2 = "Machado de Assis";
        Q36.resposta3 = "Joaquim Manuel de Macedo";
        Q36.resposta4 = "Clarice Lispector";
        Q36.resposta5 = "Graciliano Ramos";
        Q36.RespostaCerta = 2;
        listQuestao.Add(Q36);

        var Q37 = new Questao();
        Q37.Nivel = 4;
        Q37.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q37.pergunta = "Qual é a fórmula química da água?";
        Q37.resposta1 = "H2O";
        Q37.resposta2 = "O2";
        Q37.resposta3 = "CO2";
        Q37.resposta4 = "NaCl";
        Q37.resposta5 = "C6H12O6";
        Q37.RespostaCerta = 1;
        listQuestao.Add(Q37);

        var Q38 = new Questao();
        Q38.Nivel = 4;
        Q38.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q38.pergunta = "Qual é o autor da obra 'O Pequeno Príncipe'?";
        Q38.resposta1 = "Antoine de Saint-Exupéry";
        Q38.resposta2 = "Jules Verne";
        Q38.resposta3 = "Gabriel García Márquez";
        Q38.resposta4 = "Lewis Carroll";
        Q38.resposta5 = "Hans Christian Andersen";
        Q38.RespostaCerta = 1;
        listQuestao.Add(Q38);

        var Q39 = new Questao();
        Q39.Nivel = 4;
        Q39.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q39.pergunta = "Qual é o rio mais longo do mundo?";
        Q39.resposta1 = "Nilo";
        Q39.resposta2 = "Amazonas";
        Q39.resposta3 = "Yangtze";
        Q39.resposta4 = "Mississippi";
        Q39.resposta5 = "Ganges";
        Q39.RespostaCerta = 1;
        listQuestao.Add(Q39);

        var Q40 = new Questao();
        Q40.Nivel = 4;
        Q40.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q40.pergunta = "Qual é o continente onde fica o Egito?";
        Q40.resposta1 = "Ásia";
        Q40.resposta2 = "América";
        Q40.resposta3 = "África";
        Q40.resposta4 = "Europa";
        Q40.resposta5 = "Oceania";
        Q40.RespostaCerta = 3;
        listQuestao.Add(Q40);

        var Q41 = new Questao();
        Q41.Nivel = 5;
        Q41.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q41.pergunta = "Qual é o maior deserto do mundo?";
        Q41.resposta1 = "Deserto do Saara";
        Q41.resposta2 = "Deserto da Antártica";
        Q41.resposta3 = "Deserto de Gobi";
        Q41.resposta4 = "Deserto de Kalahari";
        Q41.resposta5 = "Deserto de Atacama";
        Q41.RespostaCerta = 2;
        listQuestao.Add(Q41);

        var Q42 = new Questao();
        Q42.Nivel = 5;
        Q42.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q42.pergunta = "Quem foi o primeiro homem a pisar na Lua?";
        Q42.resposta1 = "Buzz Aldrin";
        Q42.resposta2 = "Neil Armstrong";
        Q42.resposta3 = "Yuri Gagarin";
        Q42.resposta4 = "John Glenn";
        Q42.resposta5 = "Michael Collins";
        Q42.RespostaCerta = 2;
        listQuestao.Add(Q42);

        var Q43 = new Questao();
        Q43.Nivel = 5;
        Q43.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q43.pergunta = "Qual é a capital da Itália?";
        Q43.resposta1 = "Veneza";
        Q43.resposta2 = "Roma";
        Q43.resposta3 = "Milão";
        Q43.resposta4 = "Florença";
        Q43.resposta5 = "Nápoles";
        Q43.RespostaCerta = 2;
        listQuestao.Add(Q43);

        var Q44 = new Questao();
        Q44.Nivel = 5;
        Q44.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q44.pergunta = "Qual é o maior oceano do mundo?";
        Q44.resposta1 = "Oceano Atlântico";
        Q44.resposta2 = "Oceano Índico";
        Q44.resposta3 = "Oceano Pacífico";
        Q44.resposta4 = "Oceano Ártico";
        Q44.resposta5 = "Oceano Antártico";
        Q44.RespostaCerta = 3;
        listQuestao.Add(Q44);

        var Q45 = new Questao();
        Q45.Nivel = 5;
        Q45.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q45.pergunta = "Quem pintou a 'Monalisa'?";
        Q45.resposta1 = "Pablo Picasso";
        Q45.resposta2 = "Vincent van Gogh";
        Q45.resposta3 = "Leonardo da Vinci";
        Q45.resposta4 = "Michelangelo";
        Q45.resposta5 = "Rembrandt";
        Q45.RespostaCerta = 3;
        listQuestao.Add(Q45);

        var Q46 = new Questao();
        Q46.Nivel = 5;
        Q46.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q46.pergunta = "Qual é a montanha mais alta do mundo?";
        Q46.resposta1 = "K2";
        Q46.resposta2 = "Kangchenjunga";
        Q46.resposta3 = "Everest";
        Q46.resposta4 = "Lhotse";
        Q46.resposta5 = "Makalu";
        Q46.RespostaCerta = 3;
        listQuestao.Add(Q46);

        var Q47 = new Questao();
        Q47.Nivel = 5;
        Q47.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q47.pergunta = "Qual é a língua oficial do Brasil?";
        Q47.resposta1 = "Espanhol";
        Q47.resposta2 = "Inglês";
        Q47.resposta3 = "Português";
        Q47.resposta4 = "Francês";
        Q47.resposta5 = "Italiano";
        Q47.RespostaCerta = 3;
        listQuestao.Add(Q47);

        var Q48 = new Questao();
        Q48.Nivel = 5;
        Q48.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q48.pergunta = "Qual é o maior país do mundo em área territorial?";
        Q48.resposta1 = "Estados Unidos";
        Q48.resposta2 = "China";
        Q48.resposta3 = "Canadá";
        Q48.resposta4 = "Rússia";
        Q48.resposta5 = "Brasil";
        Q48.RespostaCerta = 4;
        listQuestao.Add(Q48);

        var Q49 = new Questao();
        Q49.Nivel = 5;
        Q49.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q49.pergunta = "Qual é o símbolo químico do ouro?";
        Q49.resposta1 = "Au";
        Q49.resposta2 = "Ag";
        Q49.resposta3 = "Fe";
        Q49.resposta4 = "Hg";
        Q49.resposta5 = "Pb";
        Q49.RespostaCerta = 1;
        listQuestao.Add(Q49);

        var Q50 = new Questao();
        Q50.Nivel = 5;
        Q50.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q50.pergunta = "Quem é conhecido como o 'Pai da Psicanálise'?";
        Q50.resposta1 = "Carl Jung";
        Q50.resposta2 = "Sigmund Freud";
        Q50.resposta3 = "B.F. Skinner";
        Q50.resposta4 = "Albert Bandura";
        Q50.resposta5 = "Erik Erikson";
        Q50.RespostaCerta = 2;
        listQuestao.Add(Q50);

        var Q51 = new Questao();
        Q51.Nivel = 6;
        Q51.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q51.pergunta = "Qual é o nome do famoso relógio localizado em Londres?";
        Q51.resposta1 = "Big Ben";
        Q51.resposta2 = "Torre Eiffel";
        Q51.resposta3 = "Torre de Pisa";
        Q51.resposta4 = "Cristo Redentor";
        Q51.resposta5 = "Estátua da Liberdade";
        Q51.RespostaCerta = 1;
        listQuestao.Add(Q51);

        var Q52 = new Questao();
        Q52.Nivel = 6;
        Q52.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q52.pergunta = "Qual é a capital da Austrália?";
        Q52.resposta1 = "Sydney";
        Q52.resposta2 = "Melbourne";
        Q52.resposta3 = "Canberra";
        Q52.resposta4 = "Brisbane";
        Q52.resposta5 = "Perth";
        Q52.RespostaCerta = 3;
        listQuestao.Add(Q52);

        var Q53 = new Questao();
        Q53.Nivel = 6;
        Q53.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q53.pergunta = "Qual é o nome do maior animal terrestre?";
        Q53.resposta1 = "Elefante";
        Q53.resposta2 = "Girafa";
        Q53.resposta3 = "Rinoceronte";
        Q53.resposta4 = "Hipopótamo";
        Q53.resposta5 = "Tigre";
        Q53.RespostaCerta = 1;
        listQuestao.Add(Q53);

        var Q54 = new Questao();
        Q54.Nivel = 6;
        Q54.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q54.pergunta = "Quem foi o autor de '1984'?";
        Q54.resposta1 = "Aldous Huxley";
        Q54.resposta2 = "George Orwell";
        Q54.resposta3 = "Ray Bradbury";
        Q54.resposta4 = "Margaret Atwood";
        Q54.resposta5 = "Isaac Asimov";
        Q54.RespostaCerta = 2;
        listQuestao.Add(Q54);

        var Q55 = new Questao();
        Q55.Nivel = 6;
        Q55.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q55.pergunta = "Qual é a capital da Islândia?";
        Q55.resposta1 = "Oslo";
        Q55.resposta2 = "Reykjavík";
        Q55.resposta3 = "Copenhague";
        Q55.resposta4 = "Estocolmo";
        Q55.resposta5 = "Helsinque";
        Q55.RespostaCerta = 2;
        listQuestao.Add(Q55);

        var Q56 = new Questao();
        Q56.Nivel = 6;
        Q56.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q56.pergunta = "Qual é o maior planeta do Sistema Solar?";
        Q56.resposta1 = "Saturno";
        Q56.resposta2 = "Júpiter";
        Q56.resposta3 = "Netuno";
        Q56.resposta4 = "Urano";
        Q56.resposta5 = "Marte";
        Q56.RespostaCerta = 2;
        listQuestao.Add(Q56);

        var Q57 = new Questao();
        Q57.Nivel = 6;
        Q57.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q57.pergunta = "Qual é a moeda oficial da União Europeia?";
        Q57.resposta1 = "Dólar";
        Q57.resposta2 = "Libra Esterlina";
        Q57.resposta3 = "Franco Suíço";
        Q57.resposta4 = "Euro";
        Q57.resposta5 = "Coroa Sueca";
        Q57.RespostaCerta = 4;
        listQuestao.Add(Q57);

        var Q58 = new Questao();
        Q58.Nivel = 6;
        Q58.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q58.pergunta = "Qual é a fórmula química do gás carbônico?";
        Q58.resposta1 = "CO";
        Q58.resposta2 = "CO2";
        Q58.resposta3 = "C2O";
        Q58.resposta4 = "C3O2";
        Q58.resposta5 = "C2H2";
        Q58.RespostaCerta = 2;
        listQuestao.Add(Q58);

        var Q59 = new Questao();
        Q59.Nivel = 6;
        Q59.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q59.pergunta = "Quem pintou o teto da Capela Sistina?";
        Q59.resposta1 = "Raphael";
        Q59.resposta2 = "Leonardo da Vinci";
        Q59.resposta3 = "Michelangelo";
        Q59.resposta4 = "Caravaggio";
        Q59.resposta5 = "Donatello";
        Q59.RespostaCerta = 3;
        listQuestao.Add(Q59);

        var Q60 = new Questao();
        Q60.Nivel = 6;
        Q60.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q60.pergunta = "Qual é a unidade de medida da pressão?";
        Q60.resposta1 = "Pascal";
        Q60.resposta2 = "Joule";
        Q60.resposta3 = "Newton";
        Q60.resposta4 = "Volt";
        Q60.resposta5 = "Ampère";
        Q60.RespostaCerta = 1;
        listQuestao.Add(Q60);

        var Q61 = new Questao();
        Q61.Nivel = 7;
        Q61.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q61.pergunta = "Qual é o nome da obra mais famosa de Shakespeare?";
        Q61.resposta1 = "Hamlet";
        Q61.resposta2 = "Othello";
        Q61.resposta3 = "Romeu e Julieta";
        Q61.resposta4 = "Macbeth";
        Q61.resposta5 = "Sonetos";
        Q61.RespostaCerta = 3;
        listQuestao.Add(Q61);

        var Q62 = new Questao();
        Q62.Nivel = 7;
        Q62.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q62.pergunta = "Qual é a capital da Nova Zelândia?";
        Q62.resposta1 = "Auckland";
        Q62.resposta2 = "Wellington";
        Q62.resposta3 = "Christchurch";
        Q62.resposta4 = "Hamilton";
        Q62.resposta5 = "Dunedin";
        Q62.RespostaCerta = 2;
        listQuestao.Add(Q62);

        var Q63 = new Questao();
        Q63.Nivel = 7;
        Q63.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q63.pergunta = "Qual é a principal religião do Japão?";
        Q63.resposta1 = "Cristianismo";
        Q63.resposta2 = "Islamismo";
        Q63.resposta3 = "Xintoísmo";
        Q63.resposta4 = "Budismo";
        Q63.resposta5 = "Hinduísmo";
        Q63.RespostaCerta = 3;
        listQuestao.Add(Q63);

        var Q64 = new Questao();
        Q64.Nivel = 7;
        Q64.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q64.pergunta = "Qual é o nome do primeiro livro da Bíblia?";
        Q64.resposta1 = "Êxodo";
        Q64.resposta2 = "Levítico";
        Q64.resposta3 = "Gênesis";
        Q64.resposta4 = "Números";
        Q64.resposta5 = "Deuteronômio";
        Q64.RespostaCerta = 3;
        listQuestao.Add(Q64);

        var Q65 = new Questao();
        Q65.Nivel = 7;
        Q65.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q65.pergunta = "Qual é a fórmula química do sal de cozinha?";
        Q65.resposta1 = "NaCl";
        Q65.resposta2 = "KCl";
        Q65.resposta3 = "MgCl2";
        Q65.resposta4 = "CaCl2";
        Q65.resposta5 = "Na2SO4";
        Q65.RespostaCerta = 1;
        listQuestao.Add(Q65);

        var Q66 = new Questao();
        Q66.Nivel = 7;
        Q66.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q66.pergunta = "Qual é o planeta conhecido como 'Planeta Vermelho'?";
        Q66.resposta1 = "Marte";
        Q66.resposta2 = "Vênus";
        Q66.resposta3 = "Júpiter";
        Q66.resposta4 = "Mercúrio";
        Q66.resposta5 = "Saturno";
        Q66.RespostaCerta = 1;
        listQuestao.Add(Q66);

        var Q67 = new Questao();
        Q67.Nivel = 7;
        Q67.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q67.pergunta = "Qual é a capital da Grécia?";
        Q67.resposta1 = "Atenas";
        Q67.resposta2 = "Tóquio";
        Q67.resposta3 = "Roma";
        Q67.resposta4 = "Lisboa";
        Q67.resposta5 = "Berlim";
        Q67.RespostaCerta = 1;
        listQuestao.Add(Q67);

        var Q68 = new Questao();
        Q68.Nivel = 7;
        Q68.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q68.pergunta = "Qual é a capital do Canadá?";
        Q68.resposta1 = "Toronto";
        Q68.resposta2 = "Vancouver";
        Q68.resposta3 = "Ottawa";
        Q68.resposta4 = "Montreal";
        Q68.resposta5 = "Calgary";
        Q68.RespostaCerta = 3;
        listQuestao.Add(Q68);

        var Q69 = new Questao();
        Q69.Nivel = 7;
        Q69.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q69.pergunta = "Qual é o símbolo químico do hidrogênio?";
        Q69.resposta1 = "H";
        Q69.resposta2 = "He";
        Q69.resposta3 = "O";
        Q69.resposta4 = "N";
        Q69.resposta5 = "C";
        Q69.RespostaCerta = 1;
        listQuestao.Add(Q69);

        var Q70 = new Questao();
        Q70.Nivel = 7;
        Q70.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q70.pergunta = "Quem é conhecido como o 'Rei do Pop'?";
        Q70.resposta1 = "Elvis Presley";
        Q70.resposta2 = "Michael Jackson";
        Q70.resposta3 = "Prince";
        Q70.resposta4 = "Madonna";
        Q70.resposta5 = "Freddie Mercury";
        Q70.RespostaCerta = 2;
        listQuestao.Add(Q70);

        var Q71 = new Questao();
        Q71.Nivel = 8;
        Q71.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q71.pergunta = "Qual é o nome do sistema que classifica os seres vivos?";
        Q71.resposta1 = "Taxonomia";
        Q71.resposta2 = "Anatomia";
        Q71.resposta3 = "Evolução";
        Q71.resposta4 = "Genética";
        Q71.resposta5 = "Citoquímica";
        Q71.RespostaCerta = 1;
        listQuestao.Add(Q71);

        var Q72 = new Questao();
        Q72.Nivel = 8;
        Q72.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q72.pergunta = "Quem escreveu 'Dom Quixote'?";
        Q72.resposta1 = "Gabriel García Márquez";
        Q72.resposta2 = "Miguel de Cervantes";
        Q72.resposta3 = "Jorge Luis Borges";
        Q72.resposta4 = "William Shakespeare";
        Q72.resposta5 = "Victor Hugo";
        Q72.RespostaCerta = 2;
        listQuestao.Add(Q72);

        var Q73 = new Questao();
        Q73.Nivel = 8;
        Q73.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q73.pergunta = "Qual é a principal função dos glóbulos vermelhos no sangue?";
        Q73.resposta1 = "Defesa contra infecções";
        Q73.resposta2 = "Transporte de oxigênio";
        Q73.resposta3 = "Coagulação";
        Q73.resposta4 = "Transporte de nutrientes";
        Q73.resposta5 = "Produção de hormônios";
        Q73.RespostaCerta = 2;
        listQuestao.Add(Q73);

        var Q74 = new Questao();
        Q74.Nivel = 8;
        Q74.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q74.pergunta = "Qual é a maior floresta tropical do mundo?";
        Q74.resposta1 = "Floresta Amazônica";
        Q74.resposta2 = "Floresta do Congo";
        Q74.resposta3 = "Floresta de Taiga";
        Q74.resposta4 = "Floresta Boreal";
        Q74.resposta5 = "Floresta Atlântica";
        Q74.RespostaCerta = 1;
        listQuestao.Add(Q74);

        var Q75 = new Questao();
        Q75.Nivel = 8;
        Q75.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q75.pergunta = "Qual é a capital da Rússia?";
        Q75.resposta1 = "São Petersburgo";
        Q75.resposta2 = "Moscovo";
        Q75.resposta3 = "Kiev";
        Q75.resposta4 = "Tóquio";
        Q75.resposta5 = "Pequim";
        Q75.RespostaCerta = 2;
        listQuestao.Add(Q75);

        var Q76 = new Questao();
        Q76.Nivel = 8;
        Q76.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q76.pergunta = "Qual é o elemento químico com o símbolo 'Na'?";
        Q76.resposta1 = "Nitrogênio";
        Q76.resposta2 = "Sódio";
        Q76.resposta3 = "Alumínio";
        Q76.resposta4 = "Nátron";
        Q76.resposta5 = "Cálcio";
        Q76.RespostaCerta = 2;
        listQuestao.Add(Q76);

        var Q77 = new Questao();
        Q77.Nivel = 8;
        Q77.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q77.pergunta = "Quem escreveu 'A Divina Comédia'?";
        Q77.resposta1 = "Dante Alighieri";
        Q77.resposta2 = "Homer";
        Q77.resposta3 = "Virgílio";
        Q77.resposta4 = "Boccaccio";
        Q77.resposta5 = "Petrarca";
        Q77.RespostaCerta = 1;
        listQuestao.Add(Q77);

        var Q78 = new Questao();
        Q78.Nivel = 8;
        Q78.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q78.pergunta = "Qual é o nome do processo pelo qual as plantas produzem seu próprio alimento?";
        Q78.resposta1 = "Fotossíntese";
        Q78.resposta2 = "Respiração";
        Q78.resposta3 = "Transpiração";
        Q78.resposta4 = "Digestão";
        Q78.resposta5 = "Fermentação";
        Q78.RespostaCerta = 1;
        listQuestao.Add(Q78);

        var Q79 = new Questao();
        Q79.Nivel = 8;
        Q79.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q79.pergunta = "Qual é o nome do famoso monumento que representa o Cristo Redentor?";
        Q79.resposta1 = "Cristo da Aparecida";
        Q79.resposta2 = "Cristo do Corcovado";
        Q79.resposta3 = "Cristo de Lisboa";
        Q79.resposta4 = "Cristo de Assunção";
        Q79.resposta5 = "Cristo de Buenos Aires";
        Q79.RespostaCerta = 2;
        listQuestao.Add(Q79);

        var Q80 = new Questao();
        Q80.Nivel = 8;
        Q80.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q80.pergunta = "Qual é o maior oceano do mundo?";
        Q80.resposta1 = "Oceano Atlântico";
        Q80.resposta2 = "Oceano Índico";
        Q80.resposta3 = "Oceano Pacífico";
        Q80.resposta4 = "Oceano Ártico";
        Q80.resposta5 = "Oceano Antártico";
        Q80.RespostaCerta = 3;
        listQuestao.Add(Q80);

        var Q81 = new Questao();
        Q81.Nivel = 9;
        Q81.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q81.pergunta = "Qual é o autor da teoria da relatividade?";
        Q81.resposta1 = "Isaac Newton";
        Q81.resposta2 = "Niels Bohr";
        Q81.resposta3 = "Albert Einstein";
        Q81.resposta4 = "Galileu Galilei";
        Q81.resposta5 = "Stephen Hawking";
        Q81.RespostaCerta = 3;
        listQuestao.Add(Q81);

        var Q82 = new Questao();
        Q82.Nivel = 9;
        Q82.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q82.pergunta = "Qual é a capital da Austrália?";
        Q82.resposta1 = "Sydney";
        Q82.resposta2 = "Melbourne";
        Q82.resposta3 = "Canberra";
        Q82.resposta4 = "Brisbane";
        Q82.resposta5 = "Perth";
        Q82.RespostaCerta = 3;
        listQuestao.Add(Q82);

        var Q83 = new Questao();
        Q83.Nivel = 9;
        Q83.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q83.pergunta = "Qual é a fórmula química da água?";
        Q83.resposta1 = "H2O";
        Q83.resposta2 = "CO2";
        Q83.resposta3 = "O2";
        Q83.resposta4 = "H2O2";
        Q83.resposta5 = "C6H12O6";
        Q83.RespostaCerta = 1;
        listQuestao.Add(Q83);

        var Q84 = new Questao();
        Q84.Nivel = 9;
        Q84.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q84.pergunta = "Qual é a capital da Espanha?";
        Q84.resposta1 = "Madri";
        Q84.resposta2 = "Barcelona";
        Q84.resposta3 = "Sevilha";
        Q84.resposta4 = "Valência";
        Q84.resposta5 = "Bilbau";
        Q84.RespostaCerta = 1;
        listQuestao.Add(Q84);

        var Q85 = new Questao();
        Q85.Nivel = 9;
        Q85.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q85.pergunta = "Quem escreveu 'Dom Casmurro'?";
        Q85.resposta1 = "Machado de Assis";
        Q85.resposta2 = "José de Alencar";
        Q85.resposta3 = "Graciliano Ramos";
        Q85.resposta4 = "Jorge Amado";
        Q85.resposta5 = "Raquel de Queiroz";
        Q85.RespostaCerta = 1;
        listQuestao.Add(Q85);

        var Q86 = new Questao();
        Q86.Nivel = 9;
        Q86.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q86.pergunta = "Qual é a moeda oficial do Japão?";
        Q86.resposta1 = "Yuan";
        Q86.resposta2 = "Won";
        Q86.resposta3 = "Dólar";
        Q86.resposta4 = "Iene";
        Q86.resposta5 = "Peso";
        Q86.RespostaCerta = 4;
        listQuestao.Add(Q86);

        var Q87 = new Questao();
        Q87.Nivel = 9;
        Q87.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q87.pergunta = "Qual é o planeta mais próximo do Sol?";
        Q87.resposta1 = "Vênus";
        Q87.resposta2 = "Terra";
        Q87.resposta3 = "Mercúrio";
        Q87.resposta4 = "Marte";
        Q87.resposta5 = "Júpiter";
        Q87.RespostaCerta = 3;
        listQuestao.Add(Q87);

        var Q88 = new Questao();
        Q88.Nivel = 9;
        Q88.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q88.pergunta = "Qual é o maior animal terrestre?";
        Q88.resposta1 = "Girafa";
        Q88.resposta2 = "Elefante Africano";
        Q88.resposta3 = "Rinoceronte";
        Q88.resposta4 = "Hipopótamo";
        Q88.resposta5 = "Urso Polar";
        Q88.RespostaCerta = 2;
        listQuestao.Add(Q88);

        var Q89 = new Questao();
        Q89.Nivel = 9;
        Q89.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q89.pergunta = "Qual é a principal fonte de energia da Terra?";
        Q89.resposta1 = "Vento";
        Q89.resposta2 = "Sol";
        Q89.resposta3 = "Água";
        Q89.resposta4 = "Carvão";
        Q89.resposta5 = "Gás Natural";
        Q89.RespostaCerta = 2;
        listQuestao.Add(Q89);

        var Q90 = new Questao();
        Q90.Nivel = 9;
        Q90.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q90.pergunta = "Qual é o elemento químico com símbolo 'O'?";
        Q90.resposta1 = "Ouro";
        Q90.resposta2 = "Oxigênio";
        Q90.resposta3 = "Ósmio";
        Q90.resposta4 = "Oganessônio";
        Q90.resposta5 = "Ondínio";
        Q90.RespostaCerta = 2;
        listQuestao.Add(Q90);

        var Q91 = new Questao();
        Q91.Nivel = 10;
        Q91.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q91.pergunta = "Qual país é conhecido como a Terra do Sol Nascente?";
        Q91.resposta1 = "China";
        Q91.resposta2 = "Coreia do Sul";
        Q91.resposta3 = "Japão";
        Q91.resposta4 = "Tailândia";
        Q91.resposta5 = "Filipinas";
        Q91.RespostaCerta = 3;
        listQuestao.Add(Q91);

        var Q92 = new Questao();
        Q92.Nivel = 10;
        Q92.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q92.pergunta = "Qual é o maior órgão do corpo humano?";
        Q92.resposta1 = "Coração";
        Q92.resposta2 = "Fígado";
        Q92.resposta3 = "Pele";
        Q92.resposta4 = "Pulmão";
        Q92.resposta5 = "Rim";
        Q92.RespostaCerta = 3;
        listQuestao.Add(Q92);

        var Q93 = new Questao();
        Q93.Nivel = 10;
        Q93.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q93.pergunta = "Qual é a capital da Itália?";
        Q93.resposta1 = "Roma";
        Q93.resposta2 = "Veneza";
        Q93.resposta3 = "Milão";
        Q93.resposta4 = "Nápoles";
        Q93.resposta5 = "Florença";
        Q93.RespostaCerta = 1;
        listQuestao.Add(Q93);

        var Q94 = new Questao();
        Q94.Nivel = 10;
        Q94.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q94.pergunta = "Qual é a fórmula química do sal de cozinha?";
        Q94.resposta1 = "NaCl";
        Q94.resposta2 = "KCl";
        Q94.resposta3 = "CaCO3";
        Q94.resposta4 = "HCl";
        Q94.resposta5 = "NH4Cl";
        Q94.RespostaCerta = 1;
        listQuestao.Add(Q94);

        var Q95 = new Questao();
        Q95.Nivel = 10;
        Q95.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q95.pergunta = "Qual é o animal símbolo da Austrália?";
        Q95.resposta1 = "Canguru";
        Q95.resposta2 = "Koala";
        Q95.resposta3 = "Emu";
        Q95.resposta4 = "Dingo";
        Q95.resposta5 = "Wallaby";
        Q95.RespostaCerta = 1;
        listQuestao.Add(Q95);

        var Q96 = new Questao();
        Q96.Nivel = 10;
        Q96.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q96.pergunta = "Qual é a força que puxa os objetos em direção à Terra?";
        Q96.resposta1 = "Magnetismo";
        Q96.resposta2 = "Inércia";
        Q96.resposta3 = "Gravidade";
        Q96.resposta4 = "Fricção";
        Q96.resposta5 = "Empuxo";
        Q96.RespostaCerta = 3;
        listQuestao.Add(Q96);

        var Q97 = new Questao();
        Q97.Nivel = 10;
        Q97.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q97.pergunta = "Qual é a unidade de medida da pressão?";
        Q97.resposta1 = "Joule";
        Q97.resposta2 = "Pascal";
        Q97.resposta3 = "Newton";
        Q97.resposta4 = "Watt";
        Q97.resposta5 = "Ampere";
        Q97.RespostaCerta = 2;
        listQuestao.Add(Q97);

        var Q98 = new Questao();
        Q98.Nivel = 10;
        Q98.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q98.pergunta = "Qual é o principal gás que compõe a atmosfera terrestre?";
        Q98.resposta1 = "Oxigênio";
        Q98.resposta2 = "Nitrogênio";
        Q98.resposta3 = "Dióxido de Carbono";
        Q98.resposta4 = "Hélio";
        Q98.resposta5 = "Argônio";
        Q98.RespostaCerta = 2;
        listQuestao.Add(Q98);

        var Q99 = new Questao();
        Q99.Nivel = 10;
        Q99.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q99.pergunta = "Qual é o processo pelo qual as plantas produzem seu alimento?";
        Q99.resposta1 = "Respiração";
        Q99.resposta2 = "Fermentação";
        Q99.resposta3 = "Fotossíntese";
        Q99.resposta4 = "Digestão";
        Q99.resposta5 = "Transpiração";
        Q99.RespostaCerta = 3;
        listQuestao.Add(Q99);

        var Q100 = new Questao();
        Q100.Nivel = 10;
        Q100.ConfiguraDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        Q100.pergunta = "Questaoual é a capital da Alemanha?";
        Q100.resposta1 = "Berlim";
        Q100.resposta2 = "Munique";
        Q100.resposta3 = "Hamburgo";
        Q100.resposta4 = "Colônia";
        Q100.resposta5 = "Frankfurt";
        Q100.RespostaCerta = 1;
        listQuestao.Add(Q100);

        ProximaQuestao();
    }
    public void ProximaQuestao()
    {
        var ListaQuestoes = listQuestao.Where(d => d.Nivel == NivelAtual).ToList();
        var NumAlet = Random.Shared.Next(0, ListaQuestoes.Count - 1);
        var NovaQuestao = ListaQuestoes[NumAlet];
        while (QuestoesRespondidas.Contains(NovaQuestao))
        {
            NumAlet = Random.Shared.Next(0, ListaQuestoes.Count - 1);
            NovaQuestao = ListaQuestoes[NumAlet];
        }
        QuestoesRespondidas.Add(NovaQuestao);
        QuestaoAtual = NovaQuestao;
        QuestaoAtual.desenhar();
    }
    public int Pontuacao { get; private set; }
    int NivelAtual = 1;
    void Inicializar()
    {
        QuestoesRespondidas.Clear();
        Pontuacao = 0;
        NivelAtual = 1;
        ProximaQuestao();
    }
    public async void VerificaResposta(int Respostarepondida)
    {
        if (QuestaoAtual.VerificaResposta(Respostarepondida))
        {
            await Task.Delay(1000);
            AdicionaPontuacao(NivelAtual);
            NivelAtual++;
            if (NivelAtual == 10)
                await App.Current.MainPage.DisplayAlert("Tu ACERTOU!", "PARABÉNS!", "partiu proxima questão");
                
            ProximaQuestao();
        }
        else
        {
            await App.Current.MainPage.DisplayAlert("VOCÊ ERROU", "GAME OVER", "BLZ");
            Inicializar();
        }
        labelPontuacao.Text = "Pontuação: R$" + Pontuacao.ToString();
        labelNivel.Text = "Nível:" + NivelAtual.ToString();

    }
    void AdicionaPontuacao(int n)
    {
        if (n == 1)
            Pontuacao = 1000;
        else if (n == 2)
            Pontuacao = 2000;
        else if (n == 3)
            Pontuacao = 5000;
        else if (n == 4)
            Pontuacao = 10000;
        else if (n == 5)
            Pontuacao = 20000;
        else if (n == 6)
            Pontuacao = 50000;
        else if (n == 7)
            Pontuacao = 100000;
        else if (n == 8)
            Pontuacao = 200000;
        else if (n == 9)
            Pontuacao = 500000;
        else
            Pontuacao = 1000000;
    }
}
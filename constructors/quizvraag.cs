namespace quizvraag;

class QuizVraag
{
    internal string vraag;
    internal string antwoord;
    internal QuizVraag(string vraag, string antwoord)
    {
        this.vraag = vraag;
        this.antwoord = antwoord;
    }
    private void Run(){
        QuizVraag quizVraag = new QuizVraag("heir komt de vraag", "heir komt het antwoord");
    }

}


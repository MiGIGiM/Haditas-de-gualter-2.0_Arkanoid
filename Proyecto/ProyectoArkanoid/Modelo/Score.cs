namespace ProyectoArkanoid.Controladores
{
    public class Score
    {
        public string idScore { get; }
        public string score { get; set; }
        public string nickname { get; }

        public Score(string idScore, string score, string nickname)
        {
            this.idScore = idScore;
            this.score = score;
            this.nickname = nickname;
        }
    }
}

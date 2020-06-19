namespace ProyectoArkanoid.Controladores
{
    public class User
    { 
        public string nickname { get; set; }
        public int score { get; set; }
        public int idScore { get; set; }

        public User(string nickname)
        {
            this.nickname = nickname;
        }
    }
}
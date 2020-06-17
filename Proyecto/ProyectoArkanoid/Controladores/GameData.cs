namespace ProyectoArkanoid.Controladores
{
    public static class GameData
    {
        public static bool GameStarted = false;
        public static double performedTicks = 0;

        //dirX ^ dirY establecen el movimiento de la pelota
        public static int dirX = 7, dirY = -dirX, lifes = 3, score = 0;

        public static void InitializeGame()
        {
            GameStarted = false;
            lifes = 3;
            score = 0;
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using ProyectoArkanoid.Controladores;


namespace ProyectoArkanoid.Vista
{
    public partial class GameControls : UserControl
    {
        int valorExtraWidth;
        int valorExtraHeight;

        private CustomPictureBox[,] cpb;
        private Panel pnlScore;
        private Label lblScore;
        private PictureBox picBall;
        private PictureBox[] hearts;

        private int remainingPb = 0;

        private delegate void AccionesPelota();
        private readonly AccionesPelota MovingBall;
        public Action EndGame, WinningGame;
        
        public GameControls()
        {
            InitializeComponent();

            MovingBall = BounceBall;
            MovingBall += MoveBall;
            
        }

        //Evita que se este mostrando espacios en blanco mientras se mueve la pelota o barra
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        private void GameControls_Load(object sender, EventArgs e)
        {
          
            // Se invoca el metodo que contiene el panel con la vida y los puntajes
            ScorePanel();

            // Se carga al picture box la imagen que se usara como la barra del juego
            picPaddle.BackgroundImage = Image.FromFile("../../Resources/paddle.png");
            picPaddle.BackgroundImageLayout = ImageLayout.Stretch;

            // Se ajusta la posicion de la barra para que se vea de manera adecuada 
            picPaddle.Top = ((Height - picPaddle.Height) - 90);

            // Se ajusta la posicion de la barra para que inicie al centro de la pantalla 
            picPaddle.Left = (Width / 2) - (picPaddle.Width / 2);

            //Instanciacion de la pelota
            picBall = new PictureBox();
            picBall.Width = picBall.Height = 20;
            picBall.BackgroundImage = Image.FromFile("../../Resources/ball.png");
            picBall.BackgroundImageLayout = ImageLayout.Stretch;

            //Definir la posicion para que la pelota empiece encima de la barra
            picBall.Top = picPaddle.Top - picBall.Height;
            picBall.Left = picPaddle.Left + (picPaddle.Width / 2) - (picBall.Width / 2);

            //Se pone el color de fondo del picturebox a transparente
            picBall.BackColor = Color.Transparent;

            Controls.Add(picBall);

            LoadTiles();
        }

        private void LoadTiles()
        {
            int xAxis = 10, yAxis = 6;
            remainingPb = xAxis * yAxis;

            // Calculos para la ubicación de los elementos
            int pbHeight = (int)(Height * 0.4) / yAxis;
            int pbWidth = (int)(Width - (Width * 0.45) - (xAxis - 5)) / xAxis;
            valorExtraWidth = (int)(Width *0.45) / 2;
            valorExtraHeight = (int)(Height * 0.20) / 2;

            cpb = new CustomPictureBox[yAxis, xAxis];

            // Llenado de bloques con logica de matrices

            for (int i = 0; i < yAxis; i++)
            {
                for(int j = 0; j < xAxis; j++)
                {
                    cpb[i, j] = new CustomPictureBox();

                    if (i == 0)
                    {
                        cpb[i, j].Hits = 2;
                        cpb[i, j].BackgroundImage = Image.FromFile("../../Resources/0.png");
                    }
                    else
                    {
                        cpb[i, j].Hits = 1;
                        cpb[i, j].BackgroundImage = Image.FromFile("../../Resources/" + GenerateRandomNumber() + ".png");
                    }

                    cpb[i, j].Height = pbHeight;
                    cpb[i, j].Width = pbWidth;

                    //Posicion de left y posicion de top
                    cpb[i, j].Left = valorExtraWidth + (j * pbWidth);
                    cpb[i, j].Top = valorExtraHeight + (i * pbHeight) + pnlScore.Height;

                    cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    cpb[i, j].Tag = "tileTag";

                    Controls.Add(cpb[i, j]);
                }
            }
        }

        private int GenerateRandomNumber()
        {
            return new Random().Next(1, 5);
        }

        private void GameControls_MouseMove(object sender, MouseEventArgs e)
        {
            // Delimitacion del movimiento del mouse, es decir, que este no se salga de los bordes
            // de la ventana 
            if (!GameData.GameStarted)
            {
                if (e.X < (Width - picPaddle.Width))
                {
                    picPaddle.Left = e.X;
                    picBall.Left = picPaddle.Left + (picPaddle.Width / 2) + (picBall.Width / 2);
                }
            }
            else
            {
                if (e.X < (Width - picPaddle.Width))
                    picPaddle.Left = e.X;
            }
        }

        private void GameControls_KeyDown(object sender, KeyEventArgs e)
        {
            // Al presionar la barra espaciadora, el juego comienza
            try
            {
                //Verifica que el juego no haya comenzado
                if (!GameData.GameStarted)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.Space:
                            GameData.GameStarted = true;
                            timer1.Start();
                            break;
                        default:
                            throw new WrongKeyPressedException("Presione space para iniciar juego");
                    }
                }
            }
            catch (WrongKeyPressedException ex)
            {
                MessageBox.Show(ex.Message, "Arkanoid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Timer1_Click(object sender, EventArgs e)
        {
            //Si el juego no ha iniciado, no se hace nada
            if (!GameData.GameStarted)
                return;

            GameData.performedTicks += 0.01;

            // Si por alguna razon esta nulo, no se invocara, de lo contrario se invocara
            // Se hace un try catch dentro de otro try catch, para optimizar el código
            try
            {
                MovingBall?.Invoke();           
            }
            catch(OutOfBoundsException ex)
            {
                try
                {
                    GameData.lifes--;
                    GameData.GameStarted = false;
                    timer1.Stop();

                    RepositionElements();
                    UpdateElements();

                    if (GameData.lifes == 0)
                        throw new NoRemainingLifesExeption("");
                }
                catch (NoRemainingLifesExeption ex2)
                {
                    timer1.Stop();
                    EndGame?.Invoke();
                }
            }
        }

        private void BounceBall()
        {
            if (picBall.Top < pnlScore.Height)
            {
                GameData.dirY = -GameData.dirY;
                return;
            }

            //Si la pelota toca la parte inferior del control, el usuario ha perdido
            if (picBall.Bottom > Height)
                throw new OutOfBoundsException("");

            //Si la pelota toca los bordes izq o der, rebota
            if (picBall.Left < 0 || picBall.Right > Width )
            {
                GameData.dirX = -GameData.dirX;
                return;
            }

            //Rebotar la pelota cuando choca con la barra del jugador
            if (picBall.Bounds.IntersectsWith(picPaddle.Bounds) || picBall.Top < 0)
            {
                GameData.dirY = -GameData.dirY;
                return;
            }

            //la variable i se disminuye ya que se esta iniciando desde la fila mas cercana a la pelota
            //esto se hace para hacer el menor numero de verificaciones posible
            for (int i = 5; i >= 0; i--)
            {
                for (int j = 0; j < 10; j++)
                {
                    //Cuando la pelota choca con un bloque, este se elimina y la pelota rebota
                    // y se mueve hacia el otro lado
                    if (cpb[i,j] != null && picBall.Bounds.IntersectsWith(cpb[i, j].Bounds))
                    {
                        if(i == 0)
                            cpb[i, j].BackgroundImage = Image.FromFile("../../Resources/" + GenerateRandomNumber() + ".png");

                        // Actuaiza los puntos en base a los golpes y el tiempo
                        GameData.score += (int)(cpb[i, j].Hits * GameData.performedTicks);

                        cpb[i, j].Hits--;

                        if (cpb[i, j].Hits == 0)
                        {
                            Controls.Remove(cpb[i, j]);
                            cpb[i, j] = null;

                            remainingPb--;
                        }

                        GameData.dirY = -GameData.dirY;

                        lblScore.Text = GameData.score.ToString();

                        // Si ya no quedan bloques, entonces de detiene el timer, se reposicionan los elementos y el jugador ha ganado
                        if(remainingPb == 0)
                        {
                            timer1.Stop();

                            RepositionElements();

                            WinningGame?.Invoke();
                        }
                        return;
                    }
                }
            }
        }

        private void MoveBall()
        {
            picBall.Left += GameData.dirX;
            picBall.Top += GameData.dirY;
        }

        private void ScorePanel()
        {
            // Instanciar panel
            pnlScore = new Panel();

            // Instanciar elementos del panel
            pnlScore.Width = Width;
            pnlScore.Height = (int)(Height * 0.08);

            pnlScore.Top = pnlScore.Left = 0;

            pnlScore.BackColor = Color.FromArgb(44, 9, 64);

            // Trabajando con los corazones   

            hearts = new PictureBox[GameData.lifes];

            for(int i = 0; i < GameData.lifes; i++)
            {
                // Instanciar picture box
                hearts[i] = new PictureBox();

                hearts[i].Height = hearts[i].Width = pnlScore.Height;

                // Poblar con corazones el panel 
                hearts[i].BackgroundImage = Image.FromFile("../../Resources/VIDA3.png");
                hearts[i].BackgroundImageLayout = ImageLayout.Stretch;

                hearts[i].Top = 0;

                if (i == 0)
                    hearts[i].Left = 20;
                else
                    hearts[i].Left = hearts[i - 1].Right + 5;
            }

            lblScore = new Label
            {
                // Setear elementos de los labels
                ForeColor = Color.White,
                Text = GameData.score.ToString(),

                // Agregando la fuente al label y centrando el texto
                Font = new Font("ArcadeClassic", 26F),
                TextAlign = ContentAlignment.MiddleCenter,

                Left = Width - 100,
                Height = pnlScore.Height
            };

            pnlScore.Controls.Add(lblScore);

            // Poblando los corazones
            foreach(var pb in hearts)
            {
                pnlScore.Controls.Add(pb);
            }
 
            Controls.Add(pnlScore);
        }

        private void RepositionElements()
        {
            // Se ajusta la posicion de la barra para que inicie al centro de la pantalla 
            picPaddle.Left = (Width / 2) - (picPaddle.Width / 2);

            // Definir la posicion para que la pelota empiece encima de la barra
            picBall.Top = picPaddle.Top - picBall.Height;
            picBall.Left = picPaddle.Left + (picPaddle.Width / 2) - (picBall.Width / 2);
        }

        private void GameControls_VisibleChanged(object sender, EventArgs e)
        {
            GameControls_Load(sender, e);
        }

        private void UpdateElements()
        {
            // Actualiza las vidas 
            pnlScore.Controls.Remove(hearts[GameData.lifes]);
            hearts[GameData.lifes] = null; 

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Data.SqlClient;
//using AlienGameDataBase;

namespace AlienGames
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
       

       // string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CSharpGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //string insertString = String.Format("INSERT INTO AlienGameHighScore(Username, Score, Date) VALUES ('{0}', '{1}', '{2}')", game1.Name, game1.Game1, game1.Type, game1.Review);
        // string inserting2 = "INSERT INTO GAME (name,game,type,review) VALUES('a','b','c','d')";

        SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CSharpGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        int gameScore;
        int valueOfButtons = 0;
        int generatedNum1;
        int generatedNum2;
        int sumOfGenNum;
        DateTime time = DateTime.Now;
        string format = "YYYY-MM-DD";
        
        Int32 bttn1, bttn2, bttn3, bttn4, bttn5, bttn6, bttn7, bttn8, bttn9;
        private int timeInSecs = 60;
        private DispatcherTimer timer;
        Random randomValue;

        private void Insert_button(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand insertCommand = conn.CreateCommand();
                insertCommand.CommandType = System.Data.CommandType.Text;
                insertCommand.CommandText = "INSERT INTO AlienGameHighScore(Username, Score, Date) VALUES ('"+ UsernameBox.Text +"', '"+ gameScore + "', '" + time + "')";
                //insertCommand.Parameters.AddWithValue("@value", date);
                string insert = @" insert into Table(DateTime Column) values ('" + time.ToString(format) + "')";
                Console.WriteLine(conn.State);

                insertCommand.ExecuteNonQuery();
                MessageBox.Show("Data inserted");
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Something happened to server " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

            public MainWindow()
        {
            InitializeComponent();

            gameScore = 0;
        }

        void stopWatch(object sender, EventArgs e)
        {
            if (timeInSecs > 0)

            {
                if (timeInSecs % 6 == 0)
                {
                    randomImageGen();
                    NumberGenerator();
                    GeneratedValue.Foreground = Brushes.Blue;

                }

                if (timeInSecs <= 10)
                {
                    if (timeInSecs % 1 == 0)
                    {
                        Countdown.Foreground = Brushes.Red;
                    }

                    else
                    {
                        Countdown.Foreground = Brushes.White;

                    }
                      timeInSecs--;
                      Countdown.Content = string.Format("00:0{0}:0{1}", timeInSecs / 60, timeInSecs % 60);
                }
                else
                {
                    timeInSecs--;
                    Countdown.Content = string.Format("00:0{0}:0{1}", timeInSecs / 60, timeInSecs % 60);
                }

            }
            else
            {
                timer.Stop();
                MessageBox.Show("Game Over! Your gameScore is : " + gameScore);
                
            }

        }

        public void NumberGenerator()
        {
            randomValue = new Random();
            generatedNum1 = randomValue.Next(1, 9);
            generatedNum2 = randomValue.Next(1, 9);
            sumOfGenNum = generatedNum1 + generatedNum2;
            GeneratedValue.Content =  sumOfGenNum.ToString();
            GeneratedValue.Foreground = Brushes.Blue;
            valueOfButtons = 0;
        }

      

        public void randomImageGen()
        {

           
            Random randomPic = new Random();
            bttn1 = randomPic.Next(1, 10);
            bttn2 = randomPic.Next(1, 10);
            bttn3 = randomPic.Next(1, 10);
            bttn4 = randomPic.Next(1, 10);
            bttn5 = randomPic.Next(1, 10);
            bttn6 = randomPic.Next(1, 10);
            bttn7 = randomPic.Next(1, 10);
            bttn8 = randomPic.Next(1, 10);
            bttn9 = randomPic.Next(1, 10);


            /*BitmapImage image10 = new BitmapImage();
             Image img10 = new Image();
             image10.BeginInit();
             image10.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien2.jpg");
             image10.EndInit();
             img10.Source = image10;
             Great.Content = img10;*/

            switch (bttn1)
            {
                case 1:
                    BitmapImage image1 = new BitmapImage();
                    Image img1 = new Image();
                    image1.BeginInit();
                    image1.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\One_eye_alien.jpg");
                    image1.EndInit();
                    img1.Source = image1;
                    imagePos1.Content = img1;
                    imagePos1.Tag = 1;
                    break;
                case 2:
                    BitmapImage image2 = new BitmapImage();
                    Image img2 = new Image();
                    image2.BeginInit();
                    image2.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\two_eyes_alien2.jpg");
                    image2.EndInit();
                    img2.Source = image2;
                    imagePos1.Content = img2;
                    imagePos1.Tag = 2;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\two_eyes_alien2.jpg"));
                    break;
                case 3:
                    BitmapImage image3 = new BitmapImage();
                    Image img3 = new Image();
                    image3.BeginInit();
                    image3.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\three_eye_alien.jpg");
                    image3.EndInit();
                    img3.Source = image3;
                    imagePos1.Content = img3;
                    imagePos1.Tag = 3;
                    break;
                case 4:
                    BitmapImage image4 = new BitmapImage();
                    Image img4 = new Image();
                    image4.BeginInit();
                    image4.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\four_eye_monster.jpg");
                    image4.EndInit();
                    img4.Source = image4;
                    imagePos1.Content = img4;
                    imagePos1.Tag = 4;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\four_eye_monster.jpg"));
                    break;
                case 5:
                    BitmapImage image5 = new BitmapImage();
                    Image img5 = new Image();
                    image5.BeginInit();
                    image5.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\five_eye_alien.jpeg");
                    image5.EndInit();
                    img5.Source = image5;
                    imagePos1.Content = img5;
                    imagePos1.Tag = 5;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\five_eye_alien.jpeg"));
                    break;
                case 6:
                    BitmapImage image6 = new BitmapImage();
                    Image img6 = new Image();
                    image6.BeginInit();
                    image6.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\six_eye_alien2.jpg");
                    image6.EndInit();
                    img6.Source = image6;
                    imagePos1.Content = img6;
                    imagePos1.Tag = 6;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\six_eye_alien2.jpg"));
                    break;
                case 7:
                    BitmapImage image7 = new BitmapImage();
                    Image img7 = new Image();
                    image7.BeginInit();
                    image7.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\seven_eye_alien.jpg");
                    image7.EndInit();
                    img7.Source = image7;
                    imagePos1.Content = img7;
                    imagePos1.Tag = 7;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\seven_eye_alien.jpg"));
                    break;
                case 8:
                    BitmapImage image8 = new BitmapImage();
                    Image img8 = new Image();
                    image8.BeginInit();
                    image8.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\eight_eye_alien.jpg");
                    image8.EndInit();
                    img8.Source = image8;
                    imagePos1.Content = img8;
                    imagePos1.Tag = 8;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\eight_eye_alien.jpg"));
                    break;
                case 9:
                    BitmapImage image9 = new BitmapImage();
                    Image img9 = new Image();
                    image9.BeginInit();
                    image9.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien2.jpg");
                    image9.EndInit();
                    img9.Source = image9;
                    imagePos1.Content = img9;
                    imagePos1.Tag = 9;
                    break;
            }

            switch (bttn2)
            {
                case 1:
                    BitmapImage image21 = new BitmapImage();
                    Image img21 = new Image();
                    image21.BeginInit();
                    image21.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\One_eye_alien.jpg");
                    image21.EndInit();
                    img21.Source = image21;
                    imagePos2.Content = img21;
                    imagePos2.Tag = 1;
                    break;
                case 2:
                    BitmapImage image22 = new BitmapImage();
                    Image img22 = new Image();
                    image22.BeginInit();
                    image22.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\two_eyes_alien2.jpg");
                    image22.EndInit();
                    img22.Source = image22;
                    imagePos2.Content = img22;
                    imagePos2.Tag = 2;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\two_eyes_alien2.jpg"));
                    break;
                case 3:
                    BitmapImage image23 = new BitmapImage();
                    Image img23 = new Image();
                    image23.BeginInit();
                    image23.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\three_eye_alien.jpg");
                    image23.EndInit();
                    img23.Source = image23;
                    imagePos2.Content = img23;
                    imagePos2.Tag = 3;
                    break;
                case 4:
                    BitmapImage image24 = new BitmapImage();
                    Image img24 = new Image();
                    image24.BeginInit();
                    image24.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\four_eye_monster.jpg");
                    image24.EndInit();
                    img24.Source = image24;
                    imagePos2.Content = img24;
                    imagePos2.Tag = 4;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\four_eye_monster.jpg"));
                    break;
                case 5:
                    BitmapImage image25 = new BitmapImage();
                    Image img25 = new Image();
                    image25.BeginInit();
                    image25.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\five_eye_alien.jpeg");
                    image25.EndInit();
                    img25.Source = image25;
                    imagePos2.Content = img25;
                    imagePos2.Tag = 5;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\five_eye_alien.jpeg"));
                    break;
                case 6:
                    BitmapImage image26 = new BitmapImage();
                    Image img26 = new Image();
                    image26.BeginInit();
                    image26.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\six_eye_alien2.jpg");
                    image26.EndInit();
                    img26.Source = image26;
                    imagePos2.Content = img26;
                    imagePos2.Tag = 6;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\six_eye_alien2.jpg"));
                    break;
                case 7:
                    BitmapImage image27 = new BitmapImage();
                    Image img27 = new Image();
                    image27.BeginInit();
                    image27.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\seven_eye_alien.jpg");
                    image27.EndInit();
                    img27.Source = image27;
                    imagePos2.Content = img27;
                    imagePos2.Tag = 7;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\seven_eye_alien.jpg"));
                    break;
                case 8:
                    BitmapImage image28 = new BitmapImage();
                    Image img28 = new Image();
                    image28.BeginInit();
                    image28.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\eight_eye_alien.jpg");
                    image28.EndInit();
                    img28.Source = image28;
                    imagePos2.Content = img28;
                    imagePos2.Tag = 8;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\eight_eye_alien.jpg"));
                    break;
                case 9:
                    BitmapImage image29 = new BitmapImage();
                    Image img29 = new Image();
                    image29.BeginInit();
                    image29.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien2.jpg");
                    image29.EndInit();
                    img29.Source = image29;
                    imagePos2.Content = img29;
                    imagePos2.Tag = 9;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien.jpg"));
                    break;
            }

            switch (bttn3)
            {
                case 1:
                    BitmapImage image31 = new BitmapImage();
                    Image img31 = new Image();
                    image31.BeginInit();
                    image31.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\One_eye_alien.jpg");
                    image31.EndInit();
                    img31.Source = image31;
                    imagePos3.Content = img31;
                    imagePos3.Tag = 1;
                    break;
                case 2:
                    BitmapImage image32 = new BitmapImage();
                    Image img32 = new Image();
                    image32.BeginInit();
                    image32.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\two_eyes_alien2.jpg");
                    image32.EndInit();
                    img32.Source = image32;
                    imagePos3.Content = img32;
                    imagePos3.Tag = 2;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\two_eyes_alien2.jpg"));
                    break;
                case 3:
                    BitmapImage image33 = new BitmapImage();
                    Image img33 = new Image();
                    image33.BeginInit();
                    image33.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\three_eye_alien.jpg");
                    image33.EndInit();
                    img33.Source = image33;
                    imagePos3.Content = img33;
                    imagePos3.Tag = 3;
                    break;
                case 4:
                    BitmapImage image34 = new BitmapImage();
                    Image img34 = new Image();
                    image34.BeginInit();
                    image34.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\four_eye_monster.jpg");
                    image34.EndInit();
                    img34.Source = image34;
                    imagePos3.Content = img34;
                    imagePos3.Tag = 4;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\four_eye_monster.jpg"));
                    break;
                case 5:
                    BitmapImage image35 = new BitmapImage();
                    Image img35 = new Image();
                    image35.BeginInit();
                    image35.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\five_eye_alien.jpeg");
                    image35.EndInit();
                    img35.Source = image35;
                    imagePos3.Content = img35;
                    imagePos3.Tag = 5;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\five_eye_alien.jpeg"));
                    break;
                case 6:
                    BitmapImage image36 = new BitmapImage();
                    Image img36 = new Image();
                    image36.BeginInit();
                    image36.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\six_eye_alien2.jpg");
                    image36.EndInit();
                    img36.Source = image36;
                    imagePos3.Content = img36;
                    imagePos3.Tag = 6;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\six_eye_alien2.jpg"));
                    break;
                case 7:
                    BitmapImage image37 = new BitmapImage();
                    Image img37 = new Image();
                    image37.BeginInit();
                    image37.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\seven_eye_alien.jpg");
                    image37.EndInit();
                    img37.Source = image37;
                    imagePos3.Content = img37;
                    imagePos3.Tag = 7;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\seven_eye_alien.jpg"));
                    break;
                case 8:
                    BitmapImage image38 = new BitmapImage();
                    Image img38 = new Image();
                    image38.BeginInit();
                    image38.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\eight_eye_alien.jpg");
                    image38.EndInit();
                    img38.Source = image38;
                    imagePos3.Content = img38;
                    imagePos3.Tag = 8;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\eight_eye_alien.jpg"));
                    break;
                case 9:
                    BitmapImage image39 = new BitmapImage();
                    Image img39 = new Image();
                    image39.BeginInit();
                    image39.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien2.jpg");
                    image39.EndInit();
                    img39.Source = image39;
                    imagePos3.Content = img39;
                    imagePos3.Tag = 9;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien.jpg"));
                    break;
            }

            switch (bttn4)
            {
                case 1:
                    BitmapImage image41 = new BitmapImage();
                    Image img41 = new Image();
                    image41.BeginInit();
                    image41.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\One_eye_alien.jpg");
                    image41.EndInit();
                    img41.Source = image41;
                    imagePos4.Content = img41;
                    imagePos4.Tag = 1;
                    break;
                case 2:
                    BitmapImage image42 = new BitmapImage();
                    Image img42 = new Image();
                    image42.BeginInit();
                    image42.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\two_eyes_alien2.jpg");
                    image42.EndInit();
                    img42.Source = image42;
                    imagePos4.Content = img42;
                    imagePos4.Tag = 2;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\two_eyes_alien2.jpg"));
                    break;
                case 3:
                    BitmapImage image43 = new BitmapImage();
                    Image img43 = new Image();
                    image43.BeginInit();
                    image43.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\three_eye_alien.jpg");
                    image43.EndInit();
                    img43.Source = image43;
                    imagePos4.Content = img43;
                    imagePos4.Tag = 3;
                    break;
                case 4:
                    BitmapImage image44 = new BitmapImage();
                    Image img44 = new Image();
                    image44.BeginInit();
                    image44.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\four_eye_monster.jpg");
                    image44.EndInit();
                    img44.Source = image44;
                    imagePos4.Content = img44;
                    imagePos4.Tag = 4;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\four_eye_monster.jpg"));
                    break;
                case 5:
                    BitmapImage image45 = new BitmapImage();
                    Image img45 = new Image();
                    image45.BeginInit();
                    image45.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\five_eye_alien.jpeg");
                    image45.EndInit();
                    img45.Source = image45;
                    imagePos4.Content = img45;
                    imagePos4.Tag = 5;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\five_eye_alien.jpeg"));
                    break;
                case 6:
                    BitmapImage image46 = new BitmapImage();
                    Image img46 = new Image();
                    image46.BeginInit();
                    image46.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\six_eye_alien2.jpg");
                    image46.EndInit();
                    img46.Source = image46;
                    imagePos4.Content = img46;
                    imagePos4.Tag = 6;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\six_eye_alien2.jpg"));
                    break;
                case 7:
                    BitmapImage image47 = new BitmapImage();
                    Image img47 = new Image();
                    image47.BeginInit();
                    image47.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\seven_eye_alien.jpg");
                    image47.EndInit();
                    img47.Source = image47;
                    imagePos4.Content = img47;
                    imagePos4.Tag = 7;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\seven_eye_alien.jpg"));
                    break;
                case 8:
                    BitmapImage image48 = new BitmapImage();
                    Image img48 = new Image();
                    image48.BeginInit();
                    image48.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\eight_eye_alien.jpg");
                    image48.EndInit();
                    img48.Source = image48;
                    imagePos4.Content = img48;
                    imagePos4.Tag = 8;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\eight_eye_alien.jpg"));
                    break;
                case 9:
                    BitmapImage image49 = new BitmapImage();
                    Image img49 = new Image();
                    image49.BeginInit();
                    image49.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien2.jpg");
                    image49.EndInit();
                    img49.Source = image49;
                    imagePos4.Content = img49;
                    imagePos4.Tag = 9;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien.jpg"));
                    break;
            }

            switch (bttn5)
            {
                case 1:
                    BitmapImage image51 = new BitmapImage();
                    Image img51 = new Image();
                    image51.BeginInit();
                    image51.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\One_eye_alien.jpg");
                    image51.EndInit();
                    img51.Source = image51;
                    imagePos5.Content = img51;
                    imagePos5.Tag = 1;
                    break;
                case 2:
                    BitmapImage image52 = new BitmapImage();
                    Image img52 = new Image();
                    image52.BeginInit();
                    image52.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\two_eyes_alien2.jpg");
                    image52.EndInit();
                    img52.Source = image52;
                    imagePos5.Content = img52;
                    imagePos5.Tag = 2;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\two_eyes_alien2.jpg"));
                    break;
                case 3:
                    BitmapImage image53 = new BitmapImage();
                    Image img53 = new Image();
                    image53.BeginInit();
                    image53.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\three_eye_alien.jpg");
                    image53.EndInit();
                    img53.Source = image53;
                    imagePos5.Content = img53;
                    imagePos5.Tag = 3;
                    break;
                case 4:
                    BitmapImage image54 = new BitmapImage();
                    Image img54 = new Image();
                    image54.BeginInit();
                    image54.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\four_eye_monster.jpg");
                    image54.EndInit();
                    img54.Source = image54;
                    imagePos5.Content = img54;
                    imagePos5.Tag = 4;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\four_eye_monster.jpg"));
                    break;
                case 5:
                    BitmapImage image55 = new BitmapImage();
                    Image img55 = new Image();
                    image55.BeginInit();
                    image55.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\five_eye_alien.jpeg");
                    image55.EndInit();
                    img55.Source = image55;
                    imagePos5.Content = img55;
                    imagePos5.Tag = 5;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\five_eye_alien.jpeg"));
                    break;
                case 6:
                    BitmapImage image56 = new BitmapImage();
                    Image img56 = new Image();
                    image56.BeginInit();
                    image56.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\six_eye_alien2.jpg");
                    image56.EndInit();
                    img56.Source = image56;
                    imagePos5.Content = img56;
                    imagePos5.Tag = 6;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\six_eye_alien2.jpg"));
                    break;
                case 7:
                    BitmapImage image57 = new BitmapImage();
                    Image img57 = new Image();
                    image57.BeginInit();
                    image57.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\seven_eye_alien.jpg");
                    image57.EndInit();
                    img57.Source = image57;
                    imagePos5.Content = img57;
                    imagePos5.Tag = 7;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\seven_eye_alien.jpg"));
                    break;
                case 8:
                    BitmapImage image58 = new BitmapImage();
                    Image img58 = new Image();
                    image58.BeginInit();
                    image58.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\eight_eye_alien.jpg");
                    image58.EndInit();
                    img58.Source = image58;
                    imagePos5.Content = img58;
                    imagePos5.Tag = 8;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\eight_eye_alien.jpg"));
                    break;
                case 9:
                    BitmapImage image59 = new BitmapImage();
                    Image img59 = new Image();
                    image59.BeginInit();
                    image59.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien2.jpg");
                    image59.EndInit();
                    img59.Source = image59;
                    imagePos5.Content = img59;
                    imagePos5.Tag = 9;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien.jpg"));
                    break;

            }
            switch (bttn6)
            {
                case 1:
                    BitmapImage image61 = new BitmapImage();
                    Image img61 = new Image();
                    image61.BeginInit();
                    image61.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\One_eye_alien.jpg");
                    image61.EndInit();
                    img61.Source = image61;
                    imagePos6.Content = img61;
                    imagePos6.Tag = 1;
                    break;
                case 2:
                    BitmapImage image62 = new BitmapImage();
                    Image img62 = new Image();
                    image62.BeginInit();
                    image62.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\two_eyes_alien2.jpg");
                    image62.EndInit();
                    img62.Source = image62;
                    imagePos6.Content = img62;
                    imagePos6.Tag = 2;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\two_eyes_alien2.jpg"));
                    break;
                case 3:
                    BitmapImage image63 = new BitmapImage();
                    Image img63 = new Image();
                    image63.BeginInit();
                    image63.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\three_eye_alien.jpg");
                    image63.EndInit();
                    img63.Source = image63;
                    imagePos6.Content = img63;
                    imagePos6.Tag = 3;
                    break;
                case 4:
                    BitmapImage image64 = new BitmapImage();
                    Image img64 = new Image();
                    image64.BeginInit();
                    image64.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\four_eye_monster.jpg");
                    image64.EndInit();
                    img64.Source = image64;
                    imagePos6.Content = img64;
                    imagePos6.Tag = 4;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\four_eye_monster.jpg"));
                    break;
                case 5:
                    BitmapImage image65 = new BitmapImage();
                    Image img65 = new Image();
                    image65.BeginInit();
                    image65.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\five_eye_alien.jpeg");
                    image65.EndInit();
                    img65.Source = image65;
                    imagePos6.Content = img65;
                    imagePos6.Tag = 5;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\five_eye_alien.jpeg"));
                    break;
                case 6:
                    BitmapImage image66 = new BitmapImage();
                    Image img66 = new Image();
                    image66.BeginInit();
                    image66.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\six_eye_alien2.jpg");
                    image66.EndInit();
                    img66.Source = image66;
                    imagePos6.Content = img66;
                    imagePos6.Tag = 6;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\six_eye_alien2.jpg"));
                    break;
                case 7:
                    BitmapImage image67 = new BitmapImage();
                    Image img67 = new Image();
                    image67.BeginInit();
                    image67.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\seven_eye_alien.jpg");
                    image67.EndInit();
                    img67.Source = image67;
                    imagePos6.Content = img67;
                    imagePos6.Tag = 7;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\seven_eye_alien.jpg"));
                    break;
                case 8:
                    BitmapImage image68 = new BitmapImage();
                    Image img68 = new Image();
                    image68.BeginInit();
                    image68.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\eight_eye_alien.jpg");
                    image68.EndInit();
                    img68.Source = image68;
                    imagePos6.Content = img68;
                    imagePos6.Tag = 8;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\eight_eye_alien.jpg"));
                    break;
                case 9:
                    BitmapImage image69 = new BitmapImage();
                    Image img69 = new Image();
                    image69.BeginInit();
                    image69.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien2.jpg");
                    image69.EndInit();
                    img69.Source = image69;
                    imagePos6.Content = img69;
                    imagePos6.Tag = 9;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien.jpg"));
                    break;
            }

            switch (bttn7)
            {
                case 1:
                    BitmapImage image71 = new BitmapImage();
                    Image img71 = new Image();
                    image71.BeginInit();
                    image71.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\One_eye_alien.jpg");
                    image71.EndInit();
                    img71.Source = image71;
                    imagePos7.Content = img71;
                    imagePos7.Tag = 1;
                    break;
                case 2:
                    BitmapImage image72 = new BitmapImage();
                    Image img72 = new Image();
                    image72.BeginInit();
                    image72.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\two_eyes_alien2.jpg");
                    image72.EndInit();
                    img72.Source = image72;
                    imagePos7.Content = img72;
                    imagePos7.Tag = 2;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\two_eyes_alien2.jpg"));
                    break;
                case 3:
                    BitmapImage image73 = new BitmapImage();
                    Image img73 = new Image();
                    image73.BeginInit();
                    image73.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\three_eye_alien.jpg");
                    image73.EndInit();
                    img73.Source = image73;
                    imagePos7.Content = img73;
                    imagePos7.Tag = 3;
                    break;
                case 4:
                    BitmapImage image74 = new BitmapImage();
                    Image img74 = new Image();
                    image74.BeginInit();
                    image74.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\four_eye_monster.jpg");
                    image74.EndInit();
                    img74.Source = image74;
                    imagePos6.Content = img74;
                    imagePos6.Tag = 4;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\four_eye_monster.jpg"));
                    break;
                case 5:
                    BitmapImage image75 = new BitmapImage();
                    Image img75 = new Image();
                    image75.BeginInit();
                    image75.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\five_eye_alien.jpeg");
                    image75.EndInit();
                    img75.Source = image75;
                    imagePos7.Content = img75;
                    imagePos7.Tag = 5;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\five_eye_alien.jpeg"));
                    break;
                case 6:
                    BitmapImage image76 = new BitmapImage();
                    Image img76 = new Image();
                    image76.BeginInit();
                    image76.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\six_eye_alien2.jpg");
                    image76.EndInit();
                    img76.Source = image76;
                    imagePos7.Content = img76;
                    imagePos7.Tag = 6;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\six_eye_alien2.jpg"));
                    break;
                case 7:
                    BitmapImage image77 = new BitmapImage();
                    Image img77 = new Image();
                    image77.BeginInit();
                    image77.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\seven_eye_alien.jpg");
                    image77.EndInit();
                    img77.Source = image77;
                    imagePos7.Content = img77;
                    imagePos7.Tag = 7;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\seven_eye_alien.jpg"));
                    break;
                case 8:
                    BitmapImage image78 = new BitmapImage();
                    Image img78 = new Image();
                    image78.BeginInit();
                    image78.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\eight_eye_alien.jpg");
                    image78.EndInit();
                    img78.Source = image78;
                    imagePos7.Content = img78;
                    imagePos7.Tag = 8;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\eight_eye_alien.jpg"));
                    break;
                case 9:
                    BitmapImage image79 = new BitmapImage();
                    Image img79 = new Image();
                    image79.BeginInit();
                    image79.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien2.jpg");
                    image79.EndInit();
                    img79.Source = image79;
                    imagePos7.Content = img79;
                    imagePos7.Tag = 9;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien.jpg"));
                    break;
            }
            switch (bttn8)
            {
                case 1:
                    BitmapImage image81 = new BitmapImage();
                    Image img81 = new Image();
                    image81.BeginInit();
                    image81.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\One_eye_alien.jpg");
                    image81.EndInit();
                    img81.Source = image81;
                    imagePos8.Content = img81;
                    imagePos8.Tag = 1;
                    break;
                case 2:
                    BitmapImage image82 = new BitmapImage();
                    Image img82 = new Image();
                    image82.BeginInit();
                    image82.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\two_eyes_alien2.jpg");
                    image82.EndInit();
                    img82.Source = image82;
                    imagePos8.Content = img82;
                    imagePos8.Tag = 2;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\two_eyes_alien2.jpg"));
                    break;
                case 3:
                    BitmapImage image83 = new BitmapImage();
                    Image img83 = new Image();
                    image83.BeginInit();
                    image83.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\three_eye_alien.jpg");
                    image83.EndInit();
                    img83.Source = image83;
                    imagePos8.Content = img83;
                    imagePos8.Tag = 3;
                    break;
                case 4:
                    BitmapImage image84 = new BitmapImage();
                    Image img84 = new Image();
                    image84.BeginInit();
                    image84.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\four_eye_monster.jpg");
                    image84.EndInit();
                    img84.Source = image84;
                    imagePos8.Content = img84;
                    imagePos8.Tag = 4;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\four_eye_monster.jpg"));
                    break;
                case 5:
                    BitmapImage image85 = new BitmapImage();
                    Image img85 = new Image();
                    image85.BeginInit();
                    image85.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\five_eye_alien.jpeg");
                    image85.EndInit();
                    img85.Source = image85;
                    imagePos8.Content = img85;
                    imagePos8.Tag = 5;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\five_eye_alien.jpeg"));
                    break;
                case 6:
                    BitmapImage image86 = new BitmapImage();
                    Image img86 = new Image();
                    image86.BeginInit();
                    image86.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\six_eye_alien2.jpg");
                    image86.EndInit();
                    img86.Source = image86;
                    imagePos8.Content = img86;
                    imagePos8.Tag = 6;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\six_eye_alien2.jpg"));
                    break;
                case 7:
                    BitmapImage image87 = new BitmapImage();
                    Image img87 = new Image();
                    image87.BeginInit();
                    image87.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\seven_eye_alien.jpg");
                    image87.EndInit();
                    img87.Source = image87;
                    imagePos8.Content = img87;
                    imagePos8.Tag = 7;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\seven_eye_alien.jpg"));
                    break;
                case 8:
                    BitmapImage image88 = new BitmapImage();
                    Image img88 = new Image();
                    image88.BeginInit();
                    image88.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\eight_eye_alien.jpg");
                    image88.EndInit();
                    img88.Source = image88;
                    imagePos8.Content = img88;
                    imagePos8.Tag = 8;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\eight_eye_alien.jpg"));
                    break;
                case 9:
                    BitmapImage image89 = new BitmapImage();
                    Image img89 = new Image();
                    image89.BeginInit();
                    image89.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien2.jpg");
                    image89.EndInit();
                    img89.Source = image89;
                    imagePos8.Content = img89;
                    imagePos8.Tag = 9;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien.jpg"));
                    break;
            }
            switch (bttn9)
            {
                case 1:
                    BitmapImage image91 = new BitmapImage();
                    Image img91 = new Image();
                    image91.BeginInit();
                    image91.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\One_eye_alien.jpg");
                    image91.EndInit();
                    img91.Source = image91;
                    imagePos9.Content = img91;
                    imagePos9.Tag = 1;
                    break;
                case 2:
                    BitmapImage image92 = new BitmapImage();
                    Image img92 = new Image();
                    image92.BeginInit();
                    image92.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\two_eyes_alien2.jpg");
                    image92.EndInit();
                    img92.Source = image92;
                    imagePos9.Content = img92;
                    imagePos9.Tag = 2;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\two_eyes_alien2.jpg"));
                    break;
                case 3:
                    BitmapImage image93 = new BitmapImage();
                    Image img93 = new Image();
                    image93.BeginInit();
                    image93.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\three_eye_alien.jpg");
                    image93.EndInit();
                    img93.Source = image93;
                    imagePos9.Content = img93;
                    imagePos9.Tag = 3;
                    break;
                case 4:
                    BitmapImage image94 = new BitmapImage();
                    Image img94 = new Image();
                    image94.BeginInit();
                    image94.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\four_eye_monster.jpg");
                    image94.EndInit();
                    img94.Source = image94;
                    imagePos9.Content = img94;
                    imagePos9.Tag = 4;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\four_eye_monster.jpg"));
                    break;
                case 5:
                    BitmapImage image65 = new BitmapImage();
                    Image img65 = new Image();
                    image65.BeginInit();
                    image65.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\five_eye_alien.jpeg");
                    image65.EndInit();
                    img65.Source = image65;
                    imagePos6.Content = img65;
                    imagePos6.Tag = 5;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\five_eye_alien.jpeg"));
                    break;
                case 6:
                    BitmapImage image96 = new BitmapImage();
                    Image img96 = new Image();
                    image96.BeginInit();
                    image96.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\six_eye_alien2.jpg");
                    image96.EndInit();
                    img96.Source = image96;
                    imagePos9.Content = img96;
                    imagePos9.Tag = 6;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\six_eye_alien2.jpg"));
                    break;
                case 7:
                    BitmapImage image97 = new BitmapImage();
                    Image img97 = new Image();
                    image97.BeginInit();
                    image97.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\seven_eye_alien.jpg");
                    image97.EndInit();
                    img97.Source = image97;
                    imagePos6.Content = img97;
                    imagePos6.Tag = 7;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\seven_eye_alien.jpg"));
                    break;
                case 8:
                    BitmapImage image98 = new BitmapImage();
                    Image img98 = new Image();
                    image98.BeginInit();
                    image98.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\eight_eye_alien.jpg");
                    image98.EndInit();
                    img98.Source = image98;
                    imagePos9.Content = img98;
                    imagePos9.Tag = 8;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\eight_eye_alien.jpg"));
                    break;
                case 9:
                    BitmapImage image99 = new BitmapImage();
                    Image img99 = new Image();
                    image99.BeginInit();
                    image99.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien2.jpg");
                    image99.EndInit();
                    img99.Source = image99;
                    imagePos9.Content = img99;
                    imagePos9.Tag = 9;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien.jpg"));
                    break;
            }
        }

        private void Start_Button_Click(object sender, RoutedEventArgs e) //This button starts the game
        {

            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += stopWatch;
            timer.Start();
            //randomImageGen();
            //numberGenerator();
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            //start.IsEnabled = true;
            
            VeiwValue.Content = valueOfButtons.ToString();
            if (GeneratedValue.Content.ToString() == VeiwValue.Content.ToString())
            {
                gameScore++;
                ScoreLabel.Content = "Score: " + gameScore;
            }
            
        }

        private void ImageButtonClick(object sender, RoutedEventArgs e)
        {

            Button button = (Button)sender;
            valueOfButtons += int.Parse(button.Tag.ToString()); //takes in the input1

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            
            valueOfButtons = 0;
            VeiwValue.Content = valueOfButtons.ToString();
        }
    }
}



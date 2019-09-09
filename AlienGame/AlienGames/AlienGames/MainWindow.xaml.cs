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

namespace AlienGames
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int time = 40;
        private DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += dtTicker;

            //dt.Stop();


            
            //randomGen();
           timer.Start();



        }


        void dtTicker(object sender, EventArgs e)
        {
            if (time > 0)
                
            {
                if (time % 4 == 0)
                {
                    randomGen();
                }
                
                
                if (time <= 10)
                {
                    if (time % 1 == 0)
                    {
                        Countdown.Foreground = Brushes.Red;
                    }

                    else
                    {
                        Countdown.Foreground = Brushes.White;

                    }
                    time--;
                    Countdown.Content = string.Format("00:0{0}:0{1}", time / 60, time % 60);
                }
                else
                {
                    time--;
                    Countdown.Content = string.Format("00:0{0}:0{1}", time / 60, time % 60);
                }

            }
            else
            {
                timer.Stop();
                MessageBox.Show("Game Over!");
            }


        }


        public int randomNumber(int num1, int num2)
        {
            int clickedValue1 = num1;
            int clickedValue2 = num2;
            int sum = clickedValue1 + clickedValue2;
            return sum;
        }

       // MainWindow x = new MainWindow();

        public void randomGen()
        {

            Int32 bttn1, bttn2, bttn3, bttn4, bttn5, bttn6, bttn7, bttn8, bttn9;
            Random randomPic = new Random();
            bttn1 = randomPic.Next(1, 9);
            bttn2 = randomPic.Next(1, 9);
            bttn3 = randomPic.Next(1, 9);
            bttn4 = randomPic.Next(1, 9);
            bttn5 = randomPic.Next(1, 9);
            bttn6 = randomPic.Next(1, 9);
            bttn7 = randomPic.Next(1, 9);
            bttn8 = randomPic.Next(1, 9);
            bttn9 = randomPic.Next(1, 9);


           /* BitmapImage image1 = new BitmapImage();
            Image img3 = new Image();
            image1.BeginInit();
            image1.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\One_eye_alien.jpg");
            image1.EndInit();
            img3.Source = image1;
            btn0.Content = img3;*/

            switch (bttn1)
            {
                case 1:
                    BitmapImage image1 = new BitmapImage();
                    Image img3 = new Image();
                    image1.BeginInit();
                    image1.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\One_eye_alien.jpg");
                    image1.EndInit();
                    img3.Source = image1;
                    break;
                case 2:
                    /*BitmapImage image3 = new BitmapImage();
                    image3.BeginInit();
                    image3.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\One_eye_alien.jpg");
                    image3.EndInit();
                    picBox1.Source = image3;*/
                   picBox1.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\two_eyes_alien2.jpg"));
                    break;
                case 3:
                    BitmapImage image4 = new BitmapImage();
                    image4.BeginInit();
                    image4.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\One_eye_alien.jpg");
                    image4.EndInit();
                    picBox1.Source = image4;
                   // picBox1.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\three_eye_alien.jpg"));
                    break;
                case 4:
                    picBox1.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\four_eye_monster.jpg"));
                    break;
                case 5:
                    picBox1.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\five_eye_alien.jpeg"));
                    break;
                case 6:
                    picBox1.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\six_eye_alien2.jpg"));
                    break;
                case 7:
                    picBox1.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\seven_eye_alien.jpg"));
                    break;
                case 8:
                    picBox1.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\eight_eye_alien.jpg"));
                    break;
                case 9:
                    picBox1.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien.jpg"));
                    break;
            }
            switch (bttn2)
            {
                case 1:
                    picBox2.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\One_eye_alien.jpg"));
                    break;
                case 2:
                    picBox2.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\two_eyes_alien2.jpg"));
                    break;
                case 3:
                    picBox2.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\three_eye_alien.jpg"));
                    break;
                case 4:
                    picBox2.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\four_eye_monster.jpg"));
                    break;
                case 5:
                    picBox2.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\five_eye_alien.jpeg"));
                    break;
                case 6:
                    picBox2.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\six_eye_alien2.jpg"));
                    break;
                case 7:
                    picBox2.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\seven_eye_alien.jpg"));
                    break;
                case 8:
                    picBox2.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\eight_eye_alien.jpg"));
                    break;
                case 9:
                    picBox2.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien.jpg"));
                    break;
            }
            switch (bttn3)
            {
                case 1:
                    picBox3.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\One_eye_alien.jpg"));
                    break;
                case 2:
                    picBox3.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\two_eyes_alien2.jpg"));
                    break;
                case 3:
                    picBox3.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\three_eye_alien.jpg"));
                    break;
                case 4:
                    picBox3.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\four_eye_monster.jpg"));
                    break;
                case 5:
                    picBox3.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\five_eye_alien.jpeg"));
                    break;
                case 6:
                    picBox3.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\six_eye_alien2.jpg"));
                    break;
                case 7:
                    picBox3.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\seven_eye_alien.jpg"));
                    break;
                case 8:
                    picBox3.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\eight_eye_alien.jpg"));
                    break;
                case 9:
                    picBox3.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien.jpg"));
                    break;
            }
            switch (bttn4)
            {
                case 1:
                    picBox4.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\One_eye_alien.jpg"));
                    break;
                case 2:
                    picBox4.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\two_eyes_alien2.jpg"));
                    break;
                case 3:
                    picBox4.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\three_eye_alien.jpg"));
                    break;
                case 4:
                    picBox4.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\four_eye_monster.jpg"));
                    break;
                case 5:
                    picBox4.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\five_eye_alien.jpeg"));
                    break;
                case 6:
                    picBox4.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\six_eye_alien2.jpg"));
                    break;
                case 7:
                    picBox4.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\seven_eye_alien.jpg"));
                    break;
                case 8:
                    picBox4.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\eight_eye_alien.jpg"));
                    break;
                case 9:
                    picBox4.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien.jpg"));
                    break;
            }
            switch (bttn5)
            {
                case 1:
                    picBox5.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\One_eye_alien.jpg"));
                    break;
                case 2:
                    picBox5.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\two_eyes_alien2.jpg"));
                    break;
                case 3:
                    picBox5.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\three_eye_alien.jpg"));
                    break;
                case 4:
                    picBox5.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\four_eye_monster.jpg"));
                    break;
                case 5:
                    picBox5.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\five_eye_alien.jpeg"));
                    break;
                case 6:
                    picBox5.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\six_eye_alien2.jpg"));
                    break;
                case 7:
                    picBox5.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\seven_eye_alien.jpg"));
                    break;
                case 8:
                    picBox5.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\eight_eye_alien.jpg"));
                    break;
                case 9:
                    picBox5.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien.jpg"));
                    break;
            }
            switch (bttn6)
            {
                case 1:
                    picBox6.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\One_eye_alien.jpg"));
                    break;
                case 2:
                    picBox6.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\two_eyes_alien2.jpg"));
                    break;
                case 3:
                    picBox6.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\three_eye_alien.jpg"));
                    break;
                case 4:
                    picBox6.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\four_eye_monster.jpg"));
                    break;
                case 5:
                    picBox6.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\five_eye_alien.jpeg"));
                    break;
                case 6:
                    picBox6.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\six_eye_alien2.jpg"));
                    break;
                case 7:
                    picBox6.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\seven_eye_alien.jpg"));
                    break;
                case 8:
                    picBox6.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\eight_eye_alien.jpg"));
                    break;
                case 9:
                    picBox6.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien.jpg"));
                    break;
            }
            switch (bttn7)
            {
                case 1:
                    picBox7.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\One_eye_alien.jpg"));
                    break;
                case 2:
                    picBox7.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\two_eyes_alien2.jpg"));
                    break;
                case 3:
                    picBox7.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\three_eye_alien.jpg"));
                    break;
                case 4:
                    picBox7.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\four_eye_monster.jpg"));
                    break;
                case 5:
                    picBox7.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\five_eye_alien.jpeg"));
                    break;
                case 6:
                    picBox7.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\six_eye_alien2.jpg"));
                    break;
                case 7:
                    picBox7.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\seven_eye_alien.jpg"));
                    break;
                case 8:
                    picBox7.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\eight_eye_alien.jpg"));
                    break;
                case 9:
                    picBox7.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien.jpg"));
                    break;
            }
            switch (bttn8)
            {
                case 1:
                    picBox8.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\One_eye_alien.jpg"));
                    break;
                case 2:
                    picBox8.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\two_eyes_alien2.jpg"));
                    break;
                case 3:
                    picBox8.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\three_eye_alien.jpg"));
                    break;
                case 4:
                    picBox8.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\four_eye_monster.jpg"));
                    break;
                case 5:
                    picBox8.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\five_eye_alien.jpeg"));
                    break;
                case 6:
                    picBox8.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\six_eye_alien2.jpg"));
                    break;
                case 7:
                    picBox8.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\seven_eye_alien.jpg"));
                    break;
                case 8:
                    picBox8.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\eight_eye_alien.jpg"));
                    break;
                case 9:
                    picBox8.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien.jpg"));
                    break;
            }
            switch (bttn9)
            {
                case 1:
                    picBox9.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\One_eye_alien.jpg"));
                    break;
                case 2:
                    picBox9.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\two_eyes_alien2.jpg"));
                    break;
                case 3:
                    picBox9.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\three_eye_alien.jpg"));
                    break;
                case 4:
                    picBox9.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\four_eye_monster.jpg"));
                    break;
                case 5:
                    picBox9.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\five_eye_alien.jpeg"));
                    break;
                case 6:
                    picBox9.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\six_eye_alien2.jpg"));
                    break;
                case 7:
                    picBox9.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\seven_eye_alien.jpg"));
                    break;
                case 8:
                    picBox9.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\eight_eye_alien.jpg"));
                    break;
                case 9:
                    picBox9.Source = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien.jpg"));
                    break;
            }
            
        }

    }
    public class randomGen1
    {
        public void randomGen()
        {


            int image;
            Random random = new Random();
            

           

            

            List<String> paths = new List<string>();
            
            //picBox1.Source = paths[random.Next(0, paths.Count - 1)];

            paths.Add("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\One_eye_alien.jpg");
            paths.Add("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\two_eyes_alien2.jpg");
            paths.Add("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\three_eye_alien.jpg");
            paths.Add("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\four_eye_monster.jpg");
            paths.Add("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\five_eye_alien.jpg");
            paths.Add("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\six_eye_alien2.jpg");
            paths.Add("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\seven_eye_alien.jpg");
            paths.Add("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\eight_eye_alien.jpg");
            paths.Add("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien.jpg");
        }
    }
}


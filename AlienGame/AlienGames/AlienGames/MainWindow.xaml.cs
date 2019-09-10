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
        const int valueOfImange = 9;
        private int time = 40;
        private DispatcherTimer timer;
        String[] imageFilePath;

        public MainWindow()
        {
            InitializeComponent();

        }

        void stopWatch(object sender, EventArgs e)
        {
            if (time > 0)

            {
                if (time % 4 == 0)
                {
                    randomImageGen();
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

        public int inputOne(int a)
        {
            int value = a;
            MessageBox.Show("test" + a.ToString());
            return a;
        }


        public int addClickedNumber(int num1, int num2)
        {
           
            int clickedValue1 = num1;
            int clickedValue2 = num2; 
            int sum = clickedValue1 + clickedValue2;
            return sum;
        }

        

        public void randomImageGen()
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
                    image9.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien.jpg");
                    image9.EndInit();
                    img9.Source = image9;
                    imagePos1.Content = img9;
                    imagePos1.Tag = 9;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien.jpg"));
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
                    image29.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien.jpg");
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
                    image39.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien.jpg");
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
                    image49.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien.jpg");
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
                    image59.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien.jpg");
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
                    image69.UriSource = new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien.jpg");
                    image69.EndInit();
                    img69.Source = image69;
                    imagePos6.Content = img69;
                    imagePos6.Tag = 9;
                    //imagePos1.Content = new BitmapImage(new Uri("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien.jpg"));
                    break;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += stopWatch;
            //dt.Stop();
            // path = new string[Value_Of_Image];      // _diceImages is set to the value given to NUMBER_OF_FACES
           // testRandomImageGen3();
            randomImageGen();
            timer.Start();

        }

        // From this point on I'm testing and refactoring.


        public void testRandomGen1()
        {


           /* int image;
            Random random = new Random();


            List<Image> paths = new List<Image>();

             imagePos2.Source = paths[random.Next(0, paths.Count - 1)];

             paths.Add(imagePos2.Source);
             paths.Add("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\two_eyes_alien2.jpg");
             paths.Add("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\three_eye_alien.jpg");
             paths.Add("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\four_eye_monster.jpg");
             paths.Add("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\five_eye_alien.jpg");
             paths.Add("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\six_eye_alien2.jpg");
             paths.Add("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\seven_eye_alien.jpg");
             paths.Add("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\eight_eye_alien.jpg");
             paths.Add("C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien.jpg");*/
        }

       

        public void testRandomImageGen3()
        {
           
            imageFilePath[0] = "C:\\Users\\Canute Gilzene\\Pictures\\Pics\\One_eye_alien.jpg";
            imageFilePath[1] = "C:\\Users\\Canute Gilzene\\Pictures\\Pics\\two_eyes_alien2.jpg";
            imageFilePath[2] = "C:\\Users\\Canute Gilzene\\Pictures\\Pics\\three_eye_alien.jpg";
            imageFilePath[3] = "C:\\Users\\Canute Gilzene\\Pictures\\Pics\\four_eye_monster.jpg";
            imageFilePath[4] = "C:\\Users\\Canute Gilzene\\Pictures\\Pics\\five_eye_alien.jpg";
            imageFilePath[5] = "C:\\Users\\Canute Gilzene\\Pictures\\Pics\\six_eye_alien2.jpg";
            imageFilePath[6] = "C:\\Users\\Canute Gilzene\\Pictures\\Pics\\seven_eye_alien.jpg";
            imageFilePath[7] = "C:\\Users\\Canute Gilzene\\Pictures\\Pics\\eight_eye_alien.jpg";
            imageFilePath[8] = "C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien.jpg";
        }

        private void ChangeImage()
        {
            Random random = new Random();
            // Generate random values between 0 and 5
            //path[] = Random(NUMBER_OF_FACES - 1);     //random number generated for player 1
           // Path[PLAYER_TWO] = Random(NUMBER_OF_FACES - 1);     //random number generated for player 2
          // imagePos1.Source = 
        }

        private void ImagePos3_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(imagePos3.Tag.ToString());

            inputOne(int.Parse(imagePos3.Tag.ToString()));
        }
    }



   /* public void randomGen()
    {
        String[] path;

        int image;


        path[0] = "C:\\Users\\Canute Gilzene\\Pictures\\Pics\\One_eye_alien.jpg";
        path[1] = "C:\\Users\\Canute Gilzene\\Pictures\\Pics\\two_eyes_alien2.jpg";
        path[2] = "C:\\Users\\Canute Gilzene\\Pictures\\Pics\\three_eye_alien.jpg";
        path[3] = "C:\\Users\\Canute Gilzene\\Pictures\\Pics\\four_eye_monster.jpg";
        path[4] = "C:\\Users\\Canute Gilzene\\Pictures\\Pics\\five_eye_alien.jpg";
        path[5] = "C:\\Users\\Canute Gilzene\\Pictures\\Pics\\six_eye_alien2.jpg";
        path[6] = "C:\\Users\\Canute Gilzene\\Pictures\\Pics\\seven_eye_alien.jpg";
        path[7] = "C:\\Users\\Canute Gilzene\\Pictures\\Pics\\eight_eye_alien.jpg";
        path[8] = "C:\\Users\\Canute Gilzene\\Pictures\\Pics\\nine_eye_alien.jpg";



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
    }*/
}



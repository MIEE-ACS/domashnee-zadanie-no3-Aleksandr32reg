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

namespace DZ3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            String text = textBox1.Text;
            text = text.Trim();
            text = text.ToLower();
            String result = "";
            String kirilliza = "абвгдежзийклмнопрстуфхцщыьчшъэюя";
            String alphabet = "";

            if (kirilliza.IndexOf(text[0]) != -1)
            {
                alphabet = kirilliza;
            }

            String[] morse = new string[32];
            morse[0] = ".-";
            morse[1] = "-...";
            morse[2] = ".--";
            morse[3] = "--.";
            morse[4] = "-..";
            morse[5] = ".";
            morse[6] = "...-";
            morse[7] = "--..";
            morse[8] = "..";
            morse[9] = ".---";
            morse[10] = "-.-";
            morse[11] = ".-..";
            morse[12] = "--";
            morse[13] = "-.";
            morse[14] = "---";
            morse[15] = ".--.";
            morse[16] = ".-.";
            morse[17] = "...";
            morse[18] = "-";
            morse[19] = "..-";
            morse[20] = "..-.";
            morse[21] = "....";
            morse[22] = "-.-.";
            morse[23] = "--.-";
            morse[24] = "-.--";
            morse[25] = "-..-";
            morse[26] = "---.";
            morse[27] = "----";
            morse[28] = "--.--";
            morse[29] = "..-..";
            morse[30] = "..--";
            morse[31] = ".-.-";

            for (int i = 0; i < text.Length; i++)
            {
                int j = alphabet.IndexOf(text[i]);
                if (text[i] == ' ')
                {
                    String tab = "| ";
                    result = (String)result + tab;
                }
                else if (j != -1)
                { 
                    result = (String)result + morse[j] + " "; 
                }
            }
            textBox2.Text = $"{result}";
        }
    }
}

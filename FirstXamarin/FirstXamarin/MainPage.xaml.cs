using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var MyEntry = new Entry { Text = "I am an Entry" };
            var entry = new Entry();
            entry.Completed += Entry_Completed;
        }
        void Entry_Completed(object sender, EventArgs e)
        {
            var text = ((Entry)sender).Text; //cast sender to access the properties of the Entry
            string str = text.Replace(" ", "");
            var vysledek = IsPalindrome(str);
            if(vysledek==true)
            {
                myLabel.Text = "Je to palindrom";
            }
            else
            {
                myLabel.Text = "Není to palindrom";
            }
            //myLabel.Text = second;
            
        }
        bool IsPalindrome(string value)
        {
            int min = 0;
            bool proved = true;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char test1 = value[min+1];
                char b = value[max];
                char test2 = value[max + -1];
                if (a.ToString() == "c" && test1.ToString()=="h")
                {
                    if (b.ToString() == "h" && test2.ToString() == "c")
                    {
                        proved = false;
                    }
                }
                if(proved)
                {
                    if (char.ToLower(a) != char.ToLower(b))
                    {
                        return false;
                    }
                }
                else
                {
                    min++;
                    max--;
                }
                
                min++;
                max--;
            }
        }

    }
}

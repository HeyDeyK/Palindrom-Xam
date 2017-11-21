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
            var vysledek = IsPalindrome(text);
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
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                string test1 = a.ToString();
                char b = value[max];
                if(a.ToString() == "c")
                {
                    myLabel2.Text = "Našel jsem c";
                }
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }

    }
}

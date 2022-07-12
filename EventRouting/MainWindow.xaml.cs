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

namespace EventRouting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Click-Event des Buttons
        private void Btn_Klick_Click(object sender, RoutedEventArgs e)
        {
            //Ausgabe
            Tbl_Output.Text += (sender as FrameworkElement).Name + " Click\n";
        }

        //TextChanged-Event der TextBox
        private void Tbx_Text_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Prüfung, ob Tbl_Output bereits initalisiert ist
            if (Tbl_Output != null)
                //Ausgabe
                Tbl_Output.Text += (sender as FrameworkElement).Name + " TextChanged\n";
        }


        //ButtonBase.Click-Event des Windows -> triggert durch jeden Button im Fenster (Automatischer Handling-Abschluss)
        private void Wnd_Main_Click(object sender, RoutedEventArgs e)
        {
            //Ausgabe
            Tbl_Output.Text += (sender as FrameworkElement).Name + " ButtonBase.Click\n";
        }

        //TextBoxBase.TextChanged-Event des Windows -> triggert durch jede TextBox im Fenster
        private void Wnd_Main_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Prüfung, ob Tbl_Output bereits initalisiert ist
            if (Tbl_Output != null)
                //Ausgabe
                Tbl_Output.Text += (sender as FrameworkElement).Name + " TextBoxBase.TextChanged\n";
        }

        private void SP_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if ((sender as FrameworkElement).Name == "Aqua")
                Tbl_Output.Text += "Origin: " + (e.OriginalSource as FrameworkElement).Name + "\n";
            //Ausgabe
            Tbl_Output.Text += (sender as FrameworkElement).Name + " Preview/Tunnel\n";
        }

        private void SP_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Ausgabe
            Tbl_Output.Text += (sender as FrameworkElement).Name + " Bubble\n";

            if((sender as FrameworkElement).Name == "Gelb")
            {
                e.Handled = true;
                Tbl_Output.Text += "Handeld\n";
            }
        }
    }
}
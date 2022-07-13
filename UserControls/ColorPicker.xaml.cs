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

namespace UserControls
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class ColorPicker : UserControl
    {
        public ColorPicker()
        {
            InitializeComponent();

            Binding binding = new Binding("Fill");
            binding.Source = Rct_Output;

            binding.Mode = BindingMode.OneWay;

            BindingOperations.SetBinding(this, PickedColorProperty, binding);
        }



        public SolidColorBrush PickedColor
        {
            get { return (SolidColorBrush)GetValue(PickedColorProperty); }
            set { SetValue(PickedColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PickedColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PickedColorProperty =
            DependencyProperty.Register("PickedColor", typeof(SolidColorBrush), typeof(ColorPicker), new PropertyMetadata(new SolidColorBrush(Colors.Black)));




        public bool ShowRectangle
        {
            get { return (bool)GetValue(ShowRectangleProperty); }
            set { SetValue(ShowRectangleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ShowRectangle.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ShowRectangleProperty =
            DependencyProperty.Register("ShowRectangle", typeof(bool), typeof(ColorPicker), new PropertyMetadata(true));


    }
}
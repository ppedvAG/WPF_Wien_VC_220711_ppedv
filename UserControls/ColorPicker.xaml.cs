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

            //Erstellen einer neuen Bindung (Fill-Eigenschaft des Rechtecks an PickedColor-Eigenschaft)
            //Initialisierung mit �bergabe der zu Bindenden Quell-Eigenschaft
            Binding binding = new Binding("Fill");
            //Setzen des Quell-Objekts
            binding.Source = Rct_Output;
            //Setzen des Bindings-Modes
            binding.Mode = BindingMode.TwoWay;
            //Setzen des UpdateSourceTriggers
            binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;

            //Erstellen der Bindung mit �bergabe des Ziel-Objekts, der Ziel-Eigenschaft und des Bindungs-Elements
            BindingOperations.SetBinding(this, PickedColorProperty, binding);
        }

        //Damit der Control eine Ausgabe hat, an welche die User andere Properties binden k�nnen muss f�r jede dieser Ausgaben eine DependencyProperty
        //erstellt werden, welche im Konstruktor des UserControlls manuell an die entsprechnende Property eines Teilelements gebunden wird.
        //DependencyProperties sind spezielle WPF-Element-Properties, welche nicht in den Objekten selbst gespeichert werden. Stattdessen werden diese
        //in einer eigenen Liste abgelegt. Durch diese Mechanik werden Bindungen und Co in WPF erst m�glich.

        //Getter/Setter der DependencyProperty
        public SolidColorBrush PickedColor
        {
            get { return (SolidColorBrush)GetValue(PickedColorProperty); }
            set { SetValue(PickedColorProperty, value); }
        }

        //Registrierung f�r neue Bindungen an der DependencyProperty
        public static readonly DependencyProperty PickedColorProperty =
            DependencyProperty.Register("PickedColor", typeof(SolidColorBrush), typeof(ColorPicker), new PropertyMetadata(new SolidColorBrush(Colors.Black)));




        public Boolean ShowRectangle
        {
            get { return (Boolean)GetValue(ShowRectangleProperty); }
            set { SetValue(ShowRectangleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ShowRectangle.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ShowRectangleProperty =
            DependencyProperty.Register("ShowRectangle", typeof(Boolean), typeof(ColorPicker), new PropertyMetadata((bool)false));


    }
}
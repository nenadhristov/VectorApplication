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
using Vector = VectorClass.VectorClass;

namespace VectorApp
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {

            double i;
            //Check if componets x,y,z are valid
            if (Vector1_x.Text == "" || !(double.TryParse(Vector1_x.Text, out i)))
            {
                MessageBox.Show("You need to enter a value for x in Vector1 or the value is not numeric");
                return;
            }

            if (Vector1_y.Text == "" || !(double.TryParse(Vector1_y.Text, out i)))
            {
                MessageBox.Show("You need to enter a value for y in Vector1 or the value is not numeric");
                return;
            }

            if (Vector1_z.Text == "" || !(double.TryParse(Vector1_z.Text, out i)))
            {
                MessageBox.Show("You need to enter a value for z in Vector1 or the value is not numeric");
                return;
            }

            if (Vector2_x.Text == "" || !(double.TryParse(Vector2_x.Text, out i)))
            {
                MessageBox.Show("You need to enter a value for x in Vector2 or the value is not numeric");
                return;
            }

            if (Vector2_y.Text == "" || !(double.TryParse(Vector2_y.Text, out i)))
            {
                MessageBox.Show("You need to enter a value for y in Vector2 or the value is not numeric");
                return;
            }

            if (Vector2_z.Text == "" || !(double.TryParse(Vector2_z.Text, out i)))
            {
                MessageBox.Show("You need to enter a value for z in Vector2 or the value is not numeric");
                return;
            }


            double x = double.Parse(Vector1_x.Text);
            double y = double.Parse(Vector1_y.Text);
            double z = double.Parse(Vector1_z.Text);

            var vector1 = new Vector(x, y, z);

            double x1 = double.Parse(Vector2_x.Text);
            double y1 = double.Parse(Vector2_y.Text);
            double z1 = double.Parse(Vector2_z.Text);

            var vector2 = new Vector(x1, y1, z1);

            var axb = new Vector();

            axb = axb.CrossProduct(vector1, vector2);

            AXB_x.Text = axb.x.ToString();
            AXB_y.Text = axb.y.ToString();
            AXB_z.Text = axb.z.ToString();


        }
    }
}

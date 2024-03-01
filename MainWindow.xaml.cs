
using System.Windows;
using System.Windows.Controls;
namespace PizzaProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> toppings = new List<string>(); public MainWindow()
        {
            InitializeComponent();
        }
        private void Size_Checked(object sender, RoutedEventArgs e)
        {
            txtSize.Text = ((RadioButton)sender).Content.ToString();
        }
        private void PlaceToEat_Checked(object sender, RoutedEventArgs e)
        {
            txtEatIn.Text = ((RadioButton)sender).Content.ToString();
        }
        private void CrustType(object sender, RoutedEventArgs e)
        {
            txtCrustType.Text = ((RadioButton)sender).Content.ToString();
        }
        private void Topping(object sender, RoutedEventArgs e)
        {
            toppings.Add(((CheckBox)sender).Content.ToString()); TopsIsVisibleChanged(((CheckBox)sender).Content.ToString(), 1); txtToppingRefresh();
        }
        private void unTopping(object sender, RoutedEventArgs e)
        {
            toppings.Remove(((CheckBox)sender).Content.ToString());
            txtToppingRefresh();
            TopsIsVisibleChanged(((CheckBox)sender).Content.ToString(), 0);
        }
        private void txtToppingRefresh()
        {
            txtToppings.Text = string.Empty;
            foreach (var x in toppings)
            {
                txtToppings.Text += x;
                txtToppings.Text += '\n';
            }
        }
        private void TopsIsVisibleChanged(string x, int vis)
        {
            if (x == "Extra Chees")
                ExtraChees.Opacity = vis; if (x == "Onion")
                Onions.Opacity = vis; if (x == "Mushrooms")
                Mushrooms.Opacity = vis; if (x == "Olives")
                Olives.Opacity = vis; if (x == "Green Peppers")
                Green.Opacity = vis; if (x == "Mushrooms")
                Mushrooms.Opacity = vis; if (x == "Tommatoes")
                Tomato.Opacity = vis;
        }
    }
}
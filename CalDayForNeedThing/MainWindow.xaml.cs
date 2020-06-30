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

namespace CalDayForNeedThing
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(txtInCome.Text != "" && txtOutCome.Text != "" && txtPrice.Text != "")
            {
                int inCome = int.Parse(txtInCome.Text);
                int outCome = int.Parse(txtOutCome.Text);
                int price = int.Parse(txtPrice.Text);
                int recheck = (inCome - outCome);
                
                if ((recheck ==0) || (recheck <= 0))
                {
                    MessageBox.Show("Can not calculate because รายจ่ายมากกว่ารายรับ");
                }
                else
                {
                    int dayOfkeep = (price / recheck);
                    txtDayOfkeep.Text = dayOfkeep.ToString();
                }  
            }
            else
            {
                MessageBox.Show("Please input data");
            }
        }
    }
}

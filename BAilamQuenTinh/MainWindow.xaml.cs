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

namespace BAilamQuenTinh
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
        
        private void BtnTong_Click(object sender, RoutedEventArgs e)
        {
            
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            txtDapan.Text = tong(a, b).ToString();
        }
        public  double tong(double a, double b)
        {
            return a + b;        
        }

        private void BtnHieu_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            txtDapan.Text = hieu(a, b).ToString();
        }
        public double hieu(double a, double b)
        {
            return a - b;
        }

        private void BtnTich_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            txtDapan.Text = tich(a, b).ToString();
        }
        public double tich(double a, double b)
        {
            return a * b;
        }

        private void BtnThuong_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            txtDapan.Text = thuong(a, b).ToString();
        }
        public double thuong(double a, double b)
        {
            if (b == 0)
            {
                MessageBox.Show("<_>");
            }           
            return a / b;    
        }

        private void BtnThoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

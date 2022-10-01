using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Lab3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>папа
    
    public partial class MainWindow : Window
    {
        private ObservableCollection<Point> _points = new ObservableCollection<Point>();
        public ObservableCollection<Point> Points { get { return _points; } }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = Points;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Points.Add(new Point() { X = 0 , Y = 0});
        }
    }

   
    public class Point : INotifyPropertyChanged
    {
        private double x;
        private double y;
        public double X { get { return x; } set { x = value; OnPropertyChanged("X"); } }
        public double Y { get { return y; } set { y = value; OnPropertyChanged("Y"); } }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}


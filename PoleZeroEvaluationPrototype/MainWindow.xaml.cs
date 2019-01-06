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

namespace PoleZeroEvaluationPrototype
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Canvas canvas;
        public MainWindow()
        {
            InitializeComponent();

            canvas = new Canvas();
            this.Content = canvas;

            DrawAxis();
            DrawUnitCircle();
            
        }

        public void DrawAxis()
        {
            Line line1 = new Line();
            line1.X1 = 200;
            line1.X2 = 200;
            line1.Y1 = 0;
            line1.Y2 = 300;
            line1.Stroke = System.Windows.Media.Brushes.Black ;
            line1.StrokeThickness = 1;

            Line line2 = new Line();
            line2.X1 = 50;
            line2.X2 = 350;
            line2.Y1 = 150;
            line2.Y2 = 150;
            line2.Stroke = System.Windows.Media.Brushes.Black;
            line2.StrokeThickness = 1;

            canvas.Children.Add(line1);
            canvas.Children.Add(line2);
        }

        public void DrawUnitCircle()
        {
            Ellipse ellipse = new Ellipse();

            ellipse.Height = 150;
            ellipse.Width = 150;
            ellipse.StrokeThickness = 1;
            ellipse.Stroke = System.Windows.Media.Brushes.Black;

            double left = this.Width/2 - ellipse.Width /2;
            double top = ellipse.Height/2;
            ellipse.Margin = new Thickness(left, top, 0, 0);

            canvas.Children.Add(ellipse);
        }
    }
}

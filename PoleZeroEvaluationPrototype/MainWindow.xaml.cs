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
        public MainWindow()
        {
            InitializeComponent();

            //Generate canvas and show.
            //Sizes depend on main canvas.
            Canvas mainCanvas = new Canvas
            {
                Width = this.Width,
                Height = this.Height
            };

            Canvas magCanvas = new Canvas
            {
                Width = mainCanvas.Width / 3 * 2,
                Height = mainCanvas.Height / 4,
            };
            Canvas.SetTop(magCanvas, 0);
            Canvas.SetLeft(magCanvas, 0);

            Canvas phaseCanvas = new Canvas
            {
                Width = magCanvas.Width,
                Height = magCanvas.Height,
                Background = Brushes.Beige
            };
            Canvas.SetTop(phaseCanvas, magCanvas.Height);
            Canvas.SetLeft(phaseCanvas, 0);

            Canvas pzCanvas = new Canvas
            {
                Width = phaseCanvas.Width,
                Height = mainCanvas.Height / 2,
            };
            Canvas.SetTop(pzCanvas, 2 * magCanvas.Height);
            Canvas.SetLeft(pzCanvas, 0);

            Canvas pzTextCanvase = new Canvas
            {
                Width = mainCanvas.Width - pzCanvas.Width,
                Height = mainCanvas.Height,
                Background = Brushes.Yellow
            };
            Canvas.SetTop(pzTextCanvase, 0);
            Canvas.SetLeft(pzTextCanvase, pzCanvas.Width);
            

            //Fill up some stuffs
            mainCanvas.Children.Add(magCanvas);
            mainCanvas.Children.Add(phaseCanvas);
            mainCanvas.Children.Add(pzCanvas);
            mainCanvas.Children.Add(pzTextCanvase);

            DrawingUtils.DrawAxis(pzCanvas);
            DrawingUtils.DrawUnitCircle(pzCanvas);
            DrawingUtils.InitTextBox(pzTextCanvase);
            DrawingUtils.DrawMagAxis(magCanvas);

            this.Content = mainCanvas;
            this.Show();

            //Initialize the collection
            PoleAndZeroCollection pAndzCol = new PoleAndZeroCollection();

            ((TextBox)pzTextCanvase.Children[0]).AppendText(pAndzCol.addZero(0, 1, pzCanvas));
            ((TextBox)pzTextCanvase.Children[0]).AppendText(pAndzCol.addPole(-0.5, -0.25, pzCanvas));

        }
        
    }
}

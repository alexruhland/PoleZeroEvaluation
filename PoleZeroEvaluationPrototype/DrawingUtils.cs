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
    class DrawingUtils
    {
        public static void DrawMagAxis(Canvas canvas)
        {
            Line line1 = new Line();
            line1.X1 = canvas.Width / 40;
            line1.X2 = canvas.Width * 9 / 10;
            line1.Y1 = canvas.Height * 9 / 10;
            line1.Y2 = canvas.Height * 9 / 10;
            line1.Stroke = System.Windows.Media.Brushes.Black;
            line1.StrokeThickness = 1;

            Line line2 = new Line();
            line2.X1 = line1.X1*2;
            line2.X2 = line1.X1 *2;
            line2.Y1 = canvas.Height * 1 / 20;
            line2.Y2 = canvas.Height * 39 / 40;
            line2.Stroke = System.Windows.Media.Brushes.Black;
            line2.StrokeThickness = 1;

            canvas.Children.Add(line1);
            canvas.Children.Add(line2);

            canvas.UpdateLayout();
        }

        public static void DrawAxis(Canvas canvas)
        {
            Line line1 = new Line();
            line1.X1 = 0;
            line1.X2 = canvas.Width;
            line1.Y1 = canvas.Height /2;
            line1.Y2 = canvas.Height/2;
            line1.Stroke = System.Windows.Media.Brushes.Black;
            line1.StrokeThickness = 1;

            Line line2 = new Line();
            line2.X1 = canvas.Width/2;
            line2.X2 = canvas.Width/2;
            line2.Y1 = 0;
            line2.Y2 = canvas.Height;
            line2.Stroke = System.Windows.Media.Brushes.Black;
            line2.StrokeThickness = 1;

            canvas.Children.Add(line1);
            canvas.Children.Add(line2);

            canvas.UpdateLayout();
        }

        public static void DrawUnitCircle(Canvas canvas)
        {
            Ellipse ellipse = new Ellipse();

            ellipse.Height = canvas.Height/2;
            ellipse.Width = canvas.Width/2;
            ellipse.StrokeThickness = 1;
            ellipse.Stroke = System.Windows.Media.Brushes.Black;

            double left = canvas.Width / 2 - ellipse.Width / 2;
            double top = ellipse.Height / 2;
            ellipse.Margin = new Thickness(left, top, 0, 0);

            canvas.Children.Add(ellipse);
        }

        public static void DrawShape(Canvas canvas, Double re, Double im, PoleOrZeroType type)
        {
            Shape shape = null;

            if(type == PoleOrZeroType.Pole)
            {
                shape = new Ellipse();
            }
            else
            {
                shape = new Rectangle();
            }
            shape.Height = 10;
            shape.Width = 10;
            shape.StrokeThickness = 1;
            shape.Stroke = System.Windows.Media.Brushes.Black;

            double xLoc = canvas.Width / 2;
            xLoc += (re * (canvas.Width / 4));

            double yLoc = canvas.Height / 2;
            yLoc -= (im * (canvas.Height / 4));

            Canvas.SetTop(shape, yLoc - shape.Height / 2);
            Canvas.SetLeft(shape, xLoc - shape.Width / 2);

            canvas.Children.Add(shape);
        }

        public static void InitTextBox(Canvas canvas)
        {
            TextBox tb = new TextBox();
            tb.Width = canvas.Width;
            tb.Height = canvas.Height;

            Canvas.SetTop(tb, 0);
            Canvas.SetLeft(tb, 0);

            tb.Text = "Welcome...\n";

            canvas.Children.Add(tb);
        }


    }
}

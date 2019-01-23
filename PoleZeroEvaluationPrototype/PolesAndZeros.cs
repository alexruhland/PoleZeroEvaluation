using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Threading.Tasks;

namespace PoleZeroEvaluationPrototype
{
    enum PoleOrZeroType { Pole, Zero};
        
    class PoleOrZero
    {
        private PoleOrZeroType type;
        private double real;
        private double imagionary;

        public PoleOrZero(PoleOrZeroType aType, double real, double imagionary)
        {
            this.type = aType;
            this.real = real;
            this.imagionary = imagionary;
        }
    }

    class PoleAndZeroCollection
    {
        private List<PoleOrZero> Poles;
        private List<PoleOrZero> Zeros;

        public PoleAndZeroCollection()
        {
            Poles = new List<PoleOrZero>();
            Zeros = new List<PoleOrZero>();
        }

        private string addPole(double re, double im)
        {
            PoleOrZero pole = new PoleOrZero(PoleOrZeroType.Pole, re, im);
            Poles.Add(pole);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Added Pole - re: {re}, im: {im}");

            return sb.ToString();
        }

        public string addPole(double re, double im, Canvas pzCan)
        {
            string retStr = addPole(re, im);
            DrawingUtils.DrawShape(pzCan, re, im, PoleOrZeroType.Pole);

            return retStr;
        }

        private string addZero(double re, double im)
        {
            PoleOrZero zero = new PoleOrZero(PoleOrZeroType.Zero, re, im);
            Zeros.Add(zero);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Added Zero - re: {re}, im: {im}");

            return sb.ToString();
        }

        public string addZero(double re, double im, Canvas pzCan)
        {
            string retStr = addZero(re, im);
            DrawingUtils.DrawShape(pzCan, re, im, PoleOrZeroType.Zero);

            return retStr;
        }

        /// <summary>
        /// evalues transfer at select freq
        /// </summary>
        /// <param name="pzCol">PoleZero Collection</param>
        /// <param name="freq">frequency to be evaluated at (2pi = sample rate)</param>
        /// <returns></returns>
        public double evalueMagAtFreq(PoleAndZeroCollection pzCol, double freq)
        {
            double numerator = 0;
            double denominator = 0;

            foreach(PoleOrZero pole in pzCol.Poles)
            {
                numerator *= 
            }
            foreach(PoleOrZero zero in pzCol.Zeros)
            {

            }

            return numerator/denominator;
        }
    }
}

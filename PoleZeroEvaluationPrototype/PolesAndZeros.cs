using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoleZeroEvaluationPrototype
{
    enum PoleOrZeroType { Pole, Zero};
        
    class PoleOrZero
    {
        private PoleOrZeroType type;
        private int real;
        private int imagionary;

        public PoleOrZero(PoleOrZeroType aType, int real, int imagionary)
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

        public void addPole(int re, int im)
        {
            PoleOrZero pole = new PoleOrZero(PoleOrZeroType.Pole, re, im);
            Poles.Add(pole);

            Console.WriteLine($"Added Pole - re: {re}, im: {im}");
        }

        public void addZero(int re, int im)
        {
            PoleOrZero zero = new PoleOrZero(PoleOrZeroType.Zero, re, im);
            Zeros.Add(zero);

            Console.WriteLine($"Added Zero - re: {re}, im: {im}");
        }
    }
}

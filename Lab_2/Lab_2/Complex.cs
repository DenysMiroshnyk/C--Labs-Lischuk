using System;

namespace Lab_2
{
    class Complex : Pair
    {
        public Complex(float first, float second)
        {
            base.First = first;
            base.Second = second;
        }

        public override Pair DeepCopy => new Complex(First, Second);

        protected override float ToCompare => First - Second;

        public override Pair Div(Pair v) => new Complex(First / v.First, Second / v.Second);

        public override Pair Minus(Pair v) => new Complex(First - v.First, Second - v.Second);

        public override Pair Mul(Pair v) => new Complex(First * v.First, Second * v.Second);

        public override Pair Plus(Pair v) => new Complex(First + v.First, Second + v.Second);

        public override void Print() => Console.WriteLine(this.ToString());

        public override string ToString() => String.Format("{0} + ({1})i", First, Second);
    }
}

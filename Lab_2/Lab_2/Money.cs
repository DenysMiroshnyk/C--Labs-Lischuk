using System;

namespace Lab_2
{
    class Money : Pair
    {        
        public Money(int first, int second) 
        {
            base.First = Math.Abs(first);
            base.Second = Math.Abs(second);
        }

        public override Pair DeepCopy => new Money(First, Second);

        public override Pair Div(Pair v)
        {
            if ((this.Second / v.Second)>=100)
            {
                return new Money(this.First / v.First + (((this.Second / v.Second) - ((this.Second / v.Second)) % 100)) / 100, (this.Second / v.Second) % 100);
            }
            return new Money(this.First / v.First, this.Second / v.Second);
        }

        public override Pair Minus(Pair v)
        {
            if ((this.Second - v.Second) < 0)
            {
                return new Money(this.First - v.First - 1, 100 + (this.Second - v.Second));
            }
            return new Money(this.First - v.First, this.Second - v.Second);
        }

        public override Pair Mul(Pair v)
        {
            if ((this.Second * v.Second) >= 100)
            {
                return new Money(this.First * v.First + (((this.Second * v.Second) - ((this.Second * v.Second)) % 100)) / 100, (this.Second * v.Second) % 100);
            }
            return new Money(this.First * v.First, this.Second * v.Second);
        }

        public override Pair Plus(Pair v)
        {
            if ((this.Second + v.Second) >= 100)
            {
                return new Money(this.First + v.First + (((this.Second + v.Second) - ((this.Second + v.Second)) % 100)) / 100, (this.Second + v.Second) % 100);
            }
            return new Money(this.First + v.First, this.Second + v.Second);
        }

        public override void Print() => Console.WriteLine(this.ToString());

        protected override float ToCompare => this.First + Second / 100;

        public override string ToString() =>String.Format("{0}грн. {1}коп.", First, Second);
    }      
}

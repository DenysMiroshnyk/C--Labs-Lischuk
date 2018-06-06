using System;

namespace Lab_2
{

    public abstract class Pair
    {
        public dynamic First { get; set; }
        public dynamic Second { get; set; }
    
        public override string ToString() => "First:" + this.First + " Second:" + this.Second;

        public static bool operator ==(Pair t1, Pair t2)
        {
            if (t1.ToCompare== t2.ToCompare)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Pair t1, Pair t2)
        {
            if (t1.ToCompare!= t2.ToCompare)
            {
                return true;
            }
            return false;
        }

        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Pair p = (Pair)obj;
                return this.ToString() == p.ToString();
            }
        }

        public override int GetHashCode() => this.First.GetHashCode() + this.Second.GetHashCode();

        public static bool operator <(Pair t1, Pair t2) => (t1.ToCompare< t2.ToCompare);

        public static bool operator <=(Pair t1, Pair t2) => t1.ToCompare<= t2.ToCompare;

        public static bool operator >(Pair t1, Pair t2) => t1.ToCompare> t2.ToCompare;

        public static bool operator >=(Pair t1, Pair t2) => t1.ToCompare>= t2.ToCompare;

        public abstract void Print();

        protected abstract float ToCompare { get; }

        public abstract Pair DeepCopy { get; }

        public abstract Pair Plus(Pair v);     // +

        public abstract Pair Minus(Pair v);    // -

        public abstract Pair Mul(Pair v);      // *

        public abstract Pair Div(Pair v);      // /
    
    }
}

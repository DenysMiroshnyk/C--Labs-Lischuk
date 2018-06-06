using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum ChangeType { Add, Insert, Delete, Set }
public delegate void ChangeHandler(ChangeType change);


namespace Lab_2
{
    public class Series<T>
    {
        private List<T> elements;

        private event ChangeHandler Changed;

        public Series() => elements = new List<T>();

        public void Add(T v)
        {
            elements.Add(v);
            Changed?.Invoke(ChangeType.Add);
        }

        public int Size => elements.Count;

        public T Get(int index)
        {
            if (index < 0 || index >= elements.Count) throw new IndexOutOfRangeException();
            return elements[index];
        }

        public void Set(int index, T v)
        {
            if (index < 0 || index >= elements.Count) throw new IndexOutOfRangeException();
            elements[index] = v;
            Changed?.Invoke(ChangeType.Set);
        }

        public void Insert(int index, T v)
        {
            if (index < 0 || index >= elements.Count) throw new IndexOutOfRangeException();
            elements.Insert(index, v);
            Changed?.Invoke(ChangeType.Insert);
        }

        public void Delete(int index)
        {
            if (index < 0 || index >= elements.Count) throw new IndexOutOfRangeException();
            elements.RemoveAt(index);
            Changed?.Invoke(ChangeType.Delete);
        }

        public override string ToString()
        {
            string res = "";
            for (int i = 0; i < elements.Count - 1; ++i)
            {
                res += elements[i];
                res += ",\n ";
            }
            res += elements.Last();
            return res;
        }

        public void Print() => Console.WriteLine(this.ToString());
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable()
        {

        }
        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T);
        }
    }
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculatorDiscount(TProduct product)
        {
            return product.price;
        }
    }
  
    class Program
    {
        static void Main(string[] args)
        {
            var number = new Nullable<int>(5)
            Console.WriteLine("Has Value ?" + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());
                        
            // generics list
            // System.Collections.Generic
                       
        }
    }
}

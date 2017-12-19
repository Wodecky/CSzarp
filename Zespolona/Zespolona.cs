using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zespolona
{
    public class Zespolona<T>:IComparable, ICloneable where T : IComparable
    {
        private T re;
        private T im;

        public T moduł;

        public Zespolona(T re, T im)
        {
            this.re = re;
            this.im = im;

            this.moduł = this.Moduł();
        }

       private T Moduł()
        {
            return (T)Math.Sqrt((dynamic)this.re * (dynamic)this.re + (dynamic)this.im * (dynamic)this.im);
        }

        public T ModułBezDynamiców()
        {
            try
            {
                double re = Convert.ToDouble(this.re);
                double im = Convert.ToDouble(this.im);

                return (T)Convert.ChangeType(Math.Sqrt(re * re + im * im), typeof(T));
            }
            catch (Exception ex)
            {
                return (T)Convert.ChangeType(-1.0, typeof(T));
            }
        }

       /* public Zespolona<T> Dodaj(Zespolona<T> z2)
        {
            return new Zespolona<T>(this.re + z2.re, this.im + z2.im);
        }*/

        public void przepisz(Zespolona<T> z)
        {
            this.im = z.Im;
            this.re = z.Re;
        }

        public static Zespolona<T> operator +(Zespolona<T> lhs, Zespolona<T>rhs)
        {
            
            return new Zespolona<T>((dynamic)lhs.re + (dynamic)rhs.re, (dynamic)lhs.im + (dynamic)lhs.im);
        }

        public T Re
        {
            set
            {
                this.re = value;
            }

            get
            {
                return this.re;
            }
        }

        public T Im
        {
            set
            {
                this.im = value;
            }

            get
            {
                return this.im;
            }
        }
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}

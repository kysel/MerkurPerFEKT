using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerkurPerFEKT
{

    public class Position : IEnumerable,IEnumerator
    {
        int index;
        public int[] m = new int[6];

        public Position(int m0, int m1, int m2, int m3, int m4, int m5)
        {
            m[0] = m0;
            m[1] = m1;
            m[2] = m2;
            m[3] = m3;
            m[4] = m4;
            m[5] = m5;
        }

                
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public object Current
        {
            get { return m[index]; }
        }

        public bool MoveNext()
        {
            index++;
            return index < m.Length;
        }

        public void Reset()
        {
            index = 0;
        }
    }

    public class Interpolation
    {
        #region Singleton
           private static readonly Interpolation instance = new Interpolation();   
           private Interpolation(){}
           public static Interpolation Instance
           {
              get 
              {
                 return instance; 
              }
           }
        #endregion

        public void Interpolate(Position from, Position to, double speed = 10)
        {
            int[] delta = new int[6];
            for (int i = 0; i != 6; i++)
            {
                delta[i] = Math.Abs(from.m[i] - to.m[i]);
            }
            

        }
    }
}

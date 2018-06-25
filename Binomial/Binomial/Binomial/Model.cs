using System;
using System.Collections.Generic;
using System.Text;

namespace Binomial
{
    class Model
    {
        public int fat(int nro)
        {
            if (nro <= 1)
                return 1;
            else
                return nro * fat(--nro);
        }
        public double transforma(String str)
        {
            if (isNumber(str))
            {
                return double.Parse(str);
            }
            else
            {
                String[] s = str.Split('/');
                try
                {
                    return Double.Parse(s[0]) / Double.Parse(s[1]);
                }
                catch (Exception a)
                {
                    throw new Exception("");
                }
            }
        }
        public bool isNumber(String s)
        {
            try
            {
                Double.Parse(s);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}

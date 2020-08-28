using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class BinaryNumeral
    {
        private int value;

        public BinaryNumeral(int value)
        {
            this.value = value;
        }

        static public implicit operator BinaryNumeral(int value)
        {
            return new BinaryNumeral(value);
        }

        static public explicit operator int(BinaryNumeral binary)
        {
            return binary.value;
        }

        static public implicit operator string(BinaryNumeral binary)
        {
            string conversion = "";
            int n = binary.value;
            int i;
            int[] a = new int[10];
            for (i = 0; n > 0; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            for (i = i - 1; i >= 0; i--)
            {
                conversion += a[i];
            }
            return conversion;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI2
{
    class LFSR
    {
        private int[] bitArray = { 0 };
        private int[] taps = { 0 };
        private int length;

        public LFSR (string initialState, int[] _taps)
        {
            length = initialState.Length;
            bitArray = new int[length];
            for (int i = 0; i < length; i++)
            {
                var ch = initialState[i];
                bitArray[i] = ch - '0';
            }
            taps = _taps;
            for (int i = 0; i < taps.Length; i++)
            {
                taps[i] = length - taps[i];
            }
        }

        public int Step()
        {
            int lastBit = XorBits();
            int firstBit = ShiftBits();
            bitArray[length - 1] = lastBit;
            return firstBit;
        }

        private int ShiftBits()
        {
            int first = bitArray[0];
            for (int i = 0; i < length - 1; i++)
            {
                bitArray[i] = bitArray[i + 1];
            }
            return first;
        }

        private int XorBits()
        {
            int result = bitArray[taps[0]];
            for (int i = 1; i < taps.Length; i++)
            {
                result = result ^ bitArray[taps[i]];
            }
            return result;
        }

        public string Generate(int amount)
        {
            StringBuilder sb = new StringBuilder(amount);
            for (int i = 0; i < amount; i++)
            {
                sb.Append(Step());
            }
            return sb.ToString();
        }

        public string ToString()
        {
            return "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class IntArray
    {
        private int[,] data;

        public IntArray(int rows, int cols)
        {
            data = new int[rows, cols];
        }
        private bool IsValid(int row, int col)
        {
            return row >= 0 && row < data.GetLength(0) &&
               col >= 0 && col < data.GetLength(1);
        }
        public int this[int row, int col]
        {
            get
            {
                if (IsValid(row, col))
                {
                    return data[row, col];
                }
                else
                {
                    throw new IndexOutOfRangeException("Out of range");
                }
            }
            set
            {
                if (IsValid(row, col))
                {
                    data[row, col] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Out of range");
                }
            }
        }

        public (int rows, int cols) Size
        {
            get
            {
                return (data.GetLength(0), data.GetLength(1));
            }
        }

    }

}

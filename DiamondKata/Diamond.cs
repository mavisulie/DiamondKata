using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondKata
{
    public class Diamond
    {
        public Diamond(char pointer) => Build(pointer);

        public StringBuilder _printableOutput;

        public void Print() => Console.WriteLine(_printableOutput);

        private void Build(int pointer)
        {
            pointer -= 65;
            _printableOutput = new StringBuilder();

            for (int i = 0; i <= pointer; i++)
            {
                AppendRowString(i, Convert.ToChar('A' + i), pointer);
            }

            for (int i = pointer - 1; i >= 0; i--)
            {
                AppendRowString(i, Convert.ToChar('A' + i), pointer);
            }
        }

        private void AppendRowString(int currentRowIndex, char value, int lastRowIndex)
        {
            int innerSpaces = Math.Max(0, (currentRowIndex * 2) - 1);
            var sideSpaces = lastRowIndex - currentRowIndex;

            _printableOutput.Append(string.Concat(Enumerable.Repeat(" ", sideSpaces)));
            _printableOutput.Append(value);
            _printableOutput.Append(string.Concat(Enumerable.Repeat(" ", innerSpaces)));
            if (value != 'A')
            {
                _printableOutput.Append(value);
                _printableOutput.Append(string.Concat(Enumerable.Repeat(" ", sideSpaces)));
                _printableOutput.Append("\n");
            }
        }
    }
}

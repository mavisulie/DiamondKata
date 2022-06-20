using System.Text;

namespace DiamondKata
{
    /// <summary>
    /// Rhombus representation of a given letter of the alphabet as midpoint
    /// </summary>
    public class Diamond
    {
        /// <summary>
        /// Initialises <see cref="Diamond"
        /// </summary>
        public Diamond(char pointer) => Build(pointer);

        // The rhombus as string
        public StringBuilder _printableOutput;

        /// <summary>
        /// Displays the rhombus string
        /// </summary>
        public void Print() => Console.WriteLine(_printableOutput);

        private void Build(int pointer)
        {
            pointer -= 65; // Start from A char as 0 index
            _printableOutput = new StringBuilder();

            // Build first half
            for (int i = 0; i <= pointer; i++)
            {
                AppendRowString(i, Convert.ToChar('A' + i), pointer);
            }

            // Build second half
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
            if (value != 'A') // Only print one character if A
                _printableOutput.Append(value);
            _printableOutput.Append(string.Concat(Enumerable.Repeat(" ", sideSpaces)));
            _printableOutput.Append("\n");
        }
    }
}

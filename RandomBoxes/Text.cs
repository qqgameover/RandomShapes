using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomBoxes
{
    class Text : Shape
    {
        public string TextStr { get; internal set; }
        public Text(int x, int y, string text, Random random) : base(random)
        {
            Y = y;
            X = x;
            TextStr = text;
        }
        public override string GetCharacter(int row, int col)
        {
            if (row != Y || col < X || col >= X + TextStr.Length) return null;
            var index = col - X;
            return TextStr[index].ToString();
        }
    }
}

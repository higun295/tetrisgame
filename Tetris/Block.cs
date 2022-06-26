using System.Windows.Controls;

namespace Tetris
{
    public class Block
    {
        public Block()
        {

        }

        public int X { get; set; }
        public int Y { get; set; }
        public Grid Item { get; set; }
    }
}
using System.Drawing;

namespace CoolTekenDing
{
    class Drawing : Shape
    {
        public object draw(int x, int y, int height, int width)
        {
            return new Rectangle(x - (width / 2), y - (height / 2), height, width);
        }
    }
}

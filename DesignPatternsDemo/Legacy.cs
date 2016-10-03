using System.Drawing;

namespace CoolTekenDing
{
    public class LegacyRectangle
    {
        public Rectangle drawRectangle(int x, int y, int height, int width)
        {
            return new Rectangle(x, y, height, width);
        }
    }
}

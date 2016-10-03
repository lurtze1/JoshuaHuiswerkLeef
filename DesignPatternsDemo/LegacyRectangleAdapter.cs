using System.Drawing;

namespace CoolTekenDing
{
    public class LegacyRectangleAdapter : Shape
    {
        LegacyRectangle rect;
        public LegacyRectangleAdapter()
        {
            rect = new LegacyRectangle();
        }
        public Rectangle draw(int x, int y, int height, int width)
        {
            return rect.drawRectangle(x - (width / 2), y - (height / 2), height, width);
        }
    }
}

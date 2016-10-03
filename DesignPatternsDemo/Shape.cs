using System.Drawing;

namespace CoolTekenDing
{
    public interface Shape
    {
        Rectangle draw(int x, int y, int height, int width);
    }
}

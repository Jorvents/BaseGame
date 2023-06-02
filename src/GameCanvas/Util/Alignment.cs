using System.Numerics;
using Raylib_cs;

namespace Game.Util;

public class Alignment
{
    
    public void DrawText(string text, int size, Color colour, Vector2 orientation)
    {
        int textlenght = Raylib.MeasureText(text, size);

        Rectangle box = new Rectangle();
        box.x = Raylib.GetScreenWidth() * orientation.X - textlenght / 2;
        box.y = Raylib.GetScreenHeight() * orientation.Y - size / 2f;
        box.width = textlenght;
        box.height = size;

        if (box.x < 0)
        {
            box.x = 0;
        }
        if (box.y < 0)
        {
            box.y = 0;
        }
        if (box.x + box.width > Raylib.GetScreenWidth())
        {
            box.x = Raylib.GetScreenWidth() - box.width;
        }
        if (box.y + box.height > Raylib.GetScreenHeight())
        {
            box.y = Raylib.GetScreenHeight() - box.height;
        }
        
        Raylib.DrawText(text, (int)box.x, (int)box.y, size, colour);
        
    }
    public void DrawText(string text, int size, Rectangle textbox, Color colour, Vector2 orientation)
    {
        int textlenght = Raylib.MeasureText(text, size);

        Rectangle box = new Rectangle();
        box.x = textbox.x + textbox.width * orientation.X - textlenght / 2;
        box.y = textbox.y + textbox.height * orientation.Y - size / 2f;
        box.width = textlenght;
        box.height = size;

        if (box.x < textbox.x)
        {
            box.x = 0;
        }
        if (box.y < textbox.y)
        {
            box.y = 0;
        }
        if (box.x + box.width > textbox.x + textbox.width)
        {
            box.x = Raylib.GetScreenWidth() - box.width;
        }
        if (box.y + box.height > textbox.y + textbox.height)
        {
            box.y = Raylib.GetScreenHeight() - box.height;
        }
        
        Raylib.DrawText(text, (int)box.x, (int)box.y, size, colour);
        
    }
}
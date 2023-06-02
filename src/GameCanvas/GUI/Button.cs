using System.Numerics;
using Game.Util;
using Raylib_cs;

namespace Game.GUI;

public class Button
{
    public Rectangle box;
    public bool isPressed = false;
    public bool isHovered = false;
        
    int size;
    string text;
    float rotation;

    Alignment align = new Alignment();
        
    public Button(Rectangle box, string text, int size)
    {
        this.box = box;
        this.text = text;
        this.size = size;
    }
    public void Play()
    {
        isPressed = Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), box) && Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT);
        isHovered = Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), box);
    }
    public void Draw(Color colour, float thick)
    {
        Raylib.DrawRectangleRoundedLines(box, 0.07f,2,thick, colour);
            
        align.DrawText(text, size, box, colour, new Vector2(0.5f));
    }
}
using System.Numerics;
using Game.GUI;
using Raylib_cs;

namespace Game;

public class Join
{
    
    public Button joinbutton;
    
    public TextBox textbox;

    public bool joined;

    public Join()
    {
        Vector2 size = new Vector2(350, 200);

        int spacing = 50;
        int height = 150;
        
        joinbutton =
            new Button(new Rectangle(Raylib.GetScreenWidth() / 2 - size.X / 2, Raylib.GetScreenHeight() / 2 - size.Y / 2, 
                    size.X, size.Y),
                "Join", 150
            );
        textbox = new TextBox(new Rectangle(spacing, Raylib.GetScreenHeight() - spacing - height, Raylib.GetScreenWidth() - spacing * 2, height), 15f, 60);
    }
    
    public void Play()
    {
        if (Raylib.IsCursorHidden())
        {
            Raylib.ShowCursor();
        }
        
        joinbutton.Play();
        textbox.Play();
    }
    public void Work() 
    {
        /*
        if(joinbutton.isPressed)
        {
            ConnectToPlace();
        }
        */
        textbox.Work();
    }
    public void Draw() 
    {
        joinbutton.Draw(Color.WHITE, 10f);
        textbox.Draw(Color.WHITE, Color.PINK);
    }
}
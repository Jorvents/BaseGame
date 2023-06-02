using System.Numerics;
using Game.Util;
using Raylib_cs;

namespace Game;

public class Game
{
    private Alignment alignment = new Alignment();
    public Game()
    {
        
    }
    
    public void Play()
    {
        
    }
    public void Work()
    {
        
    }
    public void Draw()
    {
        alignment.DrawText("Game", 150,Color.WHITE, new Vector2(0.5f));
    }
}
// See https://aka.ms/new-console-template for more information

using Raylib_cs;
using static Raylib_cs.CameraProjection;

namespace Game
{
    public class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(1280, 720, "Game");
            Raylib.SetTargetFPS(163);
            
            Controller controller = new Controller();
            
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.BLACK);
                
                controller.JustRun();
                
                Raylib.EndDrawing();
            }
            
            Raylib.CloseWindow();
        }
    }
}
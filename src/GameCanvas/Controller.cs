namespace Game;

public class Controller
{
    public Game game;
    public Join join;
    private enum Scene
    {
        joining,
        gaming
    }
    Scene scene;

    public Controller()
    {
        game = new Game();
        join = new Join();
    }
    public void JustRun()
    {
        Play();
        Work();
        Draw();
    }
    void Play()
    {
        switch (scene)
        {
            case 0:
                join.Play();
                break;
            case (Scene)1:
                game.Play();
                break;
        }
    }
    void Work()
    {
        switch (scene)
        {
            case 0:
                join.Work();
                if (join.joinbutton.isPressed)
                {
                    scene = Scene.gaming;
                }
                break;
            case (Scene)1:
                game.Work();
                break;
        }
    }
    void Draw()
    {
        switch (scene)
        {
            case 0:
                join.Draw();
                break;
            case (Scene)1:
                game.Draw();
                break;
        }
    }
}
using BeeEngine.OpenTK;
using ImGuiNET;

namespace Test.Implementations;

public class TestGame: Game
{
    public TestGame(string title, int width, int height) : base(title, width, height)
    {
    }

    protected override void UnloadResources()
    {
        
    }

    protected override void Initialize()
    {
        
    }

    protected override void LoadContent()
    {
        
    }

    protected override void Update(Time gameTime)
    {
        
    }

    protected override void Render(Time gameTime)
    {
        ImGui.ShowDemoWindow();
    }
}
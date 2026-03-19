using Godot;

public partial class Ground : StaticBody3D
{
    private Main _main;
    [Export] public Tale tale1;
    [Export] public Tale tale2;
    [Export] public Tale tale3;
    [Export] public Tale tale4;
    [Export] public Tale tale5;
    [Export] public Tale tale6;
    [Export] public Tale tale7;
    [Export] public Tale tale8;
    [Export] public Tale tale9;



    private Tale[] tales;
    private int currentIndex = 0;

    public override void _Ready()
    {
        _main = GetNode<Main>("/root/Main");

        tales = new Tale[]
        {
        tale1, tale2, tale3,
        tale4, tale5, tale6,
        tale7, tale8, tale9
        };
    }


    public override void _InputEvent(Camera3D camera, InputEvent @event, Vector3 position, Vector3 normal, int shape)
    {
        if (@event is InputEventMouseButton mouse && mouse.Pressed)
        {
            if (mouse.ButtonIndex == MouseButton.Left)
            {
                foreach (var tale in tales)
                {
                    if (!tale.Visible) 
                    {
                        tale.GlobalPosition = position;
                        _main.ExecuteCommand(new Placement(tale));
                        break;
                    }
                }
            }
        }
    }


}

using Godot;

public partial class Tale : StaticBody3D
{
    private Main _main;

    public override void _Ready()
    {
        _main = GetNode<Main>("/root/Main");
        Visible = false; // start hidden
    }

    public override void _InputEvent(Camera3D camera, InputEvent @event, Vector3 pos, Vector3 normal, int shape)
    {
        // Only handle right-click for removing/hiding the Tale
        if (@event is InputEventMouseButton mouse && mouse.Pressed && mouse.ButtonIndex == MouseButton.Right)
        {
            _main.ExecuteCommand(new Remove(this));
        }
    }
}
using Godot;
using System;

public partial class Placement : Command
{
    private Node3D tales;

    public Placement(Node3D t)
    {
        tales = t;
    }
    public override void Execute()
    {
        tales.Visible = true;
        GD.Print("tile placed");
    }

    public override void UnExecute()
    {
        tales.Visible = false;
        GD.Print("undo placement");
    }
}

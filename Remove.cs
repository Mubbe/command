using Godot;
using System;

public partial class Remove : Command
{
    private Node3D tales;
    public Remove(Node3D t)
    {
        tales = t;
    }
    public override void Execute()
    {
        tales.Visible = false;
    }
    public override void UnExecute()
    {
        tales.Visible = true;
    }
}

using Godot;
using System;

public partial class UndoButton : Godot.Button
{
    public override void _Pressed()
    {
        GetNode<Main>("/root/Main").Undo();
    }
}

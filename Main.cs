using Godot;
using System;
using System.Collections.Generic;

public partial class Main : Node
{
	private Stack<Command> undoStack = new Stack<Command>();

    public void ExecuteCommand(Command cmd)
    {
        cmd.Execute();
        undoStack.Push(cmd);
    }

    public void Undo()
    {
        if (undoStack.Count > 0)
        {
            Command cmd = undoStack.Pop();
            cmd.UnExecute();
        }
    }
}

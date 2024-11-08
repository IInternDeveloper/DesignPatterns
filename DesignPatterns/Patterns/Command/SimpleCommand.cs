﻿namespace DesignPatterns.Patterns.Command;

public class SimpleCommand : ICommand {
    private string _payload;

    public SimpleCommand(string payload) {
        _payload = payload;
    }

    public void Execute() {
        Console.WriteLine($"SimpleCommand: See, I can do simple things like printing ({_payload})");
    }
}
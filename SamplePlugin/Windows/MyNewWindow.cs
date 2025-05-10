using Dalamud.Interface.Windowing;
using System;
using ImGuiNET;
using System.Numerics;

namespace SamplePlugin.Windows;

public class MyNewWindow : Window, IDisposable
{
    private Configuration configuration;

    public MyNewWindow(Plugin plugin) : base("New Window")
    {
        Flags = ImGuiWindowFlags.NoResize | ImGuiWindowFlags.NoCollapse | ImGuiWindowFlags.NoScrollbar | ImGuiWindowFlags.NoScrollWithMouse;

        Size = new Vector2(232, 90);
        SizeCondition = ImGuiCond.Always;

        configuration = plugin.Configuration;

        SizeConstraints = new WindowSizeConstraints
        {
            MinimumSize = new Vector2(375, 330),
            MaximumSize = new Vector2(float.MaxValue, float.MaxValue)
        };
    }
    public void Dispose()
    {
    }
    public override void Draw()
    {
        ImGui.TextUnformatted("BaseActionID : " + Plugin.gameGui.HoveredAction.BaseActionID + "\n");
        ImGui.TextUnformatted("ActionID : " + Plugin.gameGui.HoveredAction.ActionID + "\n");
        ImGui.TextUnformatted("Kind : " + Plugin.gameGui.HoveredAction.ActionKind + "\n");
    }
    public override void PreDraw()
    {
    }
    public override void PostDraw()
    {
    }
}

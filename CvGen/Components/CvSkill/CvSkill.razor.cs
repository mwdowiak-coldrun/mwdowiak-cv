using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace CvGen.Components.CvSkill;

public partial class CvSkill : ComponentBase
{
    [Parameter] public required Skill Model { get; set; }
    [Parameter] public Color Color { get; set; } = Color.Primary;
    [Parameter] public string Class { get; set; } = "";

    private string GetDotClasses(int value) => $"{GetLevelIconClass(value)} {GetMarginClass(value)}";

    private string GetLevelIconClass(int value) => value <= Model.Level
        ? "dot filled"
        : "dot empty";

    private string GetMarginClass(int value) => value > 1 ? "ml-2" : "";

    private string GetColorVariable() => $"--dot-color: var({Color.GetCssVariable()}";
}

public record Skill(
    string Label,
    int Level,
    int MaxLevel,
    string? Description
)
{
    public static Skill Create(
        string label,
        int level,
        int maxLevel,
        string? description = null
    ) => new(label, level, maxLevel, description);

    public static Skill Empty => Create("Skill", 1, 5);
}

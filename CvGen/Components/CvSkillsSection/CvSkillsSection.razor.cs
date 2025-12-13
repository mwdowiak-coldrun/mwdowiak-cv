using System.Collections.Immutable;
using CvGen.Components.CvSkill;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace CvGen.Components.CvSkillsSection;

public partial class CvSkillsSection : ComponentBase
{
    [Parameter] public required ImmutableArray<Skill> Model { get; set; }
    [Parameter] public Color Color { get; set; } = Color.Primary;

    private string GetMarginClass(int value) => value > 0 ? "ml-8" : "";
}

using Microsoft.AspNetCore.Components;

namespace CvGen.Components.CvExperience;

public partial class CvExperience
{
    [Parameter] public required Experience Model { get; set;}
    [Parameter] public bool Open { get; set; }
    [Parameter] public string? Class { get; set; } = "";
}

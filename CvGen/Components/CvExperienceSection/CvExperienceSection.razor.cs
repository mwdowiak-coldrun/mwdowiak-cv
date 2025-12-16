using System.Collections.Immutable;
using CvGen.Components.CvExperience;
using Microsoft.AspNetCore.Components;

namespace CvGen.Components.CvExperienceSection;

public partial class CvExperienceSection : ComponentBase
{
    [Parameter] public required ImmutableArray<Experience> Model { get; set; }
}

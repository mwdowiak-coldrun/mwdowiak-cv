using MudBlazor;

namespace CvGen.Components;

public static class CssColorHelper
{
    public static string GetCssVariable(this Color color) => color switch
    {
        Color.Primary => "--mud-palette-primary",
        Color.Secondary => "--mud-palette-secondary",
        Color.Tertiary => "--mud-palette-tertiary",
        Color.Info => "--mud-palette-info",
        Color.Success => "--mud-palette-success",
        Color.Warning => "--mud-palette-warning",
        Color.Error => "--mud-palette-error",
        _ => "--mud-palette-primary"
    };
}

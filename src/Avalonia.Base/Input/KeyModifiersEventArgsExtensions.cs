using Avalonia.Interactivity;

namespace Avalonia.Input;

/// <summary>
/// Extension methods for <see cref="IKeyModifiersEventArgs"/>
/// </summary>
public static class KeyModifiersEventArgsExtensions
{
    /// <summary>
    /// Retrieve last event with <see cref="IKeyModifiersEventArgs"/> from event chain.
    /// </summary>
    /// <param name="this"></param>
    /// <returns></returns>
    public static KeyModifiers KeyModifiers(this RoutedEventArgs @this)
    {
        while (@this is not null && @this is not IKeyModifiersEventArgs)
        {
            @this = @this.Inner;
        }
        return (@this as IKeyModifiersEventArgs)?.KeyModifiers??Input.KeyModifiers.None;
    }
}

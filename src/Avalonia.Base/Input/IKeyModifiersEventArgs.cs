using Avalonia.Interactivity;

namespace Avalonia.Input;

/// <summary>
/// Interface for <see cref="RoutedEventArgs"/> that contains information about key modifiers.
/// </summary>
public interface IKeyModifiersEventArgs
{
    /// <summary>
    /// Gets a value that indicates which key modifiers were active at the time that the event was initiated.
    /// </summary>
    KeyModifiers KeyModifiers { get; }
}

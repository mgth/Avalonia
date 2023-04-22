using System;
using Avalonia.Interactivity;

namespace Avalonia.Input;


/// <summary>
/// Provides data for the Button.Click event.
/// </summary>
public class ClickEventArgs : RoutedEventArgs
{
    /// <summary>
    /// Gets the SpinDirection for the spin that has been initiated by the end-user.
    /// </summary>
    public KeyModifiers KeyModifiers { get; }


    /// <summary>
    /// Initializes a new instance of the ButtonEventArgs class.
    /// </summary>
    /// <param name="keyModifiers">Key modifiers.</param>
    public ClickEventArgs(KeyModifiers keyModifiers)
    {
        KeyModifiers = keyModifiers;
    }

    public ClickEventArgs(RoutedEvent routedEvent, KeyModifiers keyModifiers)
        : base(routedEvent)
    {
        KeyModifiers = keyModifiers;
    }
}

using OpenTK.Windowing.GraphicsLibraryFramework;

namespace BeeEngine.OpenTK.Events;

public struct KeyUpEvent: IEvent
{
    public EventCategory Category { get; init; }
    public readonly Key Key;

    public KeyUpEvent(Key key)
    {
        Key = key;
        Category = EventCategory.Input | EventCategory.Keyboard;
    }
}
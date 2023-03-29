using System;

namespace assignment_02;

public enum EventKind {
    Joined,
    Euro,
    Schengen,
    Exited
}

public class CountryEvent
{
    public EventKind Kind;
    public string Code = "";
    public DateOnly Date;
}

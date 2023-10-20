using System;

public abstract class Goal

private string shortName;

private interface points;

private string description;

public Goal (string name, string description, int point)
{
-shortName = name
-description = description
-points = point

}
public abstract void RecordEvent();

public abstract bool Iscomplete();

public virtual string GetStringRepresentation();
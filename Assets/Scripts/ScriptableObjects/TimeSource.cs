using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TimeSource : ScriptableObject
{
    public abstract DateTime GetTime();
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CurrentTimeSource : TimeSource
{
    public override DateTime GetTime()
    {
        return System.DateTime.Now;
    }
}

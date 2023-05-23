using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ElapsedTimeSource : TimeSource
{
    [SerializeField] private float m_timeMultiplier = 1;
    
    public override DateTime GetTime()
    {
        return new DateTime((long)(UnityEngine.Time.time * m_timeMultiplier));
    }
}

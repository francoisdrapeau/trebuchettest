using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class StaticTimeSource : TimeSource
{
    [SerializeField] private int m_hours;
    
    [SerializeField] private int m_minutes;
    
    public override DateTime GetTime()
    {
        return new DateTime(m_hours * 3600 + m_minutes * 60);
    }
}

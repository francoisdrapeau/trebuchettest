using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ClockWorld : MonoBehaviour
{
    [SerializeField] private TimeSource m_timeSource;
    
    [SerializeField] private GameObject m_clockPrefab;

    [SerializeField] private int m_numberOfClocksAtStart = 3;

    private List<Clock> m_clocks = new List<Clock>();

    public UnityEvent m_audioEvent;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < m_numberOfClocksAtStart; i++)
        {
            SpawnClock();
        }
        
        if (m_audioEvent == null)
            m_audioEvent = new UnityEvent();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            SpawnClock();
            m_audioEvent.Invoke();
        }
    }

    private void SpawnClock()
    {
        Clock newClock = Instantiate(m_clockPrefab).GetComponent<Clock>();
        newClock.transform.position = new Vector3(m_clocks.Count, 0, 0);
        m_clocks.Add(newClock);
    }
}

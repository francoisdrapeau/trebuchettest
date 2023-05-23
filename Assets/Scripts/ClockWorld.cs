using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockWorld : MonoBehaviour
{
    [SerializeField] private GameObject m_clockPrefab;

    [SerializeField] private int m_numberOfClocksAtStart = 3;

    private List<GameObject> m_clocks = new List<GameObject>();
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < m_numberOfClocksAtStart; i++)
        {
            GameObject newClock = Instantiate(m_clockPrefab);
            newClock.transform.position = new Vector3(i, 0, 0);
            m_clocks.Add(newClock);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

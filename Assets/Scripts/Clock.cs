using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] private List<HandsSet> m_handsSetPrefabs = new List<HandsSet>();

    [SerializeField] private Transform m_handsSetAnchor;

    private HandsSet m_currentHandsSet;

    // Start is called before the first frame update
    void Start()
    {
        if (m_handsSetPrefabs.Count > 0)
        {
            m_currentHandsSet = Instantiate(m_handsSetPrefabs[UnityEngine.Random.Range(0, m_handsSetPrefabs.Count)]);
            m_currentHandsSet.transform.parent = m_handsSetAnchor;
            m_currentHandsSet.transform.localPosition = Vector3.zero;
        }
    }
}

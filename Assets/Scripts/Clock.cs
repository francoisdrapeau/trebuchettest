using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] private Transform m_bigHand;
    
    [SerializeField] private Transform m_smallHand;

    // Start is called before the first frame update
    void Start()
    {
        DateTime currentTime = System.DateTime.Now;

        m_bigHand.eulerAngles = new Vector3(0, 0, -currentTime.Minute * 6);
        m_smallHand.eulerAngles = new Vector3(0, 0, -currentTime.Hour * 30);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

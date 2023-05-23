using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockAudio : MonoBehaviour
{
    private AudioSource m_audio;
    
    // Start is called before the first frame update
    void Start()
    {
        m_audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnAudioEventReceived()
    {
        m_audio.PlayOneShot(m_audio.clip); // This allows multiple sfx to overlap instead of cutting off the previous one.
    }
}

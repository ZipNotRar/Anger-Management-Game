using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpSound : MonoBehaviour
{
    private float startTime;
    public float timeDuration;
    public AudioSource trafficAudio;
    // Start is called before the first frame update
    void Start()
    {
        trafficAudio.GetComponent<AudioSource>();
    }
    void Awake()
    {
        startTime = Time.time;
    }
    // Update is called once per frame
    void Update()
    {
        
        if (startTime + timeDuration > Time.time)
        {
            float timeCalculation = (Time.time - startTime) / timeDuration;
            trafficAudio.volume = Mathf.Lerp(0, 1, timeCalculation);
        }
    }
}

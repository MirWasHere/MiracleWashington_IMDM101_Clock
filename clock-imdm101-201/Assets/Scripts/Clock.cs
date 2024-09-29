using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clokc : UnityEngine.MonoBehaviour
{
    const float hoursToDegrees = -30f, minutessToDegrees = -6f, secondsToDegrees = -6f;
    [SerializeField]
    // hour hand pivot. it's a transform variable type
    Transform hoursPivot, minutesPivot, secondsPivot;

    // Start is called before the first frame update
    void Start()
    {
        hoursPivot.localRotation = Quaternion.Euler(0,0,0);
        minutesPivot.localRotation = Quaternion.Euler(0,0,0);
        secondsPivot.localRotation = Quaternion.Euler(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        
        Debug.Log(DateTime.Now.Hour);

        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * (float)time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutessToDegrees * (float)time.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * (float)time.TotalSeconds);
    }
}

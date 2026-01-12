using UnityEngine;
using System;

public class ClockTicking : MonoBehaviour
{
    [Header("Wskazówki zegara")]
    public Transform hoursPivot;
    public Transform minutesPivot;
    public Transform secondsPivot;

    [Header("Ustawienia")]
    public bool continuous = true; // Czy ruch ma byæ p³ynny czy skokowy?

    private const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (continuous)
        {
            UpdateContinuous();
        }
        else
        {
            UpdateDiscrete();
        }
    }
    void UpdateContinuous()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;

        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * (float)time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * (float)time.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * (float)time.TotalSeconds);
    }

    void UpdateDiscrete()
    {
        DateTime time = DateTime.Now;

        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * time.Hour);
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * time.Minute);
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * time.Second);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Timer
{
    #region methods
    // Set the duration of the timer.
    public Timer( float duration )
    {
        maxTime = duration;
        curTime = 0.0f;
    }
    // Update is called once per frame
    public bool Update()
    {
        if( curTime <= maxTime ) curTime += Time.deltaTime;

        return IsDone();
    }
    // Reset the timer.
    public void Reset()
    {
        curTime = 0.0f;
    }
    // Tells whether the timer is done.
    public bool IsDone()
    {
        return curTime >= maxTime;
    }
    // Returns how finished the timer is, range 0.0-1.0.
    public float GetPercent()
    {
        return curTime / maxTime;
    }
    #endregion

    #region members
    float maxTime;
    float curTime;
    #endregion
}

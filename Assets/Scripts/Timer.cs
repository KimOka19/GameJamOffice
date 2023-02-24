using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Timer : MonoBehaviour
{
    private float _duration = 1f;
    private float _currentDuration = 0;

    private bool _isStarted = false;

    public void StartTimer(bool beginWithTrue)
    {
        _isStarted = true;
        _currentDuration = beginWithTrue == true ? _duration : 0;

    }

    public void StopTimer()
    {
        _isStarted = false;
    }

    public bool UpdateTimer()
    {
        if (_isStarted == false || _currentDuration > _duration)
        {
            return false;
        }
        _currentDuration += Time.deltaTime;

        if (_currentDuration > _duration)
        {
            return true;
        }
        return false;
    }

}

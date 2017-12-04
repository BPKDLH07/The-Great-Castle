using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_Model {
    private float _timeBar;
    public float TimeBar {
        get
        {
            return _timeBar;
        }
        set
        {
            if (value < 0)
            {
                _timeBar = 0f;
            }
            else if (value > 100)
            {
                _timeBar = 100f;
            }
            else {
                _timeBar = value;
            }
        }
    }

    //Convertir a int
    private float _timeScore;
    public float TimeScore
    {
        get
        {
            return _timeScore;
        }

        set {
            _timeScore = value;
        }
    }

    public Time_Model() {

    }

    public Time_Model(float TimeBar, float TimeScore) {
        this.TimeBar = TimeBar;
        this.TimeScore = TimeScore;
    }

    public void LessTimeBar()
    {
        TimeBar=TimeBar-0.3f;
    }

    public void MoreTimeBar()
    {
        TimeBar = TimeBar + 40;
    }

    public void TimePoint() {
        TimeScore = TimeScore + 0.5f;
    }



}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class My_Time {
    //Daniel
	private int _timer;
	private float _detailedTime;
	public int Timer{get{ return _timer; } set{ _timer = value; }}

	public My_Time(){

	}

	public My_Time(int Timer){
		this._timer = Timer;
		this._detailedTime = Timer;
	}

	public void Decrease(float delta) {
		_detailedTime -= delta;
		//Esta linea esta convirtiendo a entero.
		_timer = (int) _detailedTime;
	}
    //Daniel

}

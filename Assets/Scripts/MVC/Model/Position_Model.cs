using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position_Model {

	//Valor X
	private float _x;
	public float X
	{
		get		
		{
			return _x;
		}
		set
		{
			_x=value;
		}
	}

	//Valor Y
	private float _y;
	public float Y
	{
		get
		{
			return _y;
		}
		set
		{
			_y=value;
		}
	}

	//Valor Z
	private float _z;
	public float Z
	{
	get
		{
			return _z;
		}
	set
		{
			_z=value;
		}	
	}

	public Position_Model(){

	}

	public Position_Model(float X){
		this.X=X;
	}

	public Position_Model(float X, float Y): this(X){
		this.Y=Y;
	}

	public Position_Model(float X, float Y, float Z): this(X,Y){
		this.Z=Z;
	}

	//Aumentando en X
	public float MoreX(){
		return X=X+2f;
	}
	public float MoreY(){
		return Y=Y+2f;
	}
	public float MoreZ(){
		return Z=Z+2f;
	}

	//Aumentando en Y;
	public float LessX(){
		return X=X-2;
	}
	public float LessY(){
		return Y=Y-2;
	}
	public float LessZ(){
		return Z=Z-2;
	}

}

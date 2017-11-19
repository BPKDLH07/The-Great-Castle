using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character_Model {
    //Daniel
    private int _hp;
    public int HP
    {
        get
        {
            return _hp;
        }
        set
        {
            value = _hp;
        }
    }

    public Character_Model() {

    }

    public Character_Model(int HP) {
        this.HP = HP;
    }
    //Daniel
    


}

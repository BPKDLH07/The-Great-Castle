using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Model : Character_Model {


    //aqui iran los metodos del comportamiento del enemigo. (No 100% seguro) -gonzalo

    //Daniel
    Enemy_Model() {

    }

    Enemy_Model(int hp):base(hp) {
        this.hp = hp;
    }

    void EnemyAuch()
    {
        hp--;
    }
    //Daniel

}

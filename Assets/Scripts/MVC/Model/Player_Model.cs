using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Model: Character_Model {


    //Aqui iran los metodos y variables necesarias para las acciones del personaje. (movimiento, salto, ataque) - gonzalo
        
    //Daniel
    public string name;
    

    public Player_Model() {
        
    }

    public Player_Model(int hp,  string name): base (hp) {
        this.hp = hp;
        this.name = name;
    }

    public void Auch() {
        hp--;
    }

    public override string ToString()
    {
        return "Player: "+name;
    }
    //Daniel



}

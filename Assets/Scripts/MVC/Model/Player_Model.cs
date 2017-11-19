using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Model: Character_Model {


    //Aqui iran los metodos y variables necesarias para las acciones del personaje. (movimiento, salto, ataque) - gonzalo
        
    //Daniel
    public string name;

    public Player_Model() {
        
    }

    public Player_Model(int HP,  string name): base(HP) {
        this.HP=HP;
        this.name = name;
    }

    void Auch() {
        HP--;
    }
    //Daniel


    	
}

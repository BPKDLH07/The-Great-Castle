﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Manager {


    //Este es el generador de niveles. Aqui iran los metodos que instanciaran nivel tras nivel, con los parametros necesarios. -gonzalo
    //Daniel Arredondo
    public enum TileType {
        ModuA1, ModuB1, ModuC1, ModuD1,
        ModuA2, ModuB2, ModuC2, ModuD2,
        ModuA3, ModuB3, ModuC3, ModuD3
    }

    public TileType[] pattern=new TileType[4];

    public void Order1() {
        pattern[0] = TileType.ModuA2;
        pattern[1] = TileType.ModuB1;
        pattern[2] = TileType.ModuC1;
        pattern[3] = TileType.ModuD3;
    }
    public void Order2() {
        pattern[0] = TileType.ModuB2;
        pattern[1] = TileType.ModuC3;
        pattern[2] = TileType.ModuD1;
        pattern[3] = TileType.ModuA1;
    }
    public void Order3() {
        pattern[0] = TileType.ModuD2;
        pattern[1] = TileType.ModuA1;
        pattern[2] = TileType.ModuB3;
        pattern[3] = TileType.ModuC1;
    }
    public void Order4() {
        pattern[0] = TileType.ModuC2;
        pattern[1] = TileType.ModuD1;
        pattern[2] = TileType.ModuA3;
        pattern[3] = TileType.ModuB1;
    }
    //Daniel Arredondo

	
}

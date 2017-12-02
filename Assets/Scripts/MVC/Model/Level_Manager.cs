using System.Collections;
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

    //if(EndTile is A3)
    public void OrderA1() {
        pattern[0] = TileType.ModuA2;
        pattern[1] = TileType.ModuB1;
        pattern[2] = TileType.ModuC1;
        pattern[3] = TileType.ModuD3;
    }
    public void OrderA2()
    {
        pattern[0] = TileType.ModuA2;
        pattern[1] = TileType.ModuB1;
        pattern[2] = TileType.ModuC3;
        pattern[3] = TileType.ModuD1;
    }
    public void OrderA3()
    {
        pattern[0] = TileType.ModuA2;
        pattern[1] = TileType.ModuB3;
        pattern[2] = TileType.ModuC1;
        pattern[3] = TileType.ModuD1;
    }


    //if(EndTile is B3)
    public void OrderB1()
    {
        pattern[0] = TileType.ModuB2;
        pattern[1] = TileType.ModuC1;
        pattern[2] = TileType.ModuD1;
        pattern[3] = TileType.ModuA3;
    }
    public void OrderB2()
    {
        pattern[0] = TileType.ModuB2;
        pattern[1] = TileType.ModuC1;
        pattern[2] = TileType.ModuD3;
        pattern[3] = TileType.ModuA1;
    }
    public void OrderB3()
    {
        pattern[0] = TileType.ModuB2;
        pattern[1] = TileType.ModuC3;
        pattern[2] = TileType.ModuD1;
        pattern[3] = TileType.ModuA1;
    }


    //if (EndTile is C3)
    public void OrderC1()
    {
        pattern[0] = TileType.ModuC2;
        pattern[1] = TileType.ModuD1;
        pattern[2] = TileType.ModuA1;
        pattern[3] = TileType.ModuB3;
    }
    public void OrderC2()
    {
        pattern[0] = TileType.ModuC2;
        pattern[1] = TileType.ModuD1;
        pattern[2] = TileType.ModuA3;
        pattern[3] = TileType.ModuB1;
    }
    public void OrderC3()
    {
        pattern[0] = TileType.ModuC2;
        pattern[1] = TileType.ModuD3;
        pattern[2] = TileType.ModuA1;
        pattern[3] = TileType.ModuB1;
    }


    //if (EndTile is D3)
    public void OrderD1()
    {
        pattern[0] = TileType.ModuD2;
        pattern[1] = TileType.ModuA1;
        pattern[2] = TileType.ModuB1;
        pattern[3] = TileType.ModuC3;
    }
    public void OrderD2()//StartPattern
    {
        pattern[0] = TileType.ModuD2;
        pattern[1] = TileType.ModuA1;
        pattern[2] = TileType.ModuB3;
        pattern[3] = TileType.ModuC1;
    }
    public void OrderD3()
    {
        pattern[0] = TileType.ModuD2;
        pattern[1] = TileType.ModuA3;
        pattern[2] = TileType.ModuB1;
        pattern[3] = TileType.ModuC1;
    }

    //Daniel Arredondo


}

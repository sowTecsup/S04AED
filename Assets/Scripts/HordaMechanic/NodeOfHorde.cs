using UnityEngine;
using Sirenix.OdinInspector;
using System.Collections.Generic;
using System;


[InlineEditor]
public class NodeOfHorde
{
  
    [ShowInInspector] public int Life = 15;
    public int Str = 10;
    public List<Color> Colors 
        = new List<Color>() {Color.black,Color.red,Color.blue};
    public List<string> EnemyNames = new List<string>() {"Bica","Trica","Func","Vectores","Lambda" };
    public int Quantity = 5;
}

using System;
using UnityEngine;
using Sirenix.OdinInspector;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public List<string> Inputs = new List<string>(); 


    public DoubleLinkedList<string> Nombres;
    public CircularDoubleLinkedList<string> Dialogos;

    void Start()
    {
      foreach (var input in Inputs)
      {
         Nombres.Add(input);
         Dialogos.Add(input);
      }
    }
    void Update()
    {

    }
    [Button]
    public void ShowDoubleList()
    {
        Nombres.TraverseInOrder(value => Debug.Log(value.Value) );

        Nombres.TraverseInReverse(value => Debug.Log(value.Value));
    }
    [Button]
    public void RemoveFirst()
    {
        Nombres.RemoveFirst();  
    }
    [Button]
    public void RemoveLast()
    {
        Nombres.RemoveLast();
    }
    [Button]
    public void AddCustom(string value)
    {
        Nombres.Add(value);
    }



}
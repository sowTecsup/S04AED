using System;
using UnityEngine;
using Sirenix.OdinInspector;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public List<string> Inputs = new List<string>(); 


    private DoubleLinkedList<string> Nombres = new();
    private CircularDoubleLinkedList<string> Dialogos = new() ;

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
        //Nombres.TraverseInOrder(value => Debug.Log(value.Value) );

        Nombres.TraverseInReverse(value => Debug.Log(value.Value));
    }
    [Button]
    public void RemoveFirst()
    {
        Dialogos.RemoveFirst();  
    }
    [Button]
    public void RemoveLast()
    {
        Dialogos.RemoveLast();
    }
    [Button]
    public void AddCustom(string value)
    {
        Dialogos.Add(value);
    }

    [Button]
    public void GetCount()
    {
        Debug.Log(Dialogos.Count);
    }



}
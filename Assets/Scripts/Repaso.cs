using System;
using UnityEngine;

public class Repaso : MonoBehaviour
{
    public Action<int> eventoDeInteres;//->  Funciones parametrizas o vacias , SIN RETORNO ,

    public Action eventoSimple;

    public Func<string> eventoConRetorno;

    private void OnEnable()
    {
        eventoDeInteres += Test1;
        // (CONTEXTO => LINEA DE EJECUCION)
        eventoDeInteres += ctx => Debug.Log(ctx);

        eventoDeInteres += ctx =>
        {
            Debug.Log(ctx);
            Debug.Log(ctx + "1");
            Debug.Log(ctx + " 2");
        };
        eventoSimple += () => Debug.Log("asdas");
        eventoSimple += () => Debug.Log("asdasd");

        eventoConRetorno += SimpleFunc;

        eventoConRetorno += () => "oa";




        string test = SimpleFunc();

        
      //  string test1 = testFunc();
//



    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Show()
    {
        eventoDeInteres?.Invoke(15);
    }
    public void Test1(int i)
    {
        Debug.Log(i);
    }
    public void testFunc()
    {
        Debug.Log("oa");
    }
   
    public string SimpleFunc()
    {
        return "oa";
    }
}

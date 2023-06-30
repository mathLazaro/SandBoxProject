/*using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public delegate void Teste(string str);
    public event Teste Op; // O evento invoca varios metodos, é como se fosse um delegate a cada subscribe
    // Action => Classe do C# que mescla o delegate e o event porem retorna apenas void
    //( pode ser usado o Func<> em que o último parametro determina o retorno)

    public Action<int> ASe;

    public void AbrirPorta(string chave)
    {
        if(chave=="123") Debug.Log("Senha correta");
        else Debug.Log("Senha incorreta");
    }
    public void AbirBau(string a,string b)
    {
        if(a==b) Debug.Log("Senha correta, bau aberto");
        else Debug.Log("Senha incorreta, bau não foi aberto");
    }

    private void OnEnable() 
    {
        Op+=new Teste(AbrirPorta);
        
    }

    private void Start()   
    {
        //Teste del = new Teste(AbrirPorta); // O delegate funciona apenas com métodos com os mesmos tipos de paramtros e saida
        //del?.Invoke("123");

        //del = new Teste(AbirBau); 
        //  errado pois o método AbrirBau tem mais argumentos que o delegate
              
    }

    private void OnDisable()
    {
        Op-=new Teste(AbrirPorta);
    }
}*/

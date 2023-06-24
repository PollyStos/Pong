using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GOOL : MonoBehaviour
{
    public bool golRosa;
    public Placar placar;
    public Bola bola;

    public AudioSource somGol;



   private void OnTriggerEnter2D (Collider2D colliderBola)
   {
       if(golRosa)
        {
           placar.GolRosa();
        }
         else
        {
            placar.GolVerde();
        }

        somGol.Play();
        bola.VoltaParaInicio();
   }

}

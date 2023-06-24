using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Placar : MonoBehaviour
{
    // Start is called before the first frame update
    public int pontosRosa;
    public int pontosVerde;
    public TextMeshProUGUI placarRosa;
    public TextMeshProUGUI placarVerde;

    // Start is called before the first frame update
    void Start()
    {
        placarRosa.text = "0";
        placarVerde.text = "0";

        pontosRosa = pontosVerde = 0;
    }

   public void GolRosa()
   {
        pontosRosa++;
        placarRosa.text = pontosRosa.ToString();
        Debug.Log("Gol Rosa");
   }
   public void GolVerde()
   {
        pontosVerde++;
        placarVerde.text = pontosVerde.ToString();
        Debug.Log("Gol Verde");
   }
}
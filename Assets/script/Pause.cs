using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    public bool emPausa;
    public GameObject painel;
    // Start is called before the first frame update
    void Start()
    {
        emPausa = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)&& emPausa==false)
        {
            
            Time.timeScale = 0;
            painel.SetActive(true);
            emPausa = true;
        }

        else if(Input.GetKeyDown(KeyCode.Escape)&& emPausa==true)
        {
              emPausa = false;
            Time.timeScale = 1;
            painel.SetActive(false);
        }

    }
}

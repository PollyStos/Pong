using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public float speed;
    public Rigidbody2D meuRigidBody2D; 
    public Vector3 posInicial;
    public bool inicio;

    public AudioSource [] sons;
    // Start is called before the first frame update
    void Start()
    {
       inicio = true;
    }

    public void VoltaParaInicio()
    {
        meuRigidBody2D.velocity = Vector2.zero; 
        transform.position = posInicial;
        inicio = true;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)&& inicio == true)
        {
            LancaBola();
        }
    }

    public void LancaBola()
    {
        inicio = false;
        Vector2 dir = new Vector2(Random.Range(0.2f,1f),Random.Range(-1f,1f)).normalized;
        bool NegativeSignal = Random.Range(0,2)==0;

        if(NegativeSignal==true)
        {
            dir = -dir;
        }

        meuRigidBody2D.velocity = dir*speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        int randSom = Random.Range(0,sons.Length);

        sons[randSom].Play();
    }
}


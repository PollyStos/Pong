using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataforma : MonoBehaviour
{
    public Rigidbody2D meuRigidBody2D;
    public bool plataformaVerde;
    public float velocidade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(plataformaVerde)
        {
            if(Input.GetKey(KeyCode.UpArrow))          
            {
                meuRigidBody2D.velocity = velocidade*Vector2.up;
            }else if(Input.GetKey(KeyCode.DownArrow))
            {
                meuRigidBody2D.velocity = velocidade*Vector2.down;
            } else
            {
                meuRigidBody2D.velocity = Vector2.zero;
            }
        }else{
            if(Input.GetKey(KeyCode.W))
            {
                meuRigidBody2D.velocity = velocidade*Vector2.up;
            }else if(Input.GetKey(KeyCode.S))
            {
                meuRigidBody2D.velocity = velocidade*Vector2.down;
            } else
            {
                meuRigidBody2D.velocity = Vector2.zero;
            }
        }
            
    }
}

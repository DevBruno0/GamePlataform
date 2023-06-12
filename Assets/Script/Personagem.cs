using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody2D Corpo;
    public float Velocidade;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
    }
    void Mover()
    {
        Velocidade = Input.GetAxis("Horizontal") * 3;
        Corpo.velocity = new Vector2(Velocidade, Corpo.velocity.y);

    }
}

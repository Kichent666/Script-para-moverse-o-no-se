using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsulaCorre : MonoBehaviour
{
    //Vida del NPC
    public int vida = 5;

    //Nivel del NPC
    public int nivel = 1;

    //NPC Speed
    public float speed = 1.2f;

    Vector3 newPosition; 

    // Start is called before the first frame update
    void Start()
    {
      vida += nivel;
        newPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        print(vida);
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
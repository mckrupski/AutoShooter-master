using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Basher : MonoBehaviour
{
    //gracz
    GameObject player;
    //predkosc podazania za graczem
    public float walkSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform.position);
        

        transform.position += Vector3.forward;
        //idz do przodu
        transform.position += transform.forward;
    }
}

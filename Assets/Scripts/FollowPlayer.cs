using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);


    //Kamera titreþimini gidermek için LateUpdate metodu kullanýldý
    void LateUpdate()
    {

        //araba pozisyonununa (0, 5, -7)(offset) olmak üzere yeni pozisyon konumu eklendi ve bu kameranýn pozisyonu oldu
        transform.position = player.transform.position + offset;
       

    }
}

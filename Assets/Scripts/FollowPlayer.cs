using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);


    //Kamera titre�imini gidermek i�in LateUpdate metodu kullan�ld�
    void LateUpdate()
    {

        //araba pozisyonununa (0, 5, -7)(offset) olmak �zere yeni pozisyon konumu eklendi ve bu kameran�n pozisyonu oldu
        transform.position = player.transform.position + offset;
       

    }
}

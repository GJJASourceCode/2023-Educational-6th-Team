using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPoint : MonoBehaviour
{
    void Start()
    {
    }
    void Update()
    {
    }
    void OnCollisionEnter(Collision Collision){
        if(Collision.collider.gameObject.CompareTag("Player")){
            data.point++;
            Debug.Log(data.point);
            Destroy(gameObject);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ob : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        void OnCollisionEnter(Collision Collision){
            if(Collision.collider.gameObject.CompareTag("Player")){
                Debug.Log("플레이어접촉");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

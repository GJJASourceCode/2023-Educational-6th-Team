using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassageMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0,0,-10f*Time.deltaTime);
        if(transform.position.z<-40f){
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveTransitionSpeed = 5f;
    public int nowLine;
    public float jumpPower;
    public bool isJump, isSlide;
    public Rigidbody rb;
    public static bool isLive;
    public Animator anim;
    private List<float> railPos = new List<float>()
    {
        -1.8f,
        -0.08f,
        1.64f
    };
    void Start()
    {
        nowLine =1;
        jumpPower =300f;
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        isLive = true;
    }
    void OnCollisionEnter(Collision collision){
        if(collision.collider.gameObject.CompareTag("Passage")){
            isJump=false;
            
        }
    }
    void Update()
    {
        if(isLive==false){
            anim.SetTrigger("falldown");
        }

        if(Input.GetKeyDown(KeyCode.RightArrow)){
            if(nowLine==0||nowLine==1){
                nowLine++;
            }
        
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            if(nowLine==1||nowLine==2){
                nowLine--;
            }
        
        }

        if((Input.GetKeyDown("space"))&&(!isJump)){
            rb.AddForce(Vector3.up * jumpPower);
            isJump=true;
            anim.SetTrigger("jump");
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            isSlide=true;
            anim.SetTrigger("slide");
        }
        transform.position = Vector3.Lerp(transform.position, new Vector3(railPos[nowLine], transform.position.y, transform.position.z), Time.deltaTime * moveTransitionSpeed);
    

    }
}
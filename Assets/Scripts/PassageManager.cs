using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassageManager : MonoBehaviour
{
    public GameObject[] passage;
    public GameObject[] runningpassage;
    public int passageNum, runningpassageNum;
    void Start()
    {
        runningpassageNum=0;
        runningpassage[runningpassageNum] = Instantiate(passage[0],new Vector3(0,0,2.4f),transform.rotation);
        runningpassageNum++;
        runningpassage[runningpassageNum] = Instantiate(passage[Random.Range(0,1)],new Vector3(0,0,39.5f),transform.rotation);
        runningpassageNum++;
        runningpassage[runningpassageNum] = Instantiate(passage[Random.Range(0,1)],new Vector3(0,0,76.6f),transform.rotation);
        runningpassageNum++;
    }
    void Update()
    {
        if(runningpassage[runningpassageNum%3]==null){
            runningpassage[runningpassageNum%3] = Instantiate(passage[Random.Range(0,1)],new Vector3(0,0,70.6f),transform.rotation);
            runningpassageNum++;
            }
        }
    }
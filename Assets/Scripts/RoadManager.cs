using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour
{
    public GameObject[] road;
    public GameObject[] runningRoad;
    public int roadNum, runningRoadNum;
    void Start()
    {
        runningRoadNum=0;
        runningRoad[runningRoadNum] = Instantiate(road[0],new Vector3(0,0,0),transform.rotation);
        Destroy(runningRoad[runningRoadNum],3f);
        runningRoadNum++;
        runningRoad[runningRoadNum] = Instantiate(road[Random.Range(0,10)],new Vector3(0,0,30),transform.rotation);
        Destroy(runningRoad[runningRoadNum],6f);
        runningRoadNum++;
        runningRoad[runningRoadNum] = Instantiate(road[Random.Range(0,10)],new Vector3(0,0,60),transform.rotation);
        Destroy(runningRoad[runningRoadNum],9f);
        runningRoadNum++;
    }
    void Update()
    {
        if(runningRoad[runningRoadNum%3]==null){
            runningRoad[runningRoadNum%3] = Instantiate(road[Random.Range(0,10)],new Vector3(0,0,59.7f),transform.rotation);
            Destroy(runningRoad[runningRoadNum%3],9f);
            runningRoadNum++;
            }
        }
    }
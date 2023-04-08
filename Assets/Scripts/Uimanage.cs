using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Uimanage : MonoBehaviour
{
    public Text pointText;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pointText.text = "point : " + data.point;
    }
}

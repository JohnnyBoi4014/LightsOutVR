using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverScript : MonoBehaviour
{

    public GameObject leverTip;
    public GameObject leverConnection;
    public GameObject ActiveWall;

    HingeJoint hb;
    JointSpring spr;

    public bool isOn;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hb = GetComponent<HingeJoint>();
        spr = hb.spring;

        isOn = true;

        fillIn = 0.0f;
    }

    public float fillIn = 0.0f;

    // Update is called once per frame
    void Update()
    {
        if (isOn)
        {
            if (leverTip.transform.position.y < leverConnection.transform.position.y)
            {
                ActiveWall.SetActive(false);

                //this.gameObject.GetComponent<HingeJoint>().spring.targetPosition.Equals(130);

                spr.targetPosition = 130f;
                hb.spring = spr;
            }
            else
            {
                ActiveWall.SetActive(true);

                //this.gameObject.GetComponent<HingeJoint>().spring.targetPosition.Equals(0);

                spr.targetPosition = 0f;
                hb.spring = spr;
            }
        }
        else
        {
            spr.targetPosition = fillIn;
            hb.spring = spr;
        }
    }
}

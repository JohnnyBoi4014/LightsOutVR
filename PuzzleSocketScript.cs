using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class PuzzleSocketScript : MonoBehaviour
{
    public GameObject Socket1;
    public GameObject Socket2;
    public GameObject Socket3;
    public GameObject Socket4;

    public GameObject Key1;
    public GameObject Key2;
    public GameObject Key3;
    public GameObject Key4;

    public GameObject removeableWall;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        removeableWall.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Socket1.transform.position == Key1.transform.position)
        {
            if (Socket2.transform.position == Key2.transform.position)
            {
                if (Socket3.transform.position == Key3.transform.position)
                {
                    if (Socket4.transform.position == Key4.transform.position)
                    {
                        removeableWall.SetActive(false);
                    }
                }
            }
        }
    }
}

using System.Collections;
using UnityEngine;

public class LeverPuzzleScript : MonoBehaviour
{
    // TEST STUFF
    public bool canA;
    public bool oneA;
    public bool twoA;
    public bool threeA;

    public bool test1;
    public bool test2;
    // TEST STUFF

    private bool canActivate = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        platform1.SetActive(true);
        pole1.SetActive(false);
        
        canActivate = false;

        oneActive = false;
        twoActive = false;
        threeActive = false;

        // TEST STUFF
        canA = canActivate;
        oneA = oneActive;
        twoA = twoActive;
        threeA = threeActive;

        test1 = false;
        test2 = false;
        // TEST STUFF
    }

    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;

    public GameObject lever1;
    public GameObject lever2;
    public GameObject lever3;

    public GameObject glowCube1;
    public GameObject glowCube2;
    public GameObject glowCube3;

    public Material glowGreen;
    public Material glowRed;

    public GameObject platform1;
    public GameObject pole1;

    private bool oneActive;
    private bool twoActive;
    private bool threeActive;
    
    // Update is called once per frame
    void Update()
    {
        if (glowCube1.GetComponent<Renderer>().sharedMaterial == glowGreen)
        {
            test1 = true;

            if (!oneActive)
            {
                test2 = true;

                if (!cube1.activeInHierarchy || !cube3.activeInHierarchy)
                {
                    //StartCoroutine(gotWrong());
                    canActivate = true;
                }
                if (!cube2.activeInHierarchy)
                {
                    oneActive = true;
                }
            }
            if (oneActive && !twoActive)
            {
                if (!cube3.activeInHierarchy || cube2.activeInHierarchy)
                {
                    //StartCoroutine(gotWrong());
                    canActivate = true;
                }
                if (!cube1.activeInHierarchy)
                {
                    twoActive = true;
                }
            }
            if (oneActive && twoActive && !threeActive)
            {
                if (cube1.activeInHierarchy || cube2.activeInHierarchy)
                {
                    //StartCoroutine(gotWrong());
                    canActivate = true;
                }
                if (!cube3.activeInHierarchy)
                {
                    threeActive = true;
                    gotRight();
                }
            }
        }

        if (canActivate && glowCube1.GetComponent<Renderer>().sharedMaterial == glowGreen)
        {
            glowCube1.GetComponent<Renderer>().sharedMaterial = glowRed;
            StartCoroutine(gotWrong());
        }
    }

    IEnumerator gotWrong()
    {
        canActivate = false;

        oneActive = false;
        twoActive = false;
        threeActive = false;
        
        platform1.SetActive(false);
        glowCube1.GetComponent<Renderer>().sharedMaterial = glowRed;
        glowCube2.GetComponent<Renderer>().sharedMaterial = glowRed;
        glowCube3.GetComponent<Renderer>().sharedMaterial = glowRed;

        lever1.GetComponent<LeverScript>().isOn = false;
        lever2.GetComponent<LeverScript>().isOn = false;
        lever3.GetComponent<LeverScript>().isOn = false;

        yield return new WaitForSeconds(2.5f);

        lever1.GetComponent<LeverScript>().isOn = true;
        lever2.GetComponent<LeverScript>().isOn = true;
        lever3.GetComponent<LeverScript>().isOn = true;

        yield return new WaitForSeconds(2.5f);

        platform1.SetActive(true);
        glowCube1.GetComponent<Renderer>().sharedMaterial = glowGreen;
        glowCube2.GetComponent<Renderer>().sharedMaterial = glowGreen;
        glowCube3.GetComponent<Renderer>().sharedMaterial = glowGreen;
    }
    public void gotRight()
    {
        pole1.SetActive(true);
    }
}

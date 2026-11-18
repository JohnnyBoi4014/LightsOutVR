using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class GoblinScript : MonoBehaviour
{
    NavMeshAgent agentTrackerSmarter;
    public Transform target;
    //public GameManager manager;

    public bool lockIn = false;

    public float ranSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        lockIn = false;
        agentTrackerSmarter = GetComponent<NavMeshAgent>();

        ranSpeed = Random.Range(5.0f, 10.0f);
    }

    void Update()
    {
        DoSomethingSmart();
    }

    void DoSomethingSmart()
    {
        //if (manager.coins > 0 || lockIn)
        //{
            lockIn = true;
            // slow and steady advance
            agentTrackerSmarter.speed = ranSpeed;

            // go attack player
            Vector3 targetVector = target.transform.position;
            agentTrackerSmarter.SetDestination(targetVector);
        //}

        if ((this.transform.position.x - targetVector.x < 1) && (this.transform.position.y - targetVector.y < 1) && (this.transform.position.z - targetVector.z) < 1 && (this.transform.position.x - targetVector.x > -1) && (this.transform.position.y - targetVector.y > -1) && (this.transform.position.z - targetVector.z) > -1)
        {
            SceneManager.LoadScene(3); //Make this a lose screen
        }
    }
}

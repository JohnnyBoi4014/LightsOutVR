using UnityEngine;

public class ImportantCoinScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public GameObject CCspawnpoint;
    
    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y < -1)
        {
            this.transform.position = CCspawnpoint.transform.position;
        }
    }
}

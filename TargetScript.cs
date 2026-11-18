using UnityEngine;

public class TargetScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        key.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //public GameObject bullet1;
    //public GameObject bullet2;
    public GameObject target;
    public GameObject key;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Bullet"))
        {
            target.gameObject.SetActive(false);
            key.SetActive(true);
        }
    }
}

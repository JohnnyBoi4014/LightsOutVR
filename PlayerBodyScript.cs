using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBodyScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y < -1)
        {
            SceneManager.LoadScene(3);
        }
    }
}

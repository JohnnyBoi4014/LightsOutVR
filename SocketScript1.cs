using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class SocketScript1 : MonoBehaviour
{
    XRSocketInteractor xri;

    public GameObject Key;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        xri = GetComponent<XRSocketInteractor>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Key.transform.position==this.transform.position)
        {
            SceneManager.LoadScene(2);
        }
    }
}

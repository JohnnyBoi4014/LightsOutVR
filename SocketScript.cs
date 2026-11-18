using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class SocketScript : MonoBehaviour
{
    XRSocketInteractor xri;

    public GameObject RedCoin;

    public GameObject Ramp;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        xri = GetComponent<XRSocketInteractor>();
    }

    // Update is called once per frame
    void Update()
    {
        if (RedCoin.transform.position==this.transform.position)
        {
            Ramp.SetActive(true);
        }
        else
        {
            Ramp.SetActive(false);
        }
    }
}

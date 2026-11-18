using UnityEngine;
using UnityEngine.SceneManagement;

public class Pistol : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firepoint;
    public float bulletSpeed = 20f;
    public float bulletLifetime = 5f;

    public AudioClip clip;
    private AudioSource source;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void FireBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        source.PlayOneShot(clip);

        if (rb != null)
        {
            rb.linearVelocity = (firepoint.right*-1) * bulletSpeed;
        }

        Destroy(bullet, bulletLifetime);
    }

    public GameObject spawnpoint;
    
    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y < -1)
        {
            this.transform.position = spawnpoint.transform.position;
        }
    }
}

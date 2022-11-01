using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BulletMaker : MonoBehaviour
    
{
    [SerializeField] AudioSource audioSource;
    public GameObject bulletPref;
    Rigidbody bullet;
    public float thrust;
    [SerializeField] int magazineSize;
    [SerializeField] int bulletsRemaining;
    [SerializeField] AudioClip[] audioClips;

    bool isReloading;

    // Start is called before the first frame update
    void Start()
    {
        bullet = bulletPref.GetComponent<Rigidbody>();
        bulletsRemaining = magazineSize;
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

    void GetInput()
    {
        if (Input.GetKeyDown(KeyCode.R)) Reload();
        if (Input.GetMouseButtonDown(0)) Shoot();
    }
    void Shoot()
    {
        if (bulletsRemaining > 0 && !isReloading)
        {
            Debug.Log("left click detected");
            Rigidbody latestBullet = Instantiate(bullet, this.transform.position, this.transform.rotation);
            audioSource.PlayOneShot(audioClips[1]);
            latestBullet.AddRelativeForce(Vector3.forward * thrust);
            bulletsRemaining--;

        }
        else if (bulletsRemaining < 1)
        {
            audioSource.PlayOneShot(audioClips[0]);
        }
    }
    private void Reload()
    {
        if (bulletsRemaining <= 5)
        {
            StartCoroutine(Reloading());
            bulletsRemaining = magazineSize;
           
        }
    }
    private IEnumerator Reloading()
    {
        isReloading = true;
        audioSource.PlayOneShot(audioClips[2]);
        yield return new WaitForSeconds(audioClips[2].length);
        isReloading = false;
    }
}

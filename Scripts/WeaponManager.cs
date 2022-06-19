using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class WeaponManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject playerCam;
    public float range = 100f;
    public float damage = 25f;
    public Animator playerAnimator;
    public AudioSource shootSound;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerAnimator.GetBool("isShooting"))
        {
            playerAnimator.SetBool("isShooting", false);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            shootSound.Play();
            Shoot();
        }
    }
     
    void Shoot()
    {
        playerAnimator.SetBool("isShooting", true);
        RaycastHit hit;
        if (Physics.Raycast(playerCam.transform.position, transform.forward, out hit, range)) {
            //check if we hit enemy
            EnemyManager enemyManager = hit.transform.GetComponent<EnemyManager>();
            if (enemyManager != null)
            {
                enemyManager.Hit(damage);
            }
        } 
    }
}

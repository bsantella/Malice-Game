using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;
using UnityEngine.Experimental.GlobalIllumination;

public class Gun_ShowHide : MonoBehaviour
{
    public Camera playerCam;
    [SerializeField] GameObject gun;
    [SerializeField] GameObject gunFloor;
    public GameObject BulletPrefab;
    private RaycastHit hit;
    public bool hasGun = false;
    bool gunBool = false;
    private bool done = false;
    // Update is called once per frame
    void Update()
    {
        if (!done)
        {
            if (hasGun)
            {
                gunBool = !gunBool;
                gun.SetActive(true);
                gunFloor.SetActive(false);
            }
            else
            {
                gun.SetActive(false);
                gunFloor.SetActive(true);
            }
        }

        if (hasGun && Input.GetKeyDown(KeyCode.Mouse0))
        {
            gunBool = !gunBool;
            GameObject BulletObject = Instantiate(BulletPrefab);
            BulletObject.transform.position = playerCam.transform.position + playerCam.transform.forward;
            BulletObject.transform.forward = playerCam.transform.forward;
        }

    }
}

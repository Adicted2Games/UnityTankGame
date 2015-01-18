using UnityEngine;
using System.Collections;

public class EnemyShoots : MonoBehaviour {
    private float reloadTime;
    public float timeToReload;
    public GameObject bulletPrefab;
    private Transform turret;
    private Transform nozzle;
    public float shootingRange;

	// Use this for initialization
	void Start () {
        reloadTime = 0;

        Transform[] transforms = this.gameObject.GetComponentsInChildren<Transform>();

        foreach (Transform t in transforms)
        {
            if (t.gameObject.name == "Turret")
            {
                turret = t;
            }

            if (t.gameObject.name == "nozzle")
            {
                nozzle = t;
            }

        }

	}
	
	// Update is called once per frame
	void Update () {
        reloadTime += Time.deltaTime;
        if(reloadTime >= timeToReload)
        {
            CheckForPlayer();

        }
	}

    private void CheckForPlayer()
    {
        Ray myRay = new Ray();

        myRay.origin = turret.position;
        myRay.direction = turret.forward;

        RaycastHit hitInfo;

        //checken met behulp van raycast of de player in zicht is
        if (Physics.Raycast(myRay, out hitInfo, shootingRange))
        {

            string hitObjectName = hitInfo.collider.gameObject.name;


            if(hitObjectName == "Tank1")
            {
                Instantiate(bulletPrefab, nozzle.position, nozzle.rotation);

                reloadTime = 0f;
            }
        }

        //zo ja schieten en reload time resetten naar 0

    }
}

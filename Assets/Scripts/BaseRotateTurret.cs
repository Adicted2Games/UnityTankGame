using UnityEngine;
using System.Collections;

public class BaseRotateTurret : MonoBehaviour {

    private Transform[] transforms;//naar base class
    protected Transform Turret;//naar base class
    protected Vector3 targetPos;

	// Use this for initialization
	protected virtual void Start () {
	//naar base class

        bool turretFound = false;

        transforms = gameObject.GetComponentsInChildren<Transform>();
        foreach (Transform t in transforms)
        {
            if (t.gameObject.name == "Turret")
            {
                Turret = t;

                turretFound = true;
            }
        }

        if (!turretFound)
        {
            print("ok");
        }
	}
	
	// Update is called once per frame
	 protected virtual void Update () {

        Turret.LookAt(targetPos);
	}
}

﻿using UnityEngine;
using System.Collections;

public class RotateTurret : BaseRotateTurret {

    public Camera camera;



	
	// Update is called once per frame
	override protected void Update () {
        Vector3 mousePos = Input.mousePosition;//(x,y,z)
        mousePos.z = camera.transform.position.y - Turret.transform.position.y;   //- (Turret.transform.localPosition.y - this.transform.position.y);

        Vector3 worldPos = camera.ScreenToWorldPoint(mousePos);

        targetPos = worldPos;

        base.Update();

        //print("worldPos" + worldPos);
	}
}

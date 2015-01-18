using UnityEngine;
using System.Collections;

public class SelfDestruct : MonoBehaviour {
    public float maxLifeTime;
    private float lifetime;
    public float lightFade;

    private Light light;

	// Use this for initialization
	void Start () {
        light = GetComponent<Light>(); 
	}
	
	// Update is called once per frame
	void Update () {
        light.intensity -= lightFade;


        lifetime += Time.deltaTime;
        if (lifetime > maxLifeTime)
        {
            Destroy(this.gameObject);
        }
	}
}

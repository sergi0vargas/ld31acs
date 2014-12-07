using UnityEngine;
using System.Collections;

public class LightEfect : MonoBehaviour {

    public float maxRange = 2.2f;
    public float minRange = 1.8f;
    public float stepRange = 0.2f;
    private bool rangePlus = true;
    public float maxIntensity = 3f;
    public float minIntensity = 1.5f;
    public float stepIntensity = 0.2f;
    private bool intensityPlus = true;


    private Light light;

	// Use this for initialization
	void Start () {
        light = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {

        light.range = Random.Range(minRange, maxRange);
        light.intensity = Random.Range(minIntensity, maxIntensity);
	}
}

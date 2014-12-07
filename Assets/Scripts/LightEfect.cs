using UnityEngine;
using System.Collections;

public class LightEfect : MonoBehaviour {

    public float maxRange = 2.2f;
    public float minRange = 1.8f;
    public float maxIntensity = 3f;
    public float minIntensity = 1.5f;

    private float timer = 0;
    public float intervaloLuz = 0.1f;

    private Light light;

	// Use this for initialization
	void Start () {
        light = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;
        if (timer >= intervaloLuz)
        {
            light.range = Random.Range(minRange, maxRange);
            light.intensity = Random.Range(minIntensity, maxIntensity);
            timer = 0;
        }
	}
}

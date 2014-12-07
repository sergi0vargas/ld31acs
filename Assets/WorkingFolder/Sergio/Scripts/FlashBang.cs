using UnityEngine;
using System.Collections;

public class FlashBang : MonoBehaviour {

    public float flashBangTime = 0.5f;
    public float intensity = 1;
    private Light luz;
    
    void Start()
    {
        luz = GetComponent<Light>();
        luz.intensity = 0;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {

        }
    }
}

using UnityEngine;
using System.Collections;

public class FlashBang : MonoBehaviour {

    public float flashBangTime = 0.5f;
    public float intensity = .5f;
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
            Debug.Log("entro1");
            StartCoroutine("DoFlashbang");
        }
    }

    IEnumerator DoFlashbang()
    {
        Debug.Log("entro2");
        luz.intensity = intensity;
        yield return new WaitForSeconds(flashBangTime);
        Debug.Log("entro3");
        luz.intensity = 0;
    }
}

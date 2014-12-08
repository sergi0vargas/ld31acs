using UnityEngine;
using System.Collections;

public class FlashBang : MonoBehaviour {

    public float flashBangTime = 0.2f;
    public int timeDisabled = 30;
    public float intensity = .5f;
    private Light luz;
    private bool isActive = true;
    
    void Start()
    {
        luz = GetComponent<Light>();
        luz.intensity = 0;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Player") && isActive)
        {
            StartCoroutine("DoFlashbang");
        }
    }

    IEnumerator DoFlashbang()
    {
        luz.intensity = intensity;
        yield return new WaitForSeconds(flashBangTime);
        luz.intensity = 0;
        StartCoroutine("Disable");
    }

    IEnumerator Disable()
    {
        isActive = false;
        yield return new WaitForSeconds(timeDisabled);
        isActive = true;
    }
}

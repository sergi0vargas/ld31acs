using UnityEngine;
using System.Collections;

public class HasTheKey : MonoBehaviour {

    public bool hasKey = false;
   
	
	void OnTriggerStay2D(Collider2D col){
        if (col.gameObject.tag.Equals("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (hasKey)
                {
                    StartCoroutine(CambiaTexto("Found a Key",  true));
                }
                else
                {
                    StartCoroutine(CambiaTexto("Nothing here...", false));
                }
            }
        }
	}

    IEnumerator CambiaTexto(string txt, bool activarTrofeo)
    {
        GameManager.manager.posTxtFlotante.position = Camera.main.WorldToScreenPoint(transform.position);
        GameManager.manager.txtFlotante.text = txt;
        yield return new WaitForSeconds(1);
        GameManager.manager.txtFlotante.text = "";
        if (activarTrofeo)
        {
            GameManager.manager.ActivarTrofeo();
        }
    }
}

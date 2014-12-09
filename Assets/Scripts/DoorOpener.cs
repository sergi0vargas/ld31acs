using UnityEngine;
using System.Collections;

public class DoorOpener : MonoBehaviour {





    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                GameManager.manager.finish = true;
                GameManager.manager.WIN();
            }
        }
    }


}

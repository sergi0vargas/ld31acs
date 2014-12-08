using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager manager;

    public float playerLife = 100;
    public float damage = 25;
    public Text txtFlotante;
    public Image imgTrofeo;
    public Slider lifeSlider;
    public RectTransform posTxtFlotante;
    
    void Awake()
    {
        if (manager == null)
        {
            DontDestroyOnLoad(gameObject);
            manager = this;
        }
        else if (manager != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        txtFlotante = GameObject.FindGameObjectWithTag("FloatingText").GetComponent<Text>();
        if(txtFlotante != null)
            posTxtFlotante = txtFlotante.transform as RectTransform;

        imgTrofeo = GameObject.FindGameObjectWithTag("Key").GetComponent<Image>();
        if(imgTrofeo != null)
            DesactivarTrofeo();

        lifeSlider = GameObject.FindGameObjectWithTag("LifeSlider").GetComponent<Slider>();
        if (lifeSlider != null)
            lifeSlider.value = playerLife;
    }

    //Apply Damage - If the player life is less than 0 return true
    public bool ApplyDamage()
    {
        playerLife -= damage;
        if (playerLife <= 0)
            return true;
        
        return false;
    }


    public void ActivarTrofeo()
    {
        imgTrofeo.color = new Color(255, 255, 255, 255);
    }

    public void DesactivarTrofeo()
    {
        imgTrofeo.color = new Color(0, 0, 0, 0);
    }
   
}

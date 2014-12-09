using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager manager;
    
    public bool hasTheKey = false;
    public bool isDead = false;
    public bool finish = false;
    public float playerLife = 100;
    public float damage = 25;

    public int dificultad = 1;
    public int dificultadMaxima = 4;

    public Text txtFlotante;
    public Image imgTrofeo;
    public Slider lifeSlider;
    public RectTransform posTxtFlotante;
    public GameObject uiGame;
    public GameObject uiStart;
    public GameObject uiEnd;
    public GameObject uiWin;
    public Text txtDificultad;
    public Text txtDificultad1;

    public LawnMowerGenerator enemigos;
    
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
        uiGame = GameObject.FindGameObjectWithTag("uiGame");
        uiStart = GameObject.FindGameObjectWithTag("uiStart");
        uiEnd = GameObject.FindGameObjectWithTag("uiEnd");
        uiWin = GameObject.FindGameObjectWithTag("uiWin");

        txtDificultad = GameObject.FindGameObjectWithTag("dificultad1").GetComponent<Text>();
        txtDificultad1 = GameObject.FindGameObjectWithTag("dificultad2").GetComponent<Text>();
        ActiveUI(2);


        txtDificultad.text = "Difficulty: " + dificultad;
        txtDificultad1.text = "Difficulty: " + dificultad;

        enemigos = GameObject.FindGameObjectWithTag("ENEMYS").GetComponent<LawnMowerGenerator>();

    }

    //Apply Damage - If the player life is less than 0 return true
    public bool ApplyDamage()
    {
        playerLife -= damage;
        lifeSlider.value = playerLife;
        if (playerLife <= 0)
        {
            audio.Play();
            isDead = true;
            ActiveUI(3);
            return true;
        }
        
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

    public void ActiveUI(int ui)
    {
        //INGAME
        if (ui == 1)
        {
            uiGame.SetActive(true);
            uiStart.SetActive(false);
            uiEnd.SetActive(false);
            uiWin.SetActive(false);
            Pause(false);
            enemigos.GenerateLawnMower();
        }
        //MENU NORMAL
        if (ui == 2)
        {
            uiGame.SetActive(false);
            uiStart.SetActive(true);
            uiEnd.SetActive(false);
            uiWin.SetActive(false);
            Pause(true);
        }
        //MENU DE MUERTE
        if (ui == 3)
        {
            uiGame.SetActive(false);
            uiStart.SetActive(false);
            uiEnd.SetActive(true);
            uiWin.SetActive(false);
            Pause(true);
        }
    }

    public void WIN()
    {
        uiGame.SetActive(false);
        uiStart.SetActive(false);
        uiEnd.SetActive(false);
        uiWin.SetActive(true);
    }

    public void Pause(bool pausar)
    {
        if (pausar)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    public void Dificultad()
    {
        dificultad++;
        if (dificultad > dificultadMaxima)
        {
            dificultad = 1;
        }
        enemigos.lawnMowerQuantity = dificultad;
        txtDificultad.text = "Difficulty: " + dificultad;
        txtDificultad1.text = "Difficulty: " + dificultad;
    }

    public void LoadLevel()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void Votar()
    {
        Application.OpenURL("http://ludumdare.com/compo/ludum-dare-31/?action=preview&uid=44969");
    }
}

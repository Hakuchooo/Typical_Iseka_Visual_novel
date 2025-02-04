using TMPro;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    public GameObject Scene1;
    public GameObject Scene2;
    public GameObject DeathScene;
    public int Stamina;
    // Start is called before the first frame update
    void Start()
    {
        Scene1.SetActive(true);
        Scene2.SetActive(false);
        Stamina = 100;
    }
   
    // Update is called once per frame
    private void Update()
    {
       if (Stamina <= 0)
        {
            Scene1.SetActive(false);
            Scene2.SetActive(true);
        }
    }

    public void SecondScene()
    {
        Scene2.SetActive(true);
        Scene1.SetActive(false);
        Stamina = 100;
    }

    public void Deathscene()
    {
        Scene2.SetActive(false);
        Scene1.SetActive(false);
        DeathScene.SetActive(true);
    }
}


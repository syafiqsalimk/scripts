using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    public Image currentEnergy;
    public Text time;

    private GameObject player;

    private float energy = 200;
    private float maxEnergy = 200;
    private float kecepatan;
    private float kecepatanLari;
    private float input_x;
    private float input_z;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        kecepatanLari = player.GetComponent<pergerakan_player>().speed_lari;
    }

    // Update is called once per frame
    void Update()
    {
       kecepatan = player.GetComponent<pergerakan_player>().kecepatan;
       input_x = player.GetComponent<pergerakan_player>().x;
       input_z = player.GetComponent<pergerakan_player>().z;


       UpdateTime();
       
    }

   
    private void UpdateTime()
    {
        int hours = EnviroSky.instance.GameTime.Hours;
        int minutes = EnviroSky.instance.GameTime.Minutes;
        string gameHours;
        string gameMinutes;

        if(hours >= 0 && hours < 10)
        {
            gameHours = "0" + hours.ToString();
        }
        else
        {
            gameHours = hours.ToString();
        }

        if(minutes >= 0 && minutes < 10)
        {
            gameMinutes = "0" + minutes.ToString();
        }
        else
        {
            gameMinutes = minutes.ToString();
        }

        
        
        time.text = gameHours.ToString() + " : " + gameMinutes.ToString();


    }
}

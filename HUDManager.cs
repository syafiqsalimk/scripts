using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    public Image currentEnergy;

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

       EnergyDrain();
       UpdateEnergy();
    }

    private void EnergyDrain()
    {
        if(kecepatan == kecepatanLari)
        {
            if(input_x > 0 || input_z > 0)
            {
                energy -= 10 * Time.deltaTime;
            }
           
        }
        else 
        {
            energy += 15 * Time.deltaTime;
        }


    }
    private void UpdateEnergy()
    {
        float ratio = energy / maxEnergy;
        currentEnergy.rectTransform.localScale = new Vector3(ratio, 1, 1);
    }
}

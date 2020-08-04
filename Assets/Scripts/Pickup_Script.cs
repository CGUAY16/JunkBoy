using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup_Script : MonoBehaviour
{
    public GameObject Gear_Prefab;
    public int Gear_Value;
    public int Gear_Quantity;
    public bool Found_Gear;
    public bool Picked_Up_Gear;
    public GameObject Prompt;
    public GameObject Generator_Prompt;
    public Text Gears_Picked_Up;
    public GameObject Gear;
    public bool Found_Generator;
    public Transform Gear_Spawn;
    public bool Generator_On;

    public void Start()
    {
        Generator_Prompt.SetActive(false);
        Prompt.SetActive(false);
    }

    public void Update()
    {
        Gears_Picked_Up.text = "" + Gear_Quantity;

        if (Found_Gear == true && Input.GetKeyDown("e"))
        {
            Gear_Quantity = Gear_Value + 1;
            Gear.SetActive(false);
            Picked_Up_Gear = true;
        }

        if (Found_Generator == true && Input.GetKeyDown("e"))
        {
            Instantiate(Gear_Prefab).transform.position = Gear_Spawn.transform.position;
            Generator_On = true;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "Gear" && Gear.activeSelf == true)
        {
            Prompt.SetActive(true);
            Found_Gear = true;
        }

        if (col.name == "Generator" && Picked_Up_Gear == true && Generator_On == false)
        {
            Generator_Prompt.SetActive(true);
            Found_Generator = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.name == "Gear")
        {
            Prompt.SetActive(false);
            Found_Gear = false;
        }

        if (col.name == "Generator")
        {
            Generator_Prompt.SetActive(false);
            Found_Generator = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public BasicVehicleMotor basicVehicle;
    public KeyCode shopButton;
    public Canvas shopCanvas;
    public Transform[] itemUI;
    public Item[] items;


    public bool inShop;
    // Start is called before the first frame update
    void Start()
    {
        CloseShop();
        basicVehicle = GetComponent<BasicVehicleMotor>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(shopButton))
        {
            inShop = !inShop;
            if (inShop)
                OpenShop();
            else
                CloseShop();
        }
    }

    public void OpenShop()
    {
        GenerateItems();
        Time.timeScale = 0;
        shopCanvas.enabled = true;
        for (int i = 0; i < 3; i++)
        {
            Debug.Log(i);
            Item currItem = items[i];
            string descSpeed = "Speed: +" + currItem.speed;
            string descAcceleration = "Acceleration: +" + currItem.acceleration;
            string descBoost = "Boost: +" + currItem.boost;
            string descSteering = "Steering: +" + currItem.steering;
            itemUI[i].Find("Title").GetComponent<Text>().text = currItem.title;
            itemUI[i].Find("Description").GetComponent<Text>().text = descSpeed + "\n" +  descAcceleration +"\n" + descBoost + "\n" + descSteering;
        }
    }
    
    public void GenerateItems()
    {
        for(int i =0; i < 3; i++)
        {
            Item newItem = new Item();
            newItem.GenerateItem();
            items[i] = (newItem);
        }
    }

    public void CloseShop()
    {
        Time.timeScale =1;
        shopCanvas.enabled = false;
    }

    public void Click0()
    {
        Transform button = itemUI[0];
        Debug.Log(items[0].title);
        Equip(items[0]);
        CloseShop();
    }

    public void Click1()
    {
        Transform button = itemUI[1];
        Debug.Log(items[0].title);
        Equip(items[1]);
        CloseShop();
    }

    public void Click2()
    {
        Transform button = itemUI[2];
        Debug.Log(items[0].title);
        Equip(items[2]);
        CloseShop();
    }

    public void Equip(Item item)
    {
        return;
        basicVehicle.maxSpeed += item.speed;
        basicVehicle.accelerationPower += item.acceleration;
        basicVehicle.boostPower += item.boost;
        basicVehicle.steeringPower += item.steering;
    }
}

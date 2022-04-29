using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpweapon : MonoBehaviour, IInventoryItem
{
    //public GameObject WeaponPosition;
    public GameObject Slots;
    public List<GameObject> WeaponList = new List<GameObject>();
    public string Name
    {
        get
        {
            return "PickUpweapon";
        }
    }

    public Sprite _Image = null;
    public Sprite Image
    {
        get { return _Image; }
    }

    public void OnPickup()
    {
        Debug.Log(WeaponList.Count);
        gameObject.transform.parent = Slots.transform;
        //gameObject.transform.position = WeaponPosition.transform.position;
        for (int i = 0; i < Slots.transform.childCount; i++)
        {
            Debug.Log(Slots.transform.GetChild(i));
            Slots.transform.GetChild(i).GetComponent<MonoBehaviour>();
            if (true)
            {

            }
        }

        WeaponList.Add(gameObject);
    }

}

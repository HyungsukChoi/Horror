using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance;
    public static bool inventoryActivated = false;


    // 필요한 컴포넌트
    [SerializeField]
    private GameObject go_InventoryBase;

    [SerializeField]
    private GameObject go_SlotsParent;

    private Slot[] slots;

    private void Awake()
    {
        
        //#region Singleton
        //if (Inventory.Instance == null)
        //    Inventory.Instance = this;
        //#endregion
    }

    // Start is called before the first frame update
    void Start()
    {
        slots = go_SlotsParent.GetComponentsInChildren<Slot>();
    }

    // Update is called once per frame
    void Update()
    {
        TryOpenInven();
    }

    void TryOpenInven()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            inventoryActivated = !inventoryActivated;

            if (inventoryActivated)
                OpenInventory();
            else
                CloseInventory();
        }    
    }
    void OpenInventory()
    {
        go_InventoryBase.SetActive(true);
    }

    void CloseInventory()
    {
        go_InventoryBase.SetActive(false);
    }


    public void AcquireItem(Item _item, int _count = 1)
    {
        
        if (Item.ItemType.Equipment != _item.itemType)
        {
            for (int i = 0; i < slots.Length; i++)
            {
                if (slots[i].item != null)
                {
                    if (slots[i].item.itemName == _item.itemName)
                    {
                        slots[i].SetSlotCount(_count);
                        return;
                    }
                }
            }
        }

        for(int i=0; i<slots.Length; i++)
        {
            if (slots[i].item != null)
            {
                if (slots[i].item.itemName == "")
                {
                    slots[i].AddItem(_item, _count);
                    return;
                }
            }
        }
    }
}

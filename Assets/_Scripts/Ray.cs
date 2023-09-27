using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ray : MonoBehaviour
{
    RaycastHit hit;

    private float range = 10f;
    private bool pickUpAble = false;
    public LayerMask layerMask;
    public Text actionText;

    [SerializeField]
    private Inventory theInventory;

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerRay();
    }

    void PlayerRay()
    {
        if (Physics.Raycast(this.transform.position, transform.forward, out hit, range, layerMask))
        {         
            Debug.DrawRay(this.transform.position, transform.forward * 1000f, Color.green);
            if (hit.collider.tag == "Item")
            {
                ItemInterAction();
            }
            else if(hit.collider.tag != "Item")
            {
                ItemInfoDisappear();
            }
        }
    }

    private void ItemInterAction()
    {
        ItemInfoAppear();
        // æ∆¿Ã≈€ »πµÊ
        if (Input.GetKey(KeyCode.G))
        {
            CanPickUp();
        }
    }
 

    private void CanPickUp()
    {
        if(pickUpAble)
        {
            // »§Ω√ ∏∏¶ ø¿∑˘ πÊ¡ˆ
            if(hit.transform != null)
            {
                Debug.Log(hit.transform.GetComponent<ItemPickUp>().item.name + "»πµÊ");
                theInventory.AcquireItem((hit.transform.GetComponent<ItemPickUp>().item));
                Destroy(hit.transform.gameObject);
                ItemInfoDisappear();
            }
            else
            {
                ItemInfoDisappear();
            }
        }
    }

    // æ∆¿Ã≈€ ¡§∫∏ ≥Î√‚
    private void ItemInfoAppear()
    {
        pickUpAble = true;
        actionText.gameObject.SetActive(true);
        actionText.text = hit.transform.GetComponent<ItemPickUp>().item.name;
    }

    private void ItemInfoDisappear()
    {
        pickUpAble = false;
        actionText.gameObject.SetActive(false);
        // actionText.text = hit.transform.GetComponent<ItemPickUp>().item.name + "»πµÊ";
    }
}

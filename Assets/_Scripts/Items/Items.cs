using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Items : MonoBehaviour
{

    public abstract void Get(GameObject Item);
    public abstract void Use(GameObject Item);
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyButton : MonoBehaviour
{
    public GameObject b1;
    public GameObject b2;

    public void buttonDestroyEvent()
    {
        b1.SetActive(false);
        b1.SetActive(false);
    }
}

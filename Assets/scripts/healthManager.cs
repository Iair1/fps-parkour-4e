﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int vida;
    public UImanager UImanager;
    void Start()
    {
        UImanager = FindObjectOfType<UImanager>();
        UImanager.updateHealthText(vida.ToString());
    }

    public bool UpdateHealth(int cosososa)
    {
        if (vida + cosososa <= 0)
        {
            Debug.Log("game ovr");
            return false;
        }
        else
        {
            vida += cosososa;
            UImanager.updateHealthText(vida.ToString());
            return true;
        }
    }
}

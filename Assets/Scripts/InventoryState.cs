﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryState : MonoBehaviour
{
    public GameObject inventoryPanel;


    public void OpenInventory()
    {
        inventoryPanel.SetActive(true);
        Cursor.lockState = CursorLockMode.None;

    }

    public void CloseInventory()
    {
        inventoryPanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (inventoryPanel.activeSelf)
            {
                CloseInventory();
            }
            else
            {
                OpenInventory();
            }


        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
                CloseInventory();       

        }
    }

}

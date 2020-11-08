using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;

public class CardProperties : MonoBehaviour
{
    public bool flying;
    public bool taunt;
    public bool firststrike;
    public bool flash;
    public bool haste;
    public bool lifelink;
    public bool reach;
    public bool vigilance;
    public bool hexproof;

    private void Start()
    {
        String desc = gameObject.transform.Find("CardDescription").GetComponent<TextMeshProUGUI>().text;
        if (desc.IndexOf("Flying") != -1)
        {
            flying = true;
        }
        if (desc.IndexOf("Taunt") != -1)
        {
            taunt = true;
        }
        if (desc.IndexOf("First strike") != -1)
        {
            firststrike = true;
        }
        if (desc.IndexOf("Flash") != -1)
        {
            flash = true;
        }
        if (desc.IndexOf("Haste") != -1)
        {
            haste = true;
        }
        if (desc.IndexOf("Lifelink") != -1)
        {
            lifelink = true;
        }
        if (desc.IndexOf("Reach") != -1)
        {
            reach = true;
        }
        if (desc.IndexOf("Vigilance") != -1)
        {
            vigilance = true;
        }
        if (desc.IndexOf("Hexproof") != -1)
        {
            hexproof = true;
        }
    }

}

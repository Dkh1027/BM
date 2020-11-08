using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Tweak : MonoBehaviour
{
    int ID;
    public GameObject deckManager;
    public void AddCard()
    {
        deckManager.GetComponent<DeckHandler>().AddCard(gameObject.transform.Find("CardName").GetComponent<TextMeshProUGUI>().text, gameObject.transform.GetSiblingIndex());
    }

    public int getID()
    {
        return ID;
    }

    public void setID(int id)
    {
        ID = id;
    }

    public void DeleteSelfFORCARDINDECK()
    {
        gameObject.transform.parent.parent.parent.Find("DeckManager").GetComponent<DeckHandler>().RemoveCard(ID);
        Destroy(gameObject);
    }
}

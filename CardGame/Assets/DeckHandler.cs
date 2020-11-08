using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeckHandler : MonoBehaviour
{
    private List<int> cardIDs;
    public GameObject buttonPrefab;
    public GameObject deck;
    public GameObject gameManager;
    private int cardsInDeck = 0;

    private void Start()
    {
        cardIDs = new List<int>();
        
    }
    public void AddCard(String name, int ID)
    {
        if (cardsInDeck == 17)
            return;
        GameObject deckPanel = gameObject.transform.parent.Find("Canvas").Find("DeckPanel").gameObject;
        for (int i = 0; i < deckPanel.transform.childCount; i++)
        {
            if (deckPanel.transform.GetChild(i).GetComponent<Tweak>().getID() == ID)
                return;
        }
        cardsInDeck += 1;
        GameObject newCard = (GameObject)Instantiate(buttonPrefab);
        newCard.transform.SetParent(deck.transform);
        newCard.transform.Find("CardName").GetComponent<TextMeshProUGUI>().SetText(name);
        newCard.GetComponent<Tweak>().setID(ID);
        cardIDs.Add(ID);
        newCard.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
    }

    public void RemoveCard(int ID)
    {
        cardsInDeck--;
        cardIDs.Remove(ID);
    }

    public void Proceed()
    {
        if (cardsInDeck != 17)
            return;
        gameManager.GetComponent<GameHandler>().SetCards(cardIDs);
        /// load every ID in a vector 
        SceneManager.LoadScene("GameScene2");
    }
}

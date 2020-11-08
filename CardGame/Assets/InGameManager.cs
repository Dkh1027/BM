using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InGameManager : MonoBehaviour
{
    private List<int> playerCards;
    private List<int> AICards;
    private int HeroID;

    public GameObject playerHand;
    public GameObject AIHand;

    public GameObject playerArena;
    public GameObject AIArena;

    public GameObject playerPanel;
    public GameObject AIPanel;

    bool playerReady;
    public GameObject selectedCard;

    int playerMana;
    int AIMana;
    private void Start()
    {
        selectedCard = new GameObject();
        var gO = GameObject.Find("GameManager");
        playerCards = new List<int>();
        AICards = new List<int>();
        playerCards = gO.GetComponent<GameHandler>().getPlayerCards();
        AICards = gO.GetComponent<GameHandler>().getAICards();

        for (int i = 0; i < 5; i++)
        {
            GameObject temp = GameObject.Find("THolder");
            int ID = playerCards.ElementAt(0);
            playerCards.RemoveAt(0);
            var newCard = (GameObject)Instantiate(temp.transform.GetChild(ID).gameObject);
            newCard.AddComponent<BoxCollider2D>();
            newCard.transform.SetParent(playerHand.transform);
            newCard.SetActive(true);
            newCard.transform.localScale = new Vector3(0.4f, 0.4f, 0);
        }
        for (int i = 0; i < 5; i++)
        {
            var newSprite = GameObject.Find("ATWK").transform.Find("Button").GetComponent<Image>().sprite;
            GameObject temp = GameObject.Find("THolder");
            int ID = AICards.ElementAt(0);
            AICards.RemoveAt(0);
            var newCard = (GameObject)Instantiate(temp.transform.GetChild(ID).gameObject);
            newCard.transform.SetParent(AIHand.transform);
            newCard.SetActive(true);
            newCard.transform.localScale = new Vector3(0.4f, 0.4f, 0);
            newCard.GetComponent<Button>().interactable = false;
            for (int j = 0; j < newCard.transform.childCount; j++)
            {
                var child1 = newCard.transform.GetChild(j).gameObject;
                    child1.SetActive(false);
            }
            newCard.GetComponent<Image>().sprite = newSprite;

        }
        HeroID = GameObject.Find("GameManager").GetComponent<GameHandler>().getHeroID();
        GameObject temp2 = GameObject.Find("HHolder");
        var hero = (GameObject)Instantiate(temp2.transform.GetChild(HeroID).GetChild(0).gameObject);
        var heroSpell = (GameObject)Instantiate(temp2.transform.GetChild(HeroID).GetChild(1).gameObject);
        hero.transform.SetParent(playerPanel.transform);
        heroSpell.transform.SetParent(playerPanel.transform);
        hero.SetActive(true);
        heroSpell.SetActive(true);
        hero.transform.position = new Vector3(hero.transform.position.x, hero.transform.position.y, -1);
        heroSpell.transform.position = new Vector3(heroSpell.transform.position.x, heroSpell.transform.position.y, -1);
        HeroID = UnityEngine.Random.Range(0, 3);
        GameObject temp3 = GameObject.Find("HHolder");
        var hero2 = (GameObject)Instantiate(temp3.transform.GetChild(HeroID).GetChild(0).gameObject);
        var heroSpell2 = (GameObject)Instantiate(temp3.transform.GetChild(HeroID).GetChild(1).gameObject);
        heroSpell2.transform.SetParent(AIPanel.transform);
        hero2.transform.SetParent(AIPanel.transform);
        hero2.SetActive(true);
        heroSpell2.SetActive(true);
        hero2.transform.position = new Vector3(hero2.transform.position.x, hero2.transform.position.y, -1);
        heroSpell2.transform.position = new Vector3(heroSpell2.transform.position.x, heroSpell2.transform.position.y, -1);
        hero2.GetComponent<Button>().interactable = false;
        heroSpell2.GetComponent<Button>().interactable = false; ;
    }

    public void EndTurn()
    {
        ////// +1 mana
        /// urmeaza turul aiului
        
    }

    public void SelectCard(ref GameObject card)
    {
        selectedCard = card;
    }

    public void tryPlaceCard()
    {
        /// if mana...
        selectedCard.transform.SetParent(playerArena.transform);
    }
}

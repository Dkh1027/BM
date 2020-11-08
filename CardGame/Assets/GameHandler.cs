using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    private List<int> playerCards;
    private List<int> AICards;
    private int heroID;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        playerCards = new List<int>();
        AICards = new List<int>();
    }
    public void SetCards(List<int> cards)
    {
        playerCards = cards;
        for (int i = 0; i < 17; i++)
        {
            int random = Random.Range(1, 70);
            bool isInList = AICards.IndexOf(random) != -1;
            if (isInList)
            {
                i--;
                continue;
            }
            AICards.Add(random);
        }
    }

    public List<int> getPlayerCards()
    {
        return playerCards;
    }
    public List<int> getAICards()
    {
        return AICards;
    }
    public void setHeroID(int ID)
    {
        heroID = ID;
    }
   public int getHeroID()
    {
        return heroID;
    }

}

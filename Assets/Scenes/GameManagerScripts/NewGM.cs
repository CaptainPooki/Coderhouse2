using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class NewGM : MonoBehaviour
{
    // Start is called before the first frame update
public List<Card> deck = new List<Card>();
public List<Card> discardPile = new List<Card>();
public Transform[] cardSlots;
public bool[] availableCardSlots;
public Transform[] cardField;
public bool[] availableCardField;
public int firstEmptySlot;


public TMP_Text deckSizeText;
public TMP_Text discardPileText;
public void Drawcard()
{
    if(deck.Count>=1)
    {
        Card randCard = deck[Random.Range(0,deck.Count)];

        for (int i = 0; i <availableCardSlots.Length; i++)
        {if (availableCardSlots[i] == true)
                {
                randCard.gameObject.SetActive(true);
                randCard.handIndex = i;
                randCard.transform.position = cardSlots[i].position;
                randCard.hasBeenPlayed = false;
                availableCardSlots[i] = false;
                deck.Remove(randCard);
                return;
                }
            }
        }
    }
public void Shuffle()
{
    if(discardPile.Count >=1)
        foreach(Card card in discardPile)
    {
        deck.Add(card);
    }
    discardPile.Clear();
}
private void Start()
{
    firstEmptySlot = 1;
}
private void Update() 
{
    deckSizeText.text = deck.Count.ToString();
    discardPileText.text = discardPile.Count.ToString();
}
public int UpdateSlot()
{
    Debug.Log((firstEmptySlot +1)%5);
    firstEmptySlot = Mathf.Max (1,(firstEmptySlot +1)%5);
    return firstEmptySlot;
}

}

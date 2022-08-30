using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{

    public int handIndex;
    private NewGM gm;
    public int fieldIndex;
    
public bool hasBeenPlayed;
private void Start() 
{
    gm=FindObjectOfType<NewGM>(); 
    hasBeenPlayed = false;   
    }

private void OnMouseDown()
    {
        Debug.Log("cliki");
        if(hasBeenPlayed==false){
            transform.position+= Vector3.up*3;
            hasBeenPlayed = true;
            gm.availableCardSlots[handIndex] = true;
            transform.position = gm.cardField[gm.firstEmptySlot].position;
            Invoke("MoveToDiscardPile",7f);
            fieldIndex = gm.firstEmptySlot;
            gm.UpdateSlot();
            
        }
    }
    void MoveToDiscardPile()
    {
        gm.firstEmptySlot = Mathf.Min(fieldIndex, gm.firstEmptySlot);
        gm.discardPile.Add(this);
        gameObject.SetActive(false);
    }
}

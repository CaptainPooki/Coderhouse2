using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class GameManager_Master : MonoBehaviour
{
    public GameObject PFTestCard;
    public GameObject Player;
    public GameObject Enemy;
    enum PhaseList {Draw, Play, Resolution};
    PhaseList Phase;
    

    
    void Start()
    {
        Phase = PhaseList.Draw;
    }


    void Update()
    {
        if (Phase==PhaseList.Draw)
        {
            DrawCards(5);
            Phase = PhaseList.Play;
        }
        else if (Phase==PhaseList.Play)
        {
            
        }
        else if (Phase==PhaseList.Resolution)
        {

        }
    }
    
    void DrawCards(int drawNumber)
    {
        float offset = 5;
        //z35
        foreach (int Carta in Enumerable.Range(0,drawNumber))
        {
            Vector3 Position = new Vector3 (-9.5f + offset * Carta,2f,-20f);
            GameObject instance = Instantiate(PFTestCard, Position, Quaternion.identity, Player.transform);
            Position = new Vector3 ((-9.5f + offset * Carta)*-1,0f,35f);
            instance = Instantiate(PFTestCard, Position, Quaternion.identity, Enemy.transform);
            
        }
        

    }

}


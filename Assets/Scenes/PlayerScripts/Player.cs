using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public GameObject Playcard;
    public Color m_OriginalColor;
    public MeshRenderer m_Renderer;
    public Color m_MouseOverColor = Color.white;
    public bool hasBeenPlayed;
    // Start is called before the first frame update
    void Start()
    {
        //m_Renderer = GetComponent<null>
        m_OriginalColor = m_Renderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseOver()
    {
    
        m_Renderer.material.color = m_MouseOverColor;
    }

    void OnMouseExit()
    {
        m_Renderer.material.color = m_OriginalColor;
    }
    private void OnMouseDown()
    {
        if(hasBeenPlayed==false){
            transform.position+= Vector3.up*5;
            hasBeenPlayed = true;
        }
    }
    
}

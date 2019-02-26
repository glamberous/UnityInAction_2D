using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour
{
    [SerializeField] private GameObject cardBack;
    [SerializeField] private SceneController controller;

    private int _id;
    public int id
    {
        get => _id;
    }

    public void SetCard (int id, Sprite image)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }

    public void OnMouseDown()
    {
        if(cardBack.activeSelf && controller.canReveal)
        {
            cardBack.SetActive(false);
            controller.CardRevealed(this);
            Debug.Log("Card Clicked.");
        }
    }

    public void Unreveal()
    {
        cardBack.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

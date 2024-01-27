using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZoneHandler : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        CardDragHandler card = eventData.pointerDrag.GetComponent<CardDragHandler>();
        if (card != null)
        {
            card.DestroyCard(); // Destroy the card
        }
    }
}


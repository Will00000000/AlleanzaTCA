using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ArrastaItem : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [HideInspector] public Transform parentDepoisArrastar;
    public Image image;

    public void OnBeginDrag(PointerEventData eventData)
    {
        parentDepoisArrastar = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void EndDrag(PointerEventData eventData)
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            GameObject objetoAbaixo = eventData.pointerEnter;

            if (objetoAbaixo != null && objetoAbaixo.transform.parent != null && objetoAbaixo.transform.parent.CompareTag("SlotInventario"))
            {
                parentDepoisArrastar = objetoAbaixo.transform;
            }
        }

        transform.SetParent(parentDepoisArastar);
        image.raycastTarget = true;
    }
}
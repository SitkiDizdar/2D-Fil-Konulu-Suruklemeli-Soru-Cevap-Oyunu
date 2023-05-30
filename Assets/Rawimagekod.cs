using UnityEngine;
using UnityEngine.EventSystems;

public class Rawimagekod : MonoBehaviour, IDragHandler

{
    private Vector3 offset;

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 newPosition = transform.position + new Vector3(eventData.delta.x, eventData.delta.y, 0f);
        transform.position = newPosition;
    }
}
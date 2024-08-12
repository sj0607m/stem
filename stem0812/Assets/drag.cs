using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class drag : MonoBehaviour, IDragHandler
{
    [SerializeField] private RectTransform dragRectTransform; //�����ϴ������
    [SerializeField] private Canvas canvas;//ĵ��������

    public void OnDrag(PointerEventData eventData)
    {
        dragRectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;//�巡��
    }

}
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class DisplayText : MonoBehaviour, IPointerEnterHandler
{
    public GameObject text;
    public string evidenceText;
    private bool displayed = false;
    public void Start()
    {
        text = GameObject.FindGameObjectWithTag("TestText");
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!displayed)
        {
            text.SetActive(true);
            text.GetComponent<TextMeshProUGUI>().text = evidenceText;
            text.transform.position = this.transform.position;
            eventData.Reset();
            displayed = true;
        }
    }
}

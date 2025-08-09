using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonTextScaler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public TextMeshProUGUI buttonText;
    public float scaleMultiplier = 1.2f;
    public float clickScaleMultiplier = 0.9f;
    private float originalFontSize;


    private void Start()
    {
        if (buttonText == null)
            buttonText = GetComponentInChildren<TextMeshProUGUI>();

        originalFontSize = buttonText.fontSize;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonText.fontSize = originalFontSize * scaleMultiplier;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        buttonText.fontSize = originalFontSize;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonText.fontSize = originalFontSize * clickScaleMultiplier;
    }
}


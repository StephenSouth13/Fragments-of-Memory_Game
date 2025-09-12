/*
using UnityEngine;
using UnityEngine.EventSystems;

public class tooltipTrigger : MonoBehaviour
{
    public string tooltipText = "This is a tooltip!";
    public float showDelay = 0.5f;
    private Coroutine showTooltipCoroutine;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (showTooltipCoroutine != null)
            StopCoroutine(showTooltipCoroutine);

        showTooltipCoroutine = StartCoroutine(ShowTooltipDelayed());
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (showTooltipCoroutine != null)
        {
            StopCoroutine(showTooltipCoroutine);
            showTooltipCoroutine = null;
        }

        if (tooltipManager.Instance != null)
            tooltipManager.Instance.HideTooltip();
    }

    private System.Collections.IEnumerator ShowTooltipDelayed()
    {
        yield return new WaitForSeconds(showDelay);

        if (tooltipManager.Instance != null)
            tooltipManager.Instance.ShowTooltip(tooltipText);
    }

    // Alternative method for 3D objects without UI
    void OnMouseEnter()
    {
        Debug.Log("TooltipTrigger: 3D Mouse entered object: " + gameObject.name);

        if (showTooltipCoroutine != null)
            StopCoroutine(showTooltipCoroutine);

        showTooltipCoroutine = StartCoroutine(ShowTooltipDelayed());
    }

    void OnMouseExit()
    {
        Debug.Log("TooltipTrigger: 3D Mouse exited object: " + gameObject.name);

        if (showTooltipCoroutine != null)
        {
            StopCoroutine(showTooltipCoroutine);
            showTooltipCoroutine = null;
        }

        if (tooltipManager.Instance != null)
            tooltipManager.Instance.HideTooltip();
        else
            Debug.LogError("TooltipTrigger: tooltipManager instance not found in 3D mode!");
    }
}
*/


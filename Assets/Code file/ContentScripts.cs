using UnityEngine;

public class ContentScripts : MonoBehaviour
{
    public string message;

    private void OnMouseEnter()
    {
        TooltipManager._intance.SetandShowToolTips(message);
    }

    private void OnMouseExit()
    {
        TooltipManager._intance.HideToolTip();
    }
}

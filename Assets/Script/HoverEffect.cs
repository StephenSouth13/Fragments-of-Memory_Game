using UnityEngine;

public class HoverEffect: MonoBehaviour
{
    public Vector3 hoverOffset = new Vector3(-0.5f, 0f, 0f);
    public float movespeed = 20f;

    private Vector3 originalPosition;
    private bool isHovering = true;

    public static bool hoverEnabled = false;

    void Start()
    {
        originalPosition = transform.localPosition;
        //hoverEnabled = true; // Bật hover effect khi bắt đầu
    }

    void Update()
    {
        if (!hoverEnabled) return;

        // Nếu object đã bị kéo đi xa thì bỏ qua hover để không kéo lại
        if (Vector3.Distance(transform.localPosition, originalPosition) > 0.5f)
            return;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        int layerMask = ~LayerMask.GetMask("BookShelf");
        //int layerMask = LayerMask.GetMask("Book");
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            isHovering = hit.transform.gameObject == gameObject;
            Debug.Log($"Hovering: {isHovering}, Hit: {hit.transform.name}");
        }
        else
        {
            isHovering = false;
        }

        Vector3 target = isHovering ? originalPosition + hoverOffset : originalPosition;
        transform.localPosition = Vector3.Lerp(transform.localPosition, target, movespeed * Time.deltaTime);
    }
}

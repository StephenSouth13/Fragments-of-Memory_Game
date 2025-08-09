using UnityEngine;

public class ClickToZoom: MonoBehaviour
{
    public Camera mainCamera;
    public float ZoomSpeed = 3f; 

    private Transform target;
    private bool isZoomed = false;

    private Vector3 originalCameraPosition;
    private Quaternion originalCameraRotation;
    private void Start()
    {
        originalCameraPosition = mainCamera.transform.position;
        originalCameraRotation = mainCamera.transform.rotation;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                ZoomTarget zoomTarget = hit.transform.GetComponent<ZoomTarget>();
                //Tính vị trí camera cần đến (phía trước vật thẻ một đoạn)
                if (zoomTarget != null && zoomTarget.zoomPoint != null)
                {
                    target = zoomTarget.zoomPoint;
                    isZoomed = true; // Bắt đầu zoom
                    HoverEffect.hoverEnabled = false; // Tắt hiệu ứng hover khi zoom
                }
                else
                {
                    Debug.LogWarning("ZoomTarget hoặc zoomPoint không được gán!");
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            target = null;
            isZoomed = false;
            HoverEffect.hoverEnabled = false;
            mainCamera.transform.rotation = originalCameraRotation;
            mainCamera.transform.position = originalCameraPosition; // Quay về vị trí ban đầu
            
        }
        
        if (isZoomed)
        {
            Transform zoomTarget = target ?? transform;

            mainCamera.transform.position = Vector3.Lerp(
                mainCamera.transform.position, zoomTarget.position, ZoomSpeed * Time.deltaTime);
            mainCamera.transform.rotation = Quaternion.Lerp(
                mainCamera.transform.rotation, zoomTarget.rotation, ZoomSpeed * Time.deltaTime);

            if (Vector3.Distance(mainCamera.transform.position, zoomTarget.position) < 0.5f)
            {
                isZoomed = false;

                if (target != null)
                {
                    HoverEffect.hoverEnabled = true;
                }
            }
        }
    }
}

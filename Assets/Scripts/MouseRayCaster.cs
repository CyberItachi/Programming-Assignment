using UnityEngine;
using TMPro;

public class MouseRayCaster : MonoBehaviour
{
    [SerializeField] TMP_Text X_Co;
    [SerializeField] TMP_Text Y_Co;
    Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            GroundInfo groundInfo = hit.collider.GetComponent<GroundInfo>();

            if (groundInfo != null)
            {
                int x = groundInfo.GetX();
                int y = groundInfo.GetY();
                X_Co.text = $"{x}";
                Y_Co.text = $"{y}";
            }    
        }
        else 
            {
                X_Co.text = "0";
                Y_Co.text = "0";
            }
    }
}

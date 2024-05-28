using UnityEngine;

public class GroundInfo : MonoBehaviour
{
    [SerializeField] GameObject _highlight;
    int xPosition;
    int yPosition;

    public void SetGroundInfo(int xPosition, int yPosition)
    {
        this.xPosition = xPosition;
        this.yPosition = yPosition;
    }

    public int GetX()
    {
        return xPosition;
    }
    public int GetY() 
    {
        return yPosition;
    }

    private void OnMouseEnter()
    {
        _highlight.SetActive(true);
    }

    private void OnMouseExit()
    {
        _highlight.SetActive(false);
    }
}

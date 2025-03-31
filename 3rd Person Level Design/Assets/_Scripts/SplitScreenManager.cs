using UnityEngine;

public class SplitScreenSetup : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    public bool horizontalSplit = true;

    void Start()
    {
        SetupSplitScreen();
    }

    public void SetupSplitScreen()
    {
        if (horizontalSplit)
        {
            // Horizontal split (side by side)
            camera1.rect = new Rect(0, 0, 0.5f, 1);
            camera2.rect = new Rect(0.5f, 0, 0.5f, 1);
        }
        else
        {
            // Vertical split (top/bottom)
            camera1.rect = new Rect(0, 0.5f, 1, 0.5f);
            camera2.rect = new Rect(0, 0, 1, 0.5f);
        }
    }
}
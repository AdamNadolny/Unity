using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousehide : MonoBehaviour
{
    bool isLocked;
    // Start is called before the first frame update
    void Start()
    {
        SetCursorLock(true);
    }

    void SetCursorLock(bool isLocked)
    {
        this.isLocked = isLocked;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = !isLocked;
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SetCursorLock(!isLocked);
        }
    }
}

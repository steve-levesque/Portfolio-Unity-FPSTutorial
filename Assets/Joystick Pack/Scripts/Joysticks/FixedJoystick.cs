using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedJoystick : Joystick
{
    void Update()
    {
#if UNITY_ANDROID
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
#endif
    }
}
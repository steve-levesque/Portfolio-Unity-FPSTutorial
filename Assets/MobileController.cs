using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileController : MonoBehaviour
{
    public FixedButton JumpButton;
    public FixedButton ShootButton;
    public FixedJoystick MoveJoystick;
    public FixedTouchField TouchField;

    public FixedButton Weapon1;
    public FixedButton Weapon2;
    public FixedButton Weapon3;

    int counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        var fps = GetComponent<PlayerCharacterController>();
        var wfps = GetComponent<PlayerWeaponsManager>();

        fps.JumpButtonPressed = JumpButton.Pressed;
        fps.RunAxis = MoveJoystick.Direction;
        fps.LookAxis = TouchField.TouchDist;

        wfps.ShootButtonPressed = ShootButton.Pressed;


        if (Weapon1.Pressed)
            wfps.MobileWeaponChosen = 1;
        if (Weapon2.Pressed)
            wfps.MobileWeaponChosen = 2;
        if (Weapon3.Pressed)
            wfps.MobileWeaponChosen = 3;
    }
}

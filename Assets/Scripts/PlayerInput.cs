using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerInput : MonoBehaviour
    {
        private Rigidbody playerRigidbody;

        private void Awake()
        {
            playerRigidbody = GetComponent<Rigidbody>();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log("Press [A]");
            }

            if(Input.GetButtonDown(GlobalStringVars.JUMP_BUTTON))
            {
                Debug.Log("[Jump button] pressed");
            }

            if(Input.GetMouseButtonDown(0))
            {
                Debug.Log("Fire");
            }

            //Debug.Log(Input.GetAxis(GlobalStringVars.HORIZONTAL_AXIS));
            //Debug.Log(Input.GetAxis(GlobalStringVars.VERTICAL_AXIS));
        }
    }
}

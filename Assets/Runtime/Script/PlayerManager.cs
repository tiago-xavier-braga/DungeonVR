using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Haus.DugeonVR.player
{
    public class PlayerManager : MonoBehaviour
    {
        private Vector2 inputMoviment;
        [SerializeField] float velocityMoviment = 0.5f;
        public void Update()
        {
            Debug.Log(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick));

            inputMoviment = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);

            this.transform.Translate(new Vector3(inputMoviment.x * velocityMoviment, 0, inputMoviment.y * velocityMoviment));
        }
    }
}


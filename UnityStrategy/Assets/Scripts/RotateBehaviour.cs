using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

namespace UnityStrategy.Assets
{
    public class RotateBehaviour : MonoBehaviour, IAnimateBehaviour
    {
        [SerializeField] private float rotationSpeed = 30f;

        public void Animate()
        {
            Vector3 rotator = rotationSpeed * Time.deltaTime * Vector3.one;
            transform.Rotate(rotator);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

namespace UnityStrategy.Assets
{
    public class ScaleBehaviour : MonoBehaviour, IAnimateBehaviour
    {
        [SerializeField] private float scaleSpeed = 10f;

        private Vector3 minScale = new Vector3(0.1f, 0.1f, 0.1f);
        private float angle = 0.0f;

        public void Animate()
        {
            transform.localScale =
                minScale + Mathf.Abs(Mathf.Cos(angle)) * Vector3.one;
            angle += scaleSpeed * Time.deltaTime;
        }
    }
}
using UnityEngine;
using System.Collections.Generic;

namespace LightScripts
{
    public class LightSwitcher : MonoBehaviour
    {
        private readonly List<Light> _regularLights = new List<Light>();
        
        [Range(0.0f, 100.0f)]
        [SerializeField] public float currentIntensity = 1.0f;
        
        private void Start()
        {
            Light[] allLights = GetComponentsInChildren<Light>();

            foreach (Light i in allLights)
            {
                if (i.GetComponent<BlinkingLight>() == null)
                {
                    _regularLights.Add(i);
                }
            }
        }

        private void Update()
        {
            foreach (Light i in _regularLights)
            {
                if (i != null)
                {
                    i.intensity = currentIntensity;
                }
            }
        }
    }
}
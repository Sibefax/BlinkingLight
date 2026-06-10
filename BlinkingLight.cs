using UnityEngine;

namespace LightScripts
{
    public class BlinkingLight : MonoBehaviour
    {
        [SerializeField] private LightSwitcher switcher;
        [SerializeField] private string blinkPattern = "mmnnmmehfeoomm";
        [SerializeField] private float speed = 10f;

        private float _maxIntensity;
        private Light _currentLight;
        private float _indexTracker;

        private void Start()
        {
            _currentLight = GetComponent<Light>();
            
            if (string.IsNullOrEmpty(blinkPattern)) blinkPattern = "m";
        }
        
        private void Update()
        {
            if (switcher == null || _currentLight == null || blinkPattern.Length == 0)
            {
                return;
            }
            
            _maxIntensity = switcher.currentIntensity;
            
            _indexTracker += Time.deltaTime * speed;
            
            int currentIndex = Mathf.FloorToInt(_indexTracker) % blinkPattern.Length;
            
            char currentLetter = blinkPattern[currentIndex];
            
            float brightnessFactor = Mathf.Clamp01((currentLetter - 'a') / 25f);
            
            _currentLight.intensity = brightnessFactor * _maxIntensity;
        }
    }
}
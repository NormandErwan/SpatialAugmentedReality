using UnityEngine;

namespace NormandErwan.SpatialAugmentedReality
{
    public class ActivateDisplays : MonoBehaviour
    {
        void Start()
        {
            var cameras = FindObjectsOfType<Camera>();
            foreach (var camera in cameras)
            {
                int index = camera.targetDisplay;
                if (index < Display.displays.Length)
                {
                    Display.displays[index].Activate();
                }
            }
        }
    }
}

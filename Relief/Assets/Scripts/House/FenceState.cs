using UnityEngine;

namespace House
{
    public class FenceState : MonoBehaviour
    {
        [SerializeField] private GameObject fence;

        public void SetActiveFence(bool state) => 
            fence.SetActive(state);
    }
}
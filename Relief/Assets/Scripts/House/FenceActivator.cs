using System.Collections.Generic;
using UnityEngine;

namespace House
{
    public class FenceActivator : MonoBehaviour
    {
        private List<FenceState> fenceStates = new();

        public void AddFenceState(FenceState fenceState) => 
            fenceStates.Add(fenceState);

        public void SetFenceActive(bool state)
        {
            foreach (var fenceState in fenceStates) 
                fenceState.SetActiveFence(state);
        }
    }
}
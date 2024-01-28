using System.Collections.Generic;
using House;
using UnityEngine;

namespace FenceActivator
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
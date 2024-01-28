using System.Collections.Generic;
using UnityEngine;

namespace House
{
    public class FenceSide : MonoBehaviour
    {
        [SerializeField] private LayerMask layerMask;
        
        private readonly List<Transform> _fencePartsHolders = new();
        private float _fenceYCenter = 1f;
        private float yIndex;

        private void Start() => 
            InitFenceSideParts();

        private void OnTriggerStay(Collider other)
        {
            if (other.gameObject.CompareTag("Relief")) 
                ChangeFenceHeight();
        }

        private void OnTriggerExit(Collider other) => 
            ChangeFenceHeight(true);

        private void InitFenceSideParts()
        {
            foreach (Transform child in transform) 
                _fencePartsHolders.Add(child);

            if (_fencePartsHolders.Count != 0)
            {
                yIndex = _fencePartsHolders[0].GetChild(0).localPosition.y;
                _fenceYCenter = yIndex / 2 - yIndex / 10;
            }
        }

        private void ChangeFenceHeight(bool isReturnToDefault = false)
        {
            foreach (var fencePart in _fencePartsHolders)
            {
                if (isReturnToDefault)
                {
                    ReturnToDefault(fencePart);

                    continue;
                }

                var rayOrigin = new Vector3(fencePart.position.x, 20, fencePart.position.z);

                if (Physics.Raycast(rayOrigin, -Vector3.up, out var hit, 20f, ~layerMask))
                    if (hit.collider.gameObject.CompareTag("Relief"))
                        LiftFencePart(hit, fencePart);
                    else
                        ReturnToDefault(fencePart);
            }
        }

        private void LiftFencePart(RaycastHit hit, Transform fencePart)
        {
            var position = fencePart.position;
            position = new Vector3(position.x, hit.point.y - _fenceYCenter, position.z);
            fencePart.position = position;
        }

        private void ReturnToDefault(Transform fencePart)
        {
            var position = fencePart.position;
            position = new Vector3(position.x, 0, position.z);
            fencePart.position = position;
        }
    }
}

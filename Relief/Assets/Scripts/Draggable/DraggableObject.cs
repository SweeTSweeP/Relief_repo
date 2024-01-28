using UnityEngine;

namespace Draggable
{
    public class DraggableObject : MonoBehaviour
    {
        [SerializeField] private Transform root;
        [SerializeField] private Collider collider;

        private bool _isSelected;
        private Vector3 _mousePosition;

        private void OnMouseDown()
        {
            collider.enabled = false;
            _isSelected = true;
        }

        private void OnMouseUp()
        {
            collider.enabled = true;
            _isSelected = false;
        }

        private void Update()
        {
            if (_isSelected)
            {
                GetMousePosition();
                ChangePosition();
            }
        }
        
        private void GetMousePosition()
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (!Physics.Raycast(ray, out var hit)) return;
            
            if (hit.collider.gameObject.CompareTag("Ground")) _mousePosition = hit.point;

            _mousePosition.y = 0;
        }

        private void ChangePosition() =>
            root.position = _mousePosition;
    }
}

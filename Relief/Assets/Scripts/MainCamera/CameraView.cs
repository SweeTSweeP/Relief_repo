using UnityEngine;

namespace MainCamera
{
    public class CameraView : MonoBehaviour
    {
        [SerializeField] private Transform view2d;
        [SerializeField] private Transform view3d;
        [SerializeField] private Camera mainCamera;

        private void Start() => 
            Set3DView();

        public void Set2DView() => 
            SetView(false);

        public void Set3DView() => 
            SetView(true);

        private void SetView(bool is3DView)
        {
            var view = is3DView ? view3d : view2d;

            mainCamera.orthographic = !is3DView;
            mainCamera.transform.SetParent(view);
            mainCamera.transform.localPosition = Vector3.zero;
            mainCamera.transform.localRotation = Quaternion.Euler(0, 0,0);
        }
    }
}

using UnityEngine;
using g3;

namespace f3
{
    // Desktop pointer and modifier input. The default source reads Unity input.
    // Consumers must see one stable source for a whole frame/gesture.
    public class DesktopInputSource
    {
        public virtual Vector3 Position { get { return Input.mousePosition; } }
        public virtual Vector2f Delta
        {
            get { return new Vector2f(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")); }
        }
        public virtual float WheelDelta { get { return Input.GetAxis("Mouse ScrollWheel"); } }

        public virtual bool GetMouseButton(int button) { return Input.GetMouseButton(button); }
        public virtual bool GetMouseButtonDown(int button) { return Input.GetMouseButtonDown(button); }
        public virtual bool GetMouseButtonUp(int button) { return Input.GetMouseButtonUp(button); }
        public virtual bool GetKey(KeyCode key) { return Input.GetKey(key); }
        public virtual bool GetKeyDown(KeyCode key) { return Input.GetKeyDown(key); }
        public virtual bool GetKeyUp(KeyCode key) { return Input.GetKeyUp(key); }
    }
}

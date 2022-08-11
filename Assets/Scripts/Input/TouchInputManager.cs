using Nova;
using UnityEngine;

namespace NovaSamples.UIControls
{
    public class TouchInputManager : MonoBehaviour
    {
        private void Update()
        {
            for (int i = 0; i < Input.touchCount; i++)
            {
                // Using Unity's legacy input system, get the first touch point.
                Touch touch = Input.GetTouch(i);

                // Convert the touch point to a world-space ray.
                Ray ray = Camera.main.ScreenPointToRay(touch.position);

                // Create a new Interaction.Update from the ray and the finger's ID
                Interaction.Update update = new Interaction.Update(ray, (uint)touch.fingerId);

                // Get the current touch phase
                TouchPhase touchPhase = touch.phase;

                // If the touch phase hasn't ended and hasn't been canceled, then pointerDown == true.
                bool pointerDown = touchPhase != TouchPhase.Canceled && touchPhase != TouchPhase.Ended;

                // Feed the update and pressed state to Nova's Interaction APIs
                Interaction.Point(update, pointerDown);

                if (!pointerDown)
                {
                    // If the finger is off the screen, send a follow up hover that
                    // won't hit anything and cancel to indicate the interaction is over.
                    // This is to assist with cross platform compatibility for hover events,
                    // since touch events are driven by press/release and don't provide the same
                    // kind of "pointer exit" data as an unpressed mouse pointer
                    update.Ray = default;
                    Interaction.Point(update, false);
                    Interaction.Cancel(update);
                }
            }
        }
    }
}
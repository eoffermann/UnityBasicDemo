using UnityEngine;

/// <summary>
/// Rotates a GameObject along the X, Y, and Z axes independently.
/// Rotation speeds are set in degrees per second.
/// An overall magnitude multiplier scales all rotations uniformly.
/// </summary>
public class AxisRotator : MonoBehaviour
    {
    [Header("Rotation Speeds (degrees per second)")]
    [Tooltip("Rotation speed around the X-axis in degrees per second.")]
    [SerializeField]
    private float rotationSpeedX = 0f;

    [Tooltip("Rotation speed around the Y-axis in degrees per second.")]
    [SerializeField]
    private float rotationSpeedY = 30f;

    [Tooltip("Rotation speed around the Z-axis in degrees per second.")]
    [SerializeField]
    private float rotationSpeedZ = 0f;

    [Header("Overall Magnitude Multiplier")]
    [Tooltip("Multiplier to scale the rotation speed on all axes simultaneously.")]
    [SerializeField]
    private float rotationMagnitude = 1f;

    /// <summary>
    /// Rotate the object every frame based on configured rotation speeds.
    /// </summary>
    private void Update()
        {
        RotateObject();
        }

    /// <summary>
    /// Rotates the GameObject based on the configured rotation speed and magnitude.
    /// </summary>
    private void RotateObject()
        {
        // Compute rotation for this frame, adjusted by deltaTime for frame-rate independence.
        Vector3 rotationVector = new Vector3(rotationSpeedX, rotationSpeedY, rotationSpeedZ);
        transform.Rotate(rotationVector * rotationMagnitude * Time.deltaTime);
        }
    }

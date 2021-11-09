using UnityEngine;

namespace GameComponents
{
    [RequireComponent(typeof(Rigidbody))]
    public class ForceMover : ObjectMover<Vector3>
    {
        private Rigidbody _rigidBody;

        public float Acceleration { get; set; }

        private void Awake() => _rigidBody = GetComponent<Rigidbody>();

        public override void Move() => _rigidBody.AddForce(_direction * Acceleration);
    }
}
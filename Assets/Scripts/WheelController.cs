using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    [SerializeField] private HingeJoint _wheelJoint;
    [SerializeField] private float _motorTorque = 1e+10f;
    [SerializeField] private float _motorSpeed = 0.0f;
    [SerializeField] private float _speedGain = 1.0f;

    JointMotor motor;

    public float MotorSpeed { set => _motorSpeed = value; }

    // Start is called before the first frame update
    void Start()
    {
        this._wheelJoint.useMotor = true;
        motor.force = this._motorTorque;
    }

    // Update is called once per frame
    void Update()
    {
        motor.targetVelocity = this._motorSpeed * this._speedGain;
        this._wheelJoint.motor = motor;
    }
}

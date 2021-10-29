using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgvController : MonoBehaviour
{
    [SerializeField] private WheelController _FL;
    [SerializeField] private WheelController _FR;
    [SerializeField] private WheelController _RL;
    [SerializeField] private WheelController _RR;

    public float _linear = 0.0f;
    public float _angular = 0.0f;

    // Update is called once per frame
    void Update()
    {
        this._FL.MotorSpeed = this._linear;
        this._FR.MotorSpeed = this._linear;
        this._RL.MotorSpeed = this._linear;
        this._RR.MotorSpeed = this._linear;
    }
}

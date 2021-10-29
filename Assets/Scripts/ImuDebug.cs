using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImuDebug : MonoBehaviour
{
    public FRJ.Sensor.IMU imu;
    public IMUPublisher imu_ros;

    public GameObject ob;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public GameObject text6;

    Rigidbody rb;

    private void Start()
    {
        rb = ob.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        rb.AddForce(Vector3.forward * Input.GetAxis("Vertical"));
        rb.AddForce(Vector3.right * Input.GetAxis("Horizontal"));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        imu.UpdateIMU();

        text1.GetComponent<Text>().text = "GeometryQuaternion \t: " + imu.GeometryQuaternion.ToString();
        text2.GetComponent<Text>().text = "AngularVelocity \t\t\t: " + imu.AngularVelocity.ToString();
        text3.GetComponent<Text>().text = "LinearAcceleration \t\t: " + imu.LinearAcceleration.ToString();

        text4.GetComponent<Text>().text = "(ROS)GeometryQuaternion \t: (" +
                                            ((float)imu_ros._message.orientation.x).ToString() + ", " +
                                            ((float)imu_ros._message.orientation.y).ToString() + ", " +
                                            ((float)imu_ros._message.orientation.z).ToString() + ", " +
                                            ((float)imu_ros._message.orientation.w).ToString() + ")";
        text5.GetComponent<Text>().text = "(ROS)AngularVelocity \t\t\t: (" + 
                                            ((float)imu_ros._message.angular_velocity.x).ToString() + ", " +
                                            ((float)imu_ros._message.angular_velocity.y).ToString() + ", " +
                                            ((float)imu_ros._message.angular_velocity.z).ToString() + ")";
        text6.GetComponent<Text>().text = "(ROS)LinearAcceleration \t\t: (" + 
                                            ((float)imu_ros._message.linear_acceleration.x).ToString() + ", " +
                                            ((float)imu_ros._message.linear_acceleration.y).ToString() + ", " +
                                            ((float)imu_ros._message.linear_acceleration.z).ToString() + ")";
    }
}

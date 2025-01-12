using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGestureController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform targetObject; // 需要旋转的物体
    private bool isRotating = false;
    void Update()
    {
        // 获取左手和右手的手势状态
        var leftHand = OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.LHand);
        var rightHand = OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.RHand);
        // 检测是否抓住物体（假设抓取手势被映射到PrimaryHandTrigger）
        if (leftHand > 0.8f || rightHand > 0.8f)
        {
            if (!isRotating)
            {
                isRotating = true;
            }
        }
        else
        {
            isRotating = false;
        }
        // 如果正在旋转，调用旋转函数
        if (isRotating)
        {
            RotateObject();
        }
    }
    void RotateObject()
    {

        // 获取手部旋转
        Quaternion handRotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RHand);

        // 提取特定轴的旋转（例如Y轴）
        Vector3 rotationEuler = handRotation.eulerAngles;
        targetObject.rotation = Quaternion.Euler(0, rotationEuler.y, 0);
    }


}

using UnityEngine;
using System.Collections;

public class Camerascript : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    private Vector3 VelocityCamSmooth = Vector3.zero;
    private float camSMoothDampTime = .1f;

    private Vector3 targetPosition;

    void Awake()
    {
        offset = transform.position - player.transform.position;
        targetPosition = transform.position;
    }

    void FixedUpdate()
    {

        wallDetection(targetPosition, ref offset);
        smoothPosition(this.transform.position, targetPosition);
    }
    void LateUpdate()
    {
        nonesense();
    }

    private void smoothPosition(Vector3 fromPos, Vector3 toPos)
    {
        this.transform.position = Vector3.SmoothDamp(fromPos, toPos, ref VelocityCamSmooth, camSMoothDampTime);
    }
    private void wallDetection(Vector3 fromObject, ref Vector3 toTarget)
    {
        Debug.DrawLine(fromObject, toTarget, Color.cyan);
        //raycaste for wall
        RaycastHit wallHit = new RaycastHit();
        if (Physics.Linecast(fromObject, toTarget, out wallHit))
        {
            Debug.DrawRay(wallHit.point, Vector3.left, Color.red);
            // toTarget = new Vector3(wallHit.point.x, toTarget.y, wallHit.point.z);
            toTarget = new Vector3(wallHit.point.x, toTarget.y, wallHit.point.z + .01f);

        }
        else
            nonesense();
    }

    private void nonesense()
    {
        targetPosition = player.transform.position + offset;

    }
}

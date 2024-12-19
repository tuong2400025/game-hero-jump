
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Transform previousRoom;  // Tọa độ camera phòng trước
    [SerializeField] private Transform nextRoom;      // Tọa độ camera phòng sau
    [SerializeField] private CameraController cam;    // Camera controller

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Kiểm tra nhân vật
        {
            if (collision.transform.position.x < transform.position.x)
            {
                // Di chuyển camera đến phòng trước
                cam.MoveToNewRoom(nextRoom);
            }
            else
            {
                // Di chuyển camera đến phòng tiếp theo
                cam.MoveToNewRoom(previousRoom);
            }
        }
    }
}

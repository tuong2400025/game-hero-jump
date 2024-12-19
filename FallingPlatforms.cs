
using UnityEngine;

public class FallingPlatforms : MonoBehaviour
{
   
    [SerializeField] private float tocDoDiChuyen = 5f; // Tốc độ di chuyển của trap
    [SerializeField] private Transform diemA;         // Điểm A
    [SerializeField] private Transform diemB;         // Điểm B
    private Vector3 diemMucTieu;                      // Vị trí mục tiêu hiện tại

    void Start()
    {
        // Khởi tạo điểm mục tiêu là điểm A
        diemMucTieu = diemA.position;
    }

    void Update()
    {
        // Di chuyển trap đến điểm mục tiêu
        transform.position = Vector3.MoveTowards(transform.position, diemMucTieu, tocDoDiChuyen * Time.deltaTime);

        // Kiểm tra nếu trap đã đến gần điểm mục tiêu
        if (Vector3.Distance(transform.position, diemMucTieu) < 0.1f)
        {
            // Đổi điểm mục tiêu giữa A và B
            if (diemMucTieu == diemA.position)
            {
                diemMucTieu = diemB.position;
            }
            else
            {
                diemMucTieu = diemA.position;
            }
        }
    }
}


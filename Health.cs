using UnityEngine;
using UnityEngine.SceneManagement;
public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    private bool isAlive = true;
   
    private void Awake()
    {
        currentHealth = startingHealth;
    }
    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {}
        else
        { Die(); }
    }
    private void Die()
    {
        if (!isAlive) return; // Tránh gọi lại nhiều lần

        isAlive = false;

        // Chuyển sang scene "youdied"
        SceneManager.LoadScene("GameOver");
    }
    public void AddHealth( float _volue)
    {
        currentHealth = Mathf.Clamp(currentHealth + _volue, 0, startingHealth);
    }
    
}

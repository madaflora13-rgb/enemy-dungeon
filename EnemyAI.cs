using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [Header("Target")]
    public Transform player;

    [Header("Detection")]
    public float detectionRange = 10f;

    [Header("Pathfinding")]
    public NavMeshAgent agent;

    void Update()
    {
        if (player == null)
            return;

        // Menghitung jarak Enemy dengan Player
        float distance = Vector3.Distance(
            transform.position,
            player.position
        );

        // Memeriksa apakah Player berada dalam jangkauan
        if (distance <= detectionRange)
        {
            DetectAndChasePlayer();
        }
        else
        {
            // Player berada di luar jangkauan
            agent.ResetPath();
        }
    }

    void DetectAndChasePlayer()
    {
        // NavMeshAgent menggunakan pathfinding
        // untuk mencari jalur menuju posisi Player.
        agent.SetDestination(player.position);
    }

    private void OnDrawGizmosSelected()
    {
        // Menampilkan jangkauan deteksi Enemy
        Gizmos.color = Color.yellow;

        Gizmos.DrawWireSphere(
            transform.position,
            detectionRange
        );
    }
}

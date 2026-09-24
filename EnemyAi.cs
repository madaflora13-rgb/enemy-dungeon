using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform player;

    public float detectionRange = 10f;

    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (player == null)
            return;

        // Menghitung jarak Enemy dengan Player
        float distance = Vector3.Distance(
            transform.position,
            player.position
        );

        // Mengecek apakah Player berada dalam jangkauan
        if (distance <= detectionRange)
        {
            ChasePlayer();
        }
        else
        {
            // Player berada di luar jangkauan
            agent.ResetPath();
        }
    }

    void ChasePlayer()
    {
        // Mencari jalur menuju Player
        // NavMesh digunakan untuk pathfinding
        agent.SetDestination(player.position);
    }
}

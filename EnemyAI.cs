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

Penjelasan Kode

1. Deteksi Player

float distance = Vector3.Distance(
    transform.position,
    player.position
);

Kode tersebut menghitung jarak antara Enemy dan Player.

2. Mengecek Jangkauan

if (distance <= detectionRange)

Jika jarak Player lebih kecil atau sama dengan "detectionRange", Enemy akan mengejar Player.

3. Mencari Jalur

agent.SetDestination(player.position);

"NavMeshAgent" digunakan untuk mencari jalur yang dapat dilalui Enemy menuju posisi Player.

4. Bergerak Menuju Player

Setelah jalur ditemukan, "NavMeshAgent" menggerakkan Enemy mengikuti jalur tersebut.

5. Jika Player Keluar Jangkauan

agent.ResetPath();

Enemy menghentikan jalur pengejarannya ketika Player berada di luar jangkauan.

:::

Isi `flowchart.md`:

:::writing{variant="document" id="39164" title="flowchart.md"}
# Flowchart Enemy AI

## Flowchart

```mermaid
flowchart TD
    A([Start]) --> B[Enemy mendeteksi Player]
    B --> C[Hitung jarak Enemy dan Player]
    C --> D{Player dalam jangkauan?}

    D -- Tidak --> E[Enemy tidak mengejar]
    E --> B

    D -- Ya --> F[Cari jalur menggunakan A*]
    F --> G{Jalur ditemukan?}

    G -- Tidak --> H[Enemy berhenti]
    H --> B

    G -- Ya --> I[Enemy bergerak mengikuti jalur]
    I --> J[Menuju posisi Player]
    J --> B

Penjelasan

Start
Program dimulai dan Enemy melakukan proses deteksi.

Deteksi Player
Enemy mencari keberadaan Player.

Hitung Jarak
Jarak antara Enemy dan Player dihitung.

Cek Jangkauan
Jika Player berada di luar jangkauan, Enemy tidak mengejar.

A Pathfinding*
Jika Player berada dalam jangkauan, Enemy mencari jalur menuju Player.

Movement
Enemy bergerak mengikuti jalur yang telah ditemukan.

Loop
Proses dilakukan kembali karena posisi Player dapat berubah selama permainan.

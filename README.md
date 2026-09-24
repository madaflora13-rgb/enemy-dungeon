Dungeon Enemy AI

Deskripsi

Program ini merupakan contoh algoritma Artificial Intelligence (AI) pada game dungeon. Enemy bertugas mendeteksi Player, memeriksa apakah Player berada dalam jangkauan, mencari jalur menuju Player, kemudian bergerak mengikuti jalur tersebut.

Algoritma yang Digunakan

Algoritma utama yang digunakan adalah:

1. Distance / Range Detection
   
   - Digunakan untuk menghitung jarak antara Enemy dan Player.
   - Enemy hanya akan mengejar Player jika Player berada dalam jangkauan tertentu.

2. A (A-Star) Pathfinding*
   
   - Digunakan untuk mencari jalur dari posisi Enemy menuju posisi Player.
   - A* dapat mencari jalur dengan mempertimbangkan posisi yang dapat dilewati dan hambatan di dalam dungeon.

3. Movement
   
   - Setelah jalur ditemukan, Enemy bergerak mengikuti titik-titik jalur tersebut menuju Player.

Alur Algoritma

Start
  |
  v
Enemy mendeteksi Player
  |
  v
Hitung jarak Enemy dengan Player
  |
  v
Apakah Player dalam jangkauan?
  |
  +---- Tidak ----> Enemy tetap/berpatroli
  |
  +---- Ya
        |
        v
   Cari jalur dengan A*
        |
        v
   Apakah jalur ditemukan?
        |
        +---- Tidak ----> Enemy berhenti
        |
        +---- Ya
              |
              v
      Enemy mengikuti jalur
              ↓
        Menuju Player
              ↓
       Player berpindah?
              ↓
       Hitung jalur kembali

Flowchart

Flowchart menggambarkan proses:

Start → Deteksi Player → Hitung Jarak → Cek Jangkauan → A Pathfinding → Gerak Menuju Player*

Contoh Implementasi

Bahasa pemrograman yang digunakan adalah C#, karena kode dapat diterapkan pada proyek game berbasis Unity.

File implementasi terdapat pada:

"EnemyAI.cs"

Kesimpulan

Pada kasus ini, Enemy menggunakan kombinasi Range Detection, A Pathfinding*, dan Movement.

Range Detection digunakan untuk menentukan apakah Player berada dalam jangkauan Enemy. Jika Player berada dalam jangkauan, algoritma A* digunakan untuk mencari jalur yang dapat dilewati Enemy menuju Player. Setelah jalur ditemukan, Enemy bergerak mengikuti jalur tersebut.

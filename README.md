Enemy Dungeon AI

Project ini merupakan implementasi algoritma Artificial Intelligence (AI) sederhana untuk Enemy yang mengejar Player di dalam sebuah dungeon.

Deskripsi

Player bergerak di dalam dungeon. Enemy harus:

1. Mendeteksi keberadaan Player.
2. Mengecek apakah Player berada dalam jangkauan Enemy.
3. Mencari jalur menuju Player.
4. Bergerak mengikuti jalur yang telah ditemukan.
5. Mengulangi proses ketika posisi Player berubah.

Algoritma yang Digunakan

Algoritma utama yang digunakan adalah A (A-Star) Pathfinding*.

A* digunakan untuk mencari jalur dari posisi Enemy menuju posisi Player dengan mempertimbangkan jarak dan biaya perjalanan.

Selain A*, sistem menggunakan:

- Distance/Range Detection untuk menentukan apakah Player berada dalam jangkauan.
- Pathfinding untuk mencari jalur menuju Player.
- Movement untuk membuat Enemy bergerak mengikuti jalur.

Alur Sistem

Player bergerak
      ↓
Enemy mendeteksi Player
      ↓
Hitung jarak Enemy → Player
      ↓
Apakah Player dalam jangkauan?
      ↓
   ┌──Tidak──┐
   ↓         │
Enemy tidak  │
mengejar     │
   │         │
   └─────────┘
      ↑
      │
     Ya
      ↓
Cari jalur menggunakan A*
      ↓
Apakah jalur ditemukan?
      ↓
   ┌──Tidak──┐
   ↓         │
Enemy tetap  │
di posisi    │
   │         │
   └─────────┘
      ↑
      │
     Ya
      ↓
Enemy mengikuti jalur
      ↓
Menuju Player
      ↓
Player berpindah?
      ↓
Hitung jalur kembali

Flowchart

Flowchart lengkap dapat dilihat pada file:

"Flowchart.md"

Contoh Implementasi

Contoh kode menggunakan bahasa C# dan konsep yang dapat diterapkan pada Unity.

File kode:

"EnemyAI.cs"

Cara Kerja A*

A* menggunakan fungsi evaluasi:

f(n) = g(n) + h(n)

Keterangan:

- "g(n)" = biaya dari posisi awal menuju node saat ini.
- "h(n)" = perkiraan biaya dari node saat ini menuju target.
- "f(n)" = total perkiraan biaya.

A* memilih node dengan nilai "f(n)" yang paling kecil untuk menentukan jalur yang akan digunakan.

Contoh Skenario

Misalnya Enemy berada di:

Enemy  = (2, 2)
Player = (8, 6)

Enemy terlebih dahulu mengecek jarak Player.

Jika Player berada dalam radius pengejaran, Enemy menjalankan pathfinding A* untuk mencari jalur yang dapat dilewati di dalam dungeon.

Setelah jalur ditemukan, Enemy bergerak dari satu node ke node berikutnya sampai mendekati Player.

Kesimpulan

Algoritma yang digunakan pada sistem ini adalah A Pathfinding* sebagai algoritma utama untuk mencari jalur Enemy menuju Player.

Sistem juga menggunakan Range Detection untuk menentukan kapan Enemy mulai mengejar Player dan Movement untuk mengikuti jalur yang telah ditemukan.

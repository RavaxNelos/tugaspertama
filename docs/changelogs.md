# Changelog

Dokumen ini mencatat seluruh riwayat perubahan yang dilakukan pada aplikasi **Penilaian Akhir** (VB.NET / Windows Forms).

Format perubahan mengikuti pola **Semantic Versioning** (`major.minor.patch`), dimulai dari versi `0.0.1` dan naik bertahap. Versi terbaru ditampilkan paling atas.

---

## [0.0.6] - Penambahan Tombol Back (Kembali ke Form1)

### Ditambahkan
- Tombol **Back** (`buttonBack`) di Form2, terletak di pojok kanan atas, untuk kembali ke Form1.
- Saat tombol Back diklik, event handler `buttonBack_Click` akan menutup Form2 dan menampilkan kembali **Form1** sehingga user dapat mengganti/mengisi ulang Nama dan NPM.

### Diubah
- **Alur navigasi Form1 → Form2**: Form1 kini melewatkan referensi instans dirinya sendiri (`Me`) ke Form2 melalui constructor `New Form2(nama, npm, Me)`.
- **Form2** kini menyimpan referensi tersebut di variabel `form1`, sehingga tombol Back dapat memanggil `form1.Show()` setelah `Me.Close()`.
- Desain ini memastikan Form1 yang sama (dengan nilai Nama/NPM sebelumnya) ditampilkan kembali ketika user menekan Back, alih-alih membuka Form1 baru.

---

## [0.0.5] - Perbaikan Interaktivitas (Nama/NPM Menjadi Label, Hasil Read-Only)

### Diperbaiki
- **Nama & NPM di Form2 tidak bisa diklik lagi**: field `tbxNama` dan `tbxNPM` (TextBox read-only yang masih bisa diklik dan memunculkan cursor) diganti menjadi **Label** (`lblNama`, `lblNPM`). Keduanya kini tampil sebagai teks biasa yang tidak bisa diklik, dipilih, atau diedit oleh user. Code-behind `Form2.vb` diperbarui agar mengisi label-label tersebut dari Form1.
- **Hasil perhitungan menjadi read-only**: `tbxNilaiAkhir` kini di-set `ReadOnly = True`, sehingga angka Nilai Akhir tidak dapat diklik dan diganti secara manual oleh user; hasil hanya dapat diisi melalui perhitungan tombol Hitung (atau di-reset oleh tombol Reset).

---

## [0.0.4]

### Ditambahkan
- Folder **`docs/`** dibuat untuk menampung dokumentasi proyek.
- File **`docs/changelogs.md`** dibuat untuk mencatat seluruh riwayat perubahan aplikasi ini.

### Diubah
- `README.md` diperbarui dengan dokumentasi lengkap aplikasi (penjelasan setiap file dan kode, penjelasan tombol Reset, serta panduan pembuatan laporan PDF).

---

## [0.0.3] - Perbaikan Beberapa Bug (Enter, Ukuran Window, Readonly, Urutan Tab)

### Diperbaiki
- **Enter di Form1 sekarang berfungsi**: menambahkan `AcceptButton = buttonNext` sehingga menekan Enter pada `txtNama`/`txtNPM` langsung membuka Form2 (pengganti klik tombol Next).
- **Ukuran window Form2** disesuaikan agar semua konten (label, input, tombol, dan hasil) *fit* ke jendela, hanya menyisakan sedikit ruang kosong. `ClientSize` diubah dari `963 x 512` menjadi `570 x 500`.
- **Nama & NPM di Form2 dijadikan read-only** (`ReadOnly = True`) sehingga user hanya dapat menginput tiga nilai (UTS, UAS, Praktikum). Field identitas tidak dapat diedit.

### Diperbaiki (Bug navigasi Tab)
- Urutan **TabIndex** di Form2 salah: setelah input Nilai UTS, press Tab melompat ke NPM, bukan ke UAS.
- Diperbaiki dengan mengatur ulang urutan Tab dan menonaktifkan TabStop pada field Nama & NPM (karena read-only), sehingga urutan Tab menjadi: **UTS → UAS → Praktikum**.

---

## [0.0.2] - Penambahan Tombol Reset

### Ditambahkan
- Tombol **Reset** (`buttonReset`) di Form2, diletakkan bersebelahan dengan tombol Hitung.
- Event handler `buttonReset_Click` di `Form2.vb` yang mengosongkan kembali seluruh input nilai dan hasil perhitungan menjadi `"0"`:
  - `tbxNilaiUTS.Text = "0"`
  - `tbxNilaiUAS.Text = "0"`
  - `tbxNilaiPraktikum.Text = "0"`
  - `tbxNilaiAkhir.Text = "0"`

### Diubah
- Tombol **Hitung** diperkecil lebarnya (dari selebar form menjadi setengah baris) agar muat bersebelahan dengan tombol Reset.
- `README.md` diperbarui memuat dokumentasi lengkap (penjelasan kode, file, tombol reset, dan panduan laporan PDF).

---

## [0.0.1] - Awal Proyek

### Ditambahkan
- Struktur proyek awal `Penilaian Akhir` sebagai aplikasi desktop VB.NET (Windows Forms).
- **Form1** — halaman input identitas mahasiswa (Nama & NPM) dengan tombol **Next**.
- **Form2** — halaman input nilai (UTS, UAS, Praktikum) serta perhitungan **Nilai Akhir** berdasarkan rumus:
  ```
  Nilai Akhir = (0.3 x Nilai UTS) + (0.3 x Nilai UAS) + (0.4 x Nilai Praktikum)
  ```
- Alur wizard **Form1 → Form2**: Form1 mengirim `nama` dan `npm` ke Form2 melalui constructor, lalu Form1 di-hide.
- Tombol **Hitung** yang membaca ketiga nilai, menghitung, dan menampilkan hasil pada textbox besar.

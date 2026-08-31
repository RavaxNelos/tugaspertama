# Tugas Pertama - Penilaian Akhir

Aplikasi **Penilaian Akhir** (Final Grade Calculator) adalah program desktop berbasis **VB.NET (Windows Forms)** yang digunakan untuk menghitung nilai akhir mahasiswa berdasarkan tiga komponen nilai, yaitu **Nilai UTS**, **Nilai UAS**, dan **Nilai Praktikum**.

---

## Daftar Fitur

- Input identitas mahasiswa (Nama & NPM) di **Form1**.
- Menekan **Enter** pada Form1 dapat langsung memindahkan ke Form2 (pengganti klik tombol Next).
- Navigasi mundur via tombol **Back** di Form2 untuk mengganti Nama/NPM.
- Input tiga komponen nilai (UTS, UAS, Praktikum) di **Form2**.
- Perhitungan otomatis **Nilai Akhir** berbobot dengan tombol **Hitung**.
- Tombol **Reset** untuk mengosongkan kembali nilai dan hasil perhitungan.
- Field identitas (Nama/NPM) di Form2 bersifat non-editable (berupa Label).
- Hasil perhitungan bersifat read-only (tidak bisa diedit manual).
- Urutan navigasi **Tab** yang benar di Form2 (UTS → UAS → Praktikum).

---

## 1. Penjelasan Setiap Kode dan File

### Struktur Folder

```
tugaspertama-main/
|
|-- README.md                        # Dokumentasi proyek (file ini)
|-- tugaspertama.slnx                # File solusi Visual Studio
|
|-- docs/                            # Folder dokumentasi tambahan
|   |-- changelogs.md                # Riwayat perubahan versi aplikasi
|
|-- tugaspertama/                    # Folder utama proyek
|   |-- tugaspertama.vbproj          # File proyek VB.NET (referensi, konfigurasi build)
|   |-- App.config                   # Konfigurasi runtime .NET Framework 4.7.2
|   |-- Form1.vb                     # Logika (code-behind) Form1
|   |-- Form1.Designer.vb            # Layout UI Form1 (auto-generate)
|   |-- Form1.resx                   # Sumber daya Form1
|   |-- Form2.vb                     # Logika (code-behind) Form2 + perhitungan
|   |-- Form2.Designer.vb            # Layout UI Form2 (auto-generate)
|   |-- Form2.resx                   # Sumber daya Form2
|   |
|   |-- My Project/                  # Metadata aplikasi VB.NET
|       |-- Application.myapp        # Konfigurasi startup (Form1 sebagai MainForm)
|       |-- Application.Designer.vb  # Bootstrap aplikasi
|       |-- AssemblyInfo.vb          # Metadata assembly (versi, judul, dll)
|       |-- Resources.resx           # Sumber daya proyek
|       |-- Resources.Designer.vb    # Akses sumber daya
|       |-- Settings.settings        # Pengaturan aplikasi
|       |-- Settings.Designer.vb     # Akses pengaturan
```

### Penjelasan File-File Utama

| File | Fungsi |
|------|--------|
| **`tugaspertama.vbproj`** | File proyek Visual Basic yang mendefinisikan semua referensi (System, System.Windows.Forms, System.Drawing, dll.), item sumber kode, dan konfigurasi build (Debug/Release). |
| **`tugaspertama.slnx`** | File solusi Visual Studio yang menghubungkan proyek `tugaspertama.vbproj` ke dalam satu solusi agar bisa dibuka dan di-build dari IDE. |
| **`App.config`** | Berisi konfigurasi runtime aplikasi, yaitu menentukan dukungan .NET Framework versi 4.7.2. |
| **`docs/changelogs.md`** | Dokumen yang mencatat seluruh riwayat perubahan aplikasi, dimulai dari versi `0.0.1` hingga versi terbaru. Versi terbaru ditampilkan paling atas. |
| **`My Project/Application.myapp`** | Konfigurasi aplikasi yang mendeklarasikan **Form1** sebagai *MainForm* (form utama yang pertama muncul saat aplikasi dijalankan), mengaktifkan visual styles, dan mengatur mode single-instance. |
| **`My Project/AssemblyInfo.vb`** | Metadata assembly aplikasi seperti judul, versi (1.0.0.0), dan nama perusahaan. |

### Form1 (Form Input Identitas Mahasiswa)

**`Form1.Designer.vb`** — Mendefinisikan tata letak UI Form1, yaitu:
- **Label judul** "PENILAIAN AKHIR" (font tebal 24pt).
- **`txtNama`** — TextBox untuk mengisi nama mahasiswa.
- **`txtNPM`** — TextBox untuk mengisi NPM mahasiswa.
- **`buttonNext`** — Tombol hijau untuk melanjutkan ke halaman berikutnya.
- **`AcceptButton`** — di-set ke `buttonNext`, sehingga menekan **Enter** pada `txtNama`/`txtNPM` langsung memicu tombol Next.

**`Form1.vb`** — Logika dari Form1. Saat tombol **Next** diklik (atau Enter ditekan), event handler `buttonNext_Click` akan:
1. Membaca nilai dari `txtNama` dan `txtNPM` sebagai variabel `nama` dan `npm`.
2. Membuat objek `Form2` baru dengan melewatkan `nama`, `npm`, **dan referensi Form1 (`Me`)** melalui constructor `New Form2(nama, npm, Me)`.
3. Menampilkan Form2 menggunakan `form2.Show()`.
4. Menyembunyikan Form1 menggunakan `Me.Hide()`.

```vb
Dim nama As String = txtNama.Text
Dim npm As String = txtNPM.Text
Dim form2 As New Form2(nama, npm, Me)
form2.Show()
Me.Hide()
```

### Form2 (Form Input Nilai dan Perhitungan)

**`Form2.Designer.vb`** — Mendefinisikan tata letak UI Form2, yaitu:
- **`lblNama`** dan **`lblNPM`** — **Label** (teks biasa) untuk menampilkan nama dan NPM yang diterima dari Form1. Berupa Label sehingga **tidak bisa diklik, dipilih, atau diedit** oleh user.
- **`tbxNilaiUTS`** — TextBox untuk mengisi Nilai UTS (default "0", rata kanan).
- **`tbxNilaiUAS`** — TextBox untuk mengisi Nilai UAS (default "0", rata kanan).
- **`tbxNilaiPraktikum`** — TextBox untuk mengisi Nilai Praktikum (default "0", rata kanan).
- **Label rumus** — Menampilkan rumus: `(0.3*Nilai UTS)+(0.3*Nilai UAS)+(0.4*Nilai Praktikum)`.
- **`buttonHitung`** — Tombol "Hitung" untuk menghitung nilai akhir.
- **`buttonReset`** — Tombol "Reset" untuk mengosongkan kembali nilai-nilai.
- **`buttonBack`** — Tombol "Back" untuk kembali ke Form1.
- **`tbxNilaiAkhir`** — TextBox besar (font 72pt, rata tengah) untuk menampilkan hasil Nilai Akhir, di-set **ReadOnly** sehingga tidak bisa diedit manual.
- Setiap field nilai memiliki urutan **TabIndex** yang benar (UTS → UAS → Praktikum); field identitas tidak dapat menerima fokus Tab (TabStop nonaktif).

**`Form2.vb`** — Logika dari Form2. Terdapat *constructor*:
- `Public Sub New()` — constructor biasa (tanpa parameter).
- `Public Sub New(nama As String, npm As String, form1Ref As Form1)` — constructor yang menerima nama, NPM, dan referensi Form1, lalu mengisinya ke `lblNama` dan `lblNPM` serta menyimpan referensi Form1.

Terdapat deklarasi variabel level kelas:
```vb
Dim uts, uas, praktikum, nilaiAkhir As Double
Private form1 As Form1
```

**Event handler `buttonHitung_Click`** (perhitungan nilai akhir):
1. Membaca nilai dari ketiga TextBox dan mengubahnya menjadi `Double` menggunakan `CDbl()`.
2. Menghitung nilai akhir dengan rumus berbobot:
   ```vb
   nilaiAkhir = (0.3 * uts) + (0.3 * uas) + (0.4 * praktikum)
   ```
3. Menampilkan hasil ke `tbxNilaiAkhir`.

```vb
Private Sub buttonHitung_Click(sender As Object, e As EventArgs) Handles buttonHitung.Click
    uts = CDbl(tbxNilaiUTS.Text)
    uas = CDbl(tbxNilaiUAS.Text)
    praktikum = CDbl(tbxNilaiPraktikum.Text)

    nilaiAkhir = (0.3 * uts) + (0.3 * uas) + (0.4 * praktikum)

    tbxNilaiAkhir.Text = nilaiAkhir.ToString()
End Sub
```

### Rumus Nilai Akhir

```
Nilai Akhir = (0.3 x Nilai UTS) + (0.3 x Nilai UAS) + (0.4 x Nilai Praktikum)
```

| Komponen | Bobot | Keterangan |
|----------|-------|------------|
| **UTS** | 30% | Ujian Tengah Semester |
| **UAS** | 30% | Ujian Akhir Semester |
| **Praktikum** | 40% | Kerja Praktik/Laboratorium |

**Contoh perhitungan:**
Jika UTS = 80, UAS = 90, Praktikum = 85, maka:
```
Nilai Akhir = (0.3 x 80) + (0.3 x 90) + (0.4 x 85)
            = 24 + 27 + 34
            = 85
```

---

## 2. Penjelasan Mengenai Tombol Reset

Tombol **Reset** (`buttonReset`) adalah fitur yang dibuat agar pengguna dapat mengosongkan kembali seluruh nilai yang sudah diisi **setelah** melakukan perhitungan nilai akhir. Dengan tombol ini, pengguna tidak perlu menghapus satu per satu nilai secara manual, sehingga lebih cepat dan praktis jika ingin menghitung ulang dengan data yang baru.

### Cara Kerja Tombol Reset

Tombol **Reset** terhubung dengan event handler `buttonReset_Click` pada `Form2.vb`. Ketika tombol ini diklik, program akan mengeksekusi baris kode berikut:

```vb
Private Sub buttonReset_Click(sender As Object, e As EventArgs) Handles buttonReset.Click
    tbxNilaiUTS.Text = "0"
    tbxNilaiUAS.Text = "0"
    tbxNilaiPraktikum.Text = "0"
    tbxNilaiAkhir.Text = "0"
End Sub
```

Penjelasan rinci cara kerjanya:

1. **`tbxNilaiUTS.Text = "0"`** — Mengosongkan/mereset TextBox Nilai UTS kembali ke nilai awal "0".
2. **`tbxNilaiUAS.Text = "0"`** — Mengosongkan/mereset TextBox Nilai UAS kembali ke nilai awal "0".
3. **`tbxNilaiPraktikum.Text = "0"`** — Mengosongkan/mereset TextBox Nilai Praktikum kembali ke nilai awal "0".
4. **`tbxNilaiAkhir.Text = "0"`** — Mengosongkan/mereset TextBox hasil Nilai Akhir kembali ke nilai awal "0".

Perlu diperhatikan bahwa tombol **Reset** hanya mengosongkan **nilai-nilai input dan hasil perhitungan** (Nilai UTS, UAS, Praktikum, dan Nilai Akhir), sedangkan **Nama dan NPM mahasiswa tidak dihapus**. Hal ini karena nama dan NPM merupakan identitas yang sudah ditentukan dari Form1, sehingga pengguna tidak perlu mengisi ulang identitas tersebut setiap kali ingin menghitung nilai dari awal. Dengan begitu, pengguna tinggal mengisi ulang ketiga komponen nilainya lalu menekan tombol **Hitung** kembali.

---

## 3. Penjelasan Mengenai Tombol Back

Tombol **Back** (`buttonBack`) adalah fitur yang memungkinkan pengguna untuk **kembali dari Form2 ke Form1** agar dapat mengganti/mengisi ulang Nama dan NPM mahasiswa. Tombol ini terletak di pojok kanan atas Form2.

### Cara Kerja Tombol Back

Agar bisa kembali ke Form1, Form2 perlu mengetahui instans Form1 yang sedang menampilkannya. Karena itu, Form1 melewatkan referensi dirinya sendiri (`Me`) melalui constructor:

```vb
Dim form2 As New Form2(nama, npm, Me)
```

Form2 menyimpan referensi tersebut di variabel `form1`:
```vb
Private form1 As Form1
```

Saat tombol **Back** diklik, event handler `buttonBack_Click` menutup Form2 dan menampilkan kembali Form1:
```vb
Private Sub buttonBack_Click(sender As Object, e As EventArgs) Handles buttonBack.Click
    Me.Close()
    form1.Show()
End Sub
```

Dengan cara ini, Form1 yang sama (yang berisi nilai Nama/NPM sebelumnya) ditampilkan kembali, sehingga pengguna dapat mengedit/isi ulang identitas lalu menekan Next lagi.

---

## 4. Done, tinggal dijadikan laporan berbentuk pdf, taruh teks ketiga ini di readmenya, tidak usah di ubah khusus yang ini

Berikut adalah langkah-langkah untuk menjadikan README ini menjadi laporan berbentuk PDF:

1. Buka file `README.md` ini menggunakan editor teks atau Markdown editor (misalnya VS Code dengan ekstensi Markdown, atau editor online).
2. Lakukan *preview* atau *render* Markdown untuk memastikan tampilannya sesuai.
3. Ekspor/konversi dokumen Markdown menjadi format PDF. Cara yang bisa digunakan antara lain:
   - Menggunakan ekstensi VS Code seperti **"Markdown PDF"** atau **"Markdown All in One"**.
   - Menggunakan alat konversi online (misalnya pandoc, dillinger.io, atau markdowntopdf.com).
   - Menggunakan `pandoc README.md -o laporan.pdf` di terminal jika sudah terinstall.
4. Simpan hasil PDF dengan nama yang sesuai (contoh: `Laporan_Tugas_Pertama.pdf`).

using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zebra.Sdk.Comm;

namespace Megah_Motor_Inventory
{
  public partial class frmMain : Form
  {
    OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=inventory.accdb");
    public frmMain()
    {
      InitializeComponent();
      initialize_dg();
      reset_item();
      show_data();
      show_pengurangan();
    }

    private void initialize_dg()
    {
      DataGridViewColumn id = new DataGridViewTextBoxColumn();
      id.DataPropertyName = "id";
      id.HeaderText = "ID";
      id.Name = "id";
      id.Width = 5;
      dg.Columns.Add(id);

      DataGridViewColumn asalBarang = new DataGridViewTextBoxColumn();
      asalBarang.DataPropertyName = "asalBarang";
      asalBarang.HeaderText = "Asal Barang";
      asalBarang.Name = "asalBarang";
      asalBarang.Width = 100;
      dg.Columns.Add(asalBarang);

      DataGridViewColumn namaBarang = new DataGridViewTextBoxColumn();
      namaBarang.DataPropertyName = "namaBarang";
      namaBarang.HeaderText = "Nama Barang";
      namaBarang.Name = "namaBarang";
      namaBarang.Width = 100;
      dg.Columns.Add(namaBarang);

      DataGridViewColumn tipeMobil = new DataGridViewTextBoxColumn();
      tipeMobil.DataPropertyName = "tipeMobil";
      tipeMobil.HeaderText = "Tipe Mobil";
      tipeMobil.Name = "tipeMobil";
      tipeMobil.Width = 100;
      dg.Columns.Add(tipeMobil);

      DataGridViewColumn kodeJual = new DataGridViewTextBoxColumn();
      kodeJual.DataPropertyName = "kodeJual";
      kodeJual.HeaderText = "Kode Jual";
      kodeJual.Name = "kodeJual";
      kodeJual.Width = 100;
      dg.Columns.Add(kodeJual);

      DataGridViewColumn kodeMandarin = new DataGridViewTextBoxColumn();
      kodeMandarin.DataPropertyName = "kodeMandarin";
      kodeMandarin.HeaderText = "Kode Mandarin";
      kodeMandarin.Name = "kodeMandarin";
      kodeMandarin.Width = 100;
      dg.Columns.Add(kodeMandarin);

      DataGridViewColumn hurufMandarin = new DataGridViewTextBoxColumn();
      hurufMandarin.DataPropertyName = "hurufMandarin";
      hurufMandarin.HeaderText = "Huruf Mandarin";
      hurufMandarin.Name = "hurufMandarin";
      hurufMandarin.Width = 100;
      dg.Columns.Add(hurufMandarin);

      DataGridViewColumn jumlahBarang = new DataGridViewTextBoxColumn();
      jumlahBarang.DataPropertyName = "jumlahBarang";
      jumlahBarang.HeaderText = "Jumlah Barang";
      jumlahBarang.Name = "jumlahBarang";
      jumlahBarang.Width = 100;
      dg.Columns.Add(jumlahBarang);
    }

    private void btnSimpan_Click(object sender, EventArgs e)
    {
      var input = 0;
      if (int.TryParse(txtKodeMandarin.Text, out input) && int.TryParse(txtJumlahBarang.Text, out input))
      {
        simpan();
      }
      else
      {
        MessageBox.Show("Kode mandarin dan jumlah barang harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    private void reset_item() {
      txtId.Text = "";
      txtAsalBarang.Text = "";
      txtAsalBarang.Enabled = false;
      txtNamaBarang.Text = "";
      txtNamaBarang.Enabled = false;
      txtTipeMobil.Text = "";
      txtTipeMobil.Enabled = false;
      txtKodeJual.Text = "";
      txtKodeJual.Enabled = false;
      txtKodeMandarin.Text = "";
      txtKodeMandarin.Enabled = false;
      txtJumlahBarang.Text = "";
      txtJumlahBarang.Enabled = false;
      txtJumlahBarang.Text = "";
      txtJumlahBarang.Enabled = false;
      txtJumlahCetak.Text = "";
      txtJumlahCetak.Enabled = false;

      btnSimpan.Enabled = false;
      btnCetak.Enabled = false;
      btnReset.Enabled = false;
      btnHapus.Enabled = false;
    }

    private void enable_item() {
      txtAsalBarang.Enabled = true;
      txtNamaBarang.Enabled = true;
      txtTipeMobil.Enabled = true;
      txtKodeJual.Enabled = true;
      txtKodeMandarin.Enabled = true;
      txtJumlahBarang.Enabled = true;
      txtJumlahBarang.Enabled = true;
      txtJumlahCetak.Enabled = true;

      btnSimpan.Enabled = true;
      btnCetak.Enabled = true;
      btnReset.Enabled = true;
      btnHapus.Enabled = true;
    }

    private void show_data() {
      String search = txtCari.Text;
      search = search.Replace("'", "''");
      dg.Rows.Clear();

      try
      {
        conn.Open();
        String query = "SELECT * FROM barang WHERE asal_barang LIKE '%" + search + "%' OR nama_barang LIKE '%" + search + "%' OR tipe_mobil LIKE '%" + search + "%'";
        OleDbCommand cmd = new OleDbCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = query;
        cmd.Connection = conn;

        OleDbDataReader reader = cmd.ExecuteReader();
        if (reader.HasRows)
        {
          while (reader.Read())
          {
            int i = dg.Rows.Add();
            dg.Rows[i].Cells[0].Value = reader["id"].ToString();
            dg.Rows[i].Cells[1].Value = reader["asal_barang"].ToString();
            dg.Rows[i].Cells[2].Value = reader["nama_barang"].ToString();
            dg.Rows[i].Cells[3].Value = reader["tipe_mobil"].ToString();
            dg.Rows[i].Cells[4].Value = reader["kode_jual"].ToString();
            dg.Rows[i].Cells[5].Value = reader["kode_mandarin"].ToString();
            dg.Rows[i].Cells[6].Value = reader["huruf_mandarin"].ToString();
            dg.Rows[i].Cells[7].Value = reader["jumlah_barang"].ToString();
          }
        }
        reader.Close();
        conn.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString(), "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    private void simpan()
    {
      String id = txtId.Text.Replace("'", "''");
      String asalBarang = txtAsalBarang.Text.Replace("'", "''");
      String namaBarang = txtNamaBarang.Text.Replace("'", "''");
      String tipeMobil = txtTipeMobil.Text.Replace("'", "''");
      String kodeJual = txtKodeJual.Text.Replace("'", "''");
      String kodeMandarin = txtKodeMandarin.Text.Replace("'", "''");
      String jumlahBarang = txtJumlahBarang.Text.Replace("'", "''");

      if (asalBarang == "" || namaBarang == "" || tipeMobil == "" || kodeJual == "" || kodeMandarin == "")
      {
        MessageBox.Show("Semua kolom tidak boleh kosong", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
      else
      {
        if(id == "")
        {
          //create new
          try
          {
            conn.Open();
            String query = "INSERT INTO barang (asal_barang, nama_barang, tipe_mobil, kode_jual, kode_mandarin, huruf_mandarin, jumlah_barang) VALUES (@asalBarang, @namaBarang, @tipeMobil, @kodeJual, @kodeMandarin, @hurufMandarin, @jumlahBarang)";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@asalBarang", asalBarang);
            cmd.Parameters.AddWithValue("@namaBarang", namaBarang);
            cmd.Parameters.AddWithValue("@tipeMobil", tipeMobil);
            cmd.Parameters.AddWithValue("@kodeJual", kodeJual);
            cmd.Parameters.AddWithValue("@kodeMandarin", kodeMandarin);
            cmd.Parameters.AddWithValue("@hurufMandarin", angka_cina(int.Parse(kodeMandarin)));
            cmd.Parameters.AddWithValue("@jumlahBarang", jumlahBarang);
            cmd.Connection = conn;

            cmd.ExecuteNonQuery();
            conn.Close();
            //MessageBox.Show("Data berhasil disimpan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reset_item();
          }
          catch (Exception ex)
          {
            MessageBox.Show(ex.ToString(), "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          }
        }
        else
        {
          //update
          try
          {
            conn.Open();
            String query = "UPDATE barang SET asal_barang = @asalBarang, nama_barang = @namaBarang, tipe_mobil = @tipeMobil, kode_jual = @kodeJual, kode_mandarin = @kodeMandarin, huruf_mandarin = @hurufMandarin, jumlah_barang = @jumlahBarang WHERE id = @id";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@asalBarang", asalBarang);
            cmd.Parameters.AddWithValue("@namaBarang", namaBarang);
            cmd.Parameters.AddWithValue("@tipeMobil", tipeMobil);
            cmd.Parameters.AddWithValue("@kodeJual", kodeJual);
            cmd.Parameters.AddWithValue("@kodeMandarin", kodeMandarin);
            cmd.Parameters.AddWithValue("@hurufMandarin", angka_cina(int.Parse(kodeMandarin)));
            cmd.Parameters.AddWithValue("@jumlahBarang", jumlahBarang);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = conn;

            cmd.ExecuteNonQuery();
            conn.Close();
            //MessageBox.Show("Data berhasil disimpan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reset_item();
          }
          catch (Exception ex)
          {
            MessageBox.Show(ex.ToString(), "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          }
        }
        show_data();
      }
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
      reset_item();
    }

    private void btnTambah_Click(object sender, EventArgs e)
    {
      reset_item();
      enable_item();
      btnHapus.Enabled = false;
    }

    private String angka_cina(int angka)
    {
      String[] digits = { "冬", "元", "月", "东", "西", "南", "北", "車", "來", "財" };
      Char[] charArray = angka.ToString().ToCharArray();
      String result = "";

      for (int i = 0; i < charArray.Length; i++)
      {
        Char ch = charArray[i];
        result += digits[(int)Char.GetNumericValue(ch)];
      }
      return result;
    }

    private void btnCetak_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show("Apakah Anda yakin mencetak data ini?\n", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
      if (result == DialogResult.Yes)
      {
        var input = 0;
        if (int.TryParse(txtKodeMandarin.Text, out input) && int.TryParse(txtJumlahBarang.Text, out input) && int.TryParse(txtJumlahCetak.Text, out input))
        {
          for (int i = 0; i < int.Parse(txtJumlahCetak.Text); i++)
          {
            print_data();
          }
          String id = txtId.Text;
          simpan();
          edit_data(id);
        }
        else
        {
          MessageBox.Show("Kode mandarin, jumlah barang, dan jumlah cetak harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
      }
    }

    private void btnHapus_Click(object sender, EventArgs e)
    {
      String id = txtId.Text;
      DialogResult result = MessageBox.Show("Apakah Anda yakin menghapus data ini?\nAksi ini tidak bisa dikembalikan!", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
      if (result == DialogResult.Yes)
      {
        try
        {
          conn.Open();
          String query = "DELETE FROM barang WHERE id = @id";
          OleDbCommand cmd = new OleDbCommand();
          cmd.CommandType = CommandType.Text;
          cmd.CommandText = query;
          cmd.Parameters.AddWithValue("@id", id);
          cmd.Connection = conn;

          cmd.ExecuteNonQuery();
          conn.Close();
          MessageBox.Show("Data berhasil dihapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
          reset_item();
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.ToString(), "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        show_data();
      }
    }

    private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      int i = e.RowIndex;
      Console.WriteLine(i);
      if(i > -1)
      {
        dg.Rows[i].Selected = true;
      }
    }

    private void dg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      int i = e.RowIndex;
      if (i > -1)
      {
        dg.Rows[i].Selected = true;
        String id = dg.Rows[i].Cells[0].Value.ToString();
        edit_data(id);
      }
      
    }

    private void edit_data(String id)
    {
      try
      {
        conn.Open();
        String query = @"SELECT * FROM barang WHERE id = @id";
        OleDbCommand cmd = new OleDbCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = query;
        cmd.Parameters.AddWithValue("@id", id);
        cmd.Connection = conn;

        OleDbDataReader reader = cmd.ExecuteReader();
        if (reader.HasRows)
        {
          while (reader.Read())
          {
            enable_item();
            txtId.Text = reader["id"].ToString();
            txtAsalBarang.Text = reader["asal_barang"].ToString();
            txtNamaBarang.Text = reader["nama_barang"].ToString();
            txtTipeMobil.Text = reader["tipe_mobil"].ToString();
            txtKodeJual.Text = reader["kode_jual"].ToString();
            txtKodeMandarin.Text = reader["kode_mandarin"].ToString();
            txtJumlahBarang.Text = reader["jumlah_barang"].ToString();
          }
        }
        reader.Close();
        conn.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString(), "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    private void btnCari_Click(object sender, EventArgs e)
    {
      show_data();
    }

    private void btnResetCari_Click(object sender, EventArgs e)
    {
      txtCari.Text = "";
      show_data();
    }

    private void print_data()
    {
      String id = txtId.Text.Replace("'", "''");
      String asalBarang = txtAsalBarang.Text.Replace("'", "''");
      String namaBarang = txtNamaBarang.Text.Replace("'", "''");
      String tipeMobil = txtTipeMobil.Text.Replace("'", "''");
      String kodeJual = txtKodeJual.Text.Replace("'", "''");
      String kodeMandarin = txtKodeMandarin.Text.Replace("'", "''");
      String hurufMandarin = angka_cina(int.Parse(kodeMandarin));
     //String jumlahBarang = numJumlahBarang.Value.ToString();
      try 
      {
        //string settings = System.IO.File.ReadAllText("./settings.txt");
        var thePrinterConn = ConnectionBuilder.Build("ZDesigner GT800 (ZPL) (Inventory)");
        try
        {
          // Open the connection - physical connection is established here.
          thePrinterConn.Open();

          // This example prints "This is a ZPL test." near the top of the label.
          string zplData = "^XA" +
            //item id
            "^FO150,25^A0,55,40^FD" + asalBarang + "^FS" +
            //"^FO290,22^A0,38,26^FD" + kodeJual + "^FS" +
            //"^FO580,22^A0,38,26^FD" + kodeJual + "^FS" +
            //item name 1
            "^FO150,75^A0,55,40^FD" + namaBarang + "^FS" +
            //"^FO290,55^A0,30,22^FD" + asalBarang + "^FS" +
            //"^FO580,55^A0,30,22^FD" + asalBarang + "^FS" +
            //item name 2
            "^FO150,125^A0,55,40^FD" + tipeMobil + "^FS" +
            //"^FO290,82^A0,30,22^FD" + namaBarang + "^FS" +
            //"^FO580,82^A0,30,22^FD" + namaBarang + "^FS" +
            //item name 3
            "^FO150,175^A0,55,40^FD" + kodeJual + "^FS" +
            //"^FO290,108^A0,30,22^FD" + tipeMobil + "^FS" +
            //"^FO580,108^A0,30,22^FD" + tipeMobil + "^FS" +
            //item chinese
            "^FO150,225^CI28^A@N,36,36,E:SIMSUN.FNT^FD" + hurufMandarin + "^FS" +
            //"^FO290,138^CI28^A@N,40,40,E:SIMSUN.FNT^FD" + hurufMandarin + "^FS" +
            //"^FO580,138^CI28^A@N,40,40,E:SIMSUN.FNT^FD" + hurufMandarin + "^FS" +
            "^FO10,295^B3N,N,50,Y,N^FD" + kodeJual + "^FS" +
            "^XZ";

          // Send the data to printer as a byte array.
          thePrinterConn.Write(Encoding.UTF8.GetBytes(zplData));
        }
        catch (ConnectionException e)
        {
          // Handle communications error here.
          Console.WriteLine(e.ToString());
          MessageBox.Show(e.ToString(), "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        finally
        {
          // Close the connection to release resources.
          thePrinterConn.Close();
        }
      }
      catch(Exception e)
      {
        MessageBox.Show(e.ToString(), "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    private void txtAsalBarang_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Down)
      {
        txtNamaBarang.Focus();
      }
    }

    private void txtNamaBarang_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape)
      {
        txtAsalBarang.Text = "";
        txtAsalBarang.Focus();
      }
      if (e.KeyCode == Keys.Up)
      {
        txtAsalBarang.Focus();
      }
      if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Down)
      {
        txtTipeMobil.Focus();
      }
    }

    private void txtTipeMobil_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Up)
      {
        txtNamaBarang.Focus();
      }
      if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Down)
      {
        txtKodeJual.Focus();
      }
    }

    private void txtKodeJual_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Up)
      {
        txtTipeMobil.Focus();
      }
      if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Down)
      {
        txtKodeMandarin.Focus();
      }
    }

    private void txtKodeMandarin_KeyDown(object sender, KeyEventArgs e)
    {
      if(e.KeyCode == Keys.Up)
      {
        txtKodeJual.Focus();
      }
      if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Down)
      {
        var input = 0;
        if (int.TryParse(txtKodeMandarin.Text, out input))
        {
          txtJumlahBarang.Focus();
        }
        else
        {
          MessageBox.Show("Kode mandarin harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
      }
    }

    private void txtJumlahBarang_KeyDown(object sender, KeyEventArgs e)
    {
      if(e.KeyCode == Keys.Up)
      {
        txtKodeMandarin.Focus();
      }
      if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Down)
      {
        var input = 0;
        if (int.TryParse(txtJumlahBarang.Text, out input))
        {
          txtJumlahCetak.Focus();
        }
        else
        {
          MessageBox.Show("Jumlah barang harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
      }
    }

    private void txtJumlahCetak_KeyDown(object sender, KeyEventArgs e)
    {
      if(e.KeyCode == Keys.Up)
      {
        txtJumlahBarang.Focus();
      }
      if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Down)
      {
        var input = 0;
        if (int.TryParse(txtJumlahCetak.Text, out input))
        {
          btnCetak.Focus();
        }
        else
        {
          MessageBox.Show("Jumlah cetak harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string text = System.IO.File.ReadAllText("./settings.txt");
      string input = Interaction.InputBox("Masukkan nama printer", "Setting Printer", text);
      string dirParameter = AppDomain.CurrentDomain.BaseDirectory + @"\settings.txt";
      FileStream fParameter = new FileStream(dirParameter, FileMode.Create, FileAccess.Write);
      StreamWriter m_WriterParameter = new StreamWriter(fParameter);
      m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
      m_WriterParameter.Write(input);
      m_WriterParameter.Flush();
      m_WriterParameter.Close();
    }

    private void frmMain_KeyUp(object sender, KeyEventArgs e)
    {
      MessageBox.Show("Selamat datang");
    }

    private void show_pengurangan()
    {

      lbPengurangan.Items.Clear();

      try
      {
        conn.Open();
        String query = "SELECT * FROM pengurangan ORDER BY id DESC";
        OleDbCommand cmd = new OleDbCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = query;
        cmd.Connection = conn;

        OleDbDataReader reader = cmd.ExecuteReader();
        if (reader.HasRows)
        {
          while (reader.Read())
          {
            lbPengurangan.Items.Add("["+reader["tanggal"].ToString().Substring(0, 10)+"] " + reader["asal_barang"]+" | "+reader["nama_barang"]+" | " +reader["kode_jual"]+" | "+" sisa "+reader["jumlah_akhir"]);
          }
        }
        reader.Close();
        conn.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString(), "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    private void txtPengurangan_KeyDown(object sender, KeyEventArgs e)
    {
      String kodeJual = txtPengurangan.Text;
      if (e.KeyCode == Keys.Enter)  
      {
        // Pencarian data
        if (penguranganBarang(kodeJual))
        {
          insertPengurangan(kodeJual);
          updateBarang(kodeJual);
        };
        txtPengurangan.Text = "";
        txtPengurangan.Focus();
      }
    }

    private bool penguranganBarang(String kodeJual)
    {
      bool res = false;
      try
      {
        conn.Open();
        String query = "SELECT * FROM barang WHERE kode_jual = '"+kodeJual+"'";
        OleDbCommand cmd = new OleDbCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = query;
        cmd.Connection = conn;

        OleDbDataReader reader = cmd.ExecuteReader();
        if (reader.HasRows)
        {
          while (reader.Read())
          {
            res = true;
          } 
        }
        else
        {
          MessageBox.Show("Barang tidak ditemukan!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          res = false;
        }
        reader.Close();
        conn.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString(), "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        res = false;
      }
      return res;
    }

    private void insertPengurangan(String kodeJual)
    {
      String asalBarang = "", namaBarang = "";
      int jumlahAwal = 0, jumlahAkhir = 0;
      try
      {
        conn.Open();
        String query = "SELECT * FROM barang WHERE kode_jual = '" + kodeJual + "'";
        OleDbCommand cmd = new OleDbCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = query;
        cmd.Connection = conn;

        OleDbDataReader reader = cmd.ExecuteReader();
        if (reader.HasRows)
        {
          while (reader.Read())
          {
            asalBarang = reader["asal_barang"].ToString();
            namaBarang = reader["nama_barang"].ToString();
            jumlahAwal = int.Parse(reader["jumlah_barang"].ToString());
            jumlahAkhir = jumlahAwal - 1;
          }
        }
        else
        {
          MessageBox.Show("Barang tidak ditemukan!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        reader.Close();
        conn.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString(), "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
      try
      {
        conn.Open();
        String query = "INSERT INTO pengurangan (tanggal, asal_barang, nama_barang, kode_jual, jumlah_awal, jumlah_akhir) VALUES (@tanggal, @asalBarang, @namaBarang, @kodeJual, @jumlahAwal, @jumlahAkhir)";
        OleDbCommand cmd = new OleDbCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = query;
        cmd.Parameters.AddWithValue("@tanggal", new DateTime());
        cmd.Parameters.AddWithValue("@asalBarang", asalBarang);
        cmd.Parameters.AddWithValue("@namaBarang", namaBarang);
        cmd.Parameters.AddWithValue("@kodeJual", kodeJual);
        cmd.Parameters.AddWithValue("@jumlahAwal", jumlahAwal);
        cmd.Parameters.AddWithValue("@jumlahAkhir", jumlahAkhir);
        cmd.Connection = conn;

        cmd.ExecuteNonQuery();
        conn.Close();
        //MessageBox.Show("Data berhasil disimpan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        show_pengurangan();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString(), "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    private void updateBarang(String kodeJual)
    {
      try
      {
        conn.Open();
        String query = "UPDATE barang SET jumlah_barang = jumlah_barang -1 WHERE kode_jual = @kodeJual";
        OleDbCommand cmd = new OleDbCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = query;
        cmd.Parameters.AddWithValue("@kodeJual", kodeJual);
        cmd.Connection = conn;

        cmd.ExecuteNonQuery();
        conn.Close();
        //MessageBox.Show("Data berhasil disimpan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        show_data();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString(), "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      frmReport frmReport = new frmReport();
      frmReport.ShowDialog();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }
  }  
}
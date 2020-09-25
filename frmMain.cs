using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
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
      simpan();
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
      txtHurufMandarin.Text = "";
      txtHurufMandarin.Enabled = false;
      numJumlahBarang.Value = 0;
      numJumlahBarang.Enabled = false;
      numJumlahCetak.Value = 0;
      numJumlahCetak.Enabled = false;

      btnSimpan.Enabled = false;
      btnCetak.Enabled = false;
      btnReset.Enabled = false;
      btnHapus.Enabled = false;
      btnKonversi.Enabled = false;
    }

    private void enable_item() {
      txtAsalBarang.Enabled = true;
      txtNamaBarang.Enabled = true;
      txtTipeMobil.Enabled = true;
      txtKodeJual.Enabled = true;
      txtKodeMandarin.Enabled = true;
      txtHurufMandarin.Enabled = true;
      numJumlahBarang.Enabled = true;
      numJumlahCetak.Enabled = true;

      btnSimpan.Enabled = true;
      btnCetak.Enabled = true;
      btnReset.Enabled = true;
      btnHapus.Enabled = true;
      btnKonversi.Enabled = true;
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
      String hurufMandarin = txtHurufMandarin.Text.Replace("'", "''");
      String jumlahBarang = numJumlahBarang.Value.ToString();

      if (asalBarang == "" || namaBarang == "" || tipeMobil == "" || kodeJual == "" || hurufMandarin == "")
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
            cmd.Parameters.AddWithValue("@hurufMandarin", hurufMandarin);
            cmd.Parameters.AddWithValue("@jumlahBarang", jumlahBarang);
            cmd.Connection = conn;

            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data berhasil disimpan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            cmd.Parameters.AddWithValue("@hurufMandarin", hurufMandarin);
            cmd.Parameters.AddWithValue("@jumlahBarang", jumlahBarang);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = conn;

            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data berhasil disimpan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    private String angkaCina(int angka)
    {
      String[] digits = { "零", "一", "二", "三", "四", "五", "六", "七", "八", "九" };
      String[] positions = { "", "十", "百", "千", "万", "十万", "百万", "千万", "亿", "十亿", "百亿", "千亿" };
      Char[] charArray = angka.ToString().ToCharArray();
      String result = "";
      bool prevIsZero = false;

      for (int i = 0; i < charArray.Length; i++)
      {
        Char ch = charArray[i];
        if (ch != '0' && !prevIsZero)
        {
          result += digits[(int)Char.GetNumericValue(ch)] + positions[charArray.Length - i - 1];
        }
        else if (ch == '0')
        {
          prevIsZero = true;
        }
        else if (ch != '0' && prevIsZero)
        {
          result += '零' + digits[(int)Char.GetNumericValue(ch)] + positions[charArray.Length - i - 1];
        };

      }
      return result;
    }

    private void btnKonversi_Click(object sender, EventArgs e)
    {
      String kodeMandarin = txtKodeMandarin.Text;
      int value;
      if (int.TryParse(kodeMandarin, out value))
      {
        txtHurufMandarin.Text = angkaCina(int.Parse(kodeMandarin));
      }
      else
      {
        MessageBox.Show("Konversi hanya berupa angka!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    private void btnCetak_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show("Apakah Anda yakin mencetak data ini?\n", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
      if (result == DialogResult.Yes)
      {
        print_data();
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
          MessageBox.Show("Data berhasil disimpan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
      dg.Rows[i].Selected = true;
    }

    private void dg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      int i = e.RowIndex;
      dg.Rows[i].Selected = true;
      String id = dg.Rows[i].Cells[0].Value.ToString();
      edit_data(id);
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
            txtHurufMandarin.Text = reader["huruf_mandarin"].ToString();
            numJumlahBarang.Value = int.Parse(reader["jumlah_barang"].ToString());
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
      String hurufMandarin = txtHurufMandarin.Text.Replace("'", "''");
      String jumlahBarang = numJumlahBarang.Value.ToString();
      try 
      {
        string settings = System.IO.File.ReadAllText("./settings.txt");
        var thePrinterConn = ConnectionBuilder.Build("USB:"+settings);
        try
        {
          // Open the connection - physical connection is established here.
          thePrinterConn.Open();

          // This example prints "This is a ZPL test." near the top of the label.
          string zplData = "^XA" +
            //item id
            "^FO00,22^A0,38,26^FD" + id + "^FS" +
            "^FO290,22^A0,38,26^FD" + id + "^FS" +
            "^FO580,22^A0,38,26^FD" + id + "^FS" +
            //item name 1
            "^FO00,55^A0,30,22^FD" + asalBarang + "^FS" +
            "^FO290,55^A0,30,22^FD" + asalBarang + "^FS" +
            "^FO580,55^A0,30,22^FD" + asalBarang + "^FS" +
            //item name 2
            "^FO00,82^A0,30,22^FD" + namaBarang + "^FS" +
            "^FO290,82^A0,30,22^FD" + namaBarang + "^FS" +
            "^FO580,82^A0,30,22^FD" + namaBarang + "^FS" +
            //item name 3
            "^FO00,108^A0,30,22^FD" + tipeMobil + "^FS" +
            "^FO290,108^A0,30,22^FD" + tipeMobil + "^FS" +
            "^FO580,108^A0,30,22^FD" + tipeMobil + "^FS" +
            //item chinese
            "^FO00,138^CI28^A@N,40,40,E:SIMSUN.FNT^FD" + hurufMandarin + "^FS" +
            "^FO290,138^CI28^A@N,40,40,E:SIMSUN.FNT^FD" + hurufMandarin + "^FS" +
            "^FO580,138^CI28^A@N,40,40,E:SIMSUN.FNT^FD" + hurufMandarin + "^FS" +
            "^XZ";

          // Send the data to printer as a byte array.
          thePrinterConn.Write(Encoding.UTF8.GetBytes(zplData));
        }
        catch (ConnectionException e)
        {
          // Handle communications error here.
          Console.WriteLine(e.ToString());
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
  }
}
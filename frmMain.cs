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
    }

    private void initialize_dg()
    {
      DataGridViewColumn id = new DataGridViewTextBoxColumn();
      id.DataPropertyName = "id";
      id.HeaderText = "ID";
      id.Name = "id";
      id.Width = 10;
      dg.Columns.Add(id);

      DataGridViewColumn asalBarang = new DataGridViewTextBoxColumn();
      asalBarang.DataPropertyName = "asalBarang";
      asalBarang.HeaderText = "Asal Barang";
      asalBarang.Name = "asalBarang";
      asalBarang.Width = 200;
      dg.Columns.Add(asalBarang);

      DataGridViewColumn namaBarang = new DataGridViewTextBoxColumn();
      namaBarang.DataPropertyName = "namaBarang";
      namaBarang.HeaderText = "Nama Barang";
      namaBarang.Name = "namaBarang";
      namaBarang.Width = 200;
      dg.Columns.Add(namaBarang);

      DataGridViewColumn tipeMobil = new DataGridViewTextBoxColumn();
      tipeMobil.DataPropertyName = "tipeMobil";
      tipeMobil.HeaderText = "Tipe Mobil";
      tipeMobil.Name = "tipeMobil";
      tipeMobil.Width = 200;
      dg.Columns.Add(tipeMobil);

      DataGridViewColumn kodeJual = new DataGridViewTextBoxColumn();
      kodeJual.DataPropertyName = "kodeJual";
      kodeJual.HeaderText = "Kode Jual";
      kodeJual.Name = "kodeJual";
      kodeJual.Width = 200;
      dg.Columns.Add(kodeJual);

      DataGridViewColumn kodeMandarin = new DataGridViewTextBoxColumn();
      kodeMandarin.DataPropertyName = "kodeMandarin";
      kodeMandarin.HeaderText = "Kode Mandarin";
      kodeMandarin.Name = "kodeMandarin";
      kodeMandarin.Width = 200;
      dg.Columns.Add(kodeMandarin);

      DataGridViewColumn hurufMandarin = new DataGridViewTextBoxColumn();
      hurufMandarin.DataPropertyName = "hurufMandarin";
      hurufMandarin.HeaderText = "Huruf Mandarin";
      hurufMandarin.Name = "hurufMandarin";
      hurufMandarin.Width = 200;
      dg.Columns.Add(hurufMandarin);

      DataGridViewColumn jumlahBarang = new DataGridViewTextBoxColumn();
      jumlahBarang.DataPropertyName = "jumlahBarang";
      jumlahBarang.HeaderText = "Jumlah Barang";
      jumlahBarang.Name = "jumlahBarang";
      jumlahBarang.Width = 200;
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
      btnReset.Enabled = true;
      btnKonversi.Enabled = true;
    }

    private void show_data() {
      //simpan();
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
            show_data();
          }
          catch (Exception ex)
          {
            MessageBox.Show(ex.ToString(), "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          }
        }
        else
        {
          //update
        }
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

    }

    private void btnHapus_Click(object sender, EventArgs e)
    {

    }
  }
}
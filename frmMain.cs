using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Megah_Motor_Inventory
{
  public partial class frmMain : Form
  {
    public frmMain()
    {
      InitializeComponent();
      initialize_dg();
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
  }
}

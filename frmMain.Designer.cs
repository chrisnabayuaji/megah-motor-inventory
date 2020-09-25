﻿namespace Megah_Motor_Inventory
{
  partial class frmMain
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.lblTitle = new System.Windows.Forms.Label();
      this.tblLayoutMain = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.btnTambah = new System.Windows.Forms.Button();
      this.txtCari = new System.Windows.Forms.TextBox();
      this.btnCari = new System.Windows.Forms.Button();
      this.btnResetCari = new System.Windows.Forms.Button();
      this.dg = new System.Windows.Forms.DataGridView();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.label2 = new System.Windows.Forms.Label();
      this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
      this.numJumlahCetak = new System.Windows.Forms.NumericUpDown();
      this.label10 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.txtHurufMandarin = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.txtKodeJual = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.txtTipeMobil = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtNamaBarang = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtAsalBarang = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
      this.btnSimpan = new System.Windows.Forms.Button();
      this.btnCetak = new System.Windows.Forms.Button();
      this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
      this.btnReset = new System.Windows.Forms.Button();
      this.btnHapus = new System.Windows.Forms.Button();
      this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
      this.txtKodeMandarin = new System.Windows.Forms.TextBox();
      this.btnKonversi = new System.Windows.Forms.Button();
      this.numJumlahBarang = new System.Windows.Forms.NumericUpDown();
      this.txtId = new System.Windows.Forms.TextBox();
      this.panel1.SuspendLayout();
      this.tblLayoutMain.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
      this.tableLayoutPanel3.SuspendLayout();
      this.tableLayoutPanel4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numJumlahCetak)).BeginInit();
      this.tableLayoutPanel6.SuspendLayout();
      this.tableLayoutPanel7.SuspendLayout();
      this.tableLayoutPanel5.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numJumlahBarang)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.lblTitle);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1245, 60);
      this.panel1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(8, 37);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(543, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Jl. Brigjen Katamso No.9, Prawirodirjan, Kec. Gondomanan, Kota Yogyakarta, Daerah" +
    " Istimewa Yogyakarta 55121";
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitle.ForeColor = System.Drawing.Color.White;
      this.lblTitle.Location = new System.Drawing.Point(3, 6);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(535, 31);
      this.lblTitle.TabIndex = 1;
      this.lblTitle.Text = "PROGRAM INVENTORY MEGAH MOTOR";
      // 
      // tblLayoutMain
      // 
      this.tblLayoutMain.ColumnCount = 2;
      this.tblLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
      this.tblLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
      this.tblLayoutMain.Controls.Add(this.tableLayoutPanel1, 0, 0);
      this.tblLayoutMain.Controls.Add(this.tableLayoutPanel3, 1, 0);
      this.tblLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tblLayoutMain.Location = new System.Drawing.Point(0, 60);
      this.tblLayoutMain.Name = "tblLayoutMain";
      this.tblLayoutMain.RowCount = 1;
      this.tblLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tblLayoutMain.Size = new System.Drawing.Size(1245, 570);
      this.tblLayoutMain.TabIndex = 1;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.dg, 0, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(741, 564);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 5;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tableLayoutPanel2.Controls.Add(this.btnTambah, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.txtCari, 2, 0);
      this.tableLayoutPanel2.Controls.Add(this.btnCari, 3, 0);
      this.tableLayoutPanel2.Controls.Add(this.btnResetCari, 4, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(735, 44);
      this.tableLayoutPanel2.TabIndex = 0;
      // 
      // btnTambah
      // 
      this.btnTambah.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnTambah.Location = new System.Drawing.Point(3, 3);
      this.btnTambah.Name = "btnTambah";
      this.btnTambah.Size = new System.Drawing.Size(114, 38);
      this.btnTambah.TabIndex = 0;
      this.btnTambah.Text = "Tambah";
      this.btnTambah.UseVisualStyleBackColor = true;
      this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
      // 
      // txtCari
      // 
      this.txtCari.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtCari.Location = new System.Drawing.Point(288, 3);
      this.txtCari.Name = "txtCari";
      this.txtCari.Size = new System.Drawing.Size(244, 38);
      this.txtCari.TabIndex = 1;
      // 
      // btnCari
      // 
      this.btnCari.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCari.Location = new System.Drawing.Point(538, 3);
      this.btnCari.Name = "btnCari";
      this.btnCari.Size = new System.Drawing.Size(94, 38);
      this.btnCari.TabIndex = 2;
      this.btnCari.Text = "Cari";
      this.btnCari.UseVisualStyleBackColor = true;
      // 
      // btnResetCari
      // 
      this.btnResetCari.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnResetCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnResetCari.Location = new System.Drawing.Point(638, 3);
      this.btnResetCari.Name = "btnResetCari";
      this.btnResetCari.Size = new System.Drawing.Size(94, 38);
      this.btnResetCari.TabIndex = 3;
      this.btnResetCari.Text = "Reset";
      this.btnResetCari.UseVisualStyleBackColor = true;
      // 
      // dg
      // 
      this.dg.AllowUserToAddRows = false;
      this.dg.AllowUserToDeleteRows = false;
      this.dg.AllowUserToOrderColumns = true;
      this.dg.AllowUserToResizeColumns = false;
      this.dg.AllowUserToResizeRows = false;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dg.DefaultCellStyle = dataGridViewCellStyle2;
      this.dg.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dg.Location = new System.Drawing.Point(3, 53);
      this.dg.Name = "dg";
      this.dg.RowHeadersVisible = false;
      this.dg.Size = new System.Drawing.Size(735, 508);
      this.dg.TabIndex = 1;
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 1;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
      this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
      this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel3.Location = new System.Drawing.Point(750, 3);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 2;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(492, 564);
      this.tableLayoutPanel3.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(3, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(486, 55);
      this.label2.TabIndex = 0;
      this.label2.Text = "FORM BARANG";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tableLayoutPanel4
      // 
      this.tableLayoutPanel4.ColumnCount = 2;
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
      this.tableLayoutPanel4.Controls.Add(this.numJumlahCetak, 1, 7);
      this.tableLayoutPanel4.Controls.Add(this.label10, 0, 7);
      this.tableLayoutPanel4.Controls.Add(this.label9, 0, 6);
      this.tableLayoutPanel4.Controls.Add(this.txtHurufMandarin, 1, 5);
      this.tableLayoutPanel4.Controls.Add(this.label8, 0, 5);
      this.tableLayoutPanel4.Controls.Add(this.label7, 0, 4);
      this.tableLayoutPanel4.Controls.Add(this.txtKodeJual, 1, 3);
      this.tableLayoutPanel4.Controls.Add(this.label6, 0, 3);
      this.tableLayoutPanel4.Controls.Add(this.txtTipeMobil, 1, 2);
      this.tableLayoutPanel4.Controls.Add(this.label5, 0, 2);
      this.tableLayoutPanel4.Controls.Add(this.txtNamaBarang, 1, 1);
      this.tableLayoutPanel4.Controls.Add(this.label4, 0, 1);
      this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
      this.tableLayoutPanel4.Controls.Add(this.txtAsalBarang, 1, 0);
      this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 1, 8);
      this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel7, 1, 9);
      this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 4);
      this.tableLayoutPanel4.Controls.Add(this.numJumlahBarang, 1, 6);
      this.tableLayoutPanel4.Controls.Add(this.txtId, 0, 8);
      this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 58);
      this.tableLayoutPanel4.Name = "tableLayoutPanel4";
      this.tableLayoutPanel4.RowCount = 11;
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel4.Size = new System.Drawing.Size(486, 503);
      this.tableLayoutPanel4.TabIndex = 1;
      // 
      // numJumlahCetak
      // 
      this.numJumlahCetak.Dock = System.Windows.Forms.DockStyle.Fill;
      this.numJumlahCetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numJumlahCetak.Location = new System.Drawing.Point(173, 318);
      this.numJumlahCetak.Name = "numJumlahCetak";
      this.numJumlahCetak.Size = new System.Drawing.Size(310, 38);
      this.numJumlahCetak.TabIndex = 25;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(3, 315);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(164, 45);
      this.label10.TabIndex = 24;
      this.label10.Text = "Kode Mandarin";
      this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(3, 270);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(164, 45);
      this.label9.TabIndex = 22;
      this.label9.Text = "Kode Mandarin";
      this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtHurufMandarin
      // 
      this.txtHurufMandarin.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtHurufMandarin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtHurufMandarin.Location = new System.Drawing.Point(173, 228);
      this.txtHurufMandarin.Name = "txtHurufMandarin";
      this.txtHurufMandarin.Size = new System.Drawing.Size(310, 38);
      this.txtHurufMandarin.TabIndex = 21;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(3, 225);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(164, 45);
      this.label8.TabIndex = 20;
      this.label8.Text = "Huruf Mandarin";
      this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(3, 180);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(164, 45);
      this.label7.TabIndex = 9;
      this.label7.Text = "Kode Mandarin";
      this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtKodeJual
      // 
      this.txtKodeJual.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtKodeJual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtKodeJual.Location = new System.Drawing.Point(173, 138);
      this.txtKodeJual.Name = "txtKodeJual";
      this.txtKodeJual.Size = new System.Drawing.Size(310, 38);
      this.txtKodeJual.TabIndex = 8;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(3, 135);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(164, 45);
      this.label6.TabIndex = 7;
      this.label6.Text = "Kode Jual";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtTipeMobil
      // 
      this.txtTipeMobil.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtTipeMobil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTipeMobil.Location = new System.Drawing.Point(173, 93);
      this.txtTipeMobil.Name = "txtTipeMobil";
      this.txtTipeMobil.Size = new System.Drawing.Size(310, 38);
      this.txtTipeMobil.TabIndex = 6;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(3, 90);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(164, 45);
      this.label5.TabIndex = 5;
      this.label5.Text = "Tipe Mobil";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtNamaBarang
      // 
      this.txtNamaBarang.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtNamaBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNamaBarang.Location = new System.Drawing.Point(173, 48);
      this.txtNamaBarang.Name = "txtNamaBarang";
      this.txtNamaBarang.Size = new System.Drawing.Size(310, 38);
      this.txtNamaBarang.TabIndex = 4;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(3, 45);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(164, 45);
      this.label4.TabIndex = 3;
      this.label4.Text = "Nama Barang";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(3, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(164, 45);
      this.label3.TabIndex = 1;
      this.label3.Text = "Asal Barang";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtAsalBarang
      // 
      this.txtAsalBarang.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtAsalBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtAsalBarang.Location = new System.Drawing.Point(173, 3);
      this.txtAsalBarang.Name = "txtAsalBarang";
      this.txtAsalBarang.Size = new System.Drawing.Size(310, 38);
      this.txtAsalBarang.TabIndex = 2;
      // 
      // tableLayoutPanel6
      // 
      this.tableLayoutPanel6.ColumnCount = 2;
      this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel6.Controls.Add(this.btnSimpan, 0, 0);
      this.tableLayoutPanel6.Controls.Add(this.btnCetak, 1, 0);
      this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel6.Location = new System.Drawing.Point(170, 360);
      this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel6.Name = "tableLayoutPanel6";
      this.tableLayoutPanel6.RowCount = 1;
      this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel6.Size = new System.Drawing.Size(316, 45);
      this.tableLayoutPanel6.TabIndex = 17;
      // 
      // btnSimpan
      // 
      this.btnSimpan.Location = new System.Drawing.Point(3, 3);
      this.btnSimpan.Name = "btnSimpan";
      this.btnSimpan.Size = new System.Drawing.Size(75, 23);
      this.btnSimpan.TabIndex = 0;
      this.btnSimpan.Text = "button2";
      this.btnSimpan.UseVisualStyleBackColor = true;
      this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
      // 
      // btnCetak
      // 
      this.btnCetak.Location = new System.Drawing.Point(161, 3);
      this.btnCetak.Name = "btnCetak";
      this.btnCetak.Size = new System.Drawing.Size(75, 23);
      this.btnCetak.TabIndex = 1;
      this.btnCetak.Text = "button3";
      this.btnCetak.UseVisualStyleBackColor = true;
      this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
      // 
      // tableLayoutPanel7
      // 
      this.tableLayoutPanel7.ColumnCount = 2;
      this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel7.Controls.Add(this.btnReset, 0, 0);
      this.tableLayoutPanel7.Controls.Add(this.btnHapus, 1, 0);
      this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel7.Location = new System.Drawing.Point(170, 405);
      this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel7.Name = "tableLayoutPanel7";
      this.tableLayoutPanel7.RowCount = 1;
      this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel7.Size = new System.Drawing.Size(316, 45);
      this.tableLayoutPanel7.TabIndex = 18;
      // 
      // btnReset
      // 
      this.btnReset.Location = new System.Drawing.Point(3, 3);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new System.Drawing.Size(75, 23);
      this.btnReset.TabIndex = 0;
      this.btnReset.Text = "button4";
      this.btnReset.UseVisualStyleBackColor = true;
      this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
      // 
      // btnHapus
      // 
      this.btnHapus.Location = new System.Drawing.Point(161, 3);
      this.btnHapus.Name = "btnHapus";
      this.btnHapus.Size = new System.Drawing.Size(75, 23);
      this.btnHapus.TabIndex = 1;
      this.btnHapus.Text = "button5";
      this.btnHapus.UseVisualStyleBackColor = true;
      this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
      // 
      // tableLayoutPanel5
      // 
      this.tableLayoutPanel5.ColumnCount = 2;
      this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
      this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
      this.tableLayoutPanel5.Controls.Add(this.txtKodeMandarin, 0, 0);
      this.tableLayoutPanel5.Controls.Add(this.btnKonversi, 1, 0);
      this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel5.Location = new System.Drawing.Point(170, 180);
      this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel5.Name = "tableLayoutPanel5";
      this.tableLayoutPanel5.RowCount = 1;
      this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel5.Size = new System.Drawing.Size(316, 45);
      this.tableLayoutPanel5.TabIndex = 19;
      // 
      // txtKodeMandarin
      // 
      this.txtKodeMandarin.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtKodeMandarin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtKodeMandarin.Location = new System.Drawing.Point(3, 3);
      this.txtKodeMandarin.Name = "txtKodeMandarin";
      this.txtKodeMandarin.Size = new System.Drawing.Size(199, 38);
      this.txtKodeMandarin.TabIndex = 0;
      // 
      // btnKonversi
      // 
      this.btnKonversi.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnKonversi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnKonversi.Location = new System.Drawing.Point(208, 3);
      this.btnKonversi.Name = "btnKonversi";
      this.btnKonversi.Size = new System.Drawing.Size(105, 39);
      this.btnKonversi.TabIndex = 1;
      this.btnKonversi.Text = "KONVERSI";
      this.btnKonversi.UseVisualStyleBackColor = true;
      this.btnKonversi.Click += new System.EventHandler(this.btnKonversi_Click);
      // 
      // numJumlahBarang
      // 
      this.numJumlahBarang.Dock = System.Windows.Forms.DockStyle.Fill;
      this.numJumlahBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numJumlahBarang.Location = new System.Drawing.Point(173, 273);
      this.numJumlahBarang.Name = "numJumlahBarang";
      this.numJumlahBarang.Size = new System.Drawing.Size(310, 38);
      this.numJumlahBarang.TabIndex = 23;
      // 
      // txtId
      // 
      this.txtId.Location = new System.Drawing.Point(3, 363);
      this.txtId.Name = "txtId";
      this.txtId.Size = new System.Drawing.Size(100, 20);
      this.txtId.TabIndex = 26;
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1245, 630);
      this.Controls.Add(this.tblLayoutMain);
      this.Controls.Add(this.panel1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "frmMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Megah Motor Inventory";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.tblLayoutMain.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
      this.tableLayoutPanel3.ResumeLayout(false);
      this.tableLayoutPanel3.PerformLayout();
      this.tableLayoutPanel4.ResumeLayout(false);
      this.tableLayoutPanel4.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numJumlahCetak)).EndInit();
      this.tableLayoutPanel6.ResumeLayout(false);
      this.tableLayoutPanel7.ResumeLayout(false);
      this.tableLayoutPanel5.ResumeLayout(false);
      this.tableLayoutPanel5.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numJumlahBarang)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TableLayoutPanel tblLayoutMain;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Button btnTambah;
    private System.Windows.Forms.TextBox txtCari;
    private System.Windows.Forms.Button btnCari;
    private System.Windows.Forms.Button btnResetCari;
    private System.Windows.Forms.DataGridView dg;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtAsalBarang;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox txtKodeJual;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtTipeMobil;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtNamaBarang;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    private System.Windows.Forms.TextBox txtKodeMandarin;
    private System.Windows.Forms.Button btnKonversi;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TextBox txtHurufMandarin;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.NumericUpDown numJumlahCetak;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.NumericUpDown numJumlahBarang;
    private System.Windows.Forms.Button btnSimpan;
    private System.Windows.Forms.Button btnCetak;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.Button btnHapus;
    private System.Windows.Forms.TextBox txtId;
  }
}


namespace ProyectoContabilidad.View
{
    partial class Balance
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSuma1 = new System.Windows.Forms.Label();
            this.lblSuma2 = new System.Windows.Forms.Label();
            this.lblSuma3 = new System.Windows.Forms.Label();
            this.lblSuma4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mov_deudor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mov_acree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo_deudor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo_acreedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.concepto,
            this.mov_deudor,
            this.mov_acree,
            this.saldo_deudor,
            this.saldo_acreedor});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(20, 79);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(868, 399);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "SUMAS IGUALES:";
            // 
            // lblSuma1
            // 
            this.lblSuma1.AutoSize = true;
            this.lblSuma1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSuma1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuma1.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblSuma1.Location = new System.Drawing.Point(237, 494);
            this.lblSuma1.Name = "lblSuma1";
            this.lblSuma1.Size = new System.Drawing.Size(125, 22);
            this.lblSuma1.TabIndex = 2;
            this.lblSuma1.Text = "Mov Deudor";
            // 
            // lblSuma2
            // 
            this.lblSuma2.AutoSize = true;
            this.lblSuma2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSuma2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuma2.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblSuma2.Location = new System.Drawing.Point(397, 494);
            this.lblSuma2.Name = "lblSuma2";
            this.lblSuma2.Size = new System.Drawing.Size(121, 22);
            this.lblSuma2.TabIndex = 3;
            this.lblSuma2.Text = "Mov Acreed";
            // 
            // lblSuma3
            // 
            this.lblSuma3.AutoSize = true;
            this.lblSuma3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSuma3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuma3.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblSuma3.Location = new System.Drawing.Point(564, 494);
            this.lblSuma3.Name = "lblSuma3";
            this.lblSuma3.Size = new System.Drawing.Size(119, 22);
            this.lblSuma3.TabIndex = 4;
            this.lblSuma3.Text = "Saldo Deud";
            // 
            // lblSuma4
            // 
            this.lblSuma4.AutoSize = true;
            this.lblSuma4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSuma4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuma4.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblSuma4.Location = new System.Drawing.Point(709, 494);
            this.lblSuma4.Name = "lblSuma4";
            this.lblSuma4.Size = new System.Drawing.Size(135, 22);
            this.lblSuma4.TabIndex = 5;
            this.lblSuma4.Text = "Saldo Acreed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "BALANCE DE COMPROBACIÓN";
            // 
            // cod
            // 
            this.cod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cod.FillWeight = 100.1218F;
            this.cod.HeaderText = "Código de Cuenta";
            this.cod.MinimumWidth = 6;
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            this.cod.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // concepto
            // 
            this.concepto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.concepto.FillWeight = 100.0962F;
            this.concepto.HeaderText = "Concepto";
            this.concepto.MinimumWidth = 6;
            this.concepto.Name = "concepto";
            this.concepto.ReadOnly = true;
            this.concepto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.concepto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // mov_deudor
            // 
            this.mov_deudor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mov_deudor.FillWeight = 99.34443F;
            this.mov_deudor.HeaderText = "Movimiento Deudor";
            this.mov_deudor.MinimumWidth = 6;
            this.mov_deudor.Name = "mov_deudor";
            this.mov_deudor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mov_deudor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // mov_acree
            // 
            this.mov_acree.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mov_acree.FillWeight = 100.179F;
            this.mov_acree.HeaderText = "Movimiento Acreedor";
            this.mov_acree.MinimumWidth = 6;
            this.mov_acree.Name = "mov_acree";
            this.mov_acree.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mov_acree.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // saldo_deudor
            // 
            this.saldo_deudor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.saldo_deudor.FillWeight = 100.1439F;
            this.saldo_deudor.HeaderText = "Saldo Deudor";
            this.saldo_deudor.MinimumWidth = 6;
            this.saldo_deudor.Name = "saldo_deudor";
            this.saldo_deudor.ReadOnly = true;
            this.saldo_deudor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.saldo_deudor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // saldo_acreedor
            // 
            this.saldo_acreedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.saldo_acreedor.FillWeight = 100.1146F;
            this.saldo_acreedor.HeaderText = "Saldo Acreedor";
            this.saldo_acreedor.MinimumWidth = 6;
            this.saldo_acreedor.Name = "saldo_acreedor";
            this.saldo_acreedor.ReadOnly = true;
            this.saldo_acreedor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.saldo_acreedor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Balance
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(900, 647);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSuma4);
            this.Controls.Add(this.lblSuma3);
            this.Controls.Add(this.lblSuma2);
            this.Controls.Add(this.lblSuma1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Balance";
            this.Text = "Balance";
            this.Load += new System.EventHandler(this.Balance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSuma1;
        private System.Windows.Forms.Label lblSuma2;
        private System.Windows.Forms.Label lblSuma3;
        private System.Windows.Forms.Label lblSuma4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn mov_deudor;
        private System.Windows.Forms.DataGridViewTextBoxColumn mov_acree;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo_deudor;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo_acreedor;
    }
}
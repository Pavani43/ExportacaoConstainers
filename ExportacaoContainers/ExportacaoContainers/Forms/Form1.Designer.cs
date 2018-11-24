namespace ExportacaoContainers.Forms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.data_entrega = new System.Windows.Forms.TextBox();
            this.porto_entrega = new System.Windows.Forms.TextBox();
            this.data_saida = new System.Windows.Forms.TextBox();
            this.porto_saida = new System.Windows.Forms.TextBox();
            this.peso = new System.Windows.Forms.TextBox();
            this.cod_navio = new System.Windows.Forms.TextBox();
            this.cod_lacre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet = new ExportacaoContainers.Database1DataSet();
            this.tabelaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabelaTableAdapter = new ExportacaoContainers.Database1DataSetTableAdapters.TabelaTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codlacreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portosaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portoentregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codnavioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataentregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(791, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 40);
            this.button1.TabIndex = 27;
            this.button1.Text = "Registrar exportação";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // data_entrega
            // 
            this.data_entrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_entrega.Location = new System.Drawing.Point(791, 110);
            this.data_entrega.Name = "data_entrega";
            this.data_entrega.Size = new System.Drawing.Size(258, 27);
            this.data_entrega.TabIndex = 26;
            // 
            // porto_entrega
            // 
            this.porto_entrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porto_entrega.Location = new System.Drawing.Point(176, 110);
            this.porto_entrega.Name = "porto_entrega";
            this.porto_entrega.Size = new System.Drawing.Size(362, 27);
            this.porto_entrega.TabIndex = 25;
            // 
            // data_saida
            // 
            this.data_saida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_saida.Location = new System.Drawing.Point(791, 78);
            this.data_saida.Name = "data_saida";
            this.data_saida.Size = new System.Drawing.Size(258, 27);
            this.data_saida.TabIndex = 24;
            // 
            // porto_saida
            // 
            this.porto_saida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porto_saida.Location = new System.Drawing.Point(176, 78);
            this.porto_saida.Name = "porto_saida";
            this.porto_saida.Size = new System.Drawing.Size(362, 27);
            this.porto_saida.TabIndex = 23;
            // 
            // peso
            // 
            this.peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peso.Location = new System.Drawing.Point(924, 45);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(125, 27);
            this.peso.TabIndex = 22;
            // 
            // cod_navio
            // 
            this.cod_navio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_navio.Location = new System.Drawing.Point(548, 45);
            this.cod_navio.Name = "cod_navio";
            this.cod_navio.Size = new System.Drawing.Size(197, 27);
            this.cod_navio.TabIndex = 21;
            // 
            // cod_lacre
            // 
            this.cod_lacre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_lacre.Location = new System.Drawing.Point(176, 45);
            this.cod_lacre.Name = "cod_lacre";
            this.cod_lacre.Size = new System.Drawing.Size(209, 27);
            this.cod_lacre.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(751, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Peso do container:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(391, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Código do navio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(544, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Data de saída:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Porto de saída:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Porto de chegada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(544, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data prevista para entrega:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Código do lacre:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(29, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1055, 289);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de containers";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.data_entrega);
            this.groupBox1.Controls.Add(this.porto_entrega);
            this.groupBox1.Controls.Add(this.data_saida);
            this.groupBox1.Controls.Add(this.porto_saida);
            this.groupBox1.Controls.Add(this.peso);
            this.groupBox1.Controls.Add(this.cod_navio);
            this.groupBox1.Controls.Add(this.cod_lacre);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1055, 206);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de exportação";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codlacreDataGridViewTextBoxColumn,
            this.portosaidaDataGridViewTextBoxColumn,
            this.portoentregaDataGridViewTextBoxColumn,
            this.codnavioDataGridViewTextBoxColumn,
            this.pesoDataGridViewTextBoxColumn,
            this.datasaidaDataGridViewTextBoxColumn,
            this.dataentregaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tabelaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabelaBindingSource
            // 
            this.tabelaBindingSource.DataMember = "Tabela";
            this.tabelaBindingSource.DataSource = this.database1DataSet;
            // 
            // tabelaTableAdapter
            // 
            this.tabelaTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codlacreDataGridViewTextBoxColumn
            // 
            this.codlacreDataGridViewTextBoxColumn.DataPropertyName = "cod_lacre";
            this.codlacreDataGridViewTextBoxColumn.HeaderText = "cod_lacre";
            this.codlacreDataGridViewTextBoxColumn.Name = "codlacreDataGridViewTextBoxColumn";
            // 
            // portosaidaDataGridViewTextBoxColumn
            // 
            this.portosaidaDataGridViewTextBoxColumn.DataPropertyName = "porto_saida";
            this.portosaidaDataGridViewTextBoxColumn.HeaderText = "porto_saida";
            this.portosaidaDataGridViewTextBoxColumn.Name = "portosaidaDataGridViewTextBoxColumn";
            // 
            // portoentregaDataGridViewTextBoxColumn
            // 
            this.portoentregaDataGridViewTextBoxColumn.DataPropertyName = "porto_entrega";
            this.portoentregaDataGridViewTextBoxColumn.HeaderText = "porto_entrega";
            this.portoentregaDataGridViewTextBoxColumn.Name = "portoentregaDataGridViewTextBoxColumn";
            // 
            // codnavioDataGridViewTextBoxColumn
            // 
            this.codnavioDataGridViewTextBoxColumn.DataPropertyName = "cod_navio";
            this.codnavioDataGridViewTextBoxColumn.HeaderText = "cod_navio";
            this.codnavioDataGridViewTextBoxColumn.Name = "codnavioDataGridViewTextBoxColumn";
            // 
            // pesoDataGridViewTextBoxColumn
            // 
            this.pesoDataGridViewTextBoxColumn.DataPropertyName = "peso";
            this.pesoDataGridViewTextBoxColumn.HeaderText = "peso";
            this.pesoDataGridViewTextBoxColumn.Name = "pesoDataGridViewTextBoxColumn";
            // 
            // datasaidaDataGridViewTextBoxColumn
            // 
            this.datasaidaDataGridViewTextBoxColumn.DataPropertyName = "data_saida";
            this.datasaidaDataGridViewTextBoxColumn.HeaderText = "data_saida";
            this.datasaidaDataGridViewTextBoxColumn.Name = "datasaidaDataGridViewTextBoxColumn";
            // 
            // dataentregaDataGridViewTextBoxColumn
            // 
            this.dataentregaDataGridViewTextBoxColumn.DataPropertyName = "data_entrega";
            this.dataentregaDataGridViewTextBoxColumn.HeaderText = "data_entrega";
            this.dataentregaDataGridViewTextBoxColumn.Name = "dataentregaDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 523);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Controle de Containers de Exportação";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox data_entrega;
        private System.Windows.Forms.TextBox porto_entrega;
        private System.Windows.Forms.TextBox data_saida;
        private System.Windows.Forms.TextBox porto_saida;
        private System.Windows.Forms.TextBox peso;
        private System.Windows.Forms.TextBox cod_navio;
        private System.Windows.Forms.TextBox cod_lacre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tabelaBindingSource;
        private Database1DataSetTableAdapters.TabelaTableAdapter tabelaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codlacreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn portosaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn portoentregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codnavioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataentregaDataGridViewTextBoxColumn;
    }
}


namespace AlmacenTech
{
    partial class rEquiposAsignadossForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label equipoIdLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rEquiposAsignadossForm));
            this.searchButton = new System.Windows.Forms.Button();
            this.equipoIdTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.EquiposcomboBox = new System.Windows.Forms.ComboBox();
            this.PaqueteEquiposdataGridView = new System.Windows.Forms.DataGridView();
            this.EquipoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DetalletextBox = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.BuscarerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DatagrilderrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DetalleerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            equipoIdLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaqueteEquiposdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatagrilderrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // equipoIdLabel
            // 
            equipoIdLabel.AutoSize = true;
            equipoIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            equipoIdLabel.Location = new System.Drawing.Point(11, 80);
            equipoIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            equipoIdLabel.Name = "equipoIdLabel";
            equipoIdLabel.Size = new System.Drawing.Size(30, 16);
            equipoIdLabel.TabIndex = 10;
            equipoIdLabel.Text = "ID : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(5, 32);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 16);
            label1.TabIndex = 12;
            label1.Text = "Equipo ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(11, 126);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 16);
            label2.TabIndex = 13;
            label2.Text = "Detalle : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label3.Location = new System.Drawing.Point(86, 9);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(374, 25);
            label3.TabIndex = 18;
            label3.Text = "       Registro de Equipos para asignar";
            label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.searchButton.Location = new System.Drawing.Point(200, 73);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(61, 29);
            this.searchButton.TabIndex = 2;
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // equipoIdTextBox
            // 
            this.equipoIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipoIdTextBox.Location = new System.Drawing.Point(76, 77);
            this.equipoIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.equipoIdTextBox.Name = "equipoIdTextBox";
            this.equipoIdTextBox.Size = new System.Drawing.Size(88, 22);
            this.equipoIdTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Agregarbutton);
            this.groupBox1.Controls.Add(this.EquiposcomboBox);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.PaqueteEquiposdataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 230);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equipos";
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Agregarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Agregarbutton.Image")));
            this.Agregarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Agregarbutton.Location = new System.Drawing.Point(411, 32);
            this.Agregarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(61, 39);
            this.Agregarbutton.TabIndex = 2;
            this.Agregarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // EquiposcomboBox
            // 
            this.EquiposcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EquiposcomboBox.FormattingEnabled = true;
            this.EquiposcomboBox.Location = new System.Drawing.Point(78, 32);
            this.EquiposcomboBox.Name = "EquiposcomboBox";
            this.EquiposcomboBox.Size = new System.Drawing.Size(328, 24);
            this.EquiposcomboBox.TabIndex = 1;
            // 
            // PaqueteEquiposdataGridView
            // 
            this.PaqueteEquiposdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PaqueteEquiposdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EquipoId,
            this.Marca,
            this.Tipo});
            this.PaqueteEquiposdataGridView.Location = new System.Drawing.Point(6, 76);
            this.PaqueteEquiposdataGridView.Name = "PaqueteEquiposdataGridView";
            this.PaqueteEquiposdataGridView.Size = new System.Drawing.Size(466, 139);
            this.PaqueteEquiposdataGridView.TabIndex = 0;
            // 
            // EquipoId
            // 
            this.EquipoId.DataPropertyName = "EquipoId";
            this.EquipoId.HeaderText = "Equipo ID";
            this.EquipoId.Name = "EquipoId";
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "MarcaEquipo";
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tipo.DataPropertyName = "TipoId";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // SaveButton
            // 
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SaveButton.Location = new System.Drawing.Point(164, 415);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(66, 52);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Guardar";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DetalletextBox
            // 
            this.DetalletextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.DetalletextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetalletextBox.Location = new System.Drawing.Point(76, 123);
            this.DetalletextBox.Name = "DetalletextBox";
            this.DetalletextBox.Size = new System.Drawing.Size(429, 22);
            this.DetalletextBox.TabIndex = 3;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Image = ((System.Drawing.Image)(resources.GetObject("UpdateButton.Image")));
            this.UpdateButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UpdateButton.Location = new System.Drawing.Point(278, 415);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(66, 50);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "Actualizar";
            this.UpdateButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewButton.Image = ((System.Drawing.Image)(resources.GetObject("NewButton.Image")));
            this.NewButton.Location = new System.Drawing.Point(58, 413);
            this.NewButton.Margin = new System.Windows.Forms.Padding(2);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(66, 52);
            this.NewButton.TabIndex = 5;
            this.NewButton.Text = "Nuevo";
            this.NewButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.Image = ((System.Drawing.Image)(resources.GetObject("Deletebutton.Image")));
            this.Deletebutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Deletebutton.Location = new System.Drawing.Point(392, 415);
            this.Deletebutton.Margin = new System.Windows.Forms.Padding(2);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(68, 50);
            this.Deletebutton.TabIndex = 8;
            this.Deletebutton.Text = "Eliminar";
            this.Deletebutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // BuscarerrorProvider
            // 
            this.BuscarerrorProvider.ContainerControl = this;
            // 
            // DatagrilderrorProvider
            // 
            this.DatagrilderrorProvider.ContainerControl = this;
            // 
            // DetalleerrorProvider
            // 
            this.DetalleerrorProvider.ContainerControl = this;
            // 
            // rEquiposAsignadossForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 478);
            this.Controls.Add(label3);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.DetalletextBox);
            this.Controls.Add(label2);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(equipoIdLabel);
            this.Controls.Add(this.equipoIdTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(538, 517);
            this.MinimumSize = new System.Drawing.Size(538, 517);
            this.Name = "rEquiposAsignadossForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.rPaqueteEquiposForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaqueteEquiposdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatagrilderrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox equipoIdTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.ComboBox EquiposcomboBox;
        private System.Windows.Forms.DataGridView PaqueteEquiposdataGridView;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox DetalletextBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.ErrorProvider BuscarerrorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.ErrorProvider DatagrilderrorProvider;
        private System.Windows.Forms.ErrorProvider DetalleerrorProvider;
    }
}
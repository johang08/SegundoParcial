namespace SegundoParcial.UI.Registro
{
    partial class RVendedor
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
            this.label6 = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.RetencionnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SueldonumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RetencionnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SueldonumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 286);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Fecha ";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(85, 283);
            this.FechadateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(147, 22);
            this.FechadateTimePicker.TabIndex = 30;
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(363, 284);
            this.TotaltextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.ReadOnly = true;
            this.TotaltextBox.Size = new System.Drawing.Size(120, 22);
            this.TotaltextBox.TabIndex = 29;
            // 
            // RetencionnumericUpDown
            // 
            this.RetencionnumericUpDown.DecimalPlaces = 2;
            this.RetencionnumericUpDown.Location = new System.Drawing.Point(324, 210);
            this.RetencionnumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.RetencionnumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.RetencionnumericUpDown.Name = "RetencionnumericUpDown";
            this.RetencionnumericUpDown.Size = new System.Drawing.Size(160, 22);
            this.RetencionnumericUpDown.TabIndex = 28;
            this.RetencionnumericUpDown.ValueChanged += new System.EventHandler(this.RetencionnumericUpDown_ValueChanged_1);
            // 
            // SueldonumericUpDown
            // 
            this.SueldonumericUpDown.DecimalPlaces = 2;
            this.SueldonumericUpDown.Location = new System.Drawing.Point(85, 208);
            this.SueldonumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.SueldonumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.SueldonumericUpDown.Name = "SueldonumericUpDown";
            this.SueldonumericUpDown.Size = new System.Drawing.Size(148, 22);
            this.SueldonumericUpDown.TabIndex = 27;
            this.SueldonumericUpDown.ValueChanged += new System.EventHandler(this.SueldonumericUpDown_ValueChanged_1);
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(85, 126);
            this.NombretextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(376, 22);
            this.NombretextBox.TabIndex = 26;
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(85, 60);
            this.IDnumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.IDnumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(117, 22);
            this.IDnumericUpDown.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 288);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "TotalReteciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Retencion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Sueldo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID";
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::SegundoParcialDanny.Properties.Resources.search;
            this.Buscarbutton.Location = new System.Drawing.Point(245, 13);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(100, 92);
            this.Buscarbutton.TabIndex = 19;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.button4_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::SegundoParcialDanny.Properties.Resources.delete;
            this.EliminarButton.Location = new System.Drawing.Point(374, 389);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(4);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(100, 85);
            this.EliminarButton.TabIndex = 18;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::SegundoParcialDanny.Properties.Resources.save;
            this.GuardarButton.Location = new System.Drawing.Point(204, 389);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(4);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(100, 85);
            this.GuardarButton.TabIndex = 17;
            this.GuardarButton.Text = "Guarda";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::SegundoParcialDanny.Properties.Resources.document_new;
            this.NuevoButton.Location = new System.Drawing.Point(35, 389);
            this.NuevoButton.Margin = new System.Windows.Forms.Padding(4);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(100, 85);
            this.NuevoButton.TabIndex = 16;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 493);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.RetencionnumericUpDown);
            this.Controls.Add(this.SueldonumericUpDown);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Name = "RVendedor";
            this.Text = "RVendedor";
            ((System.ComponentModel.ISupportInitialize)(this.RetencionnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SueldonumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.NumericUpDown RetencionnumericUpDown;
        private System.Windows.Forms.NumericUpDown SueldonumericUpDown;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
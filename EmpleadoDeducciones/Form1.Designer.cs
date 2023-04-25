namespace EmpleadoDeducciones
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.mskCedula = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.mskSalarioBruto = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbSemanal = new System.Windows.Forms.RadioButton();
            this.rdbQuincenal = new System.Windows.Forms.RadioButton();
            this.rdbMensual = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkAsociacion = new System.Windows.Forms.CheckBox();
            this.chkPolizaVida = new System.Windows.Forms.CheckBox();
            this.chkAhorroObligatorio = new System.Windows.Forms.CheckBox();
            this.chkSeguroSocial = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalarioNeto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula";
            // 
            // mskCedula
            // 
            this.mskCedula.Location = new System.Drawing.Point(113, 25);
            this.mskCedula.Mask = "9-9999-9999";
            this.mskCedula.Name = "mskCedula";
            this.mskCedula.Size = new System.Drawing.Size(100, 22);
            this.mskCedula.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(113, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "F. Nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(113, 119);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaNacimiento.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Salario Bruto";
            // 
            // mskSalarioBruto
            // 
            this.mskSalarioBruto.Location = new System.Drawing.Point(113, 174);
            this.mskSalarioBruto.Mask = "0000000000";
            this.mskSalarioBruto.Name = "mskSalarioBruto";
            this.mskSalarioBruto.Size = new System.Drawing.Size(100, 22);
            this.mskSalarioBruto.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbFemenino);
            this.groupBox1.Controls.Add(this.rdbMasculino);
            this.groupBox1.Location = new System.Drawing.Point(18, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 110);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genero";
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(7, 75);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(91, 21);
            this.rdbFemenino.TabIndex = 1;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(7, 33);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(92, 21);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbSemanal);
            this.groupBox2.Controls.Add(this.rdbQuincenal);
            this.groupBox2.Controls.Add(this.rdbMensual);
            this.groupBox2.Location = new System.Drawing.Point(32, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Forma de pago";
            // 
            // rdbSemanal
            // 
            this.rdbSemanal.AutoSize = true;
            this.rdbSemanal.Location = new System.Drawing.Point(296, 38);
            this.rdbSemanal.Name = "rdbSemanal";
            this.rdbSemanal.Size = new System.Drawing.Size(84, 21);
            this.rdbSemanal.TabIndex = 2;
            this.rdbSemanal.TabStop = true;
            this.rdbSemanal.Text = "Semanal";
            this.rdbSemanal.UseVisualStyleBackColor = true;
            // 
            // rdbQuincenal
            // 
            this.rdbQuincenal.AutoSize = true;
            this.rdbQuincenal.Location = new System.Drawing.Point(134, 38);
            this.rdbQuincenal.Name = "rdbQuincenal";
            this.rdbQuincenal.Size = new System.Drawing.Size(93, 21);
            this.rdbQuincenal.TabIndex = 1;
            this.rdbQuincenal.TabStop = true;
            this.rdbQuincenal.Text = "Quincenal";
            this.rdbQuincenal.UseVisualStyleBackColor = true;
            // 
            // rdbMensual
            // 
            this.rdbMensual.AutoSize = true;
            this.rdbMensual.Location = new System.Drawing.Point(7, 38);
            this.rdbMensual.Name = "rdbMensual";
            this.rdbMensual.Size = new System.Drawing.Size(82, 21);
            this.rdbMensual.TabIndex = 0;
            this.rdbMensual.TabStop = true;
            this.rdbMensual.Text = "Mensual";
            this.rdbMensual.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkAsociacion);
            this.groupBox3.Controls.Add(this.chkPolizaVida);
            this.groupBox3.Controls.Add(this.chkAhorroObligatorio);
            this.groupBox3.Controls.Add(this.chkSeguroSocial);
            this.groupBox3.Location = new System.Drawing.Point(570, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 182);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Deducciones";
            // 
            // chkAsociacion
            // 
            this.chkAsociacion.AutoSize = true;
            this.chkAsociacion.Location = new System.Drawing.Point(7, 144);
            this.chkAsociacion.Name = "chkAsociacion";
            this.chkAsociacion.Size = new System.Drawing.Size(122, 21);
            this.chkAsociacion.TabIndex = 3;
            this.chkAsociacion.Text = "Asociacion 3%";
            this.chkAsociacion.UseVisualStyleBackColor = true;
            // 
            // chkPolizaVida
            // 
            this.chkPolizaVida.AutoSize = true;
            this.chkPolizaVida.Location = new System.Drawing.Point(7, 106);
            this.chkPolizaVida.Name = "chkPolizaVida";
            this.chkPolizaVida.Size = new System.Drawing.Size(142, 21);
            this.chkPolizaVida.TabIndex = 2;
            this.chkPolizaVida.Text = "Poliza de vida 2%";
            this.chkPolizaVida.UseVisualStyleBackColor = true;
            // 
            // chkAhorroObligatorio
            // 
            this.chkAhorroObligatorio.AutoSize = true;
            this.chkAhorroObligatorio.Checked = true;
            this.chkAhorroObligatorio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAhorroObligatorio.Enabled = false;
            this.chkAhorroObligatorio.Location = new System.Drawing.Point(7, 66);
            this.chkAhorroObligatorio.Name = "chkAhorroObligatorio";
            this.chkAhorroObligatorio.Size = new System.Drawing.Size(170, 21);
            this.chkAhorroObligatorio.TabIndex = 1;
            this.chkAhorroObligatorio.Text = "Ahorro Obligatorio 5%";
            this.chkAhorroObligatorio.UseVisualStyleBackColor = true;
            // 
            // chkSeguroSocial
            // 
            this.chkSeguroSocial.AutoSize = true;
            this.chkSeguroSocial.Checked = true;
            this.chkSeguroSocial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSeguroSocial.Enabled = false;
            this.chkSeguroSocial.Location = new System.Drawing.Point(7, 22);
            this.chkSeguroSocial.Name = "chkSeguroSocial";
            this.chkSeguroSocial.Size = new System.Drawing.Size(142, 21);
            this.chkSeguroSocial.TabIndex = 0;
            this.chkSeguroSocial.Text = "Seguro Social 9%";
            this.chkSeguroSocial.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(577, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Salario Neto";
            // 
            // txtSalarioNeto
            // 
            this.txtSalarioNeto.Location = new System.Drawing.Point(683, 236);
            this.txtSalarioNeto.Name = "txtSalarioNeto";
            this.txtSalarioNeto.ReadOnly = true;
            this.txtSalarioNeto.Size = new System.Drawing.Size(100, 22);
            this.txtSalarioNeto.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(570, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Edad";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(570, 387);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 17;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(636, 309);
            this.nudEdad.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(120, 22);
            this.nudEdad.TabIndex = 18;
            this.nudEdad.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 651);
            this.Controls.Add(this.nudEdad);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSalarioNeto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mskSalarioBruto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskCedula);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskSalarioBruto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbSemanal;
        private System.Windows.Forms.RadioButton rdbQuincenal;
        private System.Windows.Forms.RadioButton rdbMensual;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkAsociacion;
        private System.Windows.Forms.CheckBox chkPolizaVida;
        private System.Windows.Forms.CheckBox chkAhorroObligatorio;
        private System.Windows.Forms.CheckBox chkSeguroSocial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSalarioNeto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}


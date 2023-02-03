namespace Mili_Km
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radBtn2 = new System.Windows.Forms.RadioButton();
            this.radBtn1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMilKm = new System.Windows.Forms.TextBox();
            this.txtKmMil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radBtn2);
            this.groupBox1.Controls.Add(this.radBtn1);
            this.groupBox1.Location = new System.Drawing.Point(190, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите вариант перевода";
            // 
            // radBtn2
            // 
            this.radBtn2.AutoSize = true;
            this.radBtn2.Location = new System.Drawing.Point(31, 67);
            this.radBtn2.Name = "radBtn2";
            this.radBtn2.Size = new System.Drawing.Size(173, 20);
            this.radBtn2.TabIndex = 1;
            this.radBtn2.TabStop = true;
            this.radBtn2.Text = "Из километров в мили";
            this.radBtn2.UseVisualStyleBackColor = true;
            this.radBtn2.CheckedChanged += new System.EventHandler(this.radBtn2_CheckedChanged);
            // 
            // radBtn1
            // 
            this.radBtn1.AutoSize = true;
            this.radBtn1.Location = new System.Drawing.Point(31, 41);
            this.radBtn1.Name = "radBtn1";
            this.radBtn1.Size = new System.Drawing.Size(165, 20);
            this.radBtn1.TabIndex = 0;
            this.radBtn1.TabStop = true;
            this.radBtn1.Text = "Из миль в километры";
            this.radBtn1.UseVisualStyleBackColor = true;
            this.radBtn1.CheckedChanged += new System.EventHandler(this.radBtn1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(160, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Программа перевода значения в милях \r\nв значение в километрах \r\nи обратно";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите значение в милях";
            this.label2.Visible = false;
            // 
            // txtMilKm
            // 
            this.txtMilKm.Location = new System.Drawing.Point(238, 290);
            this.txtMilKm.Name = "txtMilKm";
            this.txtMilKm.Size = new System.Drawing.Size(148, 22);
            this.txtMilKm.TabIndex = 3;
            this.txtMilKm.Visible = false;
            this.txtMilKm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMilKm_KeyPress);
            // 
            // txtKmMil
            // 
            this.txtKmMil.Location = new System.Drawing.Point(273, 329);
            this.txtKmMil.Name = "txtKmMil";
            this.txtKmMil.Size = new System.Drawing.Size(148, 22);
            this.txtKmMil.TabIndex = 5;
            this.txtKmMil.Visible = false;
            this.txtKmMil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKmMil_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите значение в километрах";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(38, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 38);
            this.label4.TabIndex = 6;
            this.label4.Text = "Результат вычислений: \r\n\r\n";
            this.label4.Visible = false;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(209, 494);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(156, 32);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Вычислить";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(39, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKmMil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMilKm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мили-километры";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radBtn2;
        private System.Windows.Forms.RadioButton radBtn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMilKm;
        private System.Windows.Forms.TextBox txtKmMil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label5;
    }
}


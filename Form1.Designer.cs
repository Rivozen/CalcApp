namespace CalcApp
{
    partial class Form1
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
            this.field_HA = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.field_resultD = new System.Windows.Forms.TextBox();
            this.field_resultH = new System.Windows.Forms.TextBox();
            this.field_DB = new System.Windows.Forms.TextBox();
            this.field_HB = new System.Windows.Forms.TextBox();
            this.field_DA = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bA = new System.Windows.Forms.Button();
            this.bB = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.bD = new System.Windows.Forms.Button();
            this.bE = new System.Windows.Forms.Button();
            this.bF = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clear_current = new System.Windows.Forms.Button();
            this.clear_all = new System.Windows.Forms.Button();
            this.action_mod = new System.Windows.Forms.Button();
            this.action_div = new System.Windows.Forms.Button();
            this.action_mul = new System.Windows.Forms.Button();
            this.action_dif = new System.Windows.Forms.Button();
            this.action_sum = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // field_HA
            // 
            this.field_HA.Location = new System.Drawing.Point(71, 35);
            this.field_HA.Name = "field_HA";
            this.field_HA.Size = new System.Drawing.Size(144, 20);
            this.field_HA.TabIndex = 0;
            this.field_HA.Enter += new System.EventHandler(this.field_HA_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.field_resultD);
            this.groupBox1.Controls.Add(this.field_resultH);
            this.groupBox1.Controls.Add(this.field_DB);
            this.groupBox1.Controls.Add(this.field_HB);
            this.groupBox1.Controls.Add(this.field_DA);
            this.groupBox1.Controls.Add(this.field_HA);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 119);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отображение";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Результат";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Число B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Число А";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "DEC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "HEX";
            // 
            // field_resultD
            // 
            this.field_resultD.Location = new System.Drawing.Point(221, 87);
            this.field_resultD.Name = "field_resultD";
            this.field_resultD.ReadOnly = true;
            this.field_resultD.Size = new System.Drawing.Size(144, 20);
            this.field_resultD.TabIndex = 5;
            // 
            // field_resultH
            // 
            this.field_resultH.Location = new System.Drawing.Point(71, 87);
            this.field_resultH.Name = "field_resultH";
            this.field_resultH.ReadOnly = true;
            this.field_resultH.Size = new System.Drawing.Size(144, 20);
            this.field_resultH.TabIndex = 4;
            // 
            // field_DB
            // 
            this.field_DB.Location = new System.Drawing.Point(221, 61);
            this.field_DB.Name = "field_DB";
            this.field_DB.Size = new System.Drawing.Size(144, 20);
            this.field_DB.TabIndex = 3;
            this.field_DB.Enter += new System.EventHandler(this.field_DB_Enter);
            // 
            // field_HB
            // 
            this.field_HB.Location = new System.Drawing.Point(71, 61);
            this.field_HB.Name = "field_HB";
            this.field_HB.Size = new System.Drawing.Size(144, 20);
            this.field_HB.TabIndex = 2;
            this.field_HB.Enter += new System.EventHandler(this.field_HB_Enter);
            // 
            // field_DA
            // 
            this.field_DA.Location = new System.Drawing.Point(221, 35);
            this.field_DA.Name = "field_DA";
            this.field_DA.Size = new System.Drawing.Size(144, 20);
            this.field_DA.TabIndex = 1;
            this.field_DA.Enter += new System.EventHandler(this.field_DA_Enter);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(6, 19);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(50, 50);
            this.b1.TabIndex = 2;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(62, 19);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(50, 50);
            this.b2.TabIndex = 3;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(118, 19);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(50, 50);
            this.b3.TabIndex = 4;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(6, 75);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(50, 50);
            this.b4.TabIndex = 5;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(62, 75);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(50, 50);
            this.b5.TabIndex = 6;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(118, 75);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(50, 50);
            this.b6.TabIndex = 7;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(6, 131);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(50, 50);
            this.b7.TabIndex = 8;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(62, 131);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(50, 50);
            this.b8.TabIndex = 9;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(118, 131);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(50, 50);
            this.b9.TabIndex = 10;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(62, 187);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(50, 50);
            this.b0.TabIndex = 11;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // bA
            // 
            this.bA.Location = new System.Drawing.Point(6, 243);
            this.bA.Name = "bA";
            this.bA.Size = new System.Drawing.Size(50, 50);
            this.bA.TabIndex = 12;
            this.bA.Text = "A";
            this.bA.UseVisualStyleBackColor = true;
            this.bA.Click += new System.EventHandler(this.bA_Click);
            // 
            // bB
            // 
            this.bB.Location = new System.Drawing.Point(62, 243);
            this.bB.Name = "bB";
            this.bB.Size = new System.Drawing.Size(50, 50);
            this.bB.TabIndex = 13;
            this.bB.Text = "B";
            this.bB.UseVisualStyleBackColor = true;
            this.bB.Click += new System.EventHandler(this.bB_Click);
            // 
            // bC
            // 
            this.bC.Location = new System.Drawing.Point(118, 243);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(50, 50);
            this.bC.TabIndex = 14;
            this.bC.Text = "C";
            this.bC.UseVisualStyleBackColor = true;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // bD
            // 
            this.bD.Location = new System.Drawing.Point(6, 299);
            this.bD.Name = "bD";
            this.bD.Size = new System.Drawing.Size(50, 50);
            this.bD.TabIndex = 15;
            this.bD.Text = "D";
            this.bD.UseVisualStyleBackColor = true;
            this.bD.Click += new System.EventHandler(this.bD_Click);
            // 
            // bE
            // 
            this.bE.Location = new System.Drawing.Point(62, 299);
            this.bE.Name = "bE";
            this.bE.Size = new System.Drawing.Size(50, 50);
            this.bE.TabIndex = 16;
            this.bE.Text = "E";
            this.bE.UseVisualStyleBackColor = true;
            this.bE.Click += new System.EventHandler(this.bE_Click);
            // 
            // bF
            // 
            this.bF.Location = new System.Drawing.Point(118, 299);
            this.bF.Name = "bF";
            this.bF.Size = new System.Drawing.Size(50, 50);
            this.bF.TabIndex = 17;
            this.bF.Text = "F";
            this.bF.UseVisualStyleBackColor = true;
            this.bF.Click += new System.EventHandler(this.bF_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.b1);
            this.groupBox2.Controls.Add(this.bF);
            this.groupBox2.Controls.Add(this.b2);
            this.groupBox2.Controls.Add(this.bE);
            this.groupBox2.Controls.Add(this.b3);
            this.groupBox2.Controls.Add(this.bD);
            this.groupBox2.Controls.Add(this.b4);
            this.groupBox2.Controls.Add(this.bC);
            this.groupBox2.Controls.Add(this.b5);
            this.groupBox2.Controls.Add(this.bB);
            this.groupBox2.Controls.Add(this.b6);
            this.groupBox2.Controls.Add(this.bA);
            this.groupBox2.Controls.Add(this.b7);
            this.groupBox2.Controls.Add(this.b0);
            this.groupBox2.Controls.Add(this.b8);
            this.groupBox2.Controls.Add(this.b9);
            this.groupBox2.Location = new System.Drawing.Point(12, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 359);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ввод";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.clear_current);
            this.groupBox3.Controls.Add(this.clear_all);
            this.groupBox3.Controls.Add(this.action_mod);
            this.groupBox3.Controls.Add(this.action_div);
            this.groupBox3.Controls.Add(this.action_mul);
            this.groupBox3.Controls.Add(this.action_dif);
            this.groupBox3.Controls.Add(this.action_sum);
            this.groupBox3.Location = new System.Drawing.Point(194, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 359);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Обработка";
            // 
            // clear_current
            // 
            this.clear_current.Location = new System.Drawing.Point(138, 299);
            this.clear_current.Name = "clear_current";
            this.clear_current.Size = new System.Drawing.Size(56, 50);
            this.clear_current.TabIndex = 6;
            this.clear_current.Text = "CLEAR";
            this.clear_current.UseVisualStyleBackColor = true;
            // 
            // clear_all
            // 
            this.clear_all.Location = new System.Drawing.Point(6, 299);
            this.clear_all.Name = "clear_all";
            this.clear_all.Size = new System.Drawing.Size(126, 50);
            this.clear_all.TabIndex = 5;
            this.clear_all.Text = "CLEAR ALL";
            this.clear_all.UseVisualStyleBackColor = true;
            // 
            // action_mod
            // 
            this.action_mod.Location = new System.Drawing.Point(6, 243);
            this.action_mod.Name = "action_mod";
            this.action_mod.Size = new System.Drawing.Size(188, 50);
            this.action_mod.TabIndex = 4;
            this.action_mod.Text = "MOD";
            this.action_mod.UseVisualStyleBackColor = true;
            // 
            // action_div
            // 
            this.action_div.Location = new System.Drawing.Point(6, 187);
            this.action_div.Name = "action_div";
            this.action_div.Size = new System.Drawing.Size(188, 50);
            this.action_div.TabIndex = 3;
            this.action_div.Text = "DIV";
            this.action_div.UseVisualStyleBackColor = true;
            // 
            // action_mul
            // 
            this.action_mul.Location = new System.Drawing.Point(6, 131);
            this.action_mul.Name = "action_mul";
            this.action_mul.Size = new System.Drawing.Size(188, 50);
            this.action_mul.TabIndex = 2;
            this.action_mul.Text = "Умножение";
            this.action_mul.UseVisualStyleBackColor = true;
            // 
            // action_dif
            // 
            this.action_dif.Location = new System.Drawing.Point(6, 75);
            this.action_dif.Name = "action_dif";
            this.action_dif.Size = new System.Drawing.Size(188, 50);
            this.action_dif.TabIndex = 1;
            this.action_dif.Text = "Вычитание";
            this.action_dif.UseVisualStyleBackColor = true;
            // 
            // action_sum
            // 
            this.action_sum.Location = new System.Drawing.Point(6, 19);
            this.action_sum.Name = "action_sum";
            this.action_sum.Size = new System.Drawing.Size(188, 50);
            this.action_sum.TabIndex = 0;
            this.action_sum.Text = "Сложение";
            this.action_sum.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 502);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(380, 99);
            this.textBox1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 613);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор DECHEX";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox field_HA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox field_resultD;
        private System.Windows.Forms.TextBox field_resultH;
        private System.Windows.Forms.TextBox field_DB;
        private System.Windows.Forms.TextBox field_HB;
        private System.Windows.Forms.TextBox field_DA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bA;
        private System.Windows.Forms.Button bB;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button bD;
        private System.Windows.Forms.Button bE;
        private System.Windows.Forms.Button bF;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button clear_current;
        private System.Windows.Forms.Button clear_all;
        private System.Windows.Forms.Button action_mod;
        private System.Windows.Forms.Button action_div;
        private System.Windows.Forms.Button action_mul;
        private System.Windows.Forms.Button action_dif;
        private System.Windows.Forms.Button action_sum;
        private System.Windows.Forms.TextBox textBox1;
    }
}


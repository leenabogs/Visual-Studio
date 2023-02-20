namespace WindowsFormsApp1
{
    partial class example1
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtNimi = new System.Windows.Forms.TextBox();
            this.lblTulemus = new System.Windows.Forms.Label();
            this.btnTere = new System.Windows.Forms.Button();
            this.btnV2lja = new System.Windows.Forms.Button();
            this.Form2 = new System.Windows.Forms.GroupBox();
            this.lblSumma1 = new System.Windows.Forms.Label();
            this.lblSumma = new System.Windows.Forms.TextBox();
            this.chkTehing = new System.Windows.Forms.CheckBox();
            this.btnArv = new System.Windows.Forms.Button();
            this.Number2 = new System.Windows.Forms.Label();
            this.txtArv2 = new System.Windows.Forms.TextBox();
            this.number1 = new System.Windows.Forms.Label();
            this.txtArv1 = new System.Windows.Forms.TextBox();
            this.Colour1 = new System.Windows.Forms.GroupBox();
            this.btnRed = new System.Windows.Forms.RadioButton();
            this.btnBlue = new System.Windows.Forms.RadioButton();
            this.btnV2rv = new System.Windows.Forms.Button();
            this.btnTyhi = new System.Windows.Forms.Button();
            this.Form2.SuspendLayout();
            this.Colour1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl1.Location = new System.Drawing.Point(109, 48);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(105, 22);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Ваше Имя";
            // 
            // txtNimi
            // 
            this.txtNimi.Location = new System.Drawing.Point(232, 50);
            this.txtNimi.Name = "txtNimi";
            this.txtNimi.Size = new System.Drawing.Size(451, 22);
            this.txtNimi.TabIndex = 1;
            // 
            // lblTulemus
            // 
            this.lblTulemus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTulemus.Location = new System.Drawing.Point(229, 105);
            this.lblTulemus.Name = "lblTulemus";
            this.lblTulemus.Size = new System.Drawing.Size(453, 39);
            this.lblTulemus.TabIndex = 2;
            this.lblTulemus.Text = "label1";
            // 
            // btnTere
            // 
            this.btnTere.BackColor = System.Drawing.Color.Blue;
            this.btnTere.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTere.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTere.Location = new System.Drawing.Point(233, 179);
            this.btnTere.Name = "btnTere";
            this.btnTere.Size = new System.Drawing.Size(449, 61);
            this.btnTere.TabIndex = 3;
            this.btnTere.Text = "Приветствие";
            this.btnTere.UseVisualStyleBackColor = false;
            this.btnTere.Click += new System.EventHandler(this.btnTere_Click);
            // 
            // btnV2lja
            // 
            this.btnV2lja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnV2lja.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV2lja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnV2lja.Location = new System.Drawing.Point(232, 268);
            this.btnV2lja.Name = "btnV2lja";
            this.btnV2lja.Size = new System.Drawing.Size(449, 63);
            this.btnV2lja.TabIndex = 4;
            this.btnV2lja.Text = "Выход";
            this.btnV2lja.UseVisualStyleBackColor = false;
            this.btnV2lja.Click += new System.EventHandler(this.btnV2lja_Click);
            // 
            // Form2
            // 
            this.Form2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Form2.Controls.Add(this.lblSumma1);
            this.Form2.Controls.Add(this.lblSumma);
            this.Form2.Controls.Add(this.chkTehing);
            this.Form2.Controls.Add(this.btnArv);
            this.Form2.Controls.Add(this.Number2);
            this.Form2.Controls.Add(this.txtArv2);
            this.Form2.Controls.Add(this.number1);
            this.Form2.Controls.Add(this.txtArv1);
            this.Form2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Form2.Location = new System.Drawing.Point(33, 451);
            this.Form2.Name = "Form2";
            this.Form2.Size = new System.Drawing.Size(648, 273);
            this.Form2.TabIndex = 5;
            this.Form2.TabStop = false;
            this.Form2.Text = "Простая математика";
            // 
            // lblSumma1
            // 
            this.lblSumma1.AutoSize = true;
            this.lblSumma1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumma1.Location = new System.Drawing.Point(247, 204);
            this.lblSumma1.Name = "lblSumma1";
            this.lblSumma1.Size = new System.Drawing.Size(95, 22);
            this.lblSumma1.TabIndex = 7;
            this.lblSumma1.Text = "Результат";
            // 
            // lblSumma
            // 
            this.lblSumma.Location = new System.Drawing.Point(348, 196);
            this.lblSumma.Name = "lblSumma";
            this.lblSumma.Size = new System.Drawing.Size(156, 34);
            this.lblSumma.TabIndex = 6;
            // 
            // chkTehing
            // 
            this.chkTehing.AutoSize = true;
            this.chkTehing.BackColor = System.Drawing.Color.White;
            this.chkTehing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTehing.Location = new System.Drawing.Point(48, 204);
            this.chkTehing.Name = "chkTehing";
            this.chkTehing.Size = new System.Drawing.Size(90, 26);
            this.chkTehing.TabIndex = 5;
            this.chkTehing.Text = "Сумма";
            this.chkTehing.UseVisualStyleBackColor = false;
            this.chkTehing.CheckedChanged += new System.EventHandler(this.chkTehing_CheckedChanged);
            // 
            // btnArv
            // 
            this.btnArv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnArv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnArv.Location = new System.Drawing.Point(454, 69);
            this.btnArv.Name = "btnArv";
            this.btnArv.Size = new System.Drawing.Size(148, 39);
            this.btnArv.TabIndex = 4;
            this.btnArv.Text = "Посчитать";
            this.btnArv.UseVisualStyleBackColor = false;
            this.btnArv.Click += new System.EventHandler(this.btnArv_Click);
            // 
            // Number2
            // 
            this.Number2.AutoSize = true;
            this.Number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number2.Location = new System.Drawing.Point(213, 50);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(122, 22);
            this.Number2.TabIndex = 3;
            this.Number2.Text = "второе число";
            // 
            // txtArv2
            // 
            this.txtArv2.Location = new System.Drawing.Point(217, 75);
            this.txtArv2.Name = "txtArv2";
            this.txtArv2.Size = new System.Drawing.Size(118, 34);
            this.txtArv2.TabIndex = 2;
            // 
            // number1
            // 
            this.number1.AutoSize = true;
            this.number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number1.Location = new System.Drawing.Point(49, 50);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(124, 22);
            this.number1.TabIndex = 1;
            this.number1.Text = "первое число";
            // 
            // txtArv1
            // 
            this.txtArv1.Location = new System.Drawing.Point(53, 75);
            this.txtArv1.Name = "txtArv1";
            this.txtArv1.Size = new System.Drawing.Size(120, 34);
            this.txtArv1.TabIndex = 0;
            // 
            // Colour1
            // 
            this.Colour1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Colour1.Controls.Add(this.btnTyhi);
            this.Colour1.Controls.Add(this.btnV2rv);
            this.Colour1.Controls.Add(this.btnBlue);
            this.Colour1.Controls.Add(this.btnRed);
            this.Colour1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Colour1.Location = new System.Drawing.Point(721, 48);
            this.Colour1.Name = "Colour1";
            this.Colour1.Size = new System.Drawing.Size(474, 328);
            this.Colour1.TabIndex = 6;
            this.Colour1.TabStop = false;
            this.Colour1.Text = "Цвет Формы";
            // 
            // btnRed
            // 
            this.btnRed.AutoSize = true;
            this.btnRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnRed.ForeColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(40, 69);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(186, 33);
            this.btnRed.TabIndex = 0;
            this.btnRed.TabStop = true;
            this.btnRed.Text = "цвет красный";
            this.btnRed.UseVisualStyleBackColor = false;
            // 
            // btnBlue
            // 
            this.btnBlue.AutoSize = true;
            this.btnBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBlue.ForeColor = System.Drawing.Color.Blue;
            this.btnBlue.Location = new System.Drawing.Point(41, 160);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(159, 33);
            this.btnBlue.TabIndex = 1;
            this.btnBlue.TabStop = true;
            this.btnBlue.Text = "цвет синий";
            this.btnBlue.UseVisualStyleBackColor = false;
            // 
            // btnV2rv
            // 
            this.btnV2rv.BackColor = System.Drawing.Color.Blue;
            this.btnV2rv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnV2rv.Location = new System.Drawing.Point(277, 66);
            this.btnV2rv.Name = "btnV2rv";
            this.btnV2rv.Size = new System.Drawing.Size(165, 38);
            this.btnV2rv.TabIndex = 2;
            this.btnV2rv.Text = "Color";
            this.btnV2rv.UseVisualStyleBackColor = false;
            this.btnV2rv.Click += new System.EventHandler(this.btnV2rv_Click);
            // 
            // btnTyhi
            // 
            this.btnTyhi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnTyhi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTyhi.Location = new System.Drawing.Point(278, 159);
            this.btnTyhi.Name = "btnTyhi";
            this.btnTyhi.Size = new System.Drawing.Size(163, 33);
            this.btnTyhi.TabIndex = 3;
            this.btnTyhi.Text = "Clear";
            this.btnTyhi.UseVisualStyleBackColor = false;
            this.btnTyhi.Click += new System.EventHandler(this.btnTyhi_Click);
            // 
            // example1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1219, 768);
            this.Controls.Add(this.Colour1);
            this.Controls.Add(this.Form2);
            this.Controls.Add(this.btnV2lja);
            this.Controls.Add(this.btnTere);
            this.Controls.Add(this.lblTulemus);
            this.Controls.Add(this.txtNimi);
            this.Controls.Add(this.lbl1);
            this.Name = "example1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.example1_Load);
            this.Form2.ResumeLayout(false);
            this.Form2.PerformLayout();
            this.Colour1.ResumeLayout(false);
            this.Colour1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtNimi;
        private System.Windows.Forms.Label lblTulemus;
        private System.Windows.Forms.Button btnTere;
        private System.Windows.Forms.Button btnV2lja;
        private System.Windows.Forms.GroupBox Form2;
        private System.Windows.Forms.Label lblSumma1;
        private System.Windows.Forms.TextBox lblSumma;
        private System.Windows.Forms.CheckBox chkTehing;
        private System.Windows.Forms.Button btnArv;
        private System.Windows.Forms.Label Number2;
        private System.Windows.Forms.TextBox txtArv2;
        private System.Windows.Forms.Label number1;
        private System.Windows.Forms.TextBox txtArv1;
        private System.Windows.Forms.GroupBox Colour1;
        private System.Windows.Forms.Button btnTyhi;
        private System.Windows.Forms.Button btnV2rv;
        private System.Windows.Forms.RadioButton btnBlue;
        private System.Windows.Forms.RadioButton btnRed;
    }
}


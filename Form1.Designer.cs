
namespace Painter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Color1 = new System.Windows.Forms.Button();
            this.Color5 = new System.Windows.Forms.Button();
            this.Color2 = new System.Windows.Forms.Button();
            this.Color3 = new System.Windows.Forms.Button();
            this.Color4 = new System.Windows.Forms.Button();
            this.Color8 = new System.Windows.Forms.Button();
            this.Color6 = new System.Windows.Forms.Button();
            this.Color7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarGrosor = new System.Windows.Forms.TrackBar();
            this.pizarra = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGrosor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizarra)).BeginInit();
            this.SuspendLayout();
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(12, 415);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(150, 23);
            this.botonLimpiar.TabIndex = 3;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Color1);
            this.flowLayoutPanel1.Controls.Add(this.Color5);
            this.flowLayoutPanel1.Controls.Add(this.Color2);
            this.flowLayoutPanel1.Controls.Add(this.Color3);
            this.flowLayoutPanel1.Controls.Add(this.Color4);
            this.flowLayoutPanel1.Controls.Add(this.Color8);
            this.flowLayoutPanel1.Controls.Add(this.Color6);
            this.flowLayoutPanel1.Controls.Add(this.Color7);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 38);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(145, 73);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // Color1
            // 
            this.Color1.BackColor = System.Drawing.Color.White;
            this.Color1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color1.Location = new System.Drawing.Point(3, 3);
            this.Color1.Name = "Color1";
            this.Color1.Size = new System.Drawing.Size(30, 30);
            this.Color1.TabIndex = 0;
            this.Color1.UseVisualStyleBackColor = false;
            this.Color1.Click += new System.EventHandler(this.Color1_Click);
            // 
            // Color5
            // 
            this.Color5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Color5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color5.Location = new System.Drawing.Point(39, 3);
            this.Color5.Name = "Color5";
            this.Color5.Size = new System.Drawing.Size(30, 30);
            this.Color5.TabIndex = 4;
            this.Color5.UseVisualStyleBackColor = false;
            this.Color5.Click += new System.EventHandler(this.Color1_Click);
            // 
            // Color2
            // 
            this.Color2.BackColor = System.Drawing.Color.Black;
            this.Color2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color2.Location = new System.Drawing.Point(75, 3);
            this.Color2.Name = "Color2";
            this.Color2.Size = new System.Drawing.Size(30, 30);
            this.Color2.TabIndex = 1;
            this.Color2.UseVisualStyleBackColor = false;
            this.Color2.Click += new System.EventHandler(this.Color1_Click);
            // 
            // Color3
            // 
            this.Color3.BackColor = System.Drawing.Color.Red;
            this.Color3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color3.Location = new System.Drawing.Point(111, 3);
            this.Color3.Name = "Color3";
            this.Color3.Size = new System.Drawing.Size(30, 30);
            this.Color3.TabIndex = 2;
            this.Color3.UseVisualStyleBackColor = false;
            this.Color3.Click += new System.EventHandler(this.Color1_Click);
            // 
            // Color4
            // 
            this.Color4.BackColor = System.Drawing.Color.Blue;
            this.Color4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color4.Location = new System.Drawing.Point(3, 39);
            this.Color4.Name = "Color4";
            this.Color4.Size = new System.Drawing.Size(30, 30);
            this.Color4.TabIndex = 3;
            this.Color4.UseVisualStyleBackColor = false;
            this.Color4.Click += new System.EventHandler(this.Color1_Click);
            // 
            // Color8
            // 
            this.Color8.BackColor = System.Drawing.SystemColors.Control;
            this.Color8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color8.Location = new System.Drawing.Point(39, 39);
            this.Color8.Name = "Color8";
            this.Color8.Size = new System.Drawing.Size(30, 30);
            this.Color8.TabIndex = 7;
            this.Color8.UseVisualStyleBackColor = false;
            this.Color8.Click += new System.EventHandler(this.Color1_Click);
            // 
            // Color6
            // 
            this.Color6.BackColor = System.Drawing.Color.Yellow;
            this.Color6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color6.Location = new System.Drawing.Point(75, 39);
            this.Color6.Name = "Color6";
            this.Color6.Size = new System.Drawing.Size(30, 30);
            this.Color6.TabIndex = 5;
            this.Color6.UseVisualStyleBackColor = false;
            this.Color6.Click += new System.EventHandler(this.Color1_Click);
            // 
            // Color7
            // 
            this.Color7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Color7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color7.Location = new System.Drawing.Point(111, 39);
            this.Color7.Name = "Color7";
            this.Color7.Size = new System.Drawing.Size(30, 30);
            this.Color7.TabIndex = 6;
            this.Color7.UseVisualStyleBackColor = false;
            this.Color7.Click += new System.EventHandler(this.Color7_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.trackBarGrosor);
            this.panel1.Location = new System.Drawing.Point(12, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 80);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ancho";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // trackBarGrosor
            // 
            this.trackBarGrosor.Location = new System.Drawing.Point(3, 31);
            this.trackBarGrosor.Name = "trackBarGrosor";
            this.trackBarGrosor.Size = new System.Drawing.Size(138, 45);
            this.trackBarGrosor.TabIndex = 6;
            this.trackBarGrosor.ValueChanged += new System.EventHandler(this.trackBarGrosor_ValueChanged);
            // 
            // pizarra
            // 
            this.pizarra.Location = new System.Drawing.Point(164, 38);
            this.pizarra.Name = "pizarra";
            this.pizarra.Size = new System.Drawing.Size(624, 400);
            this.pizarra.TabIndex = 6;
            this.pizarra.TabStop = false;
            this.pizarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pizarra_MouseDown);
            this.pizarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pizarra_MouseMove);
            this.pizarra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pizarra_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(75, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(39, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(111, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 30);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(75, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 30);
            this.button5.TabIndex = 2;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(39, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(30, 30);
            this.button6.TabIndex = 1;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pizarra);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.botonLimpiar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGrosor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizarra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Color2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarGrosor;
        private System.Windows.Forms.PictureBox pizarra;
        private System.Windows.Forms.Button Color1;
        private System.Windows.Forms.Button Color3;
        private System.Windows.Forms.Button Color4;
        private System.Windows.Forms.Button Color5;
        private System.Windows.Forms.Button Color6;
        private System.Windows.Forms.Button Color7;
        private System.Windows.Forms.Button Color8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}


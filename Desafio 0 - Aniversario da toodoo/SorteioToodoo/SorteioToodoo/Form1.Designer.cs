namespace SorteioToodoo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSorteados = new System.Windows.Forms.Button();
            this.btnParticipantes = new System.Windows.Forms.Button();
            this.btnSortear = new System.Windows.Forms.Button();
            this.sorteadoBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.painelFogosEsquerdo = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.painelFogosdireito = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.listSorteio = new System.Windows.Forms.ListBox();
            this.panel2.SuspendLayout();
            this.painelFogosEsquerdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.painelFogosdireito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSorteados
            // 
            this.btnSorteados.Location = new System.Drawing.Point(246, 670);
            this.btnSorteados.Name = "btnSorteados";
            this.btnSorteados.Size = new System.Drawing.Size(183, 42);
            this.btnSorteados.TabIndex = 0;
            this.btnSorteados.Text = "Sorteados";
            this.btnSorteados.UseVisualStyleBackColor = true;
            this.btnSorteados.Click += new System.EventHandler(this.btnSorteados_Click);
            // 
            // btnParticipantes
            // 
            this.btnParticipantes.Location = new System.Drawing.Point(35, 670);
            this.btnParticipantes.Name = "btnParticipantes";
            this.btnParticipantes.Size = new System.Drawing.Size(183, 42);
            this.btnParticipantes.TabIndex = 1;
            this.btnParticipantes.Text = "Participantes";
            this.btnParticipantes.UseVisualStyleBackColor = true;
            this.btnParticipantes.Click += new System.EventHandler(this.btnSortear_Click);
            // 
            // btnSortear
            // 
            this.btnSortear.Location = new System.Drawing.Point(456, 670);
            this.btnSortear.Name = "btnSortear";
            this.btnSortear.Size = new System.Drawing.Size(183, 42);
            this.btnSortear.TabIndex = 2;
            this.btnSortear.Text = "Sortear";
            this.btnSortear.UseVisualStyleBackColor = true;
            this.btnSortear.Click += new System.EventHandler(this.button3_Click);
            // 
            // sorteadoBox
            // 
            this.sorteadoBox.BackColor = System.Drawing.Color.Black;
            this.sorteadoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sorteadoBox.Enabled = false;
            this.sorteadoBox.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sorteadoBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.sorteadoBox.Location = new System.Drawing.Point(59, 369);
            this.sorteadoBox.Name = "sorteadoBox";
            this.sorteadoBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sorteadoBox.Size = new System.Drawing.Size(599, 34);
            this.sorteadoBox.TabIndex = 3;
            this.sorteadoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sorteadoBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.painelFogosEsquerdo);
            this.panel2.Controls.Add(this.painelFogosdireito);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(1630, 752);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // painelFogosEsquerdo
            // 
            this.painelFogosEsquerdo.Controls.Add(this.pictureBox4);
            this.painelFogosEsquerdo.Location = new System.Drawing.Point(3, 0);
            this.painelFogosEsquerdo.Name = "painelFogosEsquerdo";
            this.painelFogosEsquerdo.Size = new System.Drawing.Size(491, 741);
            this.painelFogosEsquerdo.TabIndex = 10;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(9, 144);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(462, 454);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // painelFogosdireito
            // 
            this.painelFogosdireito.Controls.Add(this.pictureBox1);
            this.painelFogosdireito.Location = new System.Drawing.Point(1139, 3);
            this.painelFogosdireito.Name = "painelFogosdireito";
            this.painelFogosdireito.Size = new System.Drawing.Size(491, 741);
            this.painelFogosdireito.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 454);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sorteadoBox);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnSortear);
            this.panel1.Controls.Add(this.btnSorteados);
            this.panel1.Controls.Add(this.btnParticipantes);
            this.panel1.Controls.Add(this.listSorteio);
            this.panel1.Location = new System.Drawing.Point(455, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 740);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(35, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(623, 172);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // listSorteio
            // 
            this.listSorteio.BackColor = System.Drawing.SystemColors.MenuText;
            this.listSorteio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listSorteio.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listSorteio.ForeColor = System.Drawing.SystemColors.Menu;
            this.listSorteio.FormattingEnabled = true;
            this.listSorteio.ItemHeight = 28;
            this.listSorteio.Location = new System.Drawing.Point(45, 181);
            this.listSorteio.Name = "listSorteio";
            this.listSorteio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listSorteio.Size = new System.Drawing.Size(623, 476);
            this.listSorteio.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1630, 752);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.painelFogosEsquerdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.painelFogosdireito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSorteados;
        private Button btnParticipantes;
        private Button btnSortear;
        private TextBox sorteadoBox;
        private Panel panel2;
        private ListBox listSorteio;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel painelFogosEsquerdo;
        private PictureBox pictureBox4;
        private Panel painelFogosdireito;
        private PictureBox pictureBox1;
    }
}
namespace Sorteador
{
    partial class Sorteador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sorteador));
            label1 = new Label();
            txtItems = new TextBox();
            label2 = new Label();
            Lista = new ListBox();
            btnSortear = new Button();
            btnLimpar = new Button();
            label3 = new Label();
            resultList = new ListBox();
            btnAdicionar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Gill Sans MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(776, 85);
            label1.TabIndex = 0;
            label1.Text = "Sorteador ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtItems
            // 
            txtItems.BorderStyle = BorderStyle.FixedSingle;
            txtItems.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtItems.ForeColor = Color.Red;
            txtItems.Location = new Point(41, 131);
            txtItems.Name = "txtItems";
            txtItems.PlaceholderText = " Entrada de nome ou número";
            txtItems.Size = new Size(565, 27);
            txtItems.TabIndex = 1;
            txtItems.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 189);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 2;
            label2.Text = "Lista Atual:";
            // 
            // Lista
            // 
            Lista.FormattingEnabled = true;
            Lista.Location = new Point(41, 227);
            Lista.Name = "Lista";
            Lista.Size = new Size(717, 124);
            Lista.TabIndex = 0;
            // 
            // btnSortear
            // 
            btnSortear.BackColor = Color.Silver;
            btnSortear.ForeColor = SystemColors.ActiveCaptionText;
            btnSortear.Location = new Point(59, 390);
            btnSortear.Name = "btnSortear";
            btnSortear.Size = new Size(259, 60);
            btnSortear.TabIndex = 4;
            btnSortear.Text = "Sortear";
            btnSortear.UseVisualStyleBackColor = false;
            btnSortear.Click += btnSortear_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Silver;
            btnLimpar.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpar.Location = new Point(480, 390);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(259, 60);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "Limpar lista";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.MouseClick += btnLimpar_MouseClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 497);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 6;
            label3.Text = "Resultado:";
            // 
            // resultList
            // 
            resultList.FormattingEnabled = true;
            resultList.Location = new Point(41, 540);
            resultList.Name = "resultList";
            resultList.Size = new Size(717, 44);
            resultList.TabIndex = 7;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.Silver;
            btnAdicionar.ForeColor = Color.Red;
            btnAdicionar.Location = new Point(636, 122);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(122, 43);
            btnAdicionar.TabIndex = 8;
            btnAdicionar.Text = "➕";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // Sorteador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 609);
            Controls.Add(btnAdicionar);
            Controls.Add(resultList);
            Controls.Add(label3);
            Controls.Add(btnLimpar);
            Controls.Add(btnSortear);
            Controls.Add(Lista);
            Controls.Add(label2);
            Controls.Add(txtItems);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Sorteador";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Sorteador";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtItems;
        private Label label2;
        private ListBox Lista;
        private Button btnSortear;
        private Button btnLimpar;
        private Label label3;
        private ListBox resultList;
        private Button btnAdicionar;
    }
}

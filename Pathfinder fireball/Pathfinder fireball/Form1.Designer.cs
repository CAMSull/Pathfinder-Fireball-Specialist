namespace Pathfinder_fireball
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
            btnD6 = new Button();
            lblD6 = new Label();
            btnD8 = new Button();
            btnD4 = new Button();
            lblD4 = new Label();
            lblD8 = new Label();
            btnD10 = new Button();
            btnD12 = new Button();
            btnD20 = new Button();
            btnD100 = new Button();
            lblD10 = new Label();
            lblD20 = new Label();
            lblD100 = new Label();
            lblD12 = new Label();
            btnFireball = new Button();
            lblFireball = new Label();
            tboxfireballCL = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cboxEmpowerd = new CheckBox();
            cboxWidened = new CheckBox();
            label3 = new Label();
            tboxRadius = new TextBox();
            cboxShrunk = new CheckBox();
            cboxAcid = new CheckBox();
            SuspendLayout();
            // 
            // btnD6
            // 
            btnD6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnD6.Font = new Font("Segoe UI", 10F);
            btnD6.Location = new Point(12, 59);
            btnD6.Name = "btnD6";
            btnD6.Size = new Size(61, 42);
            btnD6.TabIndex = 0;
            btnD6.Text = "1d6";
            btnD6.UseVisualStyleBackColor = true;
            btnD6.Click += d6_Click;
            // 
            // lblD6
            // 
            lblD6.AutoSize = true;
            lblD6.Font = new Font("Segoe UI", 22F);
            lblD6.Location = new Point(79, 59);
            lblD6.Name = "lblD6";
            lblD6.Size = new Size(34, 41);
            lblD6.TabIndex = 1;
            lblD6.Text = "6";
            lblD6.Click += label1_Click;
            // 
            // btnD8
            // 
            btnD8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnD8.Font = new Font("Segoe UI", 10F);
            btnD8.Location = new Point(12, 107);
            btnD8.Name = "btnD8";
            btnD8.Size = new Size(61, 42);
            btnD8.TabIndex = 2;
            btnD8.Text = "1d8";
            btnD8.UseVisualStyleBackColor = true;
            btnD8.Click += btnD8_Click;
            // 
            // btnD4
            // 
            btnD4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnD4.Font = new Font("Segoe UI", 10F);
            btnD4.Location = new Point(12, 11);
            btnD4.Name = "btnD4";
            btnD4.Size = new Size(61, 42);
            btnD4.TabIndex = 3;
            btnD4.Text = "1d4";
            btnD4.UseVisualStyleBackColor = true;
            btnD4.Click += d4_Click;
            // 
            // lblD4
            // 
            lblD4.AutoSize = true;
            lblD4.Font = new Font("Segoe UI", 22F);
            lblD4.Location = new Point(79, 12);
            lblD4.Name = "lblD4";
            lblD4.Size = new Size(34, 41);
            lblD4.TabIndex = 4;
            lblD4.Text = "4";
            // 
            // lblD8
            // 
            lblD8.AutoSize = true;
            lblD8.Font = new Font("Segoe UI", 22F);
            lblD8.Location = new Point(79, 107);
            lblD8.Name = "lblD8";
            lblD8.Size = new Size(34, 41);
            lblD8.TabIndex = 5;
            lblD8.Text = "8";
            // 
            // btnD10
            // 
            btnD10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnD10.Font = new Font("Segoe UI", 10F);
            btnD10.Location = new Point(12, 155);
            btnD10.Name = "btnD10";
            btnD10.Size = new Size(61, 42);
            btnD10.TabIndex = 6;
            btnD10.Text = "1d10";
            btnD10.UseVisualStyleBackColor = true;
            btnD10.Click += btnD10_click;
            // 
            // btnD12
            // 
            btnD12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnD12.Font = new Font("Segoe UI", 10F);
            btnD12.Location = new Point(12, 203);
            btnD12.Name = "btnD12";
            btnD12.Size = new Size(61, 42);
            btnD12.TabIndex = 7;
            btnD12.Text = "1d12";
            btnD12.UseVisualStyleBackColor = true;
            btnD12.Click += btnD12_Click;
            // 
            // btnD20
            // 
            btnD20.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnD20.Font = new Font("Segoe UI", 10F);
            btnD20.Location = new Point(12, 251);
            btnD20.Name = "btnD20";
            btnD20.Size = new Size(61, 42);
            btnD20.TabIndex = 8;
            btnD20.Text = "1d20";
            btnD20.UseVisualStyleBackColor = true;
            btnD20.Click += btnD20_Click;
            // 
            // btnD100
            // 
            btnD100.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnD100.Font = new Font("Segoe UI", 10F);
            btnD100.Location = new Point(12, 299);
            btnD100.Name = "btnD100";
            btnD100.Size = new Size(61, 42);
            btnD100.TabIndex = 9;
            btnD100.Text = "1d100";
            btnD100.UseVisualStyleBackColor = true;
            btnD100.Click += btnD100_Click;
            // 
            // lblD10
            // 
            lblD10.AutoSize = true;
            lblD10.Font = new Font("Segoe UI", 22F);
            lblD10.Location = new Point(79, 156);
            lblD10.Name = "lblD10";
            lblD10.Size = new Size(50, 41);
            lblD10.TabIndex = 10;
            lblD10.Text = "10";
            // 
            // lblD20
            // 
            lblD20.AutoSize = true;
            lblD20.Font = new Font("Segoe UI", 22F);
            lblD20.Location = new Point(79, 252);
            lblD20.Name = "lblD20";
            lblD20.Size = new Size(50, 41);
            lblD20.TabIndex = 12;
            lblD20.Text = "20";
            // 
            // lblD100
            // 
            lblD100.AutoSize = true;
            lblD100.Font = new Font("Segoe UI", 22F);
            lblD100.Location = new Point(79, 300);
            lblD100.Name = "lblD100";
            lblD100.Size = new Size(66, 41);
            lblD100.TabIndex = 13;
            lblD100.Text = "100";
            // 
            // lblD12
            // 
            lblD12.AutoSize = true;
            lblD12.Font = new Font("Segoe UI", 22F);
            lblD12.Location = new Point(79, 204);
            lblD12.Name = "lblD12";
            lblD12.Size = new Size(50, 41);
            lblD12.TabIndex = 14;
            lblD12.Text = "12";
            // 
            // btnFireball
            // 
            btnFireball.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnFireball.BackColor = Color.Maroon;
            btnFireball.Font = new Font("Segoe UI", 10F);
            btnFireball.ForeColor = Color.White;
            btnFireball.Location = new Point(508, 12);
            btnFireball.Name = "btnFireball";
            btnFireball.Size = new Size(154, 54);
            btnFireball.TabIndex = 15;
            btnFireball.Text = "FIREBALL";
            btnFireball.UseVisualStyleBackColor = false;
            btnFireball.Click += btnFireball_Click;
            // 
            // lblFireball
            // 
            lblFireball.AutoSize = true;
            lblFireball.Font = new Font("Segoe UI", 22F);
            lblFireball.Location = new Point(652, 378);
            lblFireball.Name = "lblFireball";
            lblFireball.Size = new Size(34, 41);
            lblFireball.TabIndex = 16;
            lblFireball.Text = "6";
            lblFireball.Click += lblFireball_Click;
            // 
            // tboxfireballCL
            // 
            tboxfireballCL.Font = new Font("Segoe UI", 22F);
            tboxfireballCL.Location = new Point(620, 69);
            tboxfireballCL.Name = "tboxfireballCL";
            tboxfireballCL.PlaceholderText = "5";
            tboxfireballCL.Size = new Size(66, 47);
            tboxfireballCL.TabIndex = 17;
            tboxfireballCL.Text = "5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(508, 75);
            label1.Name = "label1";
            label1.Size = new Size(51, 41);
            label1.TabIndex = 18;
            label1.Text = "CL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22F);
            label2.Location = new Point(486, 378);
            label2.Name = "label2";
            label2.Size = new Size(175, 41);
            label2.TabIndex = 19;
            label2.Text = "DAMAGE = ";
            // 
            // cboxEmpowerd
            // 
            cboxEmpowerd.AutoSize = true;
            cboxEmpowerd.Font = new Font("Segoe UI", 22F);
            cboxEmpowerd.Location = new Point(486, 177);
            cboxEmpowerd.Name = "cboxEmpowerd";
            cboxEmpowerd.Size = new Size(196, 45);
            cboxEmpowerd.TabIndex = 20;
            cboxEmpowerd.Text = "Empowered";
            cboxEmpowerd.UseVisualStyleBackColor = true;
            // 
            // cboxWidened
            // 
            cboxWidened.AutoSize = true;
            cboxWidened.Font = new Font("Segoe UI", 22F);
            cboxWidened.Location = new Point(486, 228);
            cboxWidened.Name = "cboxWidened";
            cboxWidened.Size = new Size(157, 45);
            cboxWidened.TabIndex = 21;
            cboxWidened.Text = "Widened";
            cboxWidened.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22F);
            label3.Location = new Point(508, 133);
            label3.Name = "label3";
            label3.Size = new Size(106, 41);
            label3.TabIndex = 23;
            label3.Text = "Radius";
            // 
            // tboxRadius
            // 
            tboxRadius.Font = new Font("Segoe UI", 22F);
            tboxRadius.Location = new Point(620, 124);
            tboxRadius.Name = "tboxRadius";
            tboxRadius.PlaceholderText = "20";
            tboxRadius.Size = new Size(66, 47);
            tboxRadius.TabIndex = 22;
            tboxRadius.Text = "20";
            // 
            // cboxShrunk
            // 
            cboxShrunk.AutoSize = true;
            cboxShrunk.Font = new Font("Segoe UI", 22F);
            cboxShrunk.Location = new Point(486, 279);
            cboxShrunk.Name = "cboxShrunk";
            cboxShrunk.Size = new Size(129, 45);
            cboxShrunk.TabIndex = 24;
            cboxShrunk.Text = "Shrunk";
            cboxShrunk.UseVisualStyleBackColor = true;
            // 
            // cboxAcid
            // 
            cboxAcid.AutoSize = true;
            cboxAcid.Font = new Font("Segoe UI", 22F);
            cboxAcid.Location = new Point(486, 330);
            cboxAcid.Name = "cboxAcid";
            cboxAcid.Size = new Size(95, 45);
            cboxAcid.TabIndex = 25;
            cboxAcid.Text = "Acid";
            cboxAcid.UseVisualStyleBackColor = true;
            cboxAcid.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboxAcid);
            Controls.Add(cboxShrunk);
            Controls.Add(label3);
            Controls.Add(tboxRadius);
            Controls.Add(cboxWidened);
            Controls.Add(cboxEmpowerd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tboxfireballCL);
            Controls.Add(lblFireball);
            Controls.Add(btnFireball);
            Controls.Add(lblD12);
            Controls.Add(lblD100);
            Controls.Add(lblD20);
            Controls.Add(lblD10);
            Controls.Add(btnD100);
            Controls.Add(btnD20);
            Controls.Add(btnD12);
            Controls.Add(btnD10);
            Controls.Add(lblD8);
            Controls.Add(lblD4);
            Controls.Add(btnD4);
            Controls.Add(btnD8);
            Controls.Add(lblD6);
            Controls.Add(btnD6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnD6;
        private Label lblD6;
        private Button btnD8;
        private Button btnD4;
        private Label lblD4;
        private Label lblD8;
        private Button btnD10;
        private Button btnD12;
        private Button btnD20;
        private Button btnD100;
        private Label lblD10;
        private Label lblD20;
        private Label lblD100;
        private Label lblD12;
        private Button btnFireball;
        private Label lblFireball;
        private TextBox tboxfireballCL;
        private Label label1;
        private Label label2;
        private CheckBox cboxEmpowerd;
        private CheckBox cboxWidened;
        private Label label3;
        private TextBox tboxRadius;
        private CheckBox cboxShrunk;
        private CheckBox cboxAcid;
    }
}

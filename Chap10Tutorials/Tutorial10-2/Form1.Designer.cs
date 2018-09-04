namespace Tutorial10_2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.getHoursBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.idTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.infoSystemsRB = new System.Windows.Forms.RadioButton();
            this.softwareEngineeringRB = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.requiredHoursLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.requiredHoursLbl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.softwareEngineeringRB);
            this.groupBox1.Controls.Add(this.infoSystemsRB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.idTB);
            this.groupBox1.Controls.Add(this.nameTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // getHoursBtn
            // 
            this.getHoursBtn.Location = new System.Drawing.Point(48, 216);
            this.getHoursBtn.Name = "getHoursBtn";
            this.getHoursBtn.Size = new System.Drawing.Size(80, 40);
            this.getHoursBtn.TabIndex = 1;
            this.getHoursBtn.Text = "Get Required Hours";
            this.getHoursBtn.UseVisualStyleBackColor = true;
            this.getHoursBtn.Click += new System.EventHandler(this.getHoursBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(144, 216);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(83, 40);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(112, 24);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(100, 20);
            this.nameTB.TabIndex = 2;
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(112, 56);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(100, 20);
            this.idTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Academic Track:";
            // 
            // infoSystemsRB
            // 
            this.infoSystemsRB.AutoSize = true;
            this.infoSystemsRB.Location = new System.Drawing.Point(112, 88);
            this.infoSystemsRB.Name = "infoSystemsRB";
            this.infoSystemsRB.Size = new System.Drawing.Size(119, 17);
            this.infoSystemsRB.TabIndex = 5;
            this.infoSystemsRB.TabStop = true;
            this.infoSystemsRB.Text = "Information Systems";
            this.infoSystemsRB.UseVisualStyleBackColor = true;
            // 
            // softwareEngineeringRB
            // 
            this.softwareEngineeringRB.AutoSize = true;
            this.softwareEngineeringRB.Location = new System.Drawing.Point(112, 112);
            this.softwareEngineeringRB.Name = "softwareEngineeringRB";
            this.softwareEngineeringRB.Size = new System.Drawing.Size(126, 17);
            this.softwareEngineeringRB.TabIndex = 6;
            this.softwareEngineeringRB.TabStop = true;
            this.softwareEngineeringRB.Text = "Software Engineering";
            this.softwareEngineeringRB.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Required Hours:";
            // 
            // requiredHoursLbl
            // 
            this.requiredHoursLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requiredHoursLbl.Location = new System.Drawing.Point(112, 152);
            this.requiredHoursLbl.Name = "requiredHoursLbl";
            this.requiredHoursLbl.Size = new System.Drawing.Size(100, 23);
            this.requiredHoursLbl.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 265);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.getHoursBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Computer Science Student";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getHoursBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label requiredHoursLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton softwareEngineeringRB;
        private System.Windows.Forms.RadioButton infoSystemsRB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox nameTB;
    }
}


namespace Chap10Tutorials
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
            this.createAnimalBtn = new System.Windows.Forms.Button();
            this.createDogBtn = new System.Windows.Forms.Button();
            this.createCatBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createAnimalBtn
            // 
            this.createAnimalBtn.Location = new System.Drawing.Point(40, 16);
            this.createAnimalBtn.Name = "createAnimalBtn";
            this.createAnimalBtn.Size = new System.Drawing.Size(75, 40);
            this.createAnimalBtn.TabIndex = 0;
            this.createAnimalBtn.Text = "Create an Animal";
            this.createAnimalBtn.UseVisualStyleBackColor = true;
            this.createAnimalBtn.Click += new System.EventHandler(this.createAnimalBtn_Click);
            // 
            // createDogBtn
            // 
            this.createDogBtn.Location = new System.Drawing.Point(136, 16);
            this.createDogBtn.Name = "createDogBtn";
            this.createDogBtn.Size = new System.Drawing.Size(75, 40);
            this.createDogBtn.TabIndex = 1;
            this.createDogBtn.Text = "Create a Dog";
            this.createDogBtn.UseVisualStyleBackColor = true;
            this.createDogBtn.Click += new System.EventHandler(this.createDogBtn_Click);
            // 
            // createCatBtn
            // 
            this.createCatBtn.Location = new System.Drawing.Point(232, 16);
            this.createCatBtn.Name = "createCatBtn";
            this.createCatBtn.Size = new System.Drawing.Size(75, 40);
            this.createCatBtn.TabIndex = 2;
            this.createCatBtn.Text = "Create a Cate";
            this.createCatBtn.UseVisualStyleBackColor = true;
            this.createCatBtn.Click += new System.EventHandler(this.createCatBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(136, 72);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 40);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 126);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.createCatBtn);
            this.Controls.Add(this.createDogBtn);
            this.Controls.Add(this.createAnimalBtn);
            this.Name = "Form1";
            this.Text = "Polymorphism Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createAnimalBtn;
        private System.Windows.Forms.Button createDogBtn;
        private System.Windows.Forms.Button createCatBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}


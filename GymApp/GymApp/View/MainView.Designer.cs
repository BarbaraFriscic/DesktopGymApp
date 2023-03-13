namespace GymApp.View
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEmployeeView = new System.Windows.Forms.Button();
            this.btnPlansView = new System.Windows.Forms.Button();
            this.btnMemberView = new System.Windows.Forms.Button();
            this.btnLocationView = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnEmployeeView);
            this.panel1.Controls.Add(this.btnPlansView);
            this.panel1.Controls.Add(this.btnMemberView);
            this.panel1.Controls.Add(this.btnLocationView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 1;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(46, 145);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 13);
            this.lblWelcome.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnEmployeeView
            // 
            this.btnEmployeeView.Location = new System.Drawing.Point(0, 334);
            this.btnEmployeeView.Name = "btnEmployeeView";
            this.btnEmployeeView.Size = new System.Drawing.Size(200, 42);
            this.btnEmployeeView.TabIndex = 3;
            this.btnEmployeeView.Text = "Employees";
            this.btnEmployeeView.UseVisualStyleBackColor = true;
            // 
            // btnPlansView
            // 
            this.btnPlansView.Location = new System.Drawing.Point(0, 286);
            this.btnPlansView.Name = "btnPlansView";
            this.btnPlansView.Size = new System.Drawing.Size(200, 42);
            this.btnPlansView.TabIndex = 2;
            this.btnPlansView.Text = "Membership Plans";
            this.btnPlansView.UseVisualStyleBackColor = true;
            // 
            // btnMemberView
            // 
            this.btnMemberView.Location = new System.Drawing.Point(0, 238);
            this.btnMemberView.Name = "btnMemberView";
            this.btnMemberView.Size = new System.Drawing.Size(200, 42);
            this.btnMemberView.TabIndex = 1;
            this.btnMemberView.Text = "Members";
            this.btnMemberView.UseVisualStyleBackColor = true;
            // 
            // btnLocationView
            // 
            this.btnLocationView.Location = new System.Drawing.Point(0, 190);
            this.btnLocationView.Name = "btnLocationView";
            this.btnLocationView.Size = new System.Drawing.Size(200, 42);
            this.btnLocationView.TabIndex = 0;
            this.btnLocationView.Text = "Location";
            this.btnLocationView.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Controls.Add(this.panel1);
            this.Name = "MainView";
            this.Text = "MainView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEmployeeView;
        private System.Windows.Forms.Button btnPlansView;
        private System.Windows.Forms.Button btnMemberView;
        private System.Windows.Forms.Button btnLocationView;
    }
}
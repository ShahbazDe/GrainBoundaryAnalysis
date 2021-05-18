
namespace GrainBoundariesEvaluationUI
{
    partial class SpecimentSubmissionForm
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
            this.components = new System.ComponentModel.Container();
            this.DataSubmitBtn = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.TextBox();
            this.gbType = new System.Windows.Forms.TextBox();
            this.gbEnergy = new System.Windows.Forms.TextBox();
            this.solidificationFactor = new System.Windows.Forms.TextBox();
            this.thermalGradient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.userID = new System.Windows.Forms.TextBox();
            this.errorProviderUserID = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserID)).BeginInit();
            this.SuspendLayout();
            // 
            // DataSubmitBtn
            // 
            this.DataSubmitBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DataSubmitBtn.ForeColor = System.Drawing.Color.Navy;
            this.DataSubmitBtn.Location = new System.Drawing.Point(236, 417);
            this.DataSubmitBtn.Name = "DataSubmitBtn";
            this.DataSubmitBtn.Size = new System.Drawing.Size(193, 38);
            this.DataSubmitBtn.TabIndex = 0;
            this.DataSubmitBtn.Text = "Submit Data";
            this.DataSubmitBtn.UseVisualStyleBackColor = true;
            this.DataSubmitBtn.Click += new System.EventHandler(this.DataSubmitBtn_Click);
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(289, 98);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(279, 23);
            this.userName.TabIndex = 1;
            // 
            // gbType
            // 
            this.gbType.Location = new System.Drawing.Point(289, 155);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(279, 23);
            this.gbType.TabIndex = 2;
            // 
            // gbEnergy
            // 
            this.gbEnergy.Location = new System.Drawing.Point(289, 217);
            this.gbEnergy.Name = "gbEnergy";
            this.gbEnergy.Size = new System.Drawing.Size(279, 23);
            this.gbEnergy.TabIndex = 3;
            // 
            // solidificationFactor
            // 
            this.solidificationFactor.Location = new System.Drawing.Point(289, 276);
            this.solidificationFactor.Name = "solidificationFactor";
            this.solidificationFactor.Size = new System.Drawing.Size(279, 23);
            this.solidificationFactor.TabIndex = 4;
            // 
            // thermalGradient
            // 
            this.thermalGradient.Location = new System.Drawing.Point(289, 338);
            this.thermalGradient.Name = "thermalGradient";
            this.thermalGradient.Size = new System.Drawing.Size(279, 23);
            this.thermalGradient.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(47, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(47, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Grain Boundary Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(47, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Grain Boundary Energy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(47, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Solidification Factor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(47, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Thermal Gradient";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(47, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "User ID";
            // 
            // userID
            // 
            this.userID.Location = new System.Drawing.Point(289, 39);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(279, 23);
            this.userID.TabIndex = 13;
            // 
            // errorProviderUserID
            // 
            this.errorProviderUserID.BlinkRate = 0;
            this.errorProviderUserID.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderUserID.ContainerControl = this;
            // 
            // SpecimentSubmissionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 486);
            this.Controls.Add(this.userID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thermalGradient);
            this.Controls.Add(this.solidificationFactor);
            this.Controls.Add(this.gbEnergy);
            this.Controls.Add(this.gbType);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.DataSubmitBtn);
            this.Name = "SpecimentSubmissionForm";
            this.Text = "SpecimenUploadUI";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DataSubmitBtn;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox gbType;
        private System.Windows.Forms.TextBox gbEnergy;
        private System.Windows.Forms.TextBox solidificationFactor;
        private System.Windows.Forms.TextBox thermalGradient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox userID;
        private System.Windows.Forms.ErrorProvider errorProviderUserID;
    }
}


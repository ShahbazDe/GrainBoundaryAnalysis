
namespace GrainBoundariesEvaluationUI
{
    partial class EvaluationUI
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
            this.label6 = new System.Windows.Forms.Label();
            this.viewBtn = new System.Windows.Forms.Button();
            this.DataEntryBtn = new System.Windows.Forms.Button();
            this.listViewAllSpecimens = new System.Windows.Forms.ListView();
            this.cmUserName = new System.Windows.Forms.ColumnHeader();
            this.cmGBType = new System.Windows.Forms.ColumnHeader();
            this.cmGBEnergy = new System.Windows.Forms.ColumnHeader();
            this.chSolidificationFactor = new System.Windows.Forms.ColumnHeader();
            this.chThermalGrad = new System.Windows.Forms.ColumnHeader();
            this.chUserID = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(40, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Specimen quality";
            // 
            // viewBtn
            // 
            this.viewBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.viewBtn.ForeColor = System.Drawing.Color.Navy;
            this.viewBtn.Location = new System.Drawing.Point(210, 358);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(193, 38);
            this.viewBtn.TabIndex = 15;
            this.viewBtn.Text = "Update ranking";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewStatusBtn_Click);
            // 
            // DataEntryBtn
            // 
            this.DataEntryBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DataEntryBtn.ForeColor = System.Drawing.Color.Navy;
            this.DataEntryBtn.Location = new System.Drawing.Point(478, 358);
            this.DataEntryBtn.Name = "DataEntryBtn";
            this.DataEntryBtn.Size = new System.Drawing.Size(193, 38);
            this.DataEntryBtn.TabIndex = 16;
            this.DataEntryBtn.Text = "Create new entry";
            this.DataEntryBtn.UseVisualStyleBackColor = true;
            this.DataEntryBtn.Click += new System.EventHandler(this.DataEntryBtn_Click);
            // 
            // listViewAllSpecimens
            // 
            this.listViewAllSpecimens.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cmUserName,
            this.cmGBType,
            this.cmGBEnergy,
            this.chSolidificationFactor,
            this.chThermalGrad,
            this.chUserID});
            this.listViewAllSpecimens.FullRowSelect = true;
            this.listViewAllSpecimens.GridLines = true;
            this.listViewAllSpecimens.HideSelection = false;
            this.listViewAllSpecimens.Location = new System.Drawing.Point(41, 83);
            this.listViewAllSpecimens.Name = "listViewAllSpecimens";
            this.listViewAllSpecimens.Size = new System.Drawing.Size(813, 251);
            this.listViewAllSpecimens.TabIndex = 17;
            this.listViewAllSpecimens.UseCompatibleStateImageBehavior = false;
            this.listViewAllSpecimens.View = System.Windows.Forms.View.Details;
            // 
            // cmUserName
            // 
            this.cmUserName.Text = "User name";
            this.cmUserName.Width = 179;
            // 
            // cmGBType
            // 
            this.cmGBType.Text = "Grain Boundary Type";
            this.cmGBType.Width = 130;
            // 
            // cmGBEnergy
            // 
            this.cmGBEnergy.Text = "Grain Boundary Energy";
            this.cmGBEnergy.Width = 160;
            // 
            // chSolidificationFactor
            // 
            this.chSolidificationFactor.Text = "Solidification factor";
            this.chSolidificationFactor.Width = 120;
            // 
            // chThermalGrad
            // 
            this.chThermalGrad.Text = "Thermal Gradient";
            this.chThermalGrad.Width = 120;
            // 
            // chUserID
            // 
            this.chUserID.Text = "User ID";
            this.chUserID.Width = 100;
            // 
            // EvaluationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.listViewAllSpecimens);
            this.Controls.Add(this.DataEntryBtn);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.label6);
            this.Name = "EvaluationUI";
            this.Text = "EvaluationUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Button DataEntryBtn;
        private System.Windows.Forms.ListView listViewAllSpecimens;
        private System.Windows.Forms.ColumnHeader cmUserName;
        private System.Windows.Forms.ColumnHeader cmGBType;
        private System.Windows.Forms.ColumnHeader cmGBEnergy;
        private System.Windows.Forms.ColumnHeader chSolidificationFactor;
        private System.Windows.Forms.ColumnHeader chThermalGrad;
        private System.Windows.Forms.ColumnHeader chUserID;
    }
}
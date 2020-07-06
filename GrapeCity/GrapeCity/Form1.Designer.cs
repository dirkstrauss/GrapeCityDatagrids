namespace GrapeCity
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
            this.dgFlexGrid = new C1.Win.C1FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dgFlexGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dgFlexGrid
            // 
            this.dgFlexGrid.AllowFiltering = true;
            this.dgFlexGrid.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both;
            this.dgFlexGrid.ColumnInfo = "10,1,0,0,0,-1,Columns:1{ShowSparkline:True;}\t";
            this.dgFlexGrid.Location = new System.Drawing.Point(12, 12);
            this.dgFlexGrid.Name = "dgFlexGrid";
            this.dgFlexGrid.Size = new System.Drawing.Size(776, 426);
            this.dgFlexGrid.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgFlexGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgFlexGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private C1.Win.C1FlexGrid.C1FlexGrid dgFlexGrid;
    }
}


namespace Lantmäteriet.kartor
{
    partial class MapViewer
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNrOfTiles = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbTopoCol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTopoMatrixSet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTopoMatrix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTopoRow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUrl = new System.Windows.Forms.Button();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.pbMap = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNrOfTiles)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(1166, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 773);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbNrOfTiles);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(960, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 236);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TopoMap";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "NrOfTIles";
            // 
            // tbNrOfTiles
            // 
            this.tbNrOfTiles.Location = new System.Drawing.Point(70, 185);
            this.tbNrOfTiles.Name = "tbNrOfTiles";
            this.tbNrOfTiles.Size = new System.Drawing.Size(87, 20);
            this.tbNrOfTiles.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbTopoCol);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbTopoMatrixSet);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbTopoMatrix);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tbTopoRow);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 130);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TIle";
            // 
            // tbTopoCol
            // 
            this.tbTopoCol.Location = new System.Drawing.Point(54, 97);
            this.tbTopoCol.Name = "tbTopoCol";
            this.tbTopoCol.Size = new System.Drawing.Size(128, 20);
            this.tbTopoCol.TabIndex = 3;
            this.tbTopoCol.Text = "3288";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Column";
            // 
            // tbTopoMatrixSet
            // 
            this.tbTopoMatrixSet.Location = new System.Drawing.Point(54, 19);
            this.tbTopoMatrixSet.Name = "tbTopoMatrixSet";
            this.tbTopoMatrixSet.Size = new System.Drawing.Size(128, 20);
            this.tbTopoMatrixSet.TabIndex = 3;
            this.tbTopoMatrixSet.Text = "3006";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Row";
            // 
            // tbTopoMatrix
            // 
            this.tbTopoMatrix.Location = new System.Drawing.Point(54, 45);
            this.tbTopoMatrix.Name = "tbTopoMatrix";
            this.tbTopoMatrix.Size = new System.Drawing.Size(128, 20);
            this.tbTopoMatrix.TabIndex = 3;
            this.tbTopoMatrix.Text = "11";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Matrix";
            // 
            // tbTopoRow
            // 
            this.tbTopoRow.Location = new System.Drawing.Point(54, 71);
            this.tbTopoRow.Name = "tbTopoRow";
            this.tbTopoRow.Size = new System.Drawing.Size(128, 20);
            this.tbTopoRow.TabIndex = 3;
            this.tbTopoRow.Text = "4436";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Set";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "GetMap";
            this.button1.UseVisualStyleBackColor = true;
          //  this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUrl
            // 
            this.btnUrl.Location = new System.Drawing.Point(12, 12);
            this.btnUrl.Name = "btnUrl";
            this.btnUrl.Size = new System.Drawing.Size(75, 23);
            this.btnUrl.TabIndex = 2;
            this.btnUrl.Text = "URL";
            this.btnUrl.UseVisualStyleBackColor = true;
         //   this.btnUrl.Click += new System.EventHandler(this.btnUrl_Click);
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(93, 14);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(853, 20);
            this.tbURL.TabIndex = 3;
            // 
            // pbMap
            // 
            this.pbMap.Location = new System.Drawing.Point(12, 41);
            this.pbMap.Name = "pbMap";
            this.pbMap.Size = new System.Drawing.Size(934, 744);
            this.pbMap.TabIndex = 4;
            this.pbMap.TabStop = false;
            // 
            // MapViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 797);
            this.Controls.Add(this.pbMap);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.btnUrl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MapViewer";
            this.Text = "Lantmäteriets Kartor";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNrOfTiles)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUrl;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.PictureBox pbMap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTopoCol;
        private System.Windows.Forms.TextBox tbTopoRow;
        private System.Windows.Forms.TextBox tbTopoMatrix;
        private System.Windows.Forms.TextBox tbTopoMatrixSet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown tbNrOfTiles;
    }
}


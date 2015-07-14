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
            this.tbRight = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSizeX = new System.Windows.Forms.TextBox();
            this.tbSizeY = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbBottom = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbposX = new System.Windows.Forms.TextBox();
            this.tbPosY = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMapType = new System.Windows.Forms.ComboBox();
            this.tbTop = new System.Windows.Forms.TextBox();
            this.btnGetGenerealMap = new System.Windows.Forms.Button();
            this.tbLeft = new System.Windows.Forms.TextBox();
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
            this.btnGetTopoMap = new System.Windows.Forms.Button();
            this.btnUrl = new System.Windows.Forms.Button();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.pbMap = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNrOfTiles)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbRight);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbBottom);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbMapType);
            this.groupBox1.Controls.Add(this.tbTop);
            this.groupBox1.Controls.Add(this.btnGetGenerealMap);
            this.groupBox1.Controls.Add(this.tbLeft);
            this.groupBox1.Location = new System.Drawing.Point(818, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 336);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General map";
            // 
            // tbRight
            // 
            this.tbRight.Location = new System.Drawing.Point(100, 250);
            this.tbRight.Name = "tbRight";
            this.tbRight.Size = new System.Drawing.Size(68, 20);
            this.tbRight.TabIndex = 14;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.tbSizeX);
            this.groupBox5.Controls.Add(this.tbSizeY);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(6, 115);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(188, 63);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Size";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "X";
            // 
            // tbSizeX
            // 
            this.tbSizeX.Location = new System.Drawing.Point(24, 25);
            this.tbSizeX.Name = "tbSizeX";
            this.tbSizeX.Size = new System.Drawing.Size(65, 20);
            this.tbSizeX.TabIndex = 3;
            this.tbSizeX.Text = "3000";
            // 
            // tbSizeY
            // 
            this.tbSizeY.Location = new System.Drawing.Point(114, 25);
            this.tbSizeY.Name = "tbSizeY";
            this.tbSizeY.Size = new System.Drawing.Size(65, 20);
            this.tbSizeY.TabIndex = 3;
            this.tbSizeY.Text = "3000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(96, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Y";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "GetMap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GetMap_Click);
            // 
            // tbBottom
            // 
            this.tbBottom.Location = new System.Drawing.Point(65, 276);
            this.tbBottom.Name = "tbBottom";
            this.tbBottom.Size = new System.Drawing.Size(68, 20);
            this.tbBottom.TabIndex = 13;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.tbposX);
            this.groupBox4.Controls.Add(this.tbPosY);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(6, 46);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(188, 63);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "position";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "X";
            // 
            // tbposX
            // 
            this.tbposX.Location = new System.Drawing.Point(24, 25);
            this.tbposX.Name = "tbposX";
            this.tbposX.Size = new System.Drawing.Size(65, 20);
            this.tbposX.TabIndex = 3;
            this.tbposX.Text = "483000";
            // 
            // tbPosY
            // 
            this.tbPosY.Location = new System.Drawing.Point(114, 25);
            this.tbPosY.Name = "tbPosY";
            this.tbPosY.Size = new System.Drawing.Size(65, 20);
            this.tbPosY.TabIndex = 3;
            this.tbPosY.Text = "6229000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Type";
            // 
            // cbMapType
            // 
            this.cbMapType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMapType.FormattingEnabled = true;
            this.cbMapType.Location = new System.Drawing.Point(43, 19);
            this.cbMapType.Name = "cbMapType";
            this.cbMapType.Size = new System.Drawing.Size(151, 21);
            this.cbMapType.TabIndex = 8;
            // 
            // tbTop
            // 
            this.tbTop.Location = new System.Drawing.Point(65, 222);
            this.tbTop.Name = "tbTop";
            this.tbTop.Size = new System.Drawing.Size(68, 20);
            this.tbTop.TabIndex = 12;
            // 
            // btnGetGenerealMap
            // 
            this.btnGetGenerealMap.Location = new System.Drawing.Point(9, 184);
            this.btnGetGenerealMap.Name = "btnGetGenerealMap";
            this.btnGetGenerealMap.Size = new System.Drawing.Size(188, 23);
            this.btnGetGenerealMap.TabIndex = 7;
            this.btnGetGenerealMap.Text = "Transpose";
            this.btnGetGenerealMap.UseVisualStyleBackColor = true;
            this.btnGetGenerealMap.Click += new System.EventHandler(this.btnTranspose_Click);
            // 
            // tbLeft
            // 
            this.tbLeft.Location = new System.Drawing.Point(26, 250);
            this.tbLeft.Name = "tbLeft";
            this.tbLeft.Size = new System.Drawing.Size(68, 20);
            this.tbLeft.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbNrOfTiles);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnGetTopoMap);
            this.groupBox2.Location = new System.Drawing.Point(818, 611);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 236);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TopoMap";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "NrOfTIles";
            // 
            // tbNrOfTiles
            // 
            this.tbNrOfTiles.Location = new System.Drawing.Point(101, 155);
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
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
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
            // btnGetTopoMap
            // 
            this.btnGetTopoMap.Location = new System.Drawing.Point(6, 207);
            this.btnGetTopoMap.Name = "btnGetTopoMap";
            this.btnGetTopoMap.Size = new System.Drawing.Size(188, 23);
            this.btnGetTopoMap.TabIndex = 2;
            this.btnGetTopoMap.Text = "GetMap";
            this.btnGetTopoMap.UseVisualStyleBackColor = true;
            this.btnGetTopoMap.Click += new System.EventHandler(this.btnGetTopoMap_Click);
            // 
            // btnUrl
            // 
            this.btnUrl.Location = new System.Drawing.Point(12, 12);
            this.btnUrl.Name = "btnUrl";
            this.btnUrl.Size = new System.Drawing.Size(75, 23);
            this.btnUrl.TabIndex = 2;
            this.btnUrl.Text = "URL";
            this.btnUrl.UseVisualStyleBackColor = true;
            this.btnUrl.Click += new System.EventHandler(this.btnUrl_Click);
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(93, 14);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(925, 20);
            this.tbURL.TabIndex = 3;
            // 
            // pbMap
            // 
            this.pbMap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbMap.Location = new System.Drawing.Point(12, 47);
            this.pbMap.Name = "pbMap";
            this.pbMap.Size = new System.Drawing.Size(800, 800);
            this.pbMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMap.TabIndex = 4;
            this.pbMap.TabStop = false;
            this.pbMap.Paint += new System.Windows.Forms.PaintEventHandler(this.pbMap_Paint);
            this.pbMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMap_MouseDown);
            this.pbMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbMap_MouseMove);
            this.pbMap.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbMap_MouseUp);
            // 
            // MapViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 1023);
            this.Controls.Add(this.pbMap);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.btnUrl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MapViewer";
            this.Text = "Lantmäteriets Kartor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.Button btnGetTopoMap;
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
        private System.Windows.Forms.Button btnGetGenerealMap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMapType;
        private System.Windows.Forms.TextBox tbposX;
        private System.Windows.Forms.TextBox tbPosY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSizeX;
        private System.Windows.Forms.TextBox tbSizeY;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbRight;
        private System.Windows.Forms.TextBox tbBottom;
        private System.Windows.Forms.TextBox tbTop;
        private System.Windows.Forms.TextBox tbLeft;
        private System.Windows.Forms.Button button1;
    }
}


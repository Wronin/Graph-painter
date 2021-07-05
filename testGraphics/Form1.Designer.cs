
namespace testGraphics
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DrawGraph = new System.Windows.Forms.Button();
            this.TxtBoxX = new System.Windows.Forms.TextBox();
            this.TxtBoxY = new System.Windows.Forms.TextBox();
            this.LableX = new System.Windows.Forms.Label();
            this.LabelY = new System.Windows.Forms.Label();
            this.ZoomIn = new System.Windows.Forms.Button();
            this.ZoomOut = new System.Windows.Forms.Button();
            this.GraphBorder = new System.Windows.Forms.Label();
            this.TxtBoxX1 = new System.Windows.Forms.TextBox();
            this.TxtBoxY1 = new System.Windows.Forms.TextBox();
            this.DataTableGrid = new System.Windows.Forms.DataGridView();
            this.ButtonLeft = new System.Windows.Forms.Button();
            this.ButtonUp = new System.Windows.Forms.Button();
            this.ButtonDown = new System.Windows.Forms.Button();
            this.ButtonRight = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.asdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Coordinates = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 385);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // DrawGraph
            // 
            this.DrawGraph.Location = new System.Drawing.Point(624, 27);
            this.DrawGraph.Name = "DrawGraph";
            this.DrawGraph.Size = new System.Drawing.Size(164, 31);
            this.DrawGraph.TabIndex = 1;
            this.DrawGraph.Text = "Draw";
            this.DrawGraph.UseVisualStyleBackColor = true;
            this.DrawGraph.Click += new System.EventHandler(this.DrawGraph_Click);
            // 
            // TxtBoxX
            // 
            this.TxtBoxX.Location = new System.Drawing.Point(670, 92);
            this.TxtBoxX.Name = "TxtBoxX";
            this.TxtBoxX.Size = new System.Drawing.Size(53, 23);
            this.TxtBoxX.TabIndex = 2;
            // 
            // TxtBoxY
            // 
            this.TxtBoxY.Location = new System.Drawing.Point(670, 121);
            this.TxtBoxY.Name = "TxtBoxY";
            this.TxtBoxY.Size = new System.Drawing.Size(53, 23);
            this.TxtBoxY.TabIndex = 3;
            // 
            // LableX
            // 
            this.LableX.Location = new System.Drawing.Point(635, 92);
            this.LableX.Name = "LableX";
            this.LableX.Size = new System.Drawing.Size(14, 15);
            this.LableX.TabIndex = 14;
            this.LableX.Text = "X";
            // 
            // LabelY
            // 
            this.LabelY.AutoSize = true;
            this.LabelY.Location = new System.Drawing.Point(635, 121);
            this.LabelY.Name = "LabelY";
            this.LabelY.Size = new System.Drawing.Size(14, 15);
            this.LabelY.TabIndex = 5;
            this.LabelY.Text = "Y";
            // 
            // ZoomIn
            // 
            this.ZoomIn.Location = new System.Drawing.Point(299, 416);
            this.ZoomIn.Name = "ZoomIn";
            this.ZoomIn.Size = new System.Drawing.Size(75, 23);
            this.ZoomIn.TabIndex = 13;
            this.ZoomIn.Text = "Zoom in";
            this.ZoomIn.Click += new System.EventHandler(this.ZoomIn_Click);
            // 
            // ZoomOut
            // 
            this.ZoomOut.Location = new System.Drawing.Point(299, 441);
            this.ZoomOut.Name = "ZoomOut";
            this.ZoomOut.Size = new System.Drawing.Size(75, 23);
            this.ZoomOut.TabIndex = 10;
            this.ZoomOut.Text = "Zoom out";
            this.ZoomOut.UseVisualStyleBackColor = true;
            this.ZoomOut.Click += new System.EventHandler(this.ZoomOut_Click);
            // 
            // GraphBorder
            // 
            this.GraphBorder.AutoSize = true;
            this.GraphBorder.Location = new System.Drawing.Point(658, 74);
            this.GraphBorder.Name = "GraphBorder";
            this.GraphBorder.Size = new System.Drawing.Size(77, 15);
            this.GraphBorder.TabIndex = 11;
            this.GraphBorder.Text = "Graph border";
            // 
            // TxtBoxX1
            // 
            this.TxtBoxX1.Location = new System.Drawing.Point(731, 92);
            this.TxtBoxX1.Name = "TxtBoxX1";
            this.TxtBoxX1.Size = new System.Drawing.Size(57, 23);
            this.TxtBoxX1.TabIndex = 15;
            // 
            // TxtBoxY1
            // 
            this.TxtBoxY1.Location = new System.Drawing.Point(731, 121);
            this.TxtBoxY1.Name = "TxtBoxY1";
            this.TxtBoxY1.Size = new System.Drawing.Size(57, 23);
            this.TxtBoxY1.TabIndex = 16;
            // 
            // DataTableGrid
            // 
            this.DataTableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTableGrid.Location = new System.Drawing.Point(624, 160);
            this.DataTableGrid.Name = "DataTableGrid";
            this.DataTableGrid.RowTemplate.Height = 25;
            this.DataTableGrid.Size = new System.Drawing.Size(164, 223);
            this.DataTableGrid.TabIndex = 17;
            // 
            // ButtonLeft
            // 
            this.ButtonLeft.Location = new System.Drawing.Point(29, 429);
            this.ButtonLeft.Name = "ButtonLeft";
            this.ButtonLeft.Size = new System.Drawing.Size(75, 23);
            this.ButtonLeft.TabIndex = 18;
            this.ButtonLeft.Text = "Left";
            this.ButtonLeft.UseVisualStyleBackColor = true;
            this.ButtonLeft.Click += new System.EventHandler(this.ButtonLeft_Click);
            // 
            // ButtonUp
            // 
            this.ButtonUp.Location = new System.Drawing.Point(111, 416);
            this.ButtonUp.Name = "ButtonUp";
            this.ButtonUp.Size = new System.Drawing.Size(75, 23);
            this.ButtonUp.TabIndex = 19;
            this.ButtonUp.Text = "Up";
            this.ButtonUp.UseVisualStyleBackColor = true;
            this.ButtonUp.Click += new System.EventHandler(this.ButtonUp_Click);
            // 
            // ButtonDown
            // 
            this.ButtonDown.Location = new System.Drawing.Point(111, 441);
            this.ButtonDown.Name = "ButtonDown";
            this.ButtonDown.Size = new System.Drawing.Size(75, 23);
            this.ButtonDown.TabIndex = 20;
            this.ButtonDown.Text = "Down";
            this.ButtonDown.UseVisualStyleBackColor = true;
            this.ButtonDown.Click += new System.EventHandler(this.ButtonDown_Click);
            // 
            // ButtonRight
            // 
            this.ButtonRight.Location = new System.Drawing.Point(193, 429);
            this.ButtonRight.Name = "ButtonRight";
            this.ButtonRight.Size = new System.Drawing.Size(75, 23);
            this.ButtonRight.TabIndex = 21;
            this.ButtonRight.Text = "Right";
            this.ButtonRight.UseVisualStyleBackColor = true;
            this.ButtonRight.Click += new System.EventHandler(this.ButtonRight_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(624, 389);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(164, 23);
            this.ButtonDelete.TabIndex = 23;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // asdfToolStripMenuItem
            // 
            this.asdfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveTableToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.LoadGraphToolStripMenuItem});
            this.asdfToolStripMenuItem.Name = "asdfToolStripMenuItem";
            this.asdfToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.asdfToolStripMenuItem.Text = "Menu";
            // 
            // SaveTableToolStripMenuItem
            // 
            this.SaveTableToolStripMenuItem.Name = "SaveTableToolStripMenuItem";
            this.SaveTableToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.SaveTableToolStripMenuItem.Text = "Save";
            this.SaveTableToolStripMenuItem.Click += new System.EventHandler(this.SaveTableToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.loadToolStripMenuItem.Text = "Print graph";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.PrintGraphToolStripMenuItem_Click);
            // 
            // LoadGraphToolStripMenuItem
            // 
            this.LoadGraphToolStripMenuItem.Name = "LoadGraphToolStripMenuItem";
            this.LoadGraphToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.LoadGraphToolStripMenuItem.Text = "Load graph";
            this.LoadGraphToolStripMenuItem.Click += new System.EventHandler(this.LoadGraphToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdfToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(797, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Coordinates
            // 
            this.Coordinates.AutoSize = true;
            this.Coordinates.Location = new System.Drawing.Point(417, 429);
            this.Coordinates.Name = "Coordinates";
            this.Coordinates.Size = new System.Drawing.Size(0, 15);
            this.Coordinates.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 467);
            this.Controls.Add(this.Coordinates);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonRight);
            this.Controls.Add(this.ButtonDown);
            this.Controls.Add(this.ButtonUp);
            this.Controls.Add(this.ButtonLeft);
            this.Controls.Add(this.DataTableGrid);
            this.Controls.Add(this.TxtBoxY1);
            this.Controls.Add(this.TxtBoxX1);
            this.Controls.Add(this.GraphBorder);
            this.Controls.Add(this.ZoomOut);
            this.Controls.Add(this.ZoomIn);
            this.Controls.Add(this.LabelY);
            this.Controls.Add(this.LableX);
            this.Controls.Add(this.TxtBoxY);
            this.Controls.Add(this.TxtBoxX);
            this.Controls.Add(this.DrawGraph);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DrawGraph;
        private System.Windows.Forms.TextBox TxtBoxX;
        private System.Windows.Forms.TextBox TxtBoxY;
        private System.Windows.Forms.Label LableX;
        private System.Windows.Forms.Label LabelY;
        private System.Windows.Forms.Button ZoomIn;
        private System.Windows.Forms.Button ZoomOut;
        private System.Windows.Forms.Label GraphBorder;
        private System.Windows.Forms.TextBox TxtBoxX1;
        private System.Windows.Forms.TextBox TxtBoxY1;
        private System.Windows.Forms.DataGridView DataTableGrid;
        private System.Windows.Forms.Button ButtonLeft;
        private System.Windows.Forms.Button ButtonUp;
        private System.Windows.Forms.Button ButtonDown;
        private System.Windows.Forms.Button ButtonRight;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.ToolStripMenuItem asdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadGraphToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label Coordinates;
    }
}


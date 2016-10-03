namespace CoolTekenDing
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CubeRbutton = new System.Windows.Forms.RadioButton();
            this.OldCubeRbutton = new System.Windows.Forms.RadioButton();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.heightSelector = new System.Windows.Forms.NumericUpDown();
            this.widthSelector = new System.Windows.Forms.NumericUpDown();
            this.adapterTrackBar = new System.Windows.Forms.TrackBar();
            this.LegacyRectangleLabel = new System.Windows.Forms.Label();
            this.LegacyRectangleAdapterLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.heightSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adapterTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 555);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // CubeRbutton
            // 
            this.CubeRbutton.AutoSize = true;
            this.CubeRbutton.Location = new System.Drawing.Point(750, 96);
            this.CubeRbutton.Name = "CubeRbutton";
            this.CubeRbutton.Size = new System.Drawing.Size(50, 17);
            this.CubeRbutton.TabIndex = 1;
            this.CubeRbutton.TabStop = true;
            this.CubeRbutton.Text = "Cube";
            this.CubeRbutton.UseVisualStyleBackColor = true;
            this.CubeRbutton.CheckedChanged += new System.EventHandler(this.CubeRbutton_CheckedChanged);
            // 
            // OldCubeRbutton
            // 
            this.OldCubeRbutton.AutoSize = true;
            this.OldCubeRbutton.Location = new System.Drawing.Point(840, 96);
            this.OldCubeRbutton.Name = "OldCubeRbutton";
            this.OldCubeRbutton.Size = new System.Drawing.Size(69, 17);
            this.OldCubeRbutton.TabIndex = 2;
            this.OldCubeRbutton.TabStop = true;
            this.OldCubeRbutton.Text = "Old Cube";
            this.OldCubeRbutton.UseVisualStyleBackColor = true;
            this.OldCubeRbutton.CheckedChanged += new System.EventHandler(this.OldCubeRbutton_CheckedChanged);
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(747, 24);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(41, 13);
            this.HeightLabel.TabIndex = 5;
            this.HeightLabel.Text = "Height:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(750, 50);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(38, 13);
            this.WidthLabel.TabIndex = 6;
            this.WidthLabel.Text = "Width:";
            // 
            // heightSelector
            // 
            this.heightSelector.Location = new System.Drawing.Point(795, 24);
            this.heightSelector.Name = "heightSelector";
            this.heightSelector.Size = new System.Drawing.Size(120, 20);
            this.heightSelector.TabIndex = 7;
            this.heightSelector.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // widthSelector
            // 
            this.widthSelector.Location = new System.Drawing.Point(795, 51);
            this.widthSelector.Name = "widthSelector";
            this.widthSelector.Size = new System.Drawing.Size(120, 20);
            this.widthSelector.TabIndex = 8;
            this.widthSelector.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // adapterTrackBar
            // 
            this.adapterTrackBar.Location = new System.Drawing.Point(753, 173);
            this.adapterTrackBar.Maximum = 1;
            this.adapterTrackBar.Name = "adapterTrackBar";
            this.adapterTrackBar.Size = new System.Drawing.Size(156, 45);
            this.adapterTrackBar.TabIndex = 9;
            this.adapterTrackBar.ValueChanged += new System.EventHandler(this.adapterTrackBar_ValueChanged);
            // 
            // LegacyRectangleLabel
            // 
            this.LegacyRectangleLabel.AutoSize = true;
            this.LegacyRectangleLabel.Location = new System.Drawing.Point(824, 221);
            this.LegacyRectangleLabel.Name = "LegacyRectangleLabel";
            this.LegacyRectangleLabel.Size = new System.Drawing.Size(91, 13);
            this.LegacyRectangleLabel.TabIndex = 10;
            this.LegacyRectangleLabel.Text = "LegacyRectangle";
            // 
            // LegacyRectangleAdapterLabel
            // 
            this.LegacyRectangleAdapterLabel.AutoSize = true;
            this.LegacyRectangleAdapterLabel.Location = new System.Drawing.Point(744, 221);
            this.LegacyRectangleAdapterLabel.Name = "LegacyRectangleAdapterLabel";
            this.LegacyRectangleAdapterLabel.Size = new System.Drawing.Size(44, 13);
            this.LegacyRectangleAdapterLabel.TabIndex = 11;
            this.LegacyRectangleAdapterLabel.Text = "Adapter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 555);
            this.Controls.Add(this.LegacyRectangleAdapterLabel);
            this.Controls.Add(this.LegacyRectangleLabel);
            this.Controls.Add(this.adapterTrackBar);
            this.Controls.Add(this.widthSelector);
            this.Controls.Add(this.heightSelector);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.OldCubeRbutton);
            this.Controls.Add(this.CubeRbutton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Adapter Pattern";
            ((System.ComponentModel.ISupportInitialize)(this.heightSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adapterTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton CubeRbutton;
        private System.Windows.Forms.RadioButton OldCubeRbutton;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.NumericUpDown heightSelector;
        private System.Windows.Forms.NumericUpDown widthSelector;
        private System.Windows.Forms.TrackBar adapterTrackBar;
        private System.Windows.Forms.Label LegacyRectangleLabel;
        private System.Windows.Forms.Label LegacyRectangleAdapterLabel;
    }
}


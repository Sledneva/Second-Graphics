namespace SecondGraphics
{
    partial class GraphicsForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.sizeTrackBar = new System.Windows.Forms.TrackBar();
            this.vertexesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.drawingButton = new System.Windows.Forms.Button();
            this.drawingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertexesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // drawingPanel
            // 
            this.drawingPanel.Controls.Add(this.sizeTrackBar);
            this.drawingPanel.Controls.Add(this.vertexesNumericUpDown);
            this.drawingPanel.Controls.Add(this.drawingButton);
            this.drawingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingPanel.Location = new System.Drawing.Point(0, 0);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(784, 461);
            this.drawingPanel.TabIndex = 0;
            this.drawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseDown);
            this.drawingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseMove);
            this.drawingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseUp);
            // 
            // sizeTrackBar
            // 
            this.sizeTrackBar.Location = new System.Drawing.Point(668, 171);
            this.sizeTrackBar.Maximum = 500;
            this.sizeTrackBar.Minimum = 50;
            this.sizeTrackBar.Name = "sizeTrackBar";
            this.sizeTrackBar.Size = new System.Drawing.Size(104, 45);
            this.sizeTrackBar.TabIndex = 3;
            this.sizeTrackBar.Value = 100;
            this.sizeTrackBar.ValueChanged += new System.EventHandler(this.sizeTrackBar_ValueChanged);
            // 
            // vertexesNumericUpDown
            // 
            this.vertexesNumericUpDown.Location = new System.Drawing.Point(700, 92);
            this.vertexesNumericUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.vertexesNumericUpDown.Name = "vertexesNumericUpDown";
            this.vertexesNumericUpDown.Size = new System.Drawing.Size(46, 20);
            this.vertexesNumericUpDown.TabIndex = 2;
            this.vertexesNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.vertexesNumericUpDown.ValueChanged += new System.EventHandler(this.vertexesNumericUpDown_ValueChanged);
            // 
            // drawingButton
            // 
            this.drawingButton.Location = new System.Drawing.Point(684, 142);
            this.drawingButton.Name = "drawingButton";
            this.drawingButton.Size = new System.Drawing.Size(75, 23);
            this.drawingButton.TabIndex = 1;
            this.drawingButton.Text = "Draw";
            this.drawingButton.UseVisualStyleBackColor = true;
            this.drawingButton.Click += new System.EventHandler(this.drawingButton_Click);
            // 
            // GraphicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.drawingPanel);
            this.Name = "GraphicsForm";
            this.Text = "Project";
            this.drawingPanel.ResumeLayout(false);
            this.drawingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertexesNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.NumericUpDown vertexesNumericUpDown;
        private System.Windows.Forms.Button drawingButton;
        private System.Windows.Forms.TrackBar sizeTrackBar;
    }
}


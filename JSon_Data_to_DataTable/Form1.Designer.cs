namespace JSon_Data_to_DataTable
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.enhancedADGV_JSON = new JSon_Data_to_DataTable.EnhancedADGV();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.JsonUrlTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.GridViewPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.enhancedADGV_JSON)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.GridViewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // enhancedADGV_JSON
            // 
            this.enhancedADGV_JSON.AllowUserToAddRows = false;
            this.enhancedADGV_JSON.AllowUserToDeleteRows = false;
            this.enhancedADGV_JSON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enhancedADGV_JSON.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enhancedADGV_JSON.FilterAndSortEnabled = true;
            this.enhancedADGV_JSON.Location = new System.Drawing.Point(0, 0);
            this.enhancedADGV_JSON.Name = "enhancedADGV_JSON";
            this.enhancedADGV_JSON.ReadOnly = true;
            this.enhancedADGV_JSON.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.enhancedADGV_JSON.RowHeadersWidth = 51;
            this.enhancedADGV_JSON.RowTemplate.Height = 24;
            this.enhancedADGV_JSON.Size = new System.Drawing.Size(800, 384);
            this.enhancedADGV_JSON.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.JsonUrlTextBox);
            this.flowLayoutPanel1.Controls.Add(this.GenerateButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 40);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // JsonUrlTextBox
            // 
            this.JsonUrlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JsonUrlTextBox.Location = new System.Drawing.Point(147, 3);
            this.JsonUrlTextBox.Name = "JsonUrlTextBox";
            this.JsonUrlTextBox.Size = new System.Drawing.Size(547, 22);
            this.JsonUrlTextBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 26);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(800, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "V";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "JSON file WEB URL:";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateButton.Location = new System.Drawing.Point(700, 3);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(88, 23);
            this.GenerateButton.TabIndex = 2;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // GridViewPanel
            // 
            this.GridViewPanel.Controls.Add(this.enhancedADGV_JSON);
            this.GridViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewPanel.Location = new System.Drawing.Point(0, 66);
            this.GridViewPanel.Name = "GridViewPanel";
            this.GridViewPanel.Size = new System.Drawing.Size(800, 384);
            this.GridViewPanel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridViewPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.enhancedADGV_JSON)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.GridViewPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private EnhancedADGV enhancedADGV_JSON;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox JsonUrlTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel GridViewPanel;
    }
}


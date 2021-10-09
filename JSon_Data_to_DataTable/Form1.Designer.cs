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
            this.SHPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.JsonUrlTextBox = new System.Windows.Forms.TextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GridViewPanel = new System.Windows.Forms.Panel();
            this.SHButton = new XanderUI.XUIButton();
            this.enhancedADGV_JSON = new JSon_Data_to_DataTable.EnhancedADGV();
            this.SHPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.GridViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enhancedADGV_JSON)).BeginInit();
            this.SuspendLayout();
            // 
            // SHPanel
            // 
            this.SHPanel.Controls.Add(this.label1);
            this.SHPanel.Controls.Add(this.JsonUrlTextBox);
            this.SHPanel.Controls.Add(this.GenerateButton);
            this.SHPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SHPanel.Location = new System.Drawing.Point(0, 0);
            this.SHPanel.Margin = new System.Windows.Forms.Padding(8);
            this.SHPanel.Name = "SHPanel";
            this.SHPanel.Size = new System.Drawing.Size(851, 40);
            this.SHPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "JSON file WEB URL:";
            // 
            // JsonUrlTextBox
            // 
            this.JsonUrlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JsonUrlTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.JsonUrlTextBox.Location = new System.Drawing.Point(154, 3);
            this.JsonUrlTextBox.Name = "JsonUrlTextBox";
            this.JsonUrlTextBox.Size = new System.Drawing.Size(583, 25);
            this.JsonUrlTextBox.TabIndex = 0;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GenerateButton.Location = new System.Drawing.Point(743, 3);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(88, 28);
            this.GenerateButton.TabIndex = 2;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SHButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 26);
            this.panel1.TabIndex = 2;
            // 
            // GridViewPanel
            // 
            this.GridViewPanel.Controls.Add(this.enhancedADGV_JSON);
            this.GridViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewPanel.Location = new System.Drawing.Point(0, 66);
            this.GridViewPanel.Name = "GridViewPanel";
            this.GridViewPanel.Size = new System.Drawing.Size(851, 431);
            this.GridViewPanel.TabIndex = 3;
            // 
            // SHButton
            // 
            this.SHButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.SHButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SHButton.ButtonImage = null;
            this.SHButton.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.SHButton.ButtonText = "^ HIDE ^";
            this.SHButton.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.SHButton.ClickTextColor = System.Drawing.Color.Yellow;
            this.SHButton.CornerRadius = 0;
            this.SHButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SHButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SHButton.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.SHButton.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.SHButton.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SHButton.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.SHButton.Location = new System.Drawing.Point(0, 0);
            this.SHButton.Name = "SHButton";
            this.SHButton.Size = new System.Drawing.Size(851, 26);
            this.SHButton.TabIndex = 0;
            this.SHButton.TextColor = System.Drawing.Color.White;
            this.SHButton.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.SHButton.Click += new System.EventHandler(this.SHButton_Click);
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
            this.enhancedADGV_JSON.Size = new System.Drawing.Size(851, 431);
            this.enhancedADGV_JSON.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 497);
            this.Controls.Add(this.GridViewPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SHPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SHPanel.ResumeLayout(false);
            this.SHPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.GridViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.enhancedADGV_JSON)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnhancedADGV enhancedADGV_JSON;
        private System.Windows.Forms.FlowLayoutPanel SHPanel;
        private System.Windows.Forms.TextBox JsonUrlTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel GridViewPanel;
        private XanderUI.XUIButton SHButton;
    }
}


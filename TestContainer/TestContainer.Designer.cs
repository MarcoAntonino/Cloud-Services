namespace TestContainer
{
    partial class TestContainer
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblContainer = new System.Windows.Forms.Label();
            this.txtContainer = new System.Windows.Forms.TextBox();
            this.btnContainer = new System.Windows.Forms.Button();
            this.txtBlob = new System.Windows.Forms.TextBox();
            this.lblBlob = new System.Windows.Forms.Label();
            this.txtUpload = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.txtList = new System.Windows.Forms.TextBox();
            this.lblList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblContainer
            // 
            this.lblContainer.AutoSize = true;
            this.lblContainer.Location = new System.Drawing.Point(87, 50);
            this.lblContainer.Name = "lblContainer";
            this.lblContainer.Size = new System.Drawing.Size(83, 13);
            this.lblContainer.TabIndex = 0;
            this.lblContainer.Text = "Container Name";
            this.lblContainer.Click += new System.EventHandler(this.lblContainer_Click);
            // 
            // txtContainer
            // 
            this.txtContainer.Location = new System.Drawing.Point(90, 66);
            this.txtContainer.Name = "txtContainer";
            this.txtContainer.Size = new System.Drawing.Size(100, 20);
            this.txtContainer.TabIndex = 1;
            // 
            // btnContainer
            // 
            this.btnContainer.Location = new System.Drawing.Point(90, 92);
            this.btnContainer.Name = "btnContainer";
            this.btnContainer.Size = new System.Drawing.Size(100, 23);
            this.btnContainer.TabIndex = 2;
            this.btnContainer.Text = "Crea Container";
            this.btnContainer.UseVisualStyleBackColor = true;
            this.btnContainer.Click += new System.EventHandler(this.btnContainer_Click);
            // 
            // txtBlob
            // 
            this.txtBlob.Location = new System.Drawing.Point(90, 184);
            this.txtBlob.Name = "txtBlob";
            this.txtBlob.Size = new System.Drawing.Size(100, 20);
            this.txtBlob.TabIndex = 4;
            // 
            // lblBlob
            // 
            this.lblBlob.AutoSize = true;
            this.lblBlob.Location = new System.Drawing.Point(87, 168);
            this.lblBlob.Name = "lblBlob";
            this.lblBlob.Size = new System.Drawing.Size(59, 13);
            this.lblBlob.TabIndex = 3;
            this.lblBlob.Text = "Blob Name";
            // 
            // txtUpload
            // 
            this.txtUpload.Location = new System.Drawing.Point(90, 289);
            this.txtUpload.Name = "txtUpload";
            this.txtUpload.Size = new System.Drawing.Size(100, 23);
            this.txtUpload.TabIndex = 7;
            this.txtUpload.Text = "Upload";
            this.txtUpload.UseVisualStyleBackColor = true;
            this.txtUpload.Click += new System.EventHandler(this.txtUpload_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(90, 263);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(100, 20);
            this.txtFile.TabIndex = 6;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(87, 247);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(54, 13);
            this.lblFile.TabIndex = 5;
            this.lblFile.Text = "File Name";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(90, 327);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(100, 23);
            this.btnDownload.TabIndex = 8;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(90, 366);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(902, 37);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(100, 23);
            this.btnList.TabIndex = 12;
            this.btnList.Text = "Crea Container";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtList
            // 
            this.txtList.Location = new System.Drawing.Point(538, 66);
            this.txtList.Multiline = true;
            this.txtList.Name = "txtList";
            this.txtList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtList.Size = new System.Drawing.Size(464, 294);
            this.txtList.TabIndex = 11;
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(535, 50);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(83, 13);
            this.lblList.TabIndex = 10;
            this.lblList.Text = "Container Name";
            // 
            // TestContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.txtUpload);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.txtBlob);
            this.Controls.Add(this.lblBlob);
            this.Controls.Add(this.btnContainer);
            this.Controls.Add(this.txtContainer);
            this.Controls.Add(this.lblContainer);
            this.Name = "TestContainer";
            this.Text = "TestContainer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContainer;
        private System.Windows.Forms.TextBox txtContainer;
        private System.Windows.Forms.Button btnContainer;
        private System.Windows.Forms.TextBox txtBlob;
        private System.Windows.Forms.Label lblBlob;
        private System.Windows.Forms.Button txtUpload;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.Label lblList;
    }
}


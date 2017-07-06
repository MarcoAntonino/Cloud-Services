namespace SharedBlackBoard
{
    partial class SharedBlackBoard
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
            this.components = new System.ComponentModel.Container();
            this.pictBlckBrd = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkSend = new System.Windows.Forms.CheckBox();
            this.chkReceive = new System.Windows.Forms.CheckBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictBlckBrd)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBlckBrd
            // 
            this.pictBlckBrd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictBlckBrd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictBlckBrd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictBlckBrd.Location = new System.Drawing.Point(12, 12);
            this.pictBlckBrd.Name = "pictBlckBrd";
            this.pictBlckBrd.Size = new System.Drawing.Size(963, 480);
            this.pictBlckBrd.TabIndex = 0;
            this.pictBlckBrd.TabStop = false;
            this.pictBlckBrd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictBlckBrd_MouseDown);
            this.pictBlckBrd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictBlckBrd_MouseMove);
            this.pictBlckBrd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictBlckBrd_MouseUp);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Location = new System.Drawing.Point(12, 498);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkSend
            // 
            this.chkSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkSend.AutoSize = true;
            this.chkSend.Location = new System.Drawing.Point(325, 503);
            this.chkSend.Name = "chkSend";
            this.chkSend.Size = new System.Drawing.Size(51, 17);
            this.chkSend.TabIndex = 3;
            this.chkSend.Text = "Send";
            this.chkSend.UseVisualStyleBackColor = true;
            this.chkSend.CheckedChanged += new System.EventHandler(this.chkSend_CheckedChanged);
            // 
            // chkReceive
            // 
            this.chkReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkReceive.AutoSize = true;
            this.chkReceive.Location = new System.Drawing.Point(411, 503);
            this.chkReceive.Name = "chkReceive";
            this.chkReceive.Size = new System.Drawing.Size(66, 17);
            this.chkReceive.TabIndex = 4;
            this.chkReceive.Text = "Receive";
            this.chkReceive.UseVisualStyleBackColor = true;
            this.chkReceive.CheckedChanged += new System.EventHandler(this.chkReceive_CheckedChanged);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(132, 503);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(55, 13);
            this.lblColor.TabIndex = 5;
            this.lblColor.Text = "Use color:";
            this.lblColor.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(194, 500);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 6;
            this.txtColor.Text = "#FF0000";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SharedBlackBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 577);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.chkReceive);
            this.Controls.Add(this.chkSend);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pictBlckBrd);
            this.Name = "SharedBlackBoard";
            this.Text = "Shared BlackBoard";
            ((System.ComponentModel.ISupportInitialize)(this.pictBlckBrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBlckBrd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkSend;
        private System.Windows.Forms.CheckBox chkReceive;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Timer timer1;
    }
}


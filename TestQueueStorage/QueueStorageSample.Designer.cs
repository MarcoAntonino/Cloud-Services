namespace TestQueueStorage
{
    partial class QueueStorageSample
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
            this.lblQueueName = new System.Windows.Forms.Label();
            this.txtQueueName = new System.Windows.Forms.TextBox();
            this.btnQueueName = new System.Windows.Forms.Button();
            this.btnMessage = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnPick = new System.Windows.Forms.Button();
            this.btnGetMessage = new System.Windows.Forms.Button();
            this.btnOpenF2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQueueName
            // 
            this.lblQueueName.AutoSize = true;
            this.lblQueueName.Location = new System.Drawing.Point(13, 13);
            this.lblQueueName.Name = "lblQueueName";
            this.lblQueueName.Size = new System.Drawing.Size(70, 13);
            this.lblQueueName.TabIndex = 0;
            this.lblQueueName.Text = "Queue Name";
            // 
            // txtQueueName
            // 
            this.txtQueueName.Location = new System.Drawing.Point(13, 30);
            this.txtQueueName.Name = "txtQueueName";
            this.txtQueueName.Size = new System.Drawing.Size(100, 20);
            this.txtQueueName.TabIndex = 1;
            // 
            // btnQueueName
            // 
            this.btnQueueName.Location = new System.Drawing.Point(13, 57);
            this.btnQueueName.Name = "btnQueueName";
            this.btnQueueName.Size = new System.Drawing.Size(97, 23);
            this.btnQueueName.TabIndex = 2;
            this.btnQueueName.Text = "Create Queue";
            this.btnQueueName.UseVisualStyleBackColor = true;
            this.btnQueueName.Click += new System.EventHandler(this.btnQueueName_Click);
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(10, 149);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(100, 23);
            this.btnMessage.TabIndex = 5;
            this.btnMessage.Text = "Accode Msg";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(10, 122);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(100, 20);
            this.txtMessage.TabIndex = 4;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(10, 105);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Message";
            // 
            // btnPick
            // 
            this.btnPick.Location = new System.Drawing.Point(10, 178);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(100, 23);
            this.btnPick.TabIndex = 6;
            this.btnPick.Text = "Pick next message";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // btnGetMessage
            // 
            this.btnGetMessage.Location = new System.Drawing.Point(10, 207);
            this.btnGetMessage.Name = "btnGetMessage";
            this.btnGetMessage.Size = new System.Drawing.Size(100, 23);
            this.btnGetMessage.TabIndex = 7;
            this.btnGetMessage.Text = "Get Message";
            this.btnGetMessage.UseVisualStyleBackColor = true;
            this.btnGetMessage.Click += new System.EventHandler(this.btnGetMessage_Click);
            // 
            // btnOpenF2
            // 
            this.btnOpenF2.Location = new System.Drawing.Point(172, 82);
            this.btnOpenF2.Name = "btnOpenF2";
            this.btnOpenF2.Size = new System.Drawing.Size(100, 23);
            this.btnOpenF2.TabIndex = 8;
            this.btnOpenF2.Text = "Open Table";
            this.btnOpenF2.UseVisualStyleBackColor = true;
            this.btnOpenF2.Click += new System.EventHandler(this.btnOpenF2_Click);
            // 
            // QueueStorageSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnOpenF2);
            this.Controls.Add(this.btnGetMessage);
            this.Controls.Add(this.btnPick);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnQueueName);
            this.Controls.Add(this.txtQueueName);
            this.Controls.Add(this.lblQueueName);
            this.Name = "QueueStorageSample";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQueueName;
        private System.Windows.Forms.TextBox txtQueueName;
        private System.Windows.Forms.Button btnQueueName;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.Button btnGetMessage;
        private System.Windows.Forms.Button btnOpenF2;
    }
}


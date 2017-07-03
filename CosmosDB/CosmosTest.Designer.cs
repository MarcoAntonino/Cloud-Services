namespace CosmosDB
{
    partial class CosmosTest
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddressType = new System.Windows.Forms.Label();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.txtCollection = new System.Windows.Forms.TextBox();
            this.btnCreateDB = new System.Windows.Forms.Button();
            this.btnCreateCllctn = new System.Windows.Forms.Button();
            this.btnDeleteCllctn = new System.Windows.Forms.Button();
            this.btnDeleteDB = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.btnCrtDoc = new System.Windows.Forms.Button();
            this.btnListDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(79, 128);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblAddressType
            // 
            this.lblAddressType.AutoSize = true;
            this.lblAddressType.Location = new System.Drawing.Point(42, 154);
            this.lblAddressType.Name = "lblAddressType";
            this.lblAddressType.Size = new System.Drawing.Size(72, 13);
            this.lblAddressType.TabIndex = 1;
            this.lblAddressType.Text = "Address Type";
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(13, 13);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(100, 20);
            this.txtDB.TabIndex = 2;
            // 
            // txtCollection
            // 
            this.txtCollection.Location = new System.Drawing.Point(12, 39);
            this.txtCollection.Name = "txtCollection";
            this.txtCollection.Size = new System.Drawing.Size(100, 20);
            this.txtCollection.TabIndex = 3;
            // 
            // btnCreateDB
            // 
            this.btnCreateDB.Location = new System.Drawing.Point(120, 13);
            this.btnCreateDB.Name = "btnCreateDB";
            this.btnCreateDB.Size = new System.Drawing.Size(75, 23);
            this.btnCreateDB.TabIndex = 4;
            this.btnCreateDB.Text = "Create DB";
            this.btnCreateDB.UseVisualStyleBackColor = true;
            this.btnCreateDB.Click += new System.EventHandler(this.btnCreateDB_Click);
            // 
            // btnCreateCllctn
            // 
            this.btnCreateCllctn.Location = new System.Drawing.Point(120, 36);
            this.btnCreateCllctn.Name = "btnCreateCllctn";
            this.btnCreateCllctn.Size = new System.Drawing.Size(100, 23);
            this.btnCreateCllctn.TabIndex = 5;
            this.btnCreateCllctn.Text = "Create Collection";
            this.btnCreateCllctn.UseVisualStyleBackColor = true;
            this.btnCreateCllctn.Click += new System.EventHandler(this.btnCreateCllctn_Click);
            // 
            // btnDeleteCllctn
            // 
            this.btnDeleteCllctn.Location = new System.Drawing.Point(226, 37);
            this.btnDeleteCllctn.Name = "btnDeleteCllctn";
            this.btnDeleteCllctn.Size = new System.Drawing.Size(99, 23);
            this.btnDeleteCllctn.TabIndex = 7;
            this.btnDeleteCllctn.Text = "Delete Collection";
            this.btnDeleteCllctn.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDB
            // 
            this.btnDeleteDB.Location = new System.Drawing.Point(226, 12);
            this.btnDeleteDB.Name = "btnDeleteDB";
            this.btnDeleteDB.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteDB.TabIndex = 6;
            this.btnDeleteDB.Text = "Delete DB";
            this.btnDeleteDB.UseVisualStyleBackColor = true;
            this.btnDeleteDB.Click += new System.EventHandler(this.btnDeleteDB_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(120, 258);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(120, 232);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(120, 180);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(120, 206);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 10;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(120, 128);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 13;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(120, 154);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 12;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(120, 284);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 14;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(68, 287);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 16;
            this.lblCountry.Text = "Country";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(79, 239);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 15;
            this.lblState.Text = "State";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(79, 209);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 18;
            this.lblCity.Text = "City";
            this.lblCity.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(69, 183);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 17;
            this.lblAddress.Text = "Address";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(50, 261);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(64, 13);
            this.lblPostalCode.TabIndex = 19;
            this.lblPostalCode.Text = "Postal Code";
            // 
            // btnCrtDoc
            // 
            this.btnCrtDoc.Location = new System.Drawing.Point(226, 128);
            this.btnCrtDoc.Name = "btnCrtDoc";
            this.btnCrtDoc.Size = new System.Drawing.Size(99, 23);
            this.btnCrtDoc.TabIndex = 20;
            this.btnCrtDoc.Text = "Create Document";
            this.btnCrtDoc.UseVisualStyleBackColor = true;
            this.btnCrtDoc.Click += new System.EventHandler(this.btnCrtDoc_Click);
            // 
            // btnListDB
            // 
            this.btnListDB.Location = new System.Drawing.Point(331, 13);
            this.btnListDB.Name = "btnListDB";
            this.btnListDB.Size = new System.Drawing.Size(75, 23);
            this.btnListDB.TabIndex = 21;
            this.btnListDB.Text = "List DB";
            this.btnListDB.UseVisualStyleBackColor = true;
            this.btnListDB.Click += new System.EventHandler(this.btnListDB_Click);
            // 
            // CosmosTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 491);
            this.Controls.Add(this.btnListDB);
            this.Controls.Add(this.btnCrtDoc);
            this.Controls.Add(this.lblPostalCode);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btnDeleteCllctn);
            this.Controls.Add(this.btnDeleteDB);
            this.Controls.Add(this.btnCreateCllctn);
            this.Controls.Add(this.btnCreateDB);
            this.Controls.Add(this.txtCollection);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.lblAddressType);
            this.Controls.Add(this.lblName);
            this.Name = "CosmosTest";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddressType;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.TextBox txtCollection;
        private System.Windows.Forms.Button btnCreateDB;
        private System.Windows.Forms.Button btnCreateCllctn;
        private System.Windows.Forms.Button btnDeleteCllctn;
        private System.Windows.Forms.Button btnDeleteDB;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Button btnCrtDoc;
        private System.Windows.Forms.Button btnListDB;
    }
}


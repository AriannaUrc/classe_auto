namespace classe_auto
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.acceleratore_button = new System.Windows.Forms.Button();
            this.freno_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.marcia_add_button = new System.Windows.Forms.Button();
            this.marcia_sub_button = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.copia_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // acceleratore_button
            // 
            this.acceleratore_button.Location = new System.Drawing.Point(213, 331);
            this.acceleratore_button.Name = "acceleratore_button";
            this.acceleratore_button.Size = new System.Drawing.Size(75, 23);
            this.acceleratore_button.TabIndex = 0;
            this.acceleratore_button.Text = "acceleratore";
            this.acceleratore_button.UseVisualStyleBackColor = true;
            this.acceleratore_button.Click += new System.EventHandler(this.acceleratore_button_Click);
            // 
            // freno_button
            // 
            this.freno_button.Location = new System.Drawing.Point(326, 331);
            this.freno_button.Name = "freno_button";
            this.freno_button.Size = new System.Drawing.Size(75, 23);
            this.freno_button.TabIndex = 1;
            this.freno_button.Text = "freno";
            this.freno_button.UseVisualStyleBackColor = true;
            this.freno_button.Click += new System.EventHandler(this.freno_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(518, 409);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // marcia_add_button
            // 
            this.marcia_add_button.Location = new System.Drawing.Point(48, 372);
            this.marcia_add_button.Name = "marcia_add_button";
            this.marcia_add_button.Size = new System.Drawing.Size(56, 23);
            this.marcia_add_button.TabIndex = 5;
            this.marcia_add_button.Text = "Marcia +";
            this.marcia_add_button.UseVisualStyleBackColor = true;
            this.marcia_add_button.Click += new System.EventHandler(this.marcia_add_button_Click);
            // 
            // marcia_sub_button
            // 
            this.marcia_sub_button.Location = new System.Drawing.Point(135, 372);
            this.marcia_sub_button.Name = "marcia_sub_button";
            this.marcia_sub_button.Size = new System.Drawing.Size(56, 23);
            this.marcia_sub_button.TabIndex = 6;
            this.marcia_sub_button.Text = "Marcia -";
            this.marcia_sub_button.UseVisualStyleBackColor = true;
            this.marcia_sub_button.Click += new System.EventHandler(this.marcia_sub_button_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(75, 93);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(97, 43);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(125, 291);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(47, 38);
            this.listView2.TabIndex = 7;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(300, 123);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(47, 38);
            this.listView3.TabIndex = 8;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.List;
            // 
            // copia_button
            // 
            this.copia_button.Location = new System.Drawing.Point(471, 216);
            this.copia_button.Name = "copia_button";
            this.copia_button.Size = new System.Drawing.Size(52, 23);
            this.copia_button.TabIndex = 9;
            this.copia_button.Text = "copia";
            this.copia_button.UseVisualStyleBackColor = true;
            this.copia_button.Click += new System.EventHandler(this.copia_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.copia_button);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.marcia_sub_button);
            this.Controls.Add(this.marcia_add_button);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.freno_button);
            this.Controls.Add(this.acceleratore_button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Auto";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button acceleratore_button;
        private System.Windows.Forms.Button freno_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button marcia_add_button;
        private System.Windows.Forms.Button marcia_sub_button;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Button copia_button;
    }
}


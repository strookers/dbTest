namespace Client
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGetMovies = new System.Windows.Forms.Button();
            this.txtIdSearch = new System.Windows.Forms.TextBox();
            this.btnIdSearch = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.dtpickerPremiere = new System.Windows.Forms.DateTimePicker();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPremiere = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnCreateMovie = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(465, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(657, 218);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnGetMovies
            // 
            this.btnGetMovies.Location = new System.Drawing.Point(1023, 12);
            this.btnGetMovies.Name = "btnGetMovies";
            this.btnGetMovies.Size = new System.Drawing.Size(99, 28);
            this.btnGetMovies.TabIndex = 1;
            this.btnGetMovies.Text = "Hent film";
            this.btnGetMovies.UseVisualStyleBackColor = true;
            this.btnGetMovies.Click += new System.EventHandler(this.btnGetMovies_Click);
            // 
            // txtIdSearch
            // 
            this.txtIdSearch.Location = new System.Drawing.Point(465, 20);
            this.txtIdSearch.Name = "txtIdSearch";
            this.txtIdSearch.Size = new System.Drawing.Size(99, 20);
            this.txtIdSearch.TabIndex = 2;
            // 
            // btnIdSearch
            // 
            this.btnIdSearch.Location = new System.Drawing.Point(570, 15);
            this.btnIdSearch.Name = "btnIdSearch";
            this.btnIdSearch.Size = new System.Drawing.Size(99, 28);
            this.btnIdSearch.TabIndex = 3;
            this.btnIdSearch.Text = "Find film";
            this.btnIdSearch.UseVisualStyleBackColor = true;
            this.btnIdSearch.Click += new System.EventHandler(this.btnIdSearch_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(12, 54);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(201, 20);
            this.txtTitle.TabIndex = 4;
            // 
            // dtpickerPremiere
            // 
            this.dtpickerPremiere.Location = new System.Drawing.Point(219, 54);
            this.dtpickerPremiere.Name = "dtpickerPremiere";
            this.dtpickerPremiere.Size = new System.Drawing.Size(172, 20);
            this.dtpickerPremiere.TabIndex = 6;
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(12, 104);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(379, 166);
            this.rtxtDescription.TabIndex = 7;
            this.rtxtDescription.Text = "";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(9, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Titel";
            // 
            // lblPremiere
            // 
            this.lblPremiere.AutoSize = true;
            this.lblPremiere.Location = new System.Drawing.Point(216, 38);
            this.lblPremiere.Name = "lblPremiere";
            this.lblPremiere.Size = new System.Drawing.Size(76, 13);
            this.lblPremiere.TabIndex = 9;
            this.lblPremiere.Text = "Præmiere dato";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(9, 88);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(61, 13);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Beskrivelse";
            // 
            // btnCreateMovie
            // 
            this.btnCreateMovie.Location = new System.Drawing.Point(292, 276);
            this.btnCreateMovie.Name = "btnCreateMovie";
            this.btnCreateMovie.Size = new System.Drawing.Size(99, 28);
            this.btnCreateMovie.TabIndex = 11;
            this.btnCreateMovie.Text = "Tilføj film";
            this.btnCreateMovie.UseVisualStyleBackColor = true;
            this.btnCreateMovie.Click += new System.EventHandler(this.btnCreateMovie_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(465, 277);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(657, 268);
            this.dgv.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 557);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnCreateMovie);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPremiere);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.dtpickerPremiere);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnIdSearch);
            this.Controls.Add(this.txtIdSearch);
            this.Controls.Add(this.btnGetMovies);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetMovies;
        private System.Windows.Forms.TextBox txtIdSearch;
        private System.Windows.Forms.Button btnIdSearch;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.DateTimePicker dtpickerPremiere;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPremiere;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnCreateMovie;
        private System.Windows.Forms.DataGridView dgv;
    }
}


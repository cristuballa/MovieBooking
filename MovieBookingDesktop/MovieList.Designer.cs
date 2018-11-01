namespace MovieBookingDesktop
{
    partial class MovieList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieList));
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.tsMovieList = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbNewCinema = new System.Windows.Forms.ToolStripButton();
            this.tsbNewSchedule = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbMoviesList = new System.Windows.Forms.ToolStripButton();
            this.tsbCinemaList = new System.Windows.Forms.ToolStripButton();
            this.cmdFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            this.tsMovieList.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMovies
            // 
            this.dgvMovies.AllowUserToAddRows = false;
            this.dgvMovies.AllowUserToDeleteRows = false;
            this.dgvMovies.AllowUserToOrderColumns = true;
            this.dgvMovies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMovies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMovies.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMovies.Location = new System.Drawing.Point(2, 80);
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMovies.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovies.Size = new System.Drawing.Size(932, 364);
            this.dgvMovies.TabIndex = 4;
            this.dgvMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovies_CellContentClick);
            this.dgvMovies.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMovies_CellMouseDoubleClick);
            this.dgvMovies.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvMovies_KeyUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 449);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(934, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeyword.BackColor = System.Drawing.SystemColors.Window;
            this.txtKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyword.Location = new System.Drawing.Point(2, 48);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(873, 26);
            this.txtKeyword.TabIndex = 34;
            this.txtKeyword.TextChanged += new System.EventHandler(this.txtKeyword_TextChanged);
            this.txtKeyword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKeyword_KeyUp);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(0, 0);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(75, 23);
            this.cmdAdd.TabIndex = 37;
            // 
            // tsMovieList
            // 
            this.tsMovieList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsMovieList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbNewCinema,
            this.tsbNewSchedule,
            this.toolStripSeparator1,
            this.tsbMoviesList,
            this.tsbCinemaList});
            this.tsMovieList.Location = new System.Drawing.Point(0, 0);
            this.tsMovieList.Name = "tsMovieList";
            this.tsMovieList.Padding = new System.Windows.Forms.Padding(0, 5, 1, 5);
            this.tsMovieList.Size = new System.Drawing.Size(934, 38);
            this.tsMovieList.TabIndex = 36;
            this.tsMovieList.Text = "toolStrip1";
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(93, 25);
            this.tsbSave.Text = "New Movie";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbNewCinema
            // 
            this.tsbNewCinema.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNewCinema.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewCinema.Image")));
            this.tsbNewCinema.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewCinema.Name = "tsbNewCinema";
            this.tsbNewCinema.Size = new System.Drawing.Size(103, 25);
            this.tsbNewCinema.Text = "New Cinema";
            this.tsbNewCinema.Click += new System.EventHandler(this.tsbNewCinema_Click);
            // 
            // tsbNewSchedule
            // 
            this.tsbNewSchedule.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNewSchedule.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewSchedule.Image")));
            this.tsbNewSchedule.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewSchedule.Name = "tsbNewSchedule";
            this.tsbNewSchedule.Size = new System.Drawing.Size(77, 25);
            this.tsbNewSchedule.Text = "Schedule";
            this.tsbNewSchedule.Click += new System.EventHandler(this.tsbNewSchedule_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // tsbMoviesList
            // 
            this.tsbMoviesList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbMoviesList.Image = ((System.Drawing.Image)(resources.GetObject("tsbMoviesList.Image")));
            this.tsbMoviesList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMoviesList.Name = "tsbMoviesList";
            this.tsbMoviesList.Size = new System.Drawing.Size(64, 25);
            this.tsbMoviesList.Text = "Movies";
            this.tsbMoviesList.Click += new System.EventHandler(this.tsbMoviesList_Click);
            // 
            // tsbCinemaList
            // 
            this.tsbCinemaList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCinemaList.Image = ((System.Drawing.Image)(resources.GetObject("tsbCinemaList.Image")));
            this.tsbCinemaList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCinemaList.Name = "tsbCinemaList";
            this.tsbCinemaList.Size = new System.Drawing.Size(74, 25);
            this.tsbCinemaList.Text = "Cinemas";
            this.tsbCinemaList.Click += new System.EventHandler(this.tsbCinemaList_Click);
            // 
            // cmdFind
            // 
            this.cmdFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdFind.Location = new System.Drawing.Point(878, 47);
            this.cmdFind.Name = "cmdFind";
            this.cmdFind.Size = new System.Drawing.Size(50, 28);
            this.cmdFind.TabIndex = 38;
            this.cmdFind.Text = "Find";
            this.cmdFind.UseVisualStyleBackColor = true;
            this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
            // 
            // MovieList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 471);
            this.Controls.Add(this.cmdFind);
            this.Controls.Add(this.tsMovieList);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvMovies);
            this.Name = "MovieList";
            this.Text = "Movies";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MovieList_FormClosing);
            this.Load += new System.EventHandler(this.MovieList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            this.tsMovieList.ResumeLayout(false);
            this.tsMovieList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.ToolStrip tsMovieList;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.Button cmdFind;
        private System.Windows.Forms.ToolStripButton tsbNewCinema;
        private System.Windows.Forms.ToolStripButton tsbCinemaList;
        private System.Windows.Forms.ToolStripButton tsbMoviesList;
        private System.Windows.Forms.ToolStripButton tsbNewSchedule;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}
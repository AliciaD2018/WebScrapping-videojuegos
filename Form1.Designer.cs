namespace Interfaz
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.grillaSteam = new System.Windows.Forms.DataGridView();
            this.nameGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pre_des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Meta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textejecucionSteam = new System.Windows.Forms.TextBox();
            this.picture = new System.Windows.Forms.PictureBox();
            this.grillaPlay = new System.Windows.Forms.DataGridView();
            this.nombreplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentoplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciodescu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metaplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.textejecucionPlay = new System.Windows.Forms.TextBox();
            this.btn_paralela = new System.Windows.Forms.Button();
            this.picturePlay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaSteam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlay)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(536, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Steam";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grillaSteam
            // 
            this.grillaSteam.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaSteam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grillaSteam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaSteam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameGame,
            this.Discount,
            this.Price,
            this.Pre_des,
            this.Meta,
            this.Time});
            this.grillaSteam.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grillaSteam.Location = new System.Drawing.Point(7, 194);
            this.grillaSteam.Name = "grillaSteam";
            this.grillaSteam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaSteam.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grillaSteam.RowHeadersWidth = 51;
            this.grillaSteam.Size = new System.Drawing.Size(641, 264);
            this.grillaSteam.TabIndex = 1;
            // 
            // nameGame
            // 
            this.nameGame.HeaderText = "Nombre_Juego";
            this.nameGame.MinimumWidth = 6;
            this.nameGame.Name = "nameGame";
            this.nameGame.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nameGame.Width = 125;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Descuento";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            this.Discount.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Precio";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Pre_des
            // 
            this.Pre_des.HeaderText = "Precio_conDesc";
            this.Pre_des.MinimumWidth = 6;
            this.Pre_des.Name = "Pre_des";
            this.Pre_des.Width = 125;
            // 
            // Meta
            // 
            this.Meta.HeaderText = "MetaCritic";
            this.Meta.MinimumWidth = 6;
            this.Meta.Name = "Meta";
            this.Meta.Width = 125;
            // 
            // Time
            // 
            this.Time.HeaderText = "How Long to Beat";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.Width = 125;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GrayText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(667, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "Play Station";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(514, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Web Scraping Parallel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(169, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tiempo de Ejecución";
            // 
            // textejecucionSteam
            // 
            this.textejecucionSteam.Location = new System.Drawing.Point(139, 491);
            this.textejecucionSteam.Name = "textejecucionSteam";
            this.textejecucionSteam.Size = new System.Drawing.Size(255, 20);
            this.textejecucionSteam.TabIndex = 7;
            // 
            // picture
            // 
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.Location = new System.Drawing.Point(163, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(309, 158);
            this.picture.TabIndex = 8;
            this.picture.TabStop = false;
            // 
            // grillaPlay
            // 
            this.grillaPlay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaPlay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreplay,
            this.descuentoplay,
            this.precioplay,
            this.preciodescu,
            this.metaplay,
            this.timeplay});
            this.grillaPlay.Location = new System.Drawing.Point(654, 194);
            this.grillaPlay.Name = "grillaPlay";
            this.grillaPlay.RowHeadersWidth = 51;
            this.grillaPlay.Size = new System.Drawing.Size(632, 264);
            this.grillaPlay.TabIndex = 9;
            // 
            // nombreplay
            // 
            this.nombreplay.HeaderText = "Nombre_Juego";
            this.nombreplay.MinimumWidth = 6;
            this.nombreplay.Name = "nombreplay";
            this.nombreplay.Width = 125;
            // 
            // descuentoplay
            // 
            this.descuentoplay.HeaderText = "Descuento";
            this.descuentoplay.MinimumWidth = 6;
            this.descuentoplay.Name = "descuentoplay";
            this.descuentoplay.Width = 125;
            // 
            // precioplay
            // 
            this.precioplay.HeaderText = "Precio";
            this.precioplay.MinimumWidth = 6;
            this.precioplay.Name = "precioplay";
            this.precioplay.Width = 125;
            // 
            // preciodescu
            // 
            this.preciodescu.HeaderText = "Precio_conDesc";
            this.preciodescu.MinimumWidth = 6;
            this.preciodescu.Name = "preciodescu";
            this.preciodescu.Width = 125;
            // 
            // metaplay
            // 
            this.metaplay.HeaderText = "MetaCritic";
            this.metaplay.MinimumWidth = 6;
            this.metaplay.Name = "metaplay";
            this.metaplay.Width = 125;
            // 
            // timeplay
            // 
            this.timeplay.HeaderText = "How Long to Beat";
            this.timeplay.MinimumWidth = 6;
            this.timeplay.Name = "timeplay";
            this.timeplay.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(897, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tiempo de Ejecución";
            // 
            // textejecucionPlay
            // 
            this.textejecucionPlay.Location = new System.Drawing.Point(858, 491);
            this.textejecucionPlay.Name = "textejecucionPlay";
            this.textejecucionPlay.Size = new System.Drawing.Size(281, 20);
            this.textejecucionPlay.TabIndex = 11;
            // 
            // btn_paralela
            // 
            this.btn_paralela.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_paralela.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paralela.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_paralela.Location = new System.Drawing.Point(584, 464);
            this.btn_paralela.Name = "btn_paralela";
            this.btn_paralela.Size = new System.Drawing.Size(120, 46);
            this.btn_paralela.TabIndex = 12;
            this.btn_paralela.Text = "Ejecucion PARALELA";
            this.btn_paralela.UseVisualStyleBackColor = false;
            this.btn_paralela.Click += new System.EventHandler(this.btn_paralela_Click);
            // 
            // picturePlay
            // 
            this.picturePlay.Image = ((System.Drawing.Image)(resources.GetObject("picturePlay.Image")));
            this.picturePlay.Location = new System.Drawing.Point(890, 12);
            this.picturePlay.Name = "picturePlay";
            this.picturePlay.Size = new System.Drawing.Size(295, 176);
            this.picturePlay.TabIndex = 13;
            this.picturePlay.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1321, 523);
            this.Controls.Add(this.picturePlay);
            this.Controls.Add(this.btn_paralela);
            this.Controls.Add(this.textejecucionPlay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grillaPlay);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.textejecucionSteam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grillaSteam);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grillaSteam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grillaSteam;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textejecucionSteam;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pre_des;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        public System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.DataGridView grillaPlay;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuentoplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciodescu;
        private System.Windows.Forms.DataGridViewTextBoxColumn metaplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textejecucionPlay;
        private System.Windows.Forms.Button btn_paralela;
        private System.Windows.Forms.PictureBox picturePlay;
    }
}


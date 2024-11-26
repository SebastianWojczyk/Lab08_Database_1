namespace Lab08_Database_1
{
    partial class FormMain
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
            this.listBoxFilms = new System.Windows.Forms.ListBox();
            this.radioButtonCategory = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonDurationDESC = new System.Windows.Forms.RadioButton();
            this.radioButtonDuration = new System.Windows.Forms.RadioButton();
            this.radioButtonTitleDESC = new System.Windows.Forms.RadioButton();
            this.radioButtonTitle = new System.Windows.Forms.RadioButton();
            this.radioButtonCategoryDESC = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxFilms
            // 
            this.listBoxFilms.FormattingEnabled = true;
            this.listBoxFilms.Location = new System.Drawing.Point(13, 13);
            this.listBoxFilms.Name = "listBoxFilms";
            this.listBoxFilms.Size = new System.Drawing.Size(297, 290);
            this.listBoxFilms.TabIndex = 0;
            // 
            // radioButtonCategory
            // 
            this.radioButtonCategory.AutoSize = true;
            this.radioButtonCategory.Checked = true;
            this.radioButtonCategory.Location = new System.Drawing.Point(6, 19);
            this.radioButtonCategory.Name = "radioButtonCategory";
            this.radioButtonCategory.Size = new System.Drawing.Size(67, 17);
            this.radioButtonCategory.TabIndex = 1;
            this.radioButtonCategory.TabStop = true;
            this.radioButtonCategory.Text = "Category";
            this.radioButtonCategory.UseVisualStyleBackColor = true;
            this.radioButtonCategory.CheckedChanged += new System.EventHandler(this.RadioButtonOrder_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDurationDESC);
            this.groupBox1.Controls.Add(this.radioButtonDuration);
            this.groupBox1.Controls.Add(this.radioButtonTitleDESC);
            this.groupBox1.Controls.Add(this.radioButtonTitle);
            this.groupBox1.Controls.Add(this.radioButtonCategoryDESC);
            this.groupBox1.Controls.Add(this.radioButtonCategory);
            this.groupBox1.Location = new System.Drawing.Point(316, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 163);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order";
            // 
            // radioButtonDurationDESC
            // 
            this.radioButtonDurationDESC.AutoSize = true;
            this.radioButtonDurationDESC.Location = new System.Drawing.Point(6, 134);
            this.radioButtonDurationDESC.Name = "radioButtonDurationDESC";
            this.radioButtonDurationDESC.Size = new System.Drawing.Size(97, 17);
            this.radioButtonDurationDESC.TabIndex = 6;
            this.radioButtonDurationDESC.Text = "Duration DESC";
            this.radioButtonDurationDESC.UseVisualStyleBackColor = true;
            this.radioButtonDurationDESC.CheckedChanged += new System.EventHandler(this.RadioButtonOrder_CheckedChanged);
            // 
            // radioButtonDuration
            // 
            this.radioButtonDuration.AutoSize = true;
            this.radioButtonDuration.Location = new System.Drawing.Point(6, 111);
            this.radioButtonDuration.Name = "radioButtonDuration";
            this.radioButtonDuration.Size = new System.Drawing.Size(65, 17);
            this.radioButtonDuration.TabIndex = 5;
            this.radioButtonDuration.Text = "Duration";
            this.radioButtonDuration.UseVisualStyleBackColor = true;
            this.radioButtonDuration.CheckedChanged += new System.EventHandler(this.RadioButtonOrder_CheckedChanged);
            // 
            // radioButtonTitleDESC
            // 
            this.radioButtonTitleDESC.AutoSize = true;
            this.radioButtonTitleDESC.Location = new System.Drawing.Point(6, 88);
            this.radioButtonTitleDESC.Name = "radioButtonTitleDESC";
            this.radioButtonTitleDESC.Size = new System.Drawing.Size(77, 17);
            this.radioButtonTitleDESC.TabIndex = 4;
            this.radioButtonTitleDESC.Text = "Title DESC";
            this.radioButtonTitleDESC.UseVisualStyleBackColor = true;
            this.radioButtonTitleDESC.CheckedChanged += new System.EventHandler(this.RadioButtonOrder_CheckedChanged);
            // 
            // radioButtonTitle
            // 
            this.radioButtonTitle.AutoSize = true;
            this.radioButtonTitle.Location = new System.Drawing.Point(6, 65);
            this.radioButtonTitle.Name = "radioButtonTitle";
            this.radioButtonTitle.Size = new System.Drawing.Size(45, 17);
            this.radioButtonTitle.TabIndex = 3;
            this.radioButtonTitle.Text = "Title";
            this.radioButtonTitle.UseVisualStyleBackColor = true;
            this.radioButtonTitle.CheckedChanged += new System.EventHandler(this.RadioButtonOrder_CheckedChanged);
            // 
            // radioButtonCategoryDESC
            // 
            this.radioButtonCategoryDESC.AutoSize = true;
            this.radioButtonCategoryDESC.Location = new System.Drawing.Point(6, 42);
            this.radioButtonCategoryDESC.Name = "radioButtonCategoryDESC";
            this.radioButtonCategoryDESC.Size = new System.Drawing.Size(99, 17);
            this.radioButtonCategoryDESC.TabIndex = 2;
            this.radioButtonCategoryDESC.Text = "Category DESC";
            this.radioButtonCategoryDESC.UseVisualStyleBackColor = true;
            this.radioButtonCategoryDESC.CheckedChanged += new System.EventHandler(this.RadioButtonOrder_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 321);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxFilms);
            this.Name = "FormMain";
            this.Text = "Films database";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFilms;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonCategory;
        private System.Windows.Forms.RadioButton radioButtonDurationDESC;
        private System.Windows.Forms.RadioButton radioButtonDuration;
        private System.Windows.Forms.RadioButton radioButtonTitleDESC;
        private System.Windows.Forms.RadioButton radioButtonTitle;
        private System.Windows.Forms.RadioButton radioButtonCategoryDESC;
    }
}


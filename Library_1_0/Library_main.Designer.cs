
namespace Library_1_0
{
    partial class Library_main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btdel = new System.Windows.Forms.Button();
            this.btsa = new System.Windows.Forms.Button();
            this.btst = new System.Windows.Forms.Button();
            this.btShowAll = new System.Windows.Forms.Button();
            this.dataGridBooks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(40, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(48, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Назва";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(215, 38);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(47, 17);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Автор";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(406, 38);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(86, 17);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Рік видання";
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(596, 39);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(39, 17);
            this.lblIsbn.TabIndex = 3;
            this.lblIsbn.Text = "ISBN";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(43, 59);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(130, 22);
            this.txtTitle.TabIndex = 4;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(218, 59);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(130, 22);
            this.txtAuthor.TabIndex = 5;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(409, 59);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(130, 22);
            this.txtYear.TabIndex = 6;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(599, 59);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(130, 22);
            this.txtISBN.TabIndex = 7;
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.MediumOrchid;
            this.btAdd.Location = new System.Drawing.Point(28, 116);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(132, 54);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "Додати книгу";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btdel
            // 
            this.btdel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btdel.Location = new System.Drawing.Point(156, 174);
            this.btdel.Name = "btdel";
            this.btdel.Size = new System.Drawing.Size(131, 54);
            this.btdel.TabIndex = 9;
            this.btdel.Text = "Видалити книгу";
            this.btdel.UseVisualStyleBackColor = false;
            this.btdel.Click += new System.EventHandler(this.btdel_Click);
            // 
            // btsa
            // 
            this.btsa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btsa.Location = new System.Drawing.Point(291, 116);
            this.btsa.Name = "btsa";
            this.btsa.Size = new System.Drawing.Size(169, 54);
            this.btsa.TabIndex = 10;
            this.btsa.Text = "Пошук книг за автором";
            this.btsa.UseVisualStyleBackColor = false;
            this.btsa.Click += new System.EventHandler(this.btsa_Click);
            // 
            // btst
            // 
            this.btst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btst.Location = new System.Drawing.Point(457, 174);
            this.btst.Name = "btst";
            this.btst.Size = new System.Drawing.Size(166, 54);
            this.btst.TabIndex = 11;
            this.btst.Text = "Пошук книг за назвою";
            this.btst.UseVisualStyleBackColor = false;
            this.btst.Click += new System.EventHandler(this.btst_Click);
            // 
            // btShowAll
            // 
            this.btShowAll.BackColor = System.Drawing.Color.Lime;
            this.btShowAll.Location = new System.Drawing.Point(620, 116);
            this.btShowAll.Name = "btShowAll";
            this.btShowAll.Size = new System.Drawing.Size(168, 54);
            this.btShowAll.TabIndex = 12;
            this.btShowAll.Text = "Вивести список всіх книг";
            this.btShowAll.UseVisualStyleBackColor = false;
            this.btShowAll.Click += new System.EventHandler(this.btShowAll_Click);
            // 
            // dataGridBooks
            // 
            this.dataGridBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBooks.Location = new System.Drawing.Point(77, 287);
            this.dataGridBooks.Name = "dataGridBooks";
            this.dataGridBooks.RowHeadersWidth = 51;
            this.dataGridBooks.RowTemplate.Height = 24;
            this.dataGridBooks.Size = new System.Drawing.Size(600, 139);
            this.dataGridBooks.TabIndex = 13;
            // 
            // Library_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridBooks);
            this.Controls.Add(this.btShowAll);
            this.Controls.Add(this.btst);
            this.Controls.Add(this.btsa);
            this.Controls.Add(this.btdel);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblIsbn);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Name = "Library_main";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btdel;
        private System.Windows.Forms.Button btsa;
        private System.Windows.Forms.Button btst;
        private System.Windows.Forms.Button btShowAll;
        private System.Windows.Forms.DataGridView dataGridBooks;
    }
}


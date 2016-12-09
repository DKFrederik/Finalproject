namespace SearchApp
{
    partial class UserInterface
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
            this.components = new System.ComponentModel.Container();
            this.textBoxDoc = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.responseBox = new System.Windows.Forms.RichTextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.createIndexBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxQueryTerm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textboxField = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.deleteIndexBtn = new System.Windows.Forms.Button();
            this.BulkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDoc
            // 
            this.textBoxDoc.Location = new System.Drawing.Point(96, 12);
            this.textBoxDoc.Name = "textBoxDoc";
            this.textBoxDoc.Size = new System.Drawing.Size(100, 20);
            this.textBoxDoc.TabIndex = 0;
            this.textBoxDoc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Doc";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Location = new System.Drawing.Point(96, 36);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(100, 20);
            this.textBoxIndex.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Index";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Insert into index";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // responseBox
            // 
            this.responseBox.AcceptsTab = true;
            this.responseBox.Location = new System.Drawing.Point(12, 165);
            this.responseBox.Name = "responseBox";
            this.responseBox.ReadOnly = true;
            this.responseBox.Size = new System.Drawing.Size(762, 386);
            this.responseBox.TabIndex = 6;
            this.responseBox.Text = "";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(15, 132);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(122, 29);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear response field";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // createIndexBtn
            // 
            this.createIndexBtn.Location = new System.Drawing.Point(15, 97);
            this.createIndexBtn.Name = "createIndexBtn";
            this.createIndexBtn.Size = new System.Drawing.Size(100, 29);
            this.createIndexBtn.TabIndex = 8;
            this.createIndexBtn.Text = "Create index";
            this.createIndexBtn.UseVisualStyleBackColor = true;
            this.createIndexBtn.Click += new System.EventHandler(this.createIndexBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Query term";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textboxQueryTerm
            // 
            this.textboxQueryTerm.Location = new System.Drawing.Point(348, 15);
            this.textboxQueryTerm.Name = "textboxQueryTerm";
            this.textboxQueryTerm.Size = new System.Drawing.Size(100, 20);
            this.textboxQueryTerm.TabIndex = 10;
            this.textboxQueryTerm.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Field";
            // 
            // textboxField
            // 
            this.textboxField.Location = new System.Drawing.Point(348, 41);
            this.textboxField.Name = "textboxField";
            this.textboxField.Size = new System.Drawing.Size(100, 20);
            this.textboxField.TabIndex = 12;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(348, 67);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(100, 29);
            this.searchBtn.TabIndex = 14;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // deleteIndexBtn
            // 
            this.deleteIndexBtn.Location = new System.Drawing.Point(121, 97);
            this.deleteIndexBtn.Name = "deleteIndexBtn";
            this.deleteIndexBtn.Size = new System.Drawing.Size(100, 29);
            this.deleteIndexBtn.TabIndex = 15;
            this.deleteIndexBtn.Text = "Delete index";
            this.deleteIndexBtn.UseVisualStyleBackColor = true;
            this.deleteIndexBtn.Click += new System.EventHandler(this.deleteIndexBtn_Click);
            // 
            // BulkButton
            // 
            this.BulkButton.Location = new System.Drawing.Point(348, 117);
            this.BulkButton.Name = "BulkButton";
            this.BulkButton.Size = new System.Drawing.Size(100, 23);
            this.BulkButton.TabIndex = 16;
            this.BulkButton.Text = "Bulk insert";
            this.BulkButton.UseVisualStyleBackColor = true;
            this.BulkButton.Click += new System.EventHandler(this.BulkButton_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 589);
            this.Controls.Add(this.BulkButton);
            this.Controls.Add(this.deleteIndexBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textboxField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textboxQueryTerm);
            this.Controls.Add(this.createIndexBtn);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.responseBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIndex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDoc);
            this.Name = "UserInterface";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDoc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox responseBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button createIndexBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxQueryTerm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textboxField;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button deleteIndexBtn;
        private System.Windows.Forms.Button BulkButton;
    }
}


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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BulkButton = new System.Windows.Forms.Button();
            this.deleteIndexBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textboxField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxQueryTerm = new System.Windows.Forms.TextBox();
            this.createIndexBtn = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.responseBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDoc = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SolrInsert = new System.Windows.Forms.Button();
            this.solrIndicator = new System.Windows.Forms.TextBox();
            this.solrResponseBox = new System.Windows.Forms.RichTextBox();
            this.solrSearch = new System.Windows.Forms.Button();
            this.solrQueryBox = new System.Windows.Forms.TextBox();
            this.SolrDeleteAllButton = new System.Windows.Forms.Button();
            this.solrDeleteByQueryButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 586);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BulkButton);
            this.tabPage1.Controls.Add(this.deleteIndexBtn);
            this.tabPage1.Controls.Add(this.searchBtn);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textboxField);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textboxQueryTerm);
            this.tabPage1.Controls.Add(this.createIndexBtn);
            this.tabPage1.Controls.Add(this.clearButton);
            this.tabPage1.Controls.Add(this.responseBox);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxIndex);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxDoc);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(777, 560);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Elastic";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BulkButton
            // 
            this.BulkButton.Location = new System.Drawing.Point(343, 116);
            this.BulkButton.Name = "BulkButton";
            this.BulkButton.Size = new System.Drawing.Size(100, 23);
            this.BulkButton.TabIndex = 31;
            this.BulkButton.Text = "Bulk insert";
            this.BulkButton.UseVisualStyleBackColor = true;
            // 
            // deleteIndexBtn
            // 
            this.deleteIndexBtn.Location = new System.Drawing.Point(116, 96);
            this.deleteIndexBtn.Name = "deleteIndexBtn";
            this.deleteIndexBtn.Size = new System.Drawing.Size(100, 29);
            this.deleteIndexBtn.TabIndex = 30;
            this.deleteIndexBtn.Text = "Delete index";
            this.deleteIndexBtn.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(343, 66);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(100, 29);
            this.searchBtn.TabIndex = 29;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Field";
            // 
            // textboxField
            // 
            this.textboxField.Location = new System.Drawing.Point(343, 40);
            this.textboxField.Name = "textboxField";
            this.textboxField.Size = new System.Drawing.Size(100, 20);
            this.textboxField.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Query term";
            // 
            // textboxQueryTerm
            // 
            this.textboxQueryTerm.Location = new System.Drawing.Point(343, 14);
            this.textboxQueryTerm.Name = "textboxQueryTerm";
            this.textboxQueryTerm.Size = new System.Drawing.Size(100, 20);
            this.textboxQueryTerm.TabIndex = 25;
            // 
            // createIndexBtn
            // 
            this.createIndexBtn.Location = new System.Drawing.Point(10, 96);
            this.createIndexBtn.Name = "createIndexBtn";
            this.createIndexBtn.Size = new System.Drawing.Size(100, 29);
            this.createIndexBtn.TabIndex = 24;
            this.createIndexBtn.Text = "Create index";
            this.createIndexBtn.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(10, 131);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(122, 29);
            this.clearButton.TabIndex = 23;
            this.clearButton.Text = "Clear response field";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // responseBox
            // 
            this.responseBox.AcceptsTab = true;
            this.responseBox.Location = new System.Drawing.Point(7, 164);
            this.responseBox.Name = "responseBox";
            this.responseBox.ReadOnly = true;
            this.responseBox.Size = new System.Drawing.Size(762, 386);
            this.responseBox.TabIndex = 22;
            this.responseBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 21;
            this.button1.Text = "Insert into index";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Index";
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Location = new System.Drawing.Point(91, 35);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(100, 20);
            this.textBoxIndex.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Doc";
            // 
            // textBoxDoc
            // 
            this.textBoxDoc.Location = new System.Drawing.Point(91, 11);
            this.textBoxDoc.Name = "textBoxDoc";
            this.textBoxDoc.Size = new System.Drawing.Size(100, 20);
            this.textBoxDoc.TabIndex = 17;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.solrDeleteByQueryButton);
            this.tabPage2.Controls.Add(this.SolrDeleteAllButton);
            this.tabPage2.Controls.Add(this.solrQueryBox);
            this.tabPage2.Controls.Add(this.solrSearch);
            this.tabPage2.Controls.Add(this.solrResponseBox);
            this.tabPage2.Controls.Add(this.solrIndicator);
            this.tabPage2.Controls.Add(this.SolrInsert);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(777, 560);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Solr";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SolrInsert
            // 
            this.SolrInsert.Location = new System.Drawing.Point(6, 61);
            this.SolrInsert.Name = "SolrInsert";
            this.SolrInsert.Size = new System.Drawing.Size(75, 23);
            this.SolrInsert.TabIndex = 2;
            this.SolrInsert.Text = "Insert";
            this.SolrInsert.UseVisualStyleBackColor = true;
            this.SolrInsert.Click += new System.EventHandler(this.SolrInsert_Click);
            // 
            // solrIndicator
            // 
            this.solrIndicator.Location = new System.Drawing.Point(11, 534);
            this.solrIndicator.Name = "solrIndicator";
            this.solrIndicator.Size = new System.Drawing.Size(32, 20);
            this.solrIndicator.TabIndex = 3;
            // 
            // solrResponseBox
            // 
            this.solrResponseBox.Location = new System.Drawing.Point(3, 94);
            this.solrResponseBox.Name = "solrResponseBox";
            this.solrResponseBox.Size = new System.Drawing.Size(434, 434);
            this.solrResponseBox.TabIndex = 4;
            this.solrResponseBox.Text = "";
            // 
            // solrSearch
            // 
            this.solrSearch.Location = new System.Drawing.Point(6, 35);
            this.solrSearch.Name = "solrSearch";
            this.solrSearch.Size = new System.Drawing.Size(75, 23);
            this.solrSearch.TabIndex = 5;
            this.solrSearch.Text = "Search";
            this.solrSearch.UseVisualStyleBackColor = true;
            this.solrSearch.Click += new System.EventHandler(this.solrSearch_Click);
            // 
            // solrQueryBox
            // 
            this.solrQueryBox.Location = new System.Drawing.Point(6, 6);
            this.solrQueryBox.Name = "solrQueryBox";
            this.solrQueryBox.Size = new System.Drawing.Size(183, 20);
            this.solrQueryBox.TabIndex = 6;
            // 
            // SolrDeleteAllButton
            // 
            this.SolrDeleteAllButton.Location = new System.Drawing.Point(87, 61);
            this.SolrDeleteAllButton.Name = "SolrDeleteAllButton";
            this.SolrDeleteAllButton.Size = new System.Drawing.Size(102, 23);
            this.SolrDeleteAllButton.TabIndex = 7;
            this.SolrDeleteAllButton.Text = "Delete All Doc";
            this.SolrDeleteAllButton.UseVisualStyleBackColor = true;
            this.SolrDeleteAllButton.Click += new System.EventHandler(this.SolrDeleteAllButton_Click);
            // 
            // solrDeleteByQueryButton
            // 
            this.solrDeleteByQueryButton.Location = new System.Drawing.Point(87, 35);
            this.solrDeleteByQueryButton.Name = "solrDeleteByQueryButton";
            this.solrDeleteByQueryButton.Size = new System.Drawing.Size(102, 23);
            this.solrDeleteByQueryButton.TabIndex = 8;
            this.solrDeleteByQueryButton.Text = "Delete By Query";
            this.solrDeleteByQueryButton.UseVisualStyleBackColor = true;
            this.solrDeleteByQueryButton.Click += new System.EventHandler(this.solrDeleteByQueryButton_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 589);
            this.Controls.Add(this.tabControl1);
            this.Name = "UserInterface";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BulkButton;
        private System.Windows.Forms.Button deleteIndexBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textboxField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxQueryTerm;
        private System.Windows.Forms.Button createIndexBtn;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.RichTextBox responseBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDoc;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox solrResponseBox;
        private System.Windows.Forms.TextBox solrIndicator;
        private System.Windows.Forms.Button SolrInsert;
        private System.Windows.Forms.TextBox solrQueryBox;
        private System.Windows.Forms.Button solrSearch;
        private System.Windows.Forms.Button SolrDeleteAllButton;
        private System.Windows.Forms.Button solrDeleteByQueryButton;
    }
}


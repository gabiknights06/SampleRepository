namespace DatabaseSample
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
            this.label1 = new System.Windows.Forms.Label();
            this.tx_CountryCode = new System.Windows.Forms.TextBox();
            this.tx_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_District = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_Population = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_genList = new System.Windows.Forms.Button();
            this.btn_generate = new System.Windows.Forms.Button();
            this.tx_JsonUrl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lv_list = new System.Windows.Forms.ListView();
            this.ch_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_CountryCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_District = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Population = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Put = new System.Windows.Forms.Button();
            this.btn_Post = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Country Code";
            // 
            // tx_CountryCode
            // 
            this.tx_CountryCode.Location = new System.Drawing.Point(88, 19);
            this.tx_CountryCode.Margin = new System.Windows.Forms.Padding(2);
            this.tx_CountryCode.Name = "tx_CountryCode";
            this.tx_CountryCode.Size = new System.Drawing.Size(53, 20);
            this.tx_CountryCode.TabIndex = 1;
            // 
            // tx_Name
            // 
            this.tx_Name.Location = new System.Drawing.Point(88, 47);
            this.tx_Name.Margin = new System.Windows.Forms.Padding(2);
            this.tx_Name.Name = "tx_Name";
            this.tx_Name.Size = new System.Drawing.Size(138, 20);
            this.tx_Name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // tx_District
            // 
            this.tx_District.Location = new System.Drawing.Point(88, 75);
            this.tx_District.Margin = new System.Windows.Forms.Padding(2);
            this.tx_District.Name = "tx_District";
            this.tx_District.Size = new System.Drawing.Size(138, 20);
            this.tx_District.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "District";
            // 
            // tx_Population
            // 
            this.tx_Population.Location = new System.Drawing.Point(88, 102);
            this.tx_Population.Margin = new System.Windows.Forms.Padding(2);
            this.tx_Population.Name = "tx_Population";
            this.tx_Population.Size = new System.Drawing.Size(138, 20);
            this.tx_Population.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Population";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_genList);
            this.panel1.Controls.Add(this.btn_generate);
            this.panel1.Controls.Add(this.tx_JsonUrl);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 228);
            this.panel1.TabIndex = 8;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(326, 181);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(70, 37);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_genList
            // 
            this.btn_genList.Location = new System.Drawing.Point(89, 179);
            this.btn_genList.Margin = new System.Windows.Forms.Padding(2);
            this.btn_genList.Name = "btn_genList";
            this.btn_genList.Size = new System.Drawing.Size(117, 37);
            this.btn_genList.TabIndex = 4;
            this.btn_genList.Text = "Generate List";
            this.btn_genList.UseVisualStyleBackColor = true;
            this.btn_genList.Click += new System.EventHandler(this.Btn_genList_Click);
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(15, 179);
            this.btn_generate.Margin = new System.Windows.Forms.Padding(2);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(70, 37);
            this.btn_generate.TabIndex = 4;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.Btn_generate_Click);
            // 
            // tx_JsonUrl
            // 
            this.tx_JsonUrl.Location = new System.Drawing.Point(15, 27);
            this.tx_JsonUrl.Margin = new System.Windows.Forms.Padding(2);
            this.tx_JsonUrl.Multiline = true;
            this.tx_JsonUrl.Name = "tx_JsonUrl";
            this.tx_JsonUrl.Size = new System.Drawing.Size(381, 150);
            this.tx_JsonUrl.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Json Url";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tx_CountryCode);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tx_Population);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tx_Name);
            this.panel2.Controls.Add(this.tx_District);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(8, 239);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 159);
            this.panel2.TabIndex = 9;
            // 
            // lv_list
            // 
            this.lv_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_id,
            this.ch_Name,
            this.ch_CountryCode,
            this.ch_District,
            this.ch_Population});
            this.lv_list.FullRowSelect = true;
            this.lv_list.GridLines = true;
            this.lv_list.Location = new System.Drawing.Point(425, 8);
            this.lv_list.Margin = new System.Windows.Forms.Padding(2);
            this.lv_list.Name = "lv_list";
            this.lv_list.Size = new System.Drawing.Size(562, 391);
            this.lv_list.TabIndex = 10;
            this.lv_list.UseCompatibleStateImageBehavior = false;
            this.lv_list.View = System.Windows.Forms.View.Details;
            this.lv_list.SelectedIndexChanged += new System.EventHandler(this.Lv_list_SelectedIndexChanged);
            // 
            // ch_id
            // 
            this.ch_id.Text = "Id";
            this.ch_id.Width = 0;
            // 
            // ch_Name
            // 
            this.ch_Name.Text = "Name";
            this.ch_Name.Width = 201;
            // 
            // ch_CountryCode
            // 
            this.ch_CountryCode.Text = "Country Code";
            this.ch_CountryCode.Width = 87;
            // 
            // ch_District
            // 
            this.ch_District.Text = "District";
            this.ch_District.Width = 140;
            // 
            // ch_Population
            // 
            this.ch_Population.Text = "Population";
            this.ch_Population.Width = 126;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_Delete);
            this.panel3.Controls.Add(this.btn_Put);
            this.panel3.Controls.Add(this.btn_Post);
            this.panel3.Location = new System.Drawing.Point(259, 239);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(162, 159);
            this.panel3.TabIndex = 11;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(15, 106);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(130, 37);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // btn_Put
            // 
            this.btn_Put.Location = new System.Drawing.Point(15, 58);
            this.btn_Put.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Put.Name = "btn_Put";
            this.btn_Put.Size = new System.Drawing.Size(130, 37);
            this.btn_Put.TabIndex = 5;
            this.btn_Put.Text = "Put";
            this.btn_Put.UseVisualStyleBackColor = true;
            this.btn_Put.Click += new System.EventHandler(this.Btn_Put_Click);
            // 
            // btn_Post
            // 
            this.btn_Post.Location = new System.Drawing.Point(15, 10);
            this.btn_Post.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Post.Name = "btn_Post";
            this.btn_Post.Size = new System.Drawing.Size(130, 37);
            this.btn_Post.TabIndex = 5;
            this.btn_Post.Text = "Post";
            this.btn_Post.UseVisualStyleBackColor = true;
            this.btn_Post.Click += new System.EventHandler(this.Btn_Post_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 406);
            this.Controls.Add(this.lv_list);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_CountryCode;
        private System.Windows.Forms.TextBox tx_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_District;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx_Population;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.TextBox tx_JsonUrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lv_list;
        private System.Windows.Forms.ColumnHeader ch_id;
        private System.Windows.Forms.ColumnHeader ch_Name;
        private System.Windows.Forms.ColumnHeader ch_CountryCode;
        private System.Windows.Forms.ColumnHeader ch_District;
        private System.Windows.Forms.ColumnHeader ch_Population;
        private System.Windows.Forms.Button btn_genList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Put;
        private System.Windows.Forms.Button btn_Post;
    }
}


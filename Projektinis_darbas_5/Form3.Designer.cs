namespace Projektinis_darbas_5
{
    partial class Form3
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
            groupBox1 = new GroupBox();
            search_for_titlebtn = new Button();
            list_searchbox = new TextBox();
            label9 = new Label();
            Titlelist = new ListBox();
            titlebox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            urlbox = new TextBox();
            label3 = new Label();
            commentbox = new TextBox();
            label4 = new Label();
            passwordbox = new TextBox();
            groupBox2 = new GroupBox();
            buttonDelete = new Button();
            update_passwordbtn = new Button();
            groupBox3 = new GroupBox();
            generate_passwordbtn = new Button();
            new_titlebox = new TextBox();
            save_new_titlebtn = new Button();
            label5 = new Label();
            label6 = new Label();
            new_urlbox = new TextBox();
            new_passwordbox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            new_commentbox = new TextBox();
            exitbtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(search_for_titlebtn);
            groupBox1.Controls.Add(list_searchbox);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(Titlelist);
            groupBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 660);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selection";
            // 
            // search_for_titlebtn
            // 
            search_for_titlebtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            search_for_titlebtn.Location = new Point(322, 48);
            search_for_titlebtn.Name = "search_for_titlebtn";
            search_for_titlebtn.Size = new Size(87, 29);
            search_for_titlebtn.TabIndex = 13;
            search_for_titlebtn.Text = "Search";
            search_for_titlebtn.UseVisualStyleBackColor = true;
            search_for_titlebtn.Click += search_for_titlebtn_Click;
            // 
            // list_searchbox
            // 
            list_searchbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            list_searchbox.Location = new Point(74, 49);
            list_searchbox.Name = "list_searchbox";
            list_searchbox.Size = new Size(242, 29);
            list_searchbox.TabIndex = 11;
            list_searchbox.TextChanged += list_searchbox_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(8, 52);
            label9.Name = "label9";
            label9.Size = new Size(60, 21);
            label9.TabIndex = 12;
            label9.Text = "Search:";
            // 
            // Titlelist
            // 
            Titlelist.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Titlelist.FormattingEnabled = true;
            Titlelist.ItemHeight = 21;
            Titlelist.Location = new Point(6, 104);
            Titlelist.Name = "Titlelist";
            Titlelist.Size = new Size(380, 550);
            Titlelist.TabIndex = 1;
            Titlelist.SelectedIndexChanged += Titlelist_SelectedIndexChanged;
            // 
            // titlebox
            // 
            titlebox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titlebox.Location = new Point(124, 47);
            titlebox.Name = "titlebox";
            titlebox.Size = new Size(242, 29);
            titlebox.TabIndex = 1;
            titlebox.TextChanged += titlebox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(76, 50);
            label1.Name = "label1";
            label1.Size = new Size(42, 21);
            label1.TabIndex = 2;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(84, 85);
            label2.Name = "label2";
            label2.Size = new Size(34, 21);
            label2.TabIndex = 4;
            label2.Text = "Url:";
            // 
            // urlbox
            // 
            urlbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            urlbox.Location = new Point(124, 82);
            urlbox.Name = "urlbox";
            urlbox.Size = new Size(242, 29);
            urlbox.TabIndex = 3;
            urlbox.TextChanged += urlbox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(36, 120);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 6;
            label3.Text = "Comment:";
            // 
            // commentbox
            // 
            commentbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            commentbox.Location = new Point(124, 117);
            commentbox.Name = "commentbox";
            commentbox.Size = new Size(242, 29);
            commentbox.TabIndex = 5;
            commentbox.TextChanged += commentbox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(440, 47);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 8;
            label4.Text = "Password:";
            // 
            // passwordbox
            // 
            passwordbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordbox.Location = new Point(525, 44);
            passwordbox.Name = "passwordbox";
            passwordbox.Size = new Size(242, 29);
            passwordbox.TabIndex = 7;
            passwordbox.TextChanged += passwordbox_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonDelete);
            groupBox2.Controls.Add(update_passwordbtn);
            groupBox2.Controls.Add(titlebox);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(urlbox);
            groupBox2.Controls.Add(passwordbox);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(commentbox);
            groupBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(433, 133);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(833, 214);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Information";
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Location = new Point(115, 163);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(255, 36);
            buttonDelete.TabIndex = 11;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // update_passwordbtn
            // 
            update_passwordbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            update_passwordbtn.Location = new Point(500, 155);
            update_passwordbtn.Name = "update_passwordbtn";
            update_passwordbtn.Size = new Size(255, 36);
            update_passwordbtn.TabIndex = 10;
            update_passwordbtn.Text = "Update password";
            update_passwordbtn.UseVisualStyleBackColor = true;
            update_passwordbtn.Click += update_passwordbtn_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(generate_passwordbtn);
            groupBox3.Controls.Add(new_titlebox);
            groupBox3.Controls.Add(save_new_titlebtn);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(new_urlbox);
            groupBox3.Controls.Add(new_passwordbox);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(new_commentbox);
            groupBox3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(433, 366);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(833, 214);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "New Title";
            // 
            // generate_passwordbtn
            // 
            generate_passwordbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            generate_passwordbtn.Location = new Point(512, 95);
            generate_passwordbtn.Name = "generate_passwordbtn";
            generate_passwordbtn.Size = new Size(255, 36);
            generate_passwordbtn.TabIndex = 10;
            generate_passwordbtn.Text = "Generate password";
            generate_passwordbtn.UseVisualStyleBackColor = true;
            generate_passwordbtn.Click += generate_passwordbtn_Click;
            // 
            // new_titlebox
            // 
            new_titlebox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            new_titlebox.Location = new Point(124, 47);
            new_titlebox.Name = "new_titlebox";
            new_titlebox.Size = new Size(242, 29);
            new_titlebox.TabIndex = 1;
            new_titlebox.TextChanged += new_titlebox_TextChanged;
            // 
            // save_new_titlebtn
            // 
            save_new_titlebtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            save_new_titlebtn.Location = new Point(512, 152);
            save_new_titlebtn.Name = "save_new_titlebtn";
            save_new_titlebtn.Size = new Size(255, 36);
            save_new_titlebtn.TabIndex = 9;
            save_new_titlebtn.Text = "Save";
            save_new_titlebtn.UseVisualStyleBackColor = true;
            save_new_titlebtn.Click += save_new_titlebtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(76, 50);
            label5.Name = "label5";
            label5.Size = new Size(42, 21);
            label5.TabIndex = 2;
            label5.Text = "Title:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(439, 51);
            label6.Name = "label6";
            label6.Size = new Size(79, 21);
            label6.TabIndex = 8;
            label6.Text = "Password:";
            // 
            // new_urlbox
            // 
            new_urlbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            new_urlbox.Location = new Point(124, 82);
            new_urlbox.Name = "new_urlbox";
            new_urlbox.Size = new Size(242, 29);
            new_urlbox.TabIndex = 3;
            new_urlbox.TextChanged += new_urlbox_TextChanged;
            // 
            // new_passwordbox
            // 
            new_passwordbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            new_passwordbox.Location = new Point(524, 48);
            new_passwordbox.Name = "new_passwordbox";
            new_passwordbox.Size = new Size(242, 29);
            new_passwordbox.TabIndex = 7;
            new_passwordbox.TextChanged += new_passwordbox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(84, 85);
            label7.Name = "label7";
            label7.Size = new Size(34, 21);
            label7.TabIndex = 4;
            label7.Text = "Url:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(36, 120);
            label8.Name = "label8";
            label8.Size = new Size(82, 21);
            label8.TabIndex = 6;
            label8.Text = "Comment:";
            // 
            // new_commentbox
            // 
            new_commentbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            new_commentbox.Location = new Point(124, 117);
            new_commentbox.Name = "new_commentbox";
            new_commentbox.Size = new Size(242, 29);
            new_commentbox.TabIndex = 5;
            new_commentbox.TextChanged += new_commentbox_TextChanged;
            // 
            // exitbtn
            // 
            exitbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            exitbtn.Location = new Point(1044, 616);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(233, 56);
            exitbtn.TabIndex = 10;
            exitbtn.Text = "Exit";
            exitbtn.UseVisualStyleBackColor = true;
            exitbtn.Click += exitbtn_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 684);
            Controls.Add(exitbtn);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox titlebox;
        private Label label1;
        private Label label2;
        private TextBox urlbox;
        private Label label3;
        private TextBox commentbox;
        private Label label4;
        private TextBox passwordbox;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox new_titlebox;
        private Button save_new_titlebtn;
        private Label label5;
        private Label label6;
        private TextBox new_urlbox;
        private TextBox new_passwordbox;
        private Label label7;
        private Label label8;
        private TextBox new_commentbox;
        private Button update_passwordbtn;
        private ListBox Titlelist;
        private Button exitbtn;
        private TextBox list_searchbox;
        private Label label9;
        private Button generate_passwordbtn;
        private Button search_for_titlebtn;
        private Button buttonDelete;
    }
}
namespace MovieApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBox1 = new TextBox();
            searchBar = new PictureBox();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            deleteBtn = new Button();
            updateBtn = new Button();
            clearBtn = new Button();
            insertBtn = new Button();
            inPrice = new TextBox();
            label5 = new Label();
            inGenre = new TextBox();
            label6 = new Label();
            inTitle = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)searchBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(19, 20, 20);
            label1.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(225, 107, 91);
            label1.Location = new Point(24, 16);
            label1.Name = "label1";
            label1.Size = new Size(199, 70);
            label1.TabIndex = 2;
            label1.Text = "Best\r\n        Movies";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(656, 42);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(583, 44);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // searchBar
            // 
            searchBar.Image = (Image)resources.GetObject("searchBar.Image");
            searchBar.Location = new Point(1193, 42);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(46, 44);
            searchBar.SizeMode = PictureBoxSizeMode.Zoom;
            searchBar.TabIndex = 4;
            searchBar.TabStop = false;
            searchBar.Click += searchBar_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.BackgroundColor = Color.FromArgb(183, 185, 168);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridView2.Location = new Point(656, 111);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(583, 423);
            dataGridView2.TabIndex = 6;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Title";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Genre";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Price";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 130;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(209, 181, 163);
            panel2.Controls.Add(deleteBtn);
            panel2.Controls.Add(updateBtn);
            panel2.Controls.Add(clearBtn);
            panel2.Controls.Add(insertBtn);
            panel2.Controls.Add(inPrice);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(inGenre);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(inTitle);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(24, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(611, 423);
            panel2.TabIndex = 7;
            panel2.Paint += panel2_Paint;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.FromArgb(227, 107, 91);
            deleteBtn.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteBtn.ForeColor = Color.FromArgb(209, 181, 163);
            deleteBtn.Location = new Point(454, 352);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(109, 42);
            deleteBtn.TabIndex = 9;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.FromArgb(227, 107, 91);
            updateBtn.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBtn.ForeColor = Color.FromArgb(209, 181, 163);
            updateBtn.Location = new Point(322, 352);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(109, 42);
            updateBtn.TabIndex = 8;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.FromArgb(12, 13, 13);
            clearBtn.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearBtn.ForeColor = Color.FromArgb(227, 107, 91);
            clearBtn.Location = new Point(186, 352);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(109, 42);
            clearBtn.TabIndex = 7;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // insertBtn
            // 
            insertBtn.BackColor = Color.FromArgb(12, 13, 13);
            insertBtn.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            insertBtn.ForeColor = Color.FromArgb(227, 107, 91);
            insertBtn.Location = new Point(56, 352);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(109, 42);
            insertBtn.TabIndex = 6;
            insertBtn.Text = "Insert";
            insertBtn.UseVisualStyleBackColor = false;
            insertBtn.Click += button4_Click;
            // 
            // inPrice
            // 
            inPrice.BackColor = Color.White;
            inPrice.Location = new Point(56, 271);
            inPrice.Multiline = true;
            inPrice.Name = "inPrice";
            inPrice.Size = new Size(507, 44);
            inPrice.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(12, 13, 13);
            label5.Location = new Point(56, 227);
            label5.Name = "label5";
            label5.Size = new Size(72, 28);
            label5.TabIndex = 4;
            label5.Text = "Price";
            // 
            // inGenre
            // 
            inGenre.BackColor = Color.White;
            inGenre.Location = new Point(56, 161);
            inGenre.Multiline = true;
            inGenre.Name = "inGenre";
            inGenre.Size = new Size(507, 44);
            inGenre.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(12, 13, 13);
            label6.Location = new Point(56, 118);
            label6.Name = "label6";
            label6.Size = new Size(83, 28);
            label6.TabIndex = 2;
            label6.Text = "Genre";
            // 
            // inTitle
            // 
            inTitle.BackColor = Color.White;
            inTitle.Location = new Point(56, 51);
            inTitle.Multiline = true;
            inTitle.Name = "inTitle";
            inTitle.Size = new Size(507, 44);
            inTitle.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(12, 13, 13);
            label7.Location = new Point(56, 10);
            label7.Name = "label7";
            label7.Size = new Size(68, 28);
            label7.TabIndex = 0;
            label7.Text = "Title";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 20, 20);
            ClientSize = new Size(1267, 584);
            Controls.Add(panel2);
            Controls.Add(dataGridView2);
            Controls.Add(searchBar);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)searchBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox1;
        private PictureBox searchBar;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Panel panel2;
        private Button deleteBtn;
        private Button updateBtn;
        private Button clearBtn;
        private Button insertBtn;
        private TextBox inPrice;
        private Label label5;
        private TextBox inGenre;
        private Label label6;
        private TextBox inTitle;
        private Label label7;
    }
}

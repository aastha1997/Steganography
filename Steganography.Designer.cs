namespace Text2Image
{
    partial class Steganography
    {
        /// <summmary>
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Decrypt_btn = new System.Windows.Forms.Button();
            this.DeLoadImage_tbx = new System.Windows.Forms.TextBox();
            this.DeSaveFile_tbx = new System.Windows.Forms.TextBox();
            this.DeSaveFileBrowse_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DeLoadImageBrowse_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Encrypt_btn = new System.Windows.Forms.Button();
            this.EnFileBrowse_btn = new System.Windows.Forms.Button();
            this.EnImageBrowse_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EnFile_tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EnImage_tbx = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ByteCapacity_lbl = new System.Windows.Forms.Label();
            this.CanSave_lbl = new System.Windows.Forms.Label();
            this.ImageWidth_lbl = new System.Windows.Forms.Label();
            this.ImageHeight_lbl = new System.Windows.Forms.Label();
            this.ImageSize_lbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Close_btn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            //this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Decrypt_btn);
            this.groupBox1.Controls.Add(this.DeLoadImage_tbx);
            this.groupBox1.Controls.Add(this.DeSaveFile_tbx);
            this.groupBox1.Controls.Add(this.DeSaveFileBrowse_btn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DeLoadImageBrowse_btn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(80, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(427, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Load image:";
            // 
            // Decrypt_btn
            // 
            this.Decrypt_btn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decrypt_btn.Location = new System.Drawing.Point(164, 101);
            this.Decrypt_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Decrypt_btn.Name = "Decrypt_btn";
            this.Decrypt_btn.Size = new System.Drawing.Size(100, 28);
            this.Decrypt_btn.TabIndex = 3;
            this.Decrypt_btn.Text = "Decrypt";
            this.Decrypt_btn.UseVisualStyleBackColor = true;
            this.Decrypt_btn.Click += new System.EventHandler(this.Decrypt_btn_Click);
            // 
            // DeLoadImage_tbx
            // 
            this.DeLoadImage_tbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeLoadImage_tbx.Location = new System.Drawing.Point(104, 23);
            this.DeLoadImage_tbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeLoadImage_tbx.Name = "DeLoadImage_tbx";
            this.DeLoadImage_tbx.Size = new System.Drawing.Size(205, 23);
            this.DeLoadImage_tbx.TabIndex = 0;
            // 
            // DeSaveFile_tbx
            // 
            this.DeSaveFile_tbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeSaveFile_tbx.Location = new System.Drawing.Point(104, 66);
            this.DeSaveFile_tbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeSaveFile_tbx.Name = "DeSaveFile_tbx";
            this.DeSaveFile_tbx.Size = new System.Drawing.Size(205, 23);
            this.DeSaveFile_tbx.TabIndex = 2;
            // 
            // DeSaveFileBrowse_btn
            // 
            this.DeSaveFileBrowse_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeSaveFileBrowse_btn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeSaveFileBrowse_btn.Location = new System.Drawing.Point(319, 64);
            this.DeSaveFileBrowse_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeSaveFileBrowse_btn.Name = "DeSaveFileBrowse_btn";
            this.DeSaveFileBrowse_btn.Size = new System.Drawing.Size(100, 28);
            this.DeSaveFileBrowse_btn.TabIndex = 3;
            this.DeSaveFileBrowse_btn.Text = "Browse";
            this.DeSaveFileBrowse_btn.UseVisualStyleBackColor = true;
            this.DeSaveFileBrowse_btn.Click += new System.EventHandler(this.DeSaveFileBrowse_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Save file to:";
            // 
            // DeLoadImageBrowse_btn
            // 
            this.DeLoadImageBrowse_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeLoadImageBrowse_btn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeLoadImageBrowse_btn.Location = new System.Drawing.Point(319, 21);
            this.DeLoadImageBrowse_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeLoadImageBrowse_btn.Name = "DeLoadImageBrowse_btn";
            this.DeLoadImageBrowse_btn.Size = new System.Drawing.Size(100, 28);
            this.DeLoadImageBrowse_btn.TabIndex = 1;
            this.DeLoadImageBrowse_btn.Text = "Browse";
            this.DeLoadImageBrowse_btn.UseVisualStyleBackColor = true;
            this.DeLoadImageBrowse_btn.Click += new System.EventHandler(this.DeLoadImageBrowse_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Encrypt_btn);
            this.groupBox2.Controls.Add(this.EnFileBrowse_btn);
            this.groupBox2.Controls.Add(this.EnImageBrowse_btn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.EnFile_tbx);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.EnImage_tbx);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(80, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(427, 137);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // Encrypt_btn
            // 
            this.Encrypt_btn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encrypt_btn.Location = new System.Drawing.Point(164, 102);
            this.Encrypt_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Encrypt_btn.Name = "Encrypt_btn";
            this.Encrypt_btn.Size = new System.Drawing.Size(100, 28);
            this.Encrypt_btn.TabIndex = 3;
            this.Encrypt_btn.Text = "Encrypt";
            this.Encrypt_btn.UseVisualStyleBackColor = true;
            this.Encrypt_btn.Click += new System.EventHandler(this.Encrypt_btn_Click);
            // 
            // EnFileBrowse_btn
            // 
            this.EnFileBrowse_btn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnFileBrowse_btn.Location = new System.Drawing.Point(319, 64);
            this.EnFileBrowse_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnFileBrowse_btn.Name = "EnFileBrowse_btn";
            this.EnFileBrowse_btn.Size = new System.Drawing.Size(100, 28);
            this.EnFileBrowse_btn.TabIndex = 3;
            this.EnFileBrowse_btn.Text = "Browse";
            this.EnFileBrowse_btn.UseVisualStyleBackColor = true;
            this.EnFileBrowse_btn.Click += new System.EventHandler(this.EnFileBrowse_btn_Click);
            // 
            // EnImageBrowse_btn
            // 
            this.EnImageBrowse_btn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnImageBrowse_btn.Location = new System.Drawing.Point(319, 21);
            this.EnImageBrowse_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnImageBrowse_btn.Name = "EnImageBrowse_btn";
            this.EnImageBrowse_btn.Size = new System.Drawing.Size(100, 28);
            this.EnImageBrowse_btn.TabIndex = 1;
            this.EnImageBrowse_btn.Text = "Browse";
            this.EnImageBrowse_btn.UseVisualStyleBackColor = true;
            this.EnImageBrowse_btn.Click += new System.EventHandler(this.EnImageBrowse_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Load file:";
            // 
            // EnFile_tbx
            // 
            this.EnFile_tbx.Location = new System.Drawing.Point(103, 66);
            this.EnFile_tbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnFile_tbx.Name = "EnFile_tbx";
            this.EnFile_tbx.Size = new System.Drawing.Size(207, 23);
            this.EnFile_tbx.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Load image:";
            // 
            // EnImage_tbx
            // 
            this.EnImage_tbx.Location = new System.Drawing.Point(103, 25);
            this.EnImage_tbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnImage_tbx.Name = "EnImage_tbx";
            this.EnImage_tbx.Size = new System.Drawing.Size(207, 23);
            this.EnImage_tbx.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Bitmap Files (*.bmp)|*.bmp|All files(*.*)|*.*";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "All files (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Bitmap Files (*.bmp)|*.bmp";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.Filter = "Bitmap Files (*.bmp)|*.bmp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Image preview:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(221)))));
            this.groupBox3.Controls.Add(this.ByteCapacity_lbl);
            this.groupBox3.Controls.Add(this.CanSave_lbl);
            this.groupBox3.Controls.Add(this.ImageWidth_lbl);
            this.groupBox3.Controls.Add(this.ImageHeight_lbl);
            this.groupBox3.Controls.Add(this.ImageSize_lbl);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(615, 27);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(192, 150);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Image information";
            // 
            // ByteCapacity_lbl
            // 
            this.ByteCapacity_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ByteCapacity_lbl.AutoSize = true;
            this.ByteCapacity_lbl.Location = new System.Drawing.Point(117, 58);
            this.ByteCapacity_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ByteCapacity_lbl.Name = "ByteCapacity_lbl";
            this.ByteCapacity_lbl.Size = new System.Drawing.Size(0, 16);
            this.ByteCapacity_lbl.TabIndex = 2;
            // 
            // CanSave_lbl
            // 
            this.CanSave_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CanSave_lbl.AutoSize = true;
            this.CanSave_lbl.Location = new System.Drawing.Point(103, 119);
            this.CanSave_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CanSave_lbl.Name = "CanSave_lbl";
            this.CanSave_lbl.Size = new System.Drawing.Size(44, 16);
            this.CanSave_lbl.TabIndex = 1;
            this.CanSave_lbl.Text = "none";
            // 
            // ImageWidth_lbl
            // 
            this.ImageWidth_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageWidth_lbl.AutoSize = true;
            this.ImageWidth_lbl.Location = new System.Drawing.Point(103, 89);
            this.ImageWidth_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImageWidth_lbl.Name = "ImageWidth_lbl";
            this.ImageWidth_lbl.Size = new System.Drawing.Size(44, 16);
            this.ImageWidth_lbl.TabIndex = 1;
            this.ImageWidth_lbl.Text = "none";
            // 
            // ImageHeight_lbl
            // 
            this.ImageHeight_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageHeight_lbl.AutoSize = true;
            this.ImageHeight_lbl.Location = new System.Drawing.Point(103, 58);
            this.ImageHeight_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImageHeight_lbl.Name = "ImageHeight_lbl";
            this.ImageHeight_lbl.Size = new System.Drawing.Size(44, 16);
            this.ImageHeight_lbl.TabIndex = 1;
            this.ImageHeight_lbl.Text = "none";
            // 
            // ImageSize_lbl
            // 
            this.ImageSize_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageSize_lbl.AutoSize = true;
            this.ImageSize_lbl.Location = new System.Drawing.Point(103, 27);
            this.ImageSize_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImageSize_lbl.Name = "ImageSize_lbl";
            this.ImageSize_lbl.Size = new System.Drawing.Size(44, 16);
            this.ImageSize_lbl.TabIndex = 1;
            this.ImageSize_lbl.Text = "none";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 119);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Can save: ";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 89);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Width: ";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Height: ";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Size: ";
            // 
            // Close_btn
            // 
            this.Close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close_btn.Location = new System.Drawing.Point(703, 743);
            this.Close_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(100, 28);
            this.Close_btn.TabIndex = 3;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Visible = false;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(240)))), ((int)(((byte)(192)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 776);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(819, 26);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 20);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(7, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(599, 178);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(221)))));
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(591, 149);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encrypt Image";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(221)))));
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(591, 149);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decrypt Image";
            //
            //Steganography
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(196)))));
            this.CancelButton = this.Close_btn;
            this.ClientSize = new System.Drawing.Size(819, 802);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Steganography";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steganography : Any File Hide in Image";
            this.Load += new System.EventHandler(this.Steganography_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button EnImageBrowse_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EnImage_tbx;
        private System.Windows.Forms.Button EnFileBrowse_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EnFile_tbx;
        private System.Windows.Forms.Button Encrypt_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Decrypt_btn;
        private System.Windows.Forms.TextBox DeLoadImage_tbx;
        private System.Windows.Forms.TextBox DeSaveFile_tbx;
        private System.Windows.Forms.Button DeSaveFileBrowse_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DeLoadImageBrowse_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label ByteCapacity_lbl;
        private System.Windows.Forms.Label ImageSize_lbl;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label CanSave_lbl;
        private System.Windows.Forms.Label ImageWidth_lbl;
        private System.Windows.Forms.Label ImageHeight_lbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}
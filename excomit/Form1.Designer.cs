namespace excomit
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csv表形式で保存するToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.名前を付けて保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.閉じるToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.プレビューToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.リサルトログToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.デバッグToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databasepyをコンパイルするToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.その他ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョンToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(18, 147);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(151, 52);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "学校データ";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(18, 227);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(151, 52);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "生徒データ";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(387, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.Size = new System.Drawing.Size(241, 369);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(139, 19);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "選択中の学校データ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 260);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(139, 19);
            this.textBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "選択中の生徒データ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 314);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(218, 16);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "データ取得後自動でプレビューに遷移する";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.表示ToolStripMenuItem,
            this.デバッグToolStripMenuItem,
            this.その他ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csv表形式で保存するToolStripMenuItem,
            this.名前を付けて保存ToolStripMenuItem,
            this.閉じるToolStripMenuItem,
            this.終了ToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            this.ファイルToolStripMenuItem.Click += new System.EventHandler(this.ファイルToolStripMenuItem_Click);
            // 
            // csv表形式で保存するToolStripMenuItem
            // 
            this.csv表形式で保存するToolStripMenuItem.Name = "csv表形式で保存するToolStripMenuItem";
            this.csv表形式で保存するToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.csv表形式で保存するToolStripMenuItem.Text = "Csv(表)形式で保存";
            this.csv表形式で保存するToolStripMenuItem.Click += new System.EventHandler(this.csv表形式で保存するToolStripMenuItem_Click);
            // 
            // 名前を付けて保存ToolStripMenuItem
            // 
            this.名前を付けて保存ToolStripMenuItem.Name = "名前を付けて保存ToolStripMenuItem";
            this.名前を付けて保存ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.名前を付けて保存ToolStripMenuItem.Text = "Json形式で保存";
            this.名前を付けて保存ToolStripMenuItem.Click += new System.EventHandler(this.名前を付けて保存ToolStripMenuItem_Click);
            // 
            // 閉じるToolStripMenuItem
            // 
            this.閉じるToolStripMenuItem.Name = "閉じるToolStripMenuItem";
            this.閉じるToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.閉じるToolStripMenuItem.Text = "閉じる";
            this.閉じるToolStripMenuItem.Click += new System.EventHandler(this.閉じるToolStripMenuItem_Click);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // 表示ToolStripMenuItem
            // 
            this.表示ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.プレビューToolStripMenuItem1,
            this.リサルトログToolStripMenuItem});
            this.表示ToolStripMenuItem.Name = "表示ToolStripMenuItem";
            this.表示ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.表示ToolStripMenuItem.Text = "表示";
            // 
            // プレビューToolStripMenuItem1
            // 
            this.プレビューToolStripMenuItem1.Name = "プレビューToolStripMenuItem1";
            this.プレビューToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.プレビューToolStripMenuItem1.Text = "プレビュー";
            this.プレビューToolStripMenuItem1.Click += new System.EventHandler(this.プレビューToolStripMenuItem_Click);
            // 
            // リサルトログToolStripMenuItem
            // 
            this.リサルトログToolStripMenuItem.Name = "リサルトログToolStripMenuItem";
            this.リサルトログToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.リサルトログToolStripMenuItem.Text = "リサルトログ";
            this.リサルトログToolStripMenuItem.Click += new System.EventHandler(this.リサルトログToolStripMenuItem_Click);
            // 
            // デバッグToolStripMenuItem
            // 
            this.デバッグToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databasepyをコンパイルするToolStripMenuItem});
            this.デバッグToolStripMenuItem.Name = "デバッグToolStripMenuItem";
            this.デバッグToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.デバッグToolStripMenuItem.Text = "デバッグ";
            // 
            // databasepyをコンパイルするToolStripMenuItem
            // 
            this.databasepyをコンパイルするToolStripMenuItem.Name = "databasepyをコンパイルするToolStripMenuItem";
            this.databasepyをコンパイルするToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.databasepyをコンパイルするToolStripMenuItem.Text = "reader.goをデバッグする";
            this.databasepyをコンパイルするToolStripMenuItem.Click += new System.EventHandler(this.databasepyをコンパイルするToolStripMenuItem_Click);
            // 
            // その他ToolStripMenuItem
            // 
            this.その他ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.バージョンToolStripMenuItem});
            this.その他ToolStripMenuItem.Name = "その他ToolStripMenuItem";
            this.その他ToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.その他ToolStripMenuItem.Text = "その他";
            // 
            // バージョンToolStripMenuItem
            // 
            this.バージョンToolStripMenuItem.Name = "バージョンToolStripMenuItem";
            this.バージョンToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.バージョンToolStripMenuItem.Text = "バージョン";
            this.バージョンToolStripMenuItem.Click += new System.EventHandler(this.バージョンToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "excomit";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 閉じるToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 名前を付けて保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem csv表形式で保存するToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 表示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem プレビューToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem リサルトログToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem デバッグToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databasepyをコンパイルするToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem その他ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem バージョンToolStripMenuItem;
    }
}


using ControlExtends;
namespace treeViewTest
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
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.treeViewEx1 = new ControlExtends.TreeViewEx();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtEdit = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// treeViewEx1
			// 
			this.treeViewEx1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treeViewEx1.ImageIndex = 0;
			this.treeViewEx1.ImageList = this.imageList1;
			this.treeViewEx1.Location = new System.Drawing.Point(15, 100);
			this.treeViewEx1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.treeViewEx1.Name = "treeViewEx1";
			this.treeViewEx1.SelectedImageIndex = 0;
			this.treeViewEx1.Size = new System.Drawing.Size(237, 289);
			this.treeViewEx1.TabIndex = 0;
			this.treeViewEx1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "folderClose.png");
			this.imageList1.Images.SetKeyName(1, "folder.png");
			this.imageList1.Images.SetKeyName(2, "file.png");
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSearch.Location = new System.Drawing.Point(56, 56);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(60, 32);
			this.btnSearch.TabIndex = 1;
			this.btnSearch.Text = "検索";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtEdit
			// 
			this.txtEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtEdit.Location = new System.Drawing.Point(21, 13);
			this.txtEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtEdit.Name = "txtEdit";
			this.txtEdit.Size = new System.Drawing.Size(231, 33);
			this.txtEdit.TabIndex = 3;
			this.txtEdit.Text = "a:\\alpha\\amount";
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.Location = new System.Drawing.Point(124, 56);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(60, 32);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "追加";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDel
			// 
			this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDel.Location = new System.Drawing.Point(192, 56);
			this.btnDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(60, 32);
			this.btnDel.TabIndex = 4;
			this.btnDel.Text = "削除";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 394);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
			this.statusStrip1.Size = new System.Drawing.Size(268, 25);
			this.statusStrip1.TabIndex = 5;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolLabel
			// 
			this.toolLabel.Name = "toolLabel";
			this.toolLabel.Size = new System.Drawing.Size(151, 20);
			this.toolLabel.Text = "toolStripStatusLabel1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(268, 419);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.btnDel);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtEdit);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.treeViewEx1);
			this.Font = new System.Drawing.Font("メイリオ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "TreeViewExTest";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TreeViewEx treeViewEx1;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtEdit;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolLabel;
		private System.Windows.Forms.ImageList imageList1;
	}
}


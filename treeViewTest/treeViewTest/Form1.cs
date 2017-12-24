using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlExtends;

namespace treeViewTest
{
	public partial class Form1 : Form
	{

		string[] m_aryPathTest = new string[]
		{
				@"果物\",
				@"果物\りんご\",
				@"果物\りんご\りんごA",
				@"果物\りんご\りんごB",
				@"果物\みかん\",
				@"野菜\ネギ\",

		};

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			RefreshTreeView();

		}

		// TreeViewコントロールのデータを更新します。
		private void RefreshTreeView()
		{
			
			treeViewEx1.Nodes.Clear();
			// テストパスを展開する
			foreach( string mi in m_aryPathTest)
			{
				treeViewEx1.AddNode( mi,0,1);
			}
			treeViewEx1.TopNode.Expand();
			toolLabel.Text = "初期化完了";
		}

		// ツリービューが選択されたとき
		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			txtEdit.Text = treeViewEx1.SelectedNode.FullPath+"\\";
		}
		// 検索ボタンを押した時 
		private void btnSearch_Click(object sender, EventArgs e)
		{
			TreeNode res = treeViewEx1.FindNode( txtEdit.Text);
			if(res == null)
			{
				toolLabel.Text = ("見つかりません");
			}
			else
			{
				treeViewEx1.SelectedNode = res;
				treeViewEx1.Select();

			}
		}

		// 追加ボタンを押した時
		private void btnAdd_Click(object sender, EventArgs e)
		{
			string strPath = txtEdit.Text;
			// すでに存在するか検索
			TreeNode res =treeViewEx1.FindNode(strPath);
			if (res != null)
			{
				toolLabel.Text = ("すでに存在します");
			}
			else
			{
				// 追加する
				TreeNode objNew = treeViewEx1.AddNode(strPath,0,1);
				// 選択状態にする
				treeViewEx1.SelectedNode = objNew;
				treeViewEx1.Select();
				toolLabel.Text = "追加しました";
			}
		}
		// 削除ボタンをおした時
		private void btnDel_Click(object sender, EventArgs e)
		{
			string strPath = txtEdit.Text;
			TreeNode objNode = treeViewEx1.FindNode(strPath);
			bool bDelSub = true;
			if(objNode.Nodes.Count > 0)
			{
				bDelSub = (MessageBox.Show("一緒に削除しますか？", "子ノードが存在します", MessageBoxButtons.YesNo) == DialogResult.Yes);
			}
			if(bDelSub)
			{
				objNode.Remove();
				toolLabel.Text = "削除しました。";
			}
			else
			{
				toolLabel.Text = "削除できませんでした";
			}
		}
	}
}

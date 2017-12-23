﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlExtends
{
	/// <summary>
	/// ツリービューのノードにフルパスでアクセスできるようにする
	/// </summary>
	class TreeViewEx : System.Windows.Forms.TreeView
	{

		/// <summary>
		/// フルパスで指定されたツリービューを追加する
		/// </summary>
		/// <param name="p_strPath">フルパス</param>
		/// <param name="p_nImageIndex">イメージID</param>
		/// <param name="p_nSelectedImageIndex">選択中のイメージID</param>
		/// <returns></returns>
		public TreeNode AddNode( string p_strPath , int p_nImageIndex = -1, int p_nSelectedImageIndex = -1)
		{
			
			// パスを分割する
			string[] aryTree = p_strPath.Split(PathSeparator.ToCharArray());
			TreeNode objRoot = null;
//			TreeNodeCollection objRoot = Nodes;
			TreeNode objNode = null;
			foreach (string strNode in aryTree)
			{
				if (strNode == "") continue;
				// すでに存在するか確認 : ルートか子ノードで切り替え
				TreeNode[] objFind = ((objRoot == null) ? Nodes : objRoot.Nodes).Find(strNode, false); 

				if (objFind.Length == 0)
				{
					// なかったら作成する
					objNode = (p_nImageIndex == -1) ? new TreeNode(strNode) : new TreeNode(strNode,p_nImageIndex, p_nSelectedImageIndex);
					objNode.Name = strNode; // Nameをパス名にする

					// 追加：ルートか子ノードで切り替え
					((objRoot == null) ? Nodes : objRoot.Nodes).Add(objNode);

					if (objRoot != null) // 子ノードの場合展開する
					{
						objRoot.ExpandAll();
					}

					objRoot = objNode;// ノードを子パスに切り替える

				}
				else
				{
					objNode = objFind[0];
					objNode.ExpandAll();
					objRoot = objNode; // 見つけたノードの子パスをルートにする

				}

			}
			return objNode;

		}

		/// <summary>
		/// フルパスで指定されたツリービューノードを検索する
		/// </summary>
		/// <param name="p_strPath"></param>
		/// <returns></returns>
		public TreeNode FindNode(string p_strPath)
		{
			// パスを分割する
			string[] aryTree = p_strPath.Split(PathSeparator.ToCharArray());
			TreeNodeCollection objRoot = Nodes;
			TreeNode objNode = null;
			foreach (string strNode in aryTree)
			{
				if (strNode == "") continue;
				// すでに存在するか確認
				TreeNode[] objFind = objRoot.Find(strNode, false); // findNode(root, mTreeI);

				if (objFind.Length > 0)
				{
					objNode = objFind[0];
					objRoot = objNode.Nodes; // 見つけたノードの子パスをルートにする

				}
				else
				{
					objNode = null;
				}
			}
			return objNode;

		}


		/// <summary>
		/// フルパスで指定されたツリービューノードを削除する 
		/// </summary>
		/// <param name="p_strPath">フルパス</param>
		/// <param name="bSubDel">子ノードも削除する場合 true</param>
		/// <returns></returns>
		public bool RemoveNode( string p_strPath, bool bSubDel = true)
		{
			bool bRetVal = false;
			// パスを分割する
			string[] aryTree = p_strPath.Trim( PathSeparator.ToCharArray() ).Split(PathSeparator.ToCharArray());
			TreeNodeCollection objPearent = null;// ルートの親
			TreeNodeCollection objRoot = Nodes;
			TreeNode objNode = null;
			for (int nCnt = 0; nCnt < aryTree.Length; nCnt++)
			{
				//if (strNode == "") continue;
				// すでに存在するか確認
				TreeNode[] objFind = objRoot.Find(aryTree[nCnt], false); // findNode(root, mTreeI);

				if (objFind.Length > 0)
				{
					objNode = objFind[0];
					objPearent = objRoot;
					objRoot = objNode.Nodes; // 見つけたノードの子パスをルートにする

				}
				else
				{
					objNode = null;
				}
			}
			if (objPearent != null && objNode != null)
			{
				//bSub == false または 削除対象が子を持たないときは削除
				if (bSubDel == true || objNode.Nodes.Count == 0)
				{
					objPearent.Remove(objNode);
					// 削除出来たらtrue
					bRetVal = true;
				}
			}

			return bRetVal;

		}


	}
}

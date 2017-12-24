# TreeViewExTest
treeViewtreeViewコントロールをフルパスから操作する継承クラスを作成

<h1>TreeViewExの拡張機能</h1>
<ol>
  <li>フルパスで指定されたツリービューノードを追加する
    <ul>
      <li> 例えば「果物\みかん\みかんA」のような文字列を与えると、<br>
          「果物」→「みかん」→「みかんA」を順番に生成する<br>
          すでに、親ノード(「果物」や「みかん」)が存在する場合はその下に生成する
      </li>
    </ul>
  </li>
  <li> フルパスで指定されたツリービューノードを検索する
    <ul>
      <li> 「果物\みかん\みかんA」のようなフルパス文字列から、ツリービューのノードを検索する</li>
    </ul>
  </li>
</ol>
<h1>フォームのサンプル機能</h1>
<dl>
  <dt>検索</dt>
  <dd>テキストボックスに入力されたフルパスをツリービューから検索し、ノードを選択状態にする</dd>
  <dt>追加</dt>
  <dd>テキストボックスに入力されたパスを追加する。すでに存在する場合は追加しない。</dd>
  <dt>削除</dt>
  <dd>テキストボックスに入力されたパスを削除する。子ノードが存在する場合はダイアログで選択できる</dd>
 </dl>
 

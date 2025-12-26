using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;


namespace RegexTester {
	/// <summary>
	/// Form1 の概要の説明です。
	/// </summary>
	public class FrmMain : System.Windows.Forms.Form {
		private System.Windows.Forms.TextBox txtSample;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TreeView treeResult;
		private System.Windows.Forms.Button btnMatch;
		private System.Windows.Forms.TextBox txtResult;
		private System.Windows.Forms.TabControl tabSample;
		private System.Windows.Forms.OpenFileDialog oFDSample;
		private System.Windows.Forms.SaveFileDialog sFDSample;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnReplace;
		private System.Windows.Forms.Button btnBack;
		private IContainer components;
		private ComboBox cboRegExp;
		private ComboBox cboReplace;
		private MenuStrip menuMain;
		private ToolStripMenuItem menuFile;
		private ToolStripMenuItem menuFileOpen;
		private ToolStripMenuItem menuFileSave;
		private ToolStripMenuItem menuFileExit;
		private ToolStripMenuItem menuHelp;
		private ToolStripMenuItem menuHelpAbout;
		private ToolStripMenuItem menuHelpAuthor;
		private ToolStripMenuItem menuHelpMicrosoft;
		private ToolStripMenuItem menuRegExOption;
		private ToolStripMenuItem menuREOIgnoreCase;
		private ToolStripMenuItem menuREOSingleLine;
		private ToolStripMenuItem menuREOMultiLine;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel tsLabel;

		private string backstring = null;
        private ToolStripMenuItem menuFileSaveMatch;
        private SaveFileDialog sFDMatched;
		System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

		public FrmMain() {
			//
			// Windows フォーム デザイナ サポートに必要です。
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent 呼び出しの後に、コンストラクタ コードを追加してください。
			//
		}

		/// <summary>
		/// 使用されているリソースに後処理を実行します。
		/// </summary>
		protected override void Dispose(bool disposing) {
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナで生成されたコード
		/// <summary>
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
		/// </summary>
		private void InitializeComponent() {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("マッチ結果がここに表示されます。");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.txtSample = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.treeResult = new System.Windows.Forms.TreeView();
            this.btnMatch = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.tabSample = new System.Windows.Forms.TabControl();
            this.oFDSample = new System.Windows.Forms.OpenFileDialog();
            this.sFDSample = new System.Windows.Forms.SaveFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cboRegExp = new System.Windows.Forms.ComboBox();
            this.cboReplace = new System.Windows.Forms.ComboBox();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveMatch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRegExOption = new System.Windows.Forms.ToolStripMenuItem();
            this.menuREOIgnoreCase = new System.Windows.Forms.ToolStripMenuItem();
            this.menuREOSingleLine = new System.Windows.Forms.ToolStripMenuItem();
            this.menuREOMultiLine = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpMicrosoft = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.sFDMatched = new System.Windows.Forms.SaveFileDialog();
            this.menuMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSample
            // 
            this.txtSample.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSample.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtSample.HideSelection = false;
            this.txtSample.Location = new System.Drawing.Point(4, 27);
            this.txtSample.MaxLength = 0;
            this.txtSample.Multiline = true;
            this.txtSample.Name = "txtSample";
            this.txtSample.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSample.Size = new System.Drawing.Size(618, 152);
            this.txtSample.TabIndex = 1;
            this.txtSample.Text = "ここにテスト文字列を記載します。";
            this.txtSample.WordWrap = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Location = new System.Drawing.Point(2, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "正規表現";
            // 
            // treeResult
            // 
            this.treeResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.treeResult.Indent = 14;
            this.treeResult.Location = new System.Drawing.Point(4, 243);
            this.treeResult.Name = "treeResult";
            treeNode1.Name = "";
            treeNode1.Text = "マッチ結果がここに表示されます。";
            this.treeResult.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeResult.Size = new System.Drawing.Size(200, 180);
            this.treeResult.TabIndex = 7;
            this.treeResult.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeResult_AfterSelect);
            // 
            // btnMatch
            // 
            this.btnMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMatch.Image = ((System.Drawing.Image)(resources.GetObject("btnMatch.Image")));
            this.btnMatch.Location = new System.Drawing.Point(550, 185);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(72, 24);
            this.btnMatch.TabIndex = 3;
            this.btnMatch.Text = "検索";
            this.btnMatch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtResult.Location = new System.Drawing.Point(210, 243);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(176, 180);
            this.txtResult.TabIndex = 8;
            this.txtResult.Text = "各部分文字列がここに表示されます。";
            // 
            // tabSample
            // 
            this.tabSample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSample.Location = new System.Drawing.Point(392, 243);
            this.tabSample.Name = "tabSample";
            this.tabSample.SelectedIndex = 0;
            this.tabSample.Size = new System.Drawing.Size(232, 180);
            this.tabSample.TabIndex = 9;
            // 
            // oFDSample
            // 
            this.oFDSample.DefaultExt = "txt";
            this.oFDSample.FileName = "sample.txt";
            this.oFDSample.Filter = "テキストファイル|*.txt|全てのファイル|*.*";
            this.oFDSample.RestoreDirectory = true;
            this.oFDSample.Title = "開くテキストファイルを指定";
            // 
            // sFDSample
            // 
            this.sFDSample.DefaultExt = "txt";
            this.sFDSample.FileName = "sample.txt";
            this.sFDSample.Filter = "テキストファイル|*.txt|全てのファイル|*.*";
            this.sFDSample.RestoreDirectory = true;
            this.sFDSample.Title = "保存するテキストファイルを指定";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Location = new System.Drawing.Point(2, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "置換表現";
            // 
            // btnReplace
            // 
            this.btnReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReplace.Image = ((System.Drawing.Image)(resources.GetObject("btnReplace.Image")));
            this.btnReplace.Location = new System.Drawing.Point(472, 214);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(72, 24);
            this.btnReplace.TabIndex = 5;
            this.btnReplace.Text = "置換";
            this.btnReplace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(550, 214);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 24);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "元に戻す";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cboRegExp
            // 
            this.cboRegExp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRegExp.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cboRegExp.FormattingEnabled = true;
            this.cboRegExp.Location = new System.Drawing.Point(61, 185);
            this.cboRegExp.Name = "cboRegExp";
            this.cboRegExp.Size = new System.Drawing.Size(483, 23);
            this.cboRegExp.TabIndex = 2;
            // 
            // cboReplace
            // 
            this.cboReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboReplace.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cboReplace.FormattingEnabled = true;
            this.cboReplace.Location = new System.Drawing.Point(61, 214);
            this.cboReplace.Name = "cboReplace";
            this.cboReplace.Size = new System.Drawing.Size(405, 23);
            this.cboReplace.TabIndex = 4;
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuRegExOption,
            this.menuHelp});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(634, 26);
            this.menuMain.TabIndex = 11;
            this.menuMain.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileOpen,
            this.menuFileSave,
            this.menuFileSaveMatch,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(85, 22);
            this.menuFile.Text = "ファイル(&F)";
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("menuFileOpen.Image")));
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.Size = new System.Drawing.Size(215, 22);
            this.menuFileOpen.Text = "テスト文字列を開く...(&O)";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpenSample_Click);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Image = ((System.Drawing.Image)(resources.GetObject("menuFileSave.Image")));
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.Size = new System.Drawing.Size(215, 22);
            this.menuFileSave.Text = "テスト文字列を保存...(&S)";
            this.menuFileSave.Click += new System.EventHandler(this.menuFileSaveSample_Click);
            // 
            // menuFileSaveMatch
            // 
            this.menuFileSaveMatch.Name = "menuFileSaveMatch";
            this.menuFileSaveMatch.Size = new System.Drawing.Size(215, 22);
            this.menuFileSaveMatch.Text = "マッチ結果の保存...(&M)";
            this.menuFileSaveMatch.Click += new System.EventHandler(this.menuFileSaveMatch_Click);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(215, 22);
            this.menuFileExit.Text = "終了(&X)";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // menuRegExOption
            // 
            this.menuRegExOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuREOIgnoreCase,
            this.menuREOSingleLine,
            this.menuREOMultiLine});
            this.menuRegExOption.Name = "menuRegExOption";
            this.menuRegExOption.Size = new System.Drawing.Size(147, 22);
            this.menuRegExOption.Text = "正規表現オプション(&O)";
            // 
            // menuREOIgnoreCase
            // 
            this.menuREOIgnoreCase.Name = "menuREOIgnoreCase";
            this.menuREOIgnoreCase.Size = new System.Drawing.Size(335, 22);
            this.menuREOIgnoreCase.Text = "大文字と小文字を区別しない（Ignorecase）(&I)";
            this.menuREOIgnoreCase.Click += new System.EventHandler(this.menuREO_Click);
            // 
            // menuREOSingleLine
            // 
            this.menuREOSingleLine.Name = "menuREOSingleLine";
            this.menuREOSingleLine.Size = new System.Drawing.Size(335, 22);
            this.menuREOSingleLine.Text = "「.」が改行にもマッチする（SingleLine）(&S)";
            this.menuREOSingleLine.Click += new System.EventHandler(this.menuREO_Click);
            // 
            // menuREOMultiLine
            // 
            this.menuREOMultiLine.Name = "menuREOMultiLine";
            this.menuREOMultiLine.Size = new System.Drawing.Size(335, 22);
            this.menuREOMultiLine.Text = "「^$」が各行毎にマッチする（MultiLine）(&M)";
            this.menuREOMultiLine.Click += new System.EventHandler(this.menuREO_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout,
            this.menuHelpAuthor,
            this.menuHelpMicrosoft});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(75, 22);
            this.menuHelp.Text = "ヘルプ(&H)";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(291, 22);
            this.menuHelpAbout.Text = "このプログラムについて...(&A)";
            this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
            // 
            // menuHelpAuthor
            // 
            this.menuHelpAuthor.Image = ((System.Drawing.Image)(resources.GetObject("menuHelpAuthor.Image")));
            this.menuHelpAuthor.Name = "menuHelpAuthor";
            this.menuHelpAuthor.Size = new System.Drawing.Size(291, 22);
            this.menuHelpAuthor.Text = "作者のページ...(&P)";
            this.menuHelpAuthor.Click += new System.EventHandler(this.menuHelpAuthor_Click);
            // 
            // menuHelpMicrosoft
            // 
            this.menuHelpMicrosoft.Image = ((System.Drawing.Image)(resources.GetObject("menuHelpMicrosoft.Image")));
            this.menuHelpMicrosoft.Name = "menuHelpMicrosoft";
            this.menuHelpMicrosoft.Size = new System.Drawing.Size(291, 22);
            this.menuHelpMicrosoft.Text = "正規表現リファレンス(Microsoft)...(&M)";
            this.menuHelpMicrosoft.Click += new System.EventHandler(this.menuHelpMS_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 426);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(634, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsLabel
            // 
            this.tsLabel.Name = "tsLabel";
            this.tsLabel.Size = new System.Drawing.Size(619, 17);
            this.tsLabel.Spring = true;
            this.tsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sFDMatched
            // 
            this.sFDMatched.DefaultExt = "txt";
            this.sFDMatched.FileName = "match.txt";
            this.sFDMatched.Filter = "テキストファイル|*.txt|全てのファイル|*.*";
            this.sFDMatched.RestoreDirectory = true;
            this.sFDMatched.Title = "保存するテキストファイルを指定";
            // 
            // FrmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cboReplace);
            this.Controls.Add(this.cboRegExp);
            this.Controls.Add(this.tabSample);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnMatch);
            this.Controls.Add(this.treeResult);
            this.Controls.Add(this.txtSample);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.menuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Name = "FrmMain";
            this.Text = "正規表現テスター";
            this.Closed += new System.EventHandler(this.FrmMain_Closed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FrmMain());
		}

		private void btnMatch_Click(object sender, System.EventArgs e) {
			_DoRegex(false);
		}

		private void _DoRegex(bool isReplace) {
			RegexOptions options = RegexOptions.None;
			if (menuREOIgnoreCase.Checked) { options |= RegexOptions.IgnoreCase; }
			if (menuREOMultiLine.Checked) { options |= RegexOptions.Multiline; }
			if (menuREOSingleLine.Checked) { options |= RegexOptions.Singleline; }

			Regex regex;
			try {
				sw.Reset();
				sw.Start();
				regex = new Regex(cboRegExp.Text, options);
				sw.Stop();
			} catch (ArgumentException ex) {
				treeResult.Nodes.Clear();
				txtResult.Text = "正規表現の解析に失敗しました。\r\n" + ex.Message;
				return;
			}
			double msec = (double)sw.ElapsedTicks / (double)System.Diagnostics.Stopwatch.Frequency * 1000;
			tsLabel.Text = "処理時間　正規表現解析：" + msec.ToString("f3") + "ms";

			cboRegExp.Items.Add(cboRegExp.Text);
			cboReplace.Items.Add(cboReplace.Text);

			if (isReplace) {
				sw.Reset();
				backstring = txtSample.Text;
				string from=txtSample.Text.Replace("\r\n", "\n");
                string rep = Regex.Unescape(cboReplace.Text);
                //rep=rep.Replace("\n","\r\n");
				sw.Start();
				string after = regex.Replace(from, rep);
				sw.Stop();
				txtSample.Text = after.Replace("\n", "\r\n");
				msec = (double)sw.ElapsedTicks / (double)System.Diagnostics.Stopwatch.Frequency * 1000;
				tsLabel.Text += "　置換："+ msec.ToString("f3") + "ms";
			} else {
				//backstring=null;
			}
            _MatchAndCreateTreeList(regex);
        }

		private void _MatchAndCreateTreeList(Regex regex) {
			treeResult.Nodes.Clear();
			txtResult.Text = "";

			string str = txtSample.Text.Replace("\r\n", "\n");

			sw.Reset();
			sw.Start();
			MatchCollection mc = regex.Matches(str);
			sw.Stop();
			double msec = (double)sw.ElapsedTicks / (double)System.Diagnostics.Stopwatch.Frequency * 1000;
			tsLabel.Text += "　マッチ：" + msec.ToString("f3") + "ms";

			if (mc.Count == 0) {
				txtResult.Text = "マッチする文字列がありませんでした。";
				return;
			}

			//match
			for (int m = 0; m < mc.Count; m++) {
				Match match = mc[m];
				if (match.Value == "") {
					continue;
				}
				string matchstring = "[" + _ShortString(match.Value, 10) + "]";
				TreeNode tn1 = new TreeNode(matchstring);
				tn1.Tag = match;
				treeResult.Nodes.Add(tn1);

				if (match.Groups.Count >= 2) {
					//group
					for (int g = 0; g < match.Groups.Count; g++) {
						Group group = match.Groups[g];
						string groupstring;
						if (g == 0) {
							groupstring = "全体($0)";
						} else {
							string gname = regex.GroupNameFromNumber(g);
							double d;
							bool isnum = double.TryParse(gname,
								System.Globalization.NumberStyles.Any,
								System.Globalization.NumberFormatInfo.InvariantInfo, out d);
							if (isnum) {
								groupstring = "グループ($" + gname + ")";
							} else {
								groupstring = "グループ(${" + gname + "})";
							}
						}
						TreeNode tn2 = new TreeNode(groupstring);
						tn2.Tag = group;
						tn1.Nodes.Add(tn2);

						//capture
						if (group.Captures.Count >= 2) {
							for (int c = 0; c < group.Captures.Count; c++) {
								Capture capture = group.Captures[c];
								string capturestring;
								capturestring = "キャプチャ#" + c.ToString();
								TreeNode tn3 = new TreeNode(capturestring);
								tn3.Tag = capture;
								tn2.Nodes.Add(tn3);
							}
						}
					}
				}
			}

			//treeResult.ExpandAll();
		}

		private string _ShortString(string s, int n) {
			if (s.Length <= n) {
				return s;
			}
			string t = s.Substring(0, n - 3) + "...";
			return t;
		}

		private void treeResult_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e) {
			TreeNode tn = e.Node;
			if (tn.Tag == null) {
				return;
			}
			Object tag = tn.Tag;
			Capture c = null;
			if (tag.GetType() == typeof(Match)) {
				c = ((Match)tag);
			} else if (tag.GetType() == typeof(Group)) {
				c = ((Group)tag);
			} else if (tag.GetType() == typeof(Capture)) {
				c = ((Capture)tag);
			}
			if (c != null) {
				txtResult.Text = c.Value.Replace("\n", "\r\n");
				string str = txtSample.Text.Replace("\r\n", "\n");
				int start = c.Index + countLF(str, 0, c.Index);
				int length = c.Length + countLF(str, c.Index, c.Length);
				txtSample.SelectionStart = start;
				txtSample.ScrollToCaret();
				txtSample.SelectionLength = length;
			}
		}

		private int countLF(string s, int start, int length) {
			int count = 0;
			for (int i = start; i < start + length; i++) {
				if (i < s.Length && s[i] == '\n') {
					count++;
				}
			}
			return count;
		}

		private void FrmMain_Load(object sender, System.EventArgs e) {
			_LoadOption();
			_LoadSample();
			tsLabel.Text = "正規表現テスター version " + Application.ProductVersion;
		}

		private void _LoadOption() {
			FileInfo fi = new FileInfo(Application.StartupPath + "\\retoptions.xml");
			if (fi.Exists) {
				FileStream fs = null;
				Option o = null;
				try {
					fs = fi.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					System.Xml.Serialization.XmlSerializer xmls = new System.Xml.Serialization.XmlSerializer(typeof(Option));
					o = (Option)xmls.Deserialize(fs);
				} catch (Exception ex) {
					MessageBox.Show(this, "オプション読み込みに失敗しました：" + ex.Message, "エラー");
				} finally {
					if (fs != null) { fs.Close(); }
				}
				if (o != null) {
					txtSample.Text = o.Sample.Replace("\n", "\r\n");
					cboRegExp.Text = o.Regexp;
					cboReplace.Text = o.Replace;
					cboRegExp.Items.Add(cboRegExp.Text);
					cboReplace.Items.Add(cboReplace.Text);
					menuREOIgnoreCase.Checked = o.IgnoreCase;
					menuREOMultiLine.Checked = o.Multiline;
					menuREOSingleLine.Checked = o.Singleline;

					Point backLocation = this.Location;
					this.Location = o.MainWindowPosition;
					this.ClientSize = o.MainWindowSize;
					this.WindowState = FormWindowState.Normal;
					Rectangle rec = new Rectangle(this.Location, this.Size);
					if (System.Windows.Forms.Screen.GetWorkingArea(this).IntersectsWith(rec) == false) {
						this.Location = backLocation;
					}
					if (this.ClientRectangle.Width < 64 || this.ClientRectangle.Height < 64) {
						this.Size = new Size(640, 480);
					}
				}
			}
		}

		private void _SaveOption() {
			Option o = new Option();
			o.Sample = txtSample.Text;
			o.Regexp = cboRegExp.Text;
			o.Replace = cboReplace.Text;
			
			o.IgnoreCase = menuREOIgnoreCase.Checked;
			o.Multiline = menuREOMultiLine.Checked;
			o.Singleline = menuREOSingleLine.Checked;

			this.Visible = true;
			this.WindowState = FormWindowState.Normal;
			o.MainWindowPosition = this.Location;
			o.MainWindowSize = this.ClientSize;

			FileInfo fi = new FileInfo(Application.StartupPath + "\\retoptions.xml");
			FileStream fs = null;
			try {
				fs = fi.Open(FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
				System.Xml.Serialization.XmlSerializer xmls = new System.Xml.Serialization.XmlSerializer(typeof(Option));
				xmls.Serialize(fs, o);
			} catch (Exception ex) {
				MessageBox.Show(this, "オプション書き込みに失敗しました：" + ex.Message, "エラー");
			} finally {
				if (fs != null) { fs.Close(); }
			}
		}

		private void FrmMain_Closed(object sender, System.EventArgs e) {
			_SaveOption();
		}

		private void _LoadSample() {
			FileInfo fi = new FileInfo(Application.StartupPath + "\\retsample.txt");
			if (!fi.Exists) {
				return;
			}
			FileStream fs = fi.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			StreamReader sr = new StreamReader(fs, System.Text.Encoding.GetEncoding("Shift-JIS"));
			string buf;
			string tabname;
			TextBox nowtext = null;
			while ((buf = sr.ReadLine()) != null) {
				buf = buf.Trim();
				if (buf.StartsWith("#") || buf.Length == 0) {
					continue;
				}
				if (buf.StartsWith("@")) {
					tabname = buf.Substring(1);
					TabPage tp = null;
					tp = new TabPage(tabname);
					TextBox tb = new TextBox();
					tb.ReadOnly = true;
					tb.Multiline = true;
					tb.WordWrap = false;
					tb.ScrollBars = ScrollBars.Both;
					tb.Dock = DockStyle.Fill;
					tp.Controls.Add(tb);
					tabSample.TabPages.Add(tp);
					nowtext = tb;
				} else {
					if (nowtext == null) {
						continue;
					}
					nowtext.Text += buf + "\r\n";
				}
			}
			sr.Close();
		}

		private void menuFileOpenSample_Click(object sender, System.EventArgs e) {
			DialogResult dr;
			dr = oFDSample.ShowDialog(this);
			if (dr != DialogResult.OK) {
				return;
			}
			FileInfo fi = new FileInfo(oFDSample.FileName);
			StreamReader sr = new StreamReader(fi.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite), System.Text.Encoding.GetEncoding("Shift-JIS"));
			string text = sr.ReadToEnd();
			txtSample.Text = text;
			sr.Close();
		}

		private void menuFileSaveSample_Click(object sender, System.EventArgs e) {
			DialogResult dr;
			dr = sFDSample.ShowDialog(this);
			if (dr != DialogResult.OK) {
				return;
			}
			FileInfo fi = new FileInfo(sFDSample.FileName);
			StreamWriter sw = new StreamWriter(fi.Open(FileMode.Create, FileAccess.Write, FileShare.ReadWrite), System.Text.Encoding.GetEncoding("Shift-JIS"));
			sw.Write(txtSample.Text);
			sw.Close();
		}

		private void menuHelpAbout_Click(object sender, System.EventArgs e) {
			MessageBox.Show(
				this,
				"正規表現テスター version " + Application.ProductVersion + "\r\n" +
				"written by 浮子屋",
				"このプログラムについて...",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information);
		}

		protected override bool ProcessDialogKey(Keys keyData) {
			if (keyData == (Keys.A | Keys.Control)) {
				if (this.ActiveControl is TextBox) {
					TextBox txt = (TextBox)this.ActiveControl;
					txt.SelectionStart = 0;
					txt.SelectionLength = txt.Text.Length;
					return true;
				}
				return false;
			}
			return base.ProcessDialogKey(keyData);
		}

		private void btnReplace_Click(object sender, System.EventArgs e) {
			_DoRegex(true);
		}

		private void btnBack_Click(object sender, System.EventArgs e) {
			if (backstring != null) {
				txtSample.Text = backstring;
			}
		}

		private void menuHelpAuthor_Click(object sender, System.EventArgs e) {
			System.Diagnostics.Process.Start("http://ukiya.sakura.ne.jp/");
		}

		private void menuHelpMS_Click(object sender, System.EventArgs e) {
			System.Diagnostics.Process.Start("http://www.microsoft.com/japan/msdn/library/ja/cpgenref/html/cpconregularexpressionslanguageelements.asp?frame=true");
		}

		private void menuFileExit_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void menuREO_Click(object sender, EventArgs e) {
			ToolStripMenuItem mi = (ToolStripMenuItem)sender;
			mi.Checked=!mi.Checked;
		}

        private void menuFileSaveMatch_Click(object sender, EventArgs e) {
            DialogResult dr;
            dr = sFDMatched.ShowDialog(this);
            if (dr != DialogResult.OK) {
                return;
            }

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (TreeNode tn in treeResult.Nodes) {
			    if (tn.Tag == null) {
				    continue;
			    }
			    Object tag = tn.Tag;
			    Capture c = null;
			    if (tag.GetType() == typeof(Match)) {
				    c = ((Match)tag);
			    }/* else if (tag.GetType() == typeof(Group)) {
				    c = ((Group)tag);
			    } else if (tag.GetType() == typeof(Capture)) {
				    c = ((Capture)tag);
			    }*/
			    if (c != null) {
                    sb.Append(c.Value.Replace("\n", "\r\n"));
			    }
            }


            FileInfo fi = new FileInfo(sFDMatched.FileName);
            StreamWriter sw = new StreamWriter(fi.Open(FileMode.Create, FileAccess.Write, FileShare.ReadWrite), System.Text.Encoding.GetEncoding("Shift-JIS"));

            sw.Write(sb.ToString());
            sw.Close();
        }


	}

	public class Option {
		public string Sample;
		public string Regexp;
		public string Replace;
		public bool IgnoreCase;
		public bool Singleline;
		public bool Multiline;
		public Point MainWindowPosition;
		public Size MainWindowSize;
	}
}

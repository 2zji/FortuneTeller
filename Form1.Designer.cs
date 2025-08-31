namespace FortuneTeller
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowResult = new System.Windows.Forms.Button();
            this.tbBirthtime = new System.Windows.Forms.TextBox();
            this.tbBirthday = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.내역불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.포츈텔러정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowResult);
            this.groupBox1.Controls.Add(this.tbBirthtime);
            this.groupBox1.Controls.Add(this.tbBirthday);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(421, 496);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사용자 입력";
            // 
            // btnShowResult
            // 
            this.btnShowResult.Location = new System.Drawing.Point(40, 351);
            this.btnShowResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowResult.Name = "btnShowResult";
            this.btnShowResult.Size = new System.Drawing.Size(313, 55);
            this.btnShowResult.TabIndex = 4;
            this.btnShowResult.Text = "사주 결과 보기";
            this.btnShowResult.UseVisualStyleBackColor = true;
            this.btnShowResult.Click += new System.EventHandler(this.btnShowResult_Click);
            // 
            // tbBirthtime
            // 
            this.tbBirthtime.Location = new System.Drawing.Point(40, 211);
            this.tbBirthtime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbBirthtime.Name = "tbBirthtime";
            this.tbBirthtime.Size = new System.Drawing.Size(214, 25);
            this.tbBirthtime.TabIndex = 3;
            // 
            // tbBirthday
            // 
            this.tbBirthday.Location = new System.Drawing.Point(38, 91);
            this.tbBirthday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbBirthday.Name = "tbBirthday";
            this.tbBirthday.Size = new System.Drawing.Size(268, 25);
            this.tbBirthday.TabIndex = 2;
            this.tbBirthday.TextChanged += new System.EventHandler(this.tbBirthday_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "태어난 시각을 적어주세요";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "생년월일을 적어주세요";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbResult);
            this.groupBox2.Location = new System.Drawing.Point(469, 35);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(421, 496);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "사주결과";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(19, 25);
            this.tbResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(380, 448);
            this.tbResult.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(914, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.내역불러오기ToolStripMenuItem,
            this.끝내기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 내역불러오기ToolStripMenuItem
            // 
            this.내역불러오기ToolStripMenuItem.Name = "내역불러오기ToolStripMenuItem";
            this.내역불러오기ToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.내역불러오기ToolStripMenuItem.Text = "내역 불러오기";
            this.내역불러오기ToolStripMenuItem.Click += new System.EventHandler(this.내역불러오기ToolStripMenuItem_Click);
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.끝내기ToolStripMenuItem.Text = "끝내기";
            this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.포츈텔러정보ToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // 포츈텔러정보ToolStripMenuItem
            // 
            this.포츈텔러정보ToolStripMenuItem.Name = "포츈텔러정보ToolStripMenuItem";
            this.포츈텔러정보ToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.포츈텔러정보ToolStripMenuItem.Text = "포츈텔러 정보";
            this.포츈텔러정보ToolStripMenuItem.Click += new System.EventHandler(this.포츈텔러정보ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "3109윤예지";
<<<<<<< HEAD
            this.Load += new System.EventHandler(this.Form1_Load);
=======
>>>>>>> 3cf6f7a (Fix gitignore and remove unnecessary VS/obj files)
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShowResult;
        private System.Windows.Forms.TextBox tbBirthtime;
        private System.Windows.Forms.TextBox tbBirthday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 내역불러오기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 포츈텔러정보ToolStripMenuItem;
    }
}


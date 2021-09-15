namespace ProfessorMain
{
    partial class ProfesserMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.allcheck = new System.Windows.Forms.CheckBox();
            this.screenbtn = new System.Windows.Forms.Button();
            this.questionbtn = new System.Windows.Forms.Button();
            this.unconstu = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.allscreenbtn = new System.Windows.Forms.Button();
            this.attendbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.studList = new System.Windows.Forms.DataGridView();
            this.stucheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.stuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuscreenshot = new System.Windows.Forms.DataGridViewImageColumn();
            this.stuanswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuattend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.className = new System.Windows.Forms.Label();
            this.classTime = new System.Windows.Forms.Label();
            this.attenddanceBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "선택";
            // 
            // allcheck
            // 
            this.allcheck.AutoSize = true;
            this.allcheck.Location = new System.Drawing.Point(35, 91);
            this.allcheck.Name = "allcheck";
            this.allcheck.Size = new System.Drawing.Size(15, 14);
            this.allcheck.TabIndex = 7;
            this.allcheck.UseVisualStyleBackColor = true;
            this.allcheck.CheckedChanged += new System.EventHandler(this.allcheck_CheckedChanged);
            // 
            // screenbtn
            // 
            this.screenbtn.Location = new System.Drawing.Point(154, 358);
            this.screenbtn.Name = "screenbtn";
            this.screenbtn.Size = new System.Drawing.Size(69, 23);
            this.screenbtn.TabIndex = 10;
            this.screenbtn.Text = "스크린샷";
            this.screenbtn.UseVisualStyleBackColor = true;
            this.screenbtn.Click += new System.EventHandler(this.screenbtn_Click);
            // 
            // questionbtn
            // 
            this.questionbtn.Location = new System.Drawing.Point(85, 358);
            this.questionbtn.Name = "questionbtn";
            this.questionbtn.Size = new System.Drawing.Size(63, 23);
            this.questionbtn.TabIndex = 10;
            this.questionbtn.Text = "문제";
            this.questionbtn.UseVisualStyleBackColor = true;
            this.questionbtn.Click += new System.EventHandler(this.questionbtn_Click);
            // 
            // unconstu
            // 
            this.unconstu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unconstu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
            this.unconstu.HideSelection = false;
            this.unconstu.Location = new System.Drawing.Point(467, 87);
            this.unconstu.Name = "unconstu";
            this.unconstu.Size = new System.Drawing.Size(184, 262);
            this.unconstu.TabIndex = 12;
            this.unconstu.UseCompatibleStateImageBehavior = false;
            this.unconstu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "학번";
            this.columnHeader6.Width = 84;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "이름";
            this.columnHeader7.Width = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "접속학생";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "미접속학생";
            // 
            // allscreenbtn
            // 
            this.allscreenbtn.Location = new System.Drawing.Point(229, 358);
            this.allscreenbtn.Name = "allscreenbtn";
            this.allscreenbtn.Size = new System.Drawing.Size(130, 23);
            this.allscreenbtn.TabIndex = 15;
            this.allscreenbtn.Text = "전체 스크린샷 확인";
            this.allscreenbtn.UseVisualStyleBackColor = true;
            this.allscreenbtn.Click += new System.EventHandler(this.allscreenbtn_Click);
            // 
            // attendbtn
            // 
            this.attendbtn.Location = new System.Drawing.Point(531, 358);
            this.attendbtn.Name = "attendbtn";
            this.attendbtn.Size = new System.Drawing.Size(63, 23);
            this.attendbtn.TabIndex = 16;
            this.attendbtn.Text = "출석시작";
            this.attendbtn.UseVisualStyleBackColor = true;
            this.attendbtn.Click += new System.EventHandler(this.attendbtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "수업시작";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(593, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "수업종료";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // studList
            // 
            this.studList.AllowUserToAddRows = false;
            this.studList.BackgroundColor = System.Drawing.Color.White;
            this.studList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stucheck,
            this.stuid,
            this.stuname,
            this.stuscreenshot,
            this.stuanswer,
            this.stuattend});
            this.studList.Location = new System.Drawing.Point(28, 86);
            this.studList.Name = "studList";
            this.studList.RowHeadersVisible = false;
            this.studList.RowTemplate.Height = 23;
            this.studList.Size = new System.Drawing.Size(424, 266);
            this.studList.TabIndex = 19;
            this.studList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studList_CellDoubleClick);
            this.studList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.studList_CellMouseDoubleClick);
            // 
            // stucheck
            // 
            this.stucheck.HeaderText = "";
            this.stucheck.Name = "stucheck";
            this.stucheck.Width = 25;
            // 
            // stuid
            // 
            this.stuid.HeaderText = "학번";
            this.stuid.Name = "stuid";
            this.stuid.Width = 80;
            // 
            // stuname
            // 
            this.stuname.HeaderText = "이름";
            this.stuname.Name = "stuname";
            this.stuname.Width = 55;
            // 
            // stuscreenshot
            // 
            this.stuscreenshot.HeaderText = "스크린샷 썸네일";
            this.stuscreenshot.Name = "stuscreenshot";
            this.stuscreenshot.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stuscreenshot.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.stuscreenshot.Width = 150;
            // 
            // stuanswer
            // 
            this.stuanswer.HeaderText = "응답";
            this.stuanswer.Name = "stuanswer";
            this.stuanswer.Width = 55;
            // 
            // stuattend
            // 
            this.stuattend.HeaderText = "출석";
            this.stuattend.Name = "stuattend";
            this.stuattend.Width = 55;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 436);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(516, 21);
            this.textBox1.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "테스트 용입니다";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 15F);
            this.label6.Location = new System.Drawing.Point(264, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "수업 시간 : ";
            // 
            // className
            // 
            this.className.AutoSize = true;
            this.className.Font = new System.Drawing.Font("굴림", 30F);
            this.className.Location = new System.Drawing.Point(12, 11);
            this.className.Name = "className";
            this.className.Size = new System.Drawing.Size(190, 40);
            this.className.TabIndex = 24;
            this.className.Text = "수업 이름";
            // 
            // classTime
            // 
            this.classTime.AutoSize = true;
            this.classTime.Font = new System.Drawing.Font("굴림", 12F);
            this.classTime.Location = new System.Drawing.Point(376, 31);
            this.classTime.Name = "classTime";
            this.classTime.Size = new System.Drawing.Size(49, 16);
            this.classTime.TabIndex = 25;
            this.classTime.Text = "label8";
            // 
            // attenddanceBtn
            // 
            this.attenddanceBtn.Location = new System.Drawing.Point(365, 358);
            this.attenddanceBtn.Name = "attenddanceBtn";
            this.attenddanceBtn.Size = new System.Drawing.Size(87, 23);
            this.attenddanceBtn.TabIndex = 26;
            this.attenddanceBtn.Text = "출석부 확인";
            this.attenddanceBtn.UseVisualStyleBackColor = true;
            this.attenddanceBtn.Click += new System.EventHandler(this.attenddanceBtn_Click);
            // 
            // ProfesserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(683, 478);
            this.Controls.Add(this.attenddanceBtn);
            this.Controls.Add(this.classTime);
            this.Controls.Add(this.className);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.allcheck);
            this.Controls.Add(this.studList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.attendbtn);
            this.Controls.Add(this.allscreenbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.unconstu);
            this.Controls.Add(this.questionbtn);
            this.Controls.Add(this.screenbtn);
            this.Controls.Add(this.label1);
            this.Name = "ProfesserMain";
            this.Text = "메인화면";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox allcheck;
        private System.Windows.Forms.Button screenbtn;
        private System.Windows.Forms.Button questionbtn;
        private System.Windows.Forms.ListView unconstu;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button allscreenbtn;
        private System.Windows.Forms.Button attendbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView studList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stucheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuname;
        private System.Windows.Forms.DataGridViewImageColumn stuscreenshot;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuanswer;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuattend;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label className;
        private System.Windows.Forms.Label classTime;
        private System.Windows.Forms.Button attenddanceBtn;
    }
}


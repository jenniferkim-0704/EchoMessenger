namespace EchoMessenger
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
            lblTitle = new Label();
            txtMessenger = new TextBox();
            lstEchoWindow = new ListBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("MV Boli", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(406, 65);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Echo Messenger";
            // 
            // lblCount
            // 
            lblCount = new Label();
            lblCount.AutoSize = true;
            lblCount.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblCount.Location = new Point(560, 20);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(100, 23);
            lblCount.TabIndex = 4;
            lblCount.Text = "총 메시지: 0";
            // 
            // txtMessenger
            // 
            txtMessenger.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtMessenger.Location = new Point(12, 370);
            txtMessenger.Multiline = true;
            txtMessenger.Name = "txtMessenger";
            txtMessenger.Size = new Size(542, 44);
            txtMessenger.TabIndex = 1;
            txtMessenger.Text = "(여기에 입력하세요)";
            txtMessenger.KeyDown += txtMessenger_KeyDown;
            // 
            // lstEchoWindow
            // 
            lstEchoWindow.BackColor = SystemColors.HighlightText;
            lstEchoWindow.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lstEchoWindow.FormattingEnabled = true;
            lstEchoWindow.Location = new Point(12, 79);
            lstEchoWindow.Name = "lstEchoWindow";
            lstEchoWindow.Size = new Size(738, 249);
            lstEchoWindow.TabIndex = 2;
            // 
            // btnSend
            // 
            btnSend.BackColor = SystemColors.ButtonHighlight;
            btnSend.Font = new Font("바탕", 15F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnSend.ForeColor = SystemColors.WindowText;
            btnSend.Location = new Point(560, 373);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(141, 41);
            btnSend.TabIndex = 3;
            btnSend.Text = "전송";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // Form1
            // 
            AcceptButton = btnSend;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSend);
            Controls.Add(lstEchoWindow);
            Controls.Add(txtMessenger);
            Controls.Add(lblTitle);
            Controls.Add(lblCount);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblCount;
        private TextBox txtMessenger;
        private ListBox lstEchoWindow;
        private Button btnSend;
    }
}

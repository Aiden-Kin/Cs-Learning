namespace mini选课习题.StudentRegister
{
    partial class RegistInformation
    {

        /// <summary>
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
            TbInfo = new TextBox();
            BuConfirm = new Button();
            SuspendLayout();
            // 
            // TbInfo
            // 
            TbInfo.BackColor = Color.White;
            TbInfo.Location = new Point(57, 27);
            TbInfo.Margin = new Padding(2, 3, 2, 3);
            TbInfo.Multiline = true;
            TbInfo.Name = "TbInfo";
            TbInfo.ReadOnly = true;
            TbInfo.Size = new Size(509, 245);
            TbInfo.TabIndex = 0;
            TbInfo.TextChanged += textBox1_TextChanged;
            // 
            // BuConfirm
            // 
            BuConfirm.Location = new Point(260, 306);
            BuConfirm.Margin = new Padding(2, 3, 2, 3);
            BuConfirm.Name = "BuConfirm";
            BuConfirm.Size = new Size(79, 31);
            BuConfirm.TabIndex = 1;
            BuConfirm.Text = "确定";
            BuConfirm.UseVisualStyleBackColor = true;
            BuConfirm.Click += button1_Click;
            // 
            // RegistInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 382);
            Controls.Add(BuConfirm);
            Controls.Add(TbInfo);
            Margin = new Padding(2, 3, 2, 3);
            Name = "RegistInformation";
            Text = "RegistInformation";
            Load += RegistInformation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TbInfo;
        private Button BuConfirm;
    }
}
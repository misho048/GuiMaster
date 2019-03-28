namespace Gui_Master
{
    partial class Form1
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
            this.txtText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FontChanger = new System.Windows.Forms.GroupBox();
            this.radioButtonMSSerif = new System.Windows.Forms.RadioButton();
            this.radioButtonArial = new System.Windows.Forms.RadioButton();
            this.radioButtonComicSans = new System.Windows.Forms.RadioButton();
            this.textBoxFontSize = new System.Windows.Forms.TextBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.checkBoxReadOnly = new System.Windows.Forms.CheckBox();
            this.groupBoxDock = new System.Windows.Forms.GroupBox();
            this.radioButtonLeft = new System.Windows.Forms.RadioButton();
            this.radioButtonTop = new System.Windows.Forms.RadioButton();
            this.radioButtonRight = new System.Windows.Forms.RadioButton();
            this.radioButtonBottom = new System.Windows.Forms.RadioButton();
            this.radioButtonNone = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxEnabled = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelMousePointer = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonListBox = new System.Windows.Forms.Button();
            this.labelListBox = new System.Windows.Forms.Label();
            this.FontChanger.SuspendLayout();
            this.groupBoxDock.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText.Location = new System.Drawing.Point(9, 0);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(307, 228);
            this.txtText.TabIndex = 0;
            this.txtText.TextChanged += new System.EventHandler(this.Form1_Load);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(733, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // FontChanger
            // 
            this.FontChanger.Controls.Add(this.radioButtonComicSans);
            this.FontChanger.Controls.Add(this.radioButtonArial);
            this.FontChanger.Controls.Add(this.radioButtonMSSerif);
            this.FontChanger.Location = new System.Drawing.Point(353, 55);
            this.FontChanger.Name = "FontChanger";
            this.FontChanger.Size = new System.Drawing.Size(319, 69);
            this.FontChanger.TabIndex = 2;
            this.FontChanger.TabStop = false;
            this.FontChanger.Text = "Change Font";
            // 
            // radioButtonMSSerif
            // 
            this.radioButtonMSSerif.AutoSize = true;
            this.radioButtonMSSerif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonMSSerif.Location = new System.Drawing.Point(6, 29);
            this.radioButtonMSSerif.Name = "radioButtonMSSerif";
            this.radioButtonMSSerif.Size = new System.Drawing.Size(144, 20);
            this.radioButtonMSSerif.TabIndex = 0;
            this.radioButtonMSSerif.TabStop = true;
            this.radioButtonMSSerif.Text = "Microsoft Sans Serif";
            this.radioButtonMSSerif.UseVisualStyleBackColor = true;
            this.radioButtonMSSerif.CheckedChanged += new System.EventHandler(this.radioButtonMSSerif_CheckedChanged);
            // 
            // radioButtonArial
            // 
            this.radioButtonArial.AutoSize = true;
            this.radioButtonArial.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonArial.Location = new System.Drawing.Point(166, 29);
            this.radioButtonArial.Name = "radioButtonArial";
            this.radioButtonArial.Size = new System.Drawing.Size(47, 20);
            this.radioButtonArial.TabIndex = 1;
            this.radioButtonArial.TabStop = true;
            this.radioButtonArial.Text = "Arial";
            this.radioButtonArial.UseVisualStyleBackColor = true;
            this.radioButtonArial.CheckedChanged += new System.EventHandler(this.radioButtonArial_CheckedChanged);
            // 
            // radioButtonComicSans
            // 
            this.radioButtonComicSans.AutoSize = true;
            this.radioButtonComicSans.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonComicSans.Location = new System.Drawing.Point(219, 27);
            this.radioButtonComicSans.Name = "radioButtonComicSans";
            this.radioButtonComicSans.Size = new System.Drawing.Size(94, 22);
            this.radioButtonComicSans.TabIndex = 2;
            this.radioButtonComicSans.TabStop = true;
            this.radioButtonComicSans.Text = "Comic Sans";
            this.radioButtonComicSans.UseVisualStyleBackColor = true;
            this.radioButtonComicSans.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // textBoxFontSize
            // 
            this.textBoxFontSize.Location = new System.Drawing.Point(678, 85);
            this.textBoxFontSize.Name = "textBoxFontSize";
            this.textBoxFontSize.Size = new System.Drawing.Size(58, 20);
            this.textBoxFontSize.TabIndex = 3;
            this.textBoxFontSize.TextChanged += new System.EventHandler(this.textBoxFontSize_TextChanged);
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "Black",
            "Green",
            "Darkblue",
            "Red",
            "Purple",
            "Brown"});
            this.comboBoxColor.Location = new System.Drawing.Point(353, 143);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(163, 21);
            this.comboBoxColor.TabIndex = 4;
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBoxReadOnly
            // 
            this.checkBoxReadOnly.AutoSize = true;
            this.checkBoxReadOnly.Location = new System.Drawing.Point(584, 144);
            this.checkBoxReadOnly.Name = "checkBoxReadOnly";
            this.checkBoxReadOnly.Size = new System.Drawing.Size(76, 17);
            this.checkBoxReadOnly.TabIndex = 5;
            this.checkBoxReadOnly.Text = "Read Only";
            this.checkBoxReadOnly.UseVisualStyleBackColor = true;
            this.checkBoxReadOnly.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBoxDock
            // 
            this.groupBoxDock.Controls.Add(this.radioButtonNone);
            this.groupBoxDock.Controls.Add(this.radioButtonBottom);
            this.groupBoxDock.Controls.Add(this.radioButtonRight);
            this.groupBoxDock.Controls.Add(this.radioButtonTop);
            this.groupBoxDock.Controls.Add(this.radioButtonLeft);
            this.groupBoxDock.Location = new System.Drawing.Point(358, 195);
            this.groupBoxDock.Name = "groupBoxDock";
            this.groupBoxDock.Size = new System.Drawing.Size(404, 93);
            this.groupBoxDock.TabIndex = 6;
            this.groupBoxDock.TabStop = false;
            this.groupBoxDock.Text = "Dock";
            // 
            // radioButtonLeft
            // 
            this.radioButtonLeft.AutoSize = true;
            this.radioButtonLeft.Location = new System.Drawing.Point(35, 25);
            this.radioButtonLeft.Name = "radioButtonLeft";
            this.radioButtonLeft.Size = new System.Drawing.Size(43, 17);
            this.radioButtonLeft.TabIndex = 0;
            this.radioButtonLeft.TabStop = true;
            this.radioButtonLeft.Text = "Left";
            this.radioButtonLeft.UseVisualStyleBackColor = true;
            this.radioButtonLeft.CheckedChanged += new System.EventHandler(this.radioButtonLeft_CheckedChanged);
            // 
            // radioButtonTop
            // 
            this.radioButtonTop.AutoSize = true;
            this.radioButtonTop.Location = new System.Drawing.Point(148, 25);
            this.radioButtonTop.Name = "radioButtonTop";
            this.radioButtonTop.Size = new System.Drawing.Size(44, 17);
            this.radioButtonTop.TabIndex = 1;
            this.radioButtonTop.TabStop = true;
            this.radioButtonTop.Text = "Top";
            this.radioButtonTop.UseVisualStyleBackColor = true;
            this.radioButtonTop.CheckedChanged += new System.EventHandler(this.radioButtonTop_CheckedChanged);
            // 
            // radioButtonRight
            // 
            this.radioButtonRight.AutoSize = true;
            this.radioButtonRight.Location = new System.Drawing.Point(269, 25);
            this.radioButtonRight.Name = "radioButtonRight";
            this.radioButtonRight.Size = new System.Drawing.Size(50, 17);
            this.radioButtonRight.TabIndex = 2;
            this.radioButtonRight.TabStop = true;
            this.radioButtonRight.Text = "Right";
            this.radioButtonRight.UseVisualStyleBackColor = true;
            this.radioButtonRight.CheckedChanged += new System.EventHandler(this.radioButtonRight_CheckedChanged);
            // 
            // radioButtonBottom
            // 
            this.radioButtonBottom.AutoSize = true;
            this.radioButtonBottom.Location = new System.Drawing.Point(73, 63);
            this.radioButtonBottom.Name = "radioButtonBottom";
            this.radioButtonBottom.Size = new System.Drawing.Size(58, 17);
            this.radioButtonBottom.TabIndex = 3;
            this.radioButtonBottom.TabStop = true;
            this.radioButtonBottom.Text = "Bottom";
            this.radioButtonBottom.UseVisualStyleBackColor = true;
            this.radioButtonBottom.CheckedChanged += new System.EventHandler(this.radioButtonBottom_CheckedChanged);
            // 
            // radioButtonNone
            // 
            this.radioButtonNone.AutoSize = true;
            this.radioButtonNone.Location = new System.Drawing.Point(214, 63);
            this.radioButtonNone.Name = "radioButtonNone";
            this.radioButtonNone.Size = new System.Drawing.Size(51, 17);
            this.radioButtonNone.TabIndex = 4;
            this.radioButtonNone.TabStop = true;
            this.radioButtonNone.Text = "None";
            this.radioButtonNone.UseVisualStyleBackColor = true;
            this.radioButtonNone.CheckedChanged += new System.EventHandler(this.radioButtonNone_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtText);
            this.panel1.Location = new System.Drawing.Point(3, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 266);
            this.panel1.TabIndex = 7;
            // 
            // checkBoxEnabled
            // 
            this.checkBoxEnabled.AutoSize = true;
            this.checkBoxEnabled.Location = new System.Drawing.Point(584, 172);
            this.checkBoxEnabled.Name = "checkBoxEnabled";
            this.checkBoxEnabled.Size = new System.Drawing.Size(68, 17);
            this.checkBoxEnabled.TabIndex = 8;
            this.checkBoxEnabled.Text = "!Enabled";
            this.checkBoxEnabled.UseVisualStyleBackColor = true;
            this.checkBoxEnabled.CheckedChanged += new System.EventHandler(this.checkBoxEnabled_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 136);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(14, 457);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(304, 62);
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(612, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 133);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            this.panel2.MouseHover += new System.EventHandler(this.panel2_MouseHover);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // labelMousePointer
            // 
            this.labelMousePointer.AutoSize = true;
            this.labelMousePointer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMousePointer.Location = new System.Drawing.Point(616, 482);
            this.labelMousePointer.Name = "labelMousePointer";
            this.labelMousePointer.Size = new System.Drawing.Size(0, 24);
            this.labelMousePointer.TabIndex = 12;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(367, 304);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(121, 212);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonListBox
            // 
            this.buttonListBox.Location = new System.Drawing.Point(510, 314);
            this.buttonListBox.Name = "buttonListBox";
            this.buttonListBox.Size = new System.Drawing.Size(84, 36);
            this.buttonListBox.TabIndex = 14;
            this.buttonListBox.Text = "Show Words";
            this.buttonListBox.UseVisualStyleBackColor = true;
            this.buttonListBox.Click += new System.EventHandler(this.buttonListBox_Click);
            // 
            // labelListBox
            // 
            this.labelListBox.AutoSize = true;
            this.labelListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelListBox.Location = new System.Drawing.Point(503, 367);
            this.labelListBox.Name = "labelListBox";
            this.labelListBox.Size = new System.Drawing.Size(0, 16);
            this.labelListBox.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.labelListBox);
            this.Controls.Add(this.buttonListBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelMousePointer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBoxEnabled);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxDock);
            this.Controls.Add(this.checkBoxReadOnly);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.textBoxFontSize);
            this.Controls.Add(this.FontChanger);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FontChanger.ResumeLayout(false);
            this.FontChanger.PerformLayout();
            this.groupBoxDock.ResumeLayout(false);
            this.groupBoxDock.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox FontChanger;
        private System.Windows.Forms.RadioButton radioButtonComicSans;
        private System.Windows.Forms.RadioButton radioButtonArial;
        private System.Windows.Forms.RadioButton radioButtonMSSerif;
        private System.Windows.Forms.TextBox textBoxFontSize;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.CheckBox checkBoxReadOnly;
        private System.Windows.Forms.GroupBox groupBoxDock;
        private System.Windows.Forms.RadioButton radioButtonNone;
        private System.Windows.Forms.RadioButton radioButtonBottom;
        private System.Windows.Forms.RadioButton radioButtonRight;
        private System.Windows.Forms.RadioButton radioButtonTop;
        private System.Windows.Forms.RadioButton radioButtonLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxEnabled;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelMousePointer;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonListBox;
        private System.Windows.Forms.Label labelListBox;
    }
}


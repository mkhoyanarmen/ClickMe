namespace ClickMe
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbGameArena = new System.Windows.Forms.GroupBox();
            this.btnClickMe = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstPoints = new System.Windows.Forms.ListBox();
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.lblblblb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trcButtonSize = new System.Windows.Forms.TrackBar();
            this.lblBtnSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProgSec = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnResults = new System.Windows.Forms.Button();
            this.gbGameArena.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trcButtonSize)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGameArena
            // 
            this.gbGameArena.Controls.Add(this.btnClickMe);
            this.gbGameArena.Enabled = false;
            this.gbGameArena.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbGameArena.Location = new System.Drawing.Point(12, 12);
            this.gbGameArena.Name = "gbGameArena";
            this.gbGameArena.Size = new System.Drawing.Size(347, 432);
            this.gbGameArena.TabIndex = 0;
            this.gbGameArena.TabStop = false;
            this.gbGameArena.Text = "Game Arena";
            // 
            // btnClickMe
            // 
            this.btnClickMe.Location = new System.Drawing.Point(100, 150);
            this.btnClickMe.MaximumSize = new System.Drawing.Size(300, 240);
            this.btnClickMe.MinimumSize = new System.Drawing.Size(60, 25);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(60, 25);
            this.btnClickMe.TabIndex = 0;
            this.btnClickMe.Text = "Click Me";
            this.btnClickMe.UseVisualStyleBackColor = true;
            this.btnClickMe.Click += new System.EventHandler(this.btnClickMe_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstPoints);
            this.groupBox4.Controls.Add(this.lstPlayers);
            this.groupBox4.Location = new System.Drawing.Point(372, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(228, 432);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Top 10 High Scores";
            // 
            // lstPoints
            // 
            this.lstPoints.BackColor = System.Drawing.SystemColors.Menu;
            this.lstPoints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPoints.Cursor = System.Windows.Forms.Cursors.No;
            this.lstPoints.Enabled = false;
            this.lstPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstPoints.FormattingEnabled = true;
            this.lstPoints.ItemHeight = 18;
            this.lstPoints.Location = new System.Drawing.Point(173, 24);
            this.lstPoints.Name = "lstPoints";
            this.lstPoints.Size = new System.Drawing.Size(48, 396);
            this.lstPoints.TabIndex = 56;
            // 
            // lstPlayers
            // 
            this.lstPlayers.BackColor = System.Drawing.SystemColors.Menu;
            this.lstPlayers.Cursor = System.Windows.Forms.Cursors.No;
            this.lstPlayers.Enabled = false;
            this.lstPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.ItemHeight = 18;
            this.lstPlayers.Location = new System.Drawing.Point(6, 21);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(216, 400);
            this.lstPlayers.TabIndex = 55;
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.txtPlayerName);
            this.gbSettings.Controls.Add(this.label3);
            this.gbSettings.Controls.Add(this.btnAccept);
            this.gbSettings.Controls.Add(this.btnDefault);
            this.gbSettings.Controls.Add(this.txtSeconds);
            this.gbSettings.Controls.Add(this.lblblblb);
            this.gbSettings.Controls.Add(this.label2);
            this.gbSettings.Controls.Add(this.trcButtonSize);
            this.gbSettings.Controls.Add(this.lblBtnSize);
            this.gbSettings.Controls.Add(this.label1);
            this.gbSettings.Location = new System.Drawing.Point(604, 126);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(223, 228);
            this.gbSettings.TabIndex = 5;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPlayerName.Location = new System.Drawing.Point(96, 27);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(121, 22);
            this.txtPlayerName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Your name:";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(31, 185);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(113, 185);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(75, 23);
            this.btnDefault.TabIndex = 4;
            this.btnDefault.Text = "Default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // txtSeconds
            // 
            this.txtSeconds.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSeconds.Location = new System.Drawing.Point(96, 141);
            this.txtSeconds.MaxLength = 2;
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(34, 22);
            this.txtSeconds.TabIndex = 2;
            this.txtSeconds.Text = "10";
            this.txtSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblblblb
            // 
            this.lblblblb.AutoSize = true;
            this.lblblblb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblblblb.Location = new System.Drawing.Point(134, 141);
            this.lblblblb.Name = "lblblblb";
            this.lblblblb.Size = new System.Drawing.Size(16, 18);
            this.lblblblb.TabIndex = 5;
            this.lblblblb.Text = "s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Game time:";
            // 
            // trcButtonSize
            // 
            this.trcButtonSize.BackColor = System.Drawing.SystemColors.Control;
            this.trcButtonSize.Location = new System.Drawing.Point(37, 80);
            this.trcButtonSize.Maximum = 9;
            this.trcButtonSize.Minimum = 1;
            this.trcButtonSize.Name = "trcButtonSize";
            this.trcButtonSize.Size = new System.Drawing.Size(133, 56);
            this.trcButtonSize.TabIndex = 56;
            this.trcButtonSize.Value = 1;
            this.trcButtonSize.Scroll += new System.EventHandler(this.trcButtonSize_Scroll);
            // 
            // lblBtnSize
            // 
            this.lblBtnSize.AutoSize = true;
            this.lblBtnSize.Location = new System.Drawing.Point(97, 57);
            this.lblBtnSize.Name = "lblBtnSize";
            this.lblBtnSize.Size = new System.Drawing.Size(0, 16);
            this.lblBtnSize.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Button Size:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(604, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 112);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "How to play?";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(6, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 78);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Click the button in the Game Arena to get points(p). Get as many points as possib" +
    "le. You have a few seconds to do it.";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 464);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Minimum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(347, 30);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Value = 10;
            // 
            // lblProgSec
            // 
            this.lblProgSec.AutoSize = true;
            this.lblProgSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProgSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProgSec.Location = new System.Drawing.Point(368, 469);
            this.lblProgSec.Name = "lblProgSec";
            this.lblProgSec.Size = new System.Drawing.Size(29, 20);
            this.lblProgSec.TabIndex = 7;
            this.lblProgSec.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(396, 469);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "s";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(431, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Points:";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPoints.Location = new System.Drawing.Point(505, 469);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(0, 20);
            this.lblPoints.TabIndex = 10;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(610, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 65);
            this.button1.TabIndex = 11;
            this.button1.Text = "Start Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnResults
            // 
            this.btnResults.Location = new System.Drawing.Point(525, 439);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(75, 23);
            this.btnResults.TabIndex = 12;
            this.btnResults.Text = "Results";
            this.btnResults.UseVisualStyleBackColor = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 525);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblProgSec);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbGameArena);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Click Me";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbGameArena.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trcButtonSize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGameArena;
        private System.Windows.Forms.Button btnClickMe;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstPlayers;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.Label lblblblb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trcButtonSize;
        private System.Windows.Forms.Label lblBtnSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblProgSec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstPoints;
        private System.Windows.Forms.Button btnResults;
    }
}


namespace ConnectFourUI
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
            lblDisplay = new Label();
            btnReset = new Button();
            btnP1 = new Button();
            btn00 = new Button();
            btn10 = new Button();
            btn20 = new Button();
            btn30 = new Button();
            btn40 = new Button();
            btn50 = new Button();
            btn60 = new Button();
            btn61 = new Button();
            btn51 = new Button();
            btn41 = new Button();
            btn31 = new Button();
            btn21 = new Button();
            btn11 = new Button();
            btn01 = new Button();
            btn62 = new Button();
            btn52 = new Button();
            btn42 = new Button();
            btn32 = new Button();
            btn22 = new Button();
            btn12 = new Button();
            btn02 = new Button();
            btn63 = new Button();
            btn53 = new Button();
            btn43 = new Button();
            btn33 = new Button();
            btn23 = new Button();
            btn13 = new Button();
            btn03 = new Button();
            btn64 = new Button();
            btn54 = new Button();
            btn44 = new Button();
            btn34 = new Button();
            btn24 = new Button();
            btn14 = new Button();
            btn04 = new Button();
            btn65 = new Button();
            btn55 = new Button();
            btn45 = new Button();
            btn35 = new Button();
            btn25 = new Button();
            btn15 = new Button();
            btn05 = new Button();
            btnControl6 = new Button();
            btnControl5 = new Button();
            btnControl4 = new Button();
            btnControl2 = new Button();
            btnControl1 = new Button();
            btnControl0 = new Button();
            btnP2 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnControl3 = new Button();
            SuspendLayout();
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.Font = new Font("Segoe UI", 22F);
            lblDisplay.Location = new Point(135, 469);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(97, 41);
            lblDisplay.TabIndex = 59;
            lblDisplay.Text = "label1";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(135, 513);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(414, 23);
            btnReset.TabIndex = 60;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnP1
            // 
            btnP1.AllowDrop = true;
            btnP1.BackColor = Color.Red;
            btnP1.ForeColor = SystemColors.ControlText;
            btnP1.Location = new Point(15, 106);
            btnP1.Name = "btnP1";
            btnP1.Size = new Size(54, 55);
            btnP1.TabIndex = 61;
            btnP1.Text = "P1";
            btnP1.UseVisualStyleBackColor = false;
            btnP1.Click += btn_Click;
            btnP1.MouseDown += btnDrag_MouseDown;
            // 
            // btn00
            // 
            btn00.Enabled = false;
            btn00.Location = new Point(135, 106);
            btn00.Name = "btn00";
            btn00.Size = new Size(54, 55);
            btn00.TabIndex = 62;
            btn00.UseVisualStyleBackColor = true;
            // 
            // btn10
            // 
            btn10.Enabled = false;
            btn10.Location = new Point(195, 106);
            btn10.Name = "btn10";
            btn10.Size = new Size(54, 55);
            btn10.TabIndex = 63;
            btn10.UseVisualStyleBackColor = true;
            // 
            // btn20
            // 
            btn20.Enabled = false;
            btn20.Location = new Point(255, 106);
            btn20.Name = "btn20";
            btn20.Size = new Size(54, 55);
            btn20.TabIndex = 64;
            btn20.UseVisualStyleBackColor = true;
            // 
            // btn30
            // 
            btn30.Enabled = false;
            btn30.Location = new Point(315, 106);
            btn30.Name = "btn30";
            btn30.Size = new Size(54, 55);
            btn30.TabIndex = 65;
            btn30.UseVisualStyleBackColor = true;
            // 
            // btn40
            // 
            btn40.Enabled = false;
            btn40.Location = new Point(375, 106);
            btn40.Name = "btn40";
            btn40.Size = new Size(54, 55);
            btn40.TabIndex = 66;
            btn40.UseVisualStyleBackColor = true;
            // 
            // btn50
            // 
            btn50.Enabled = false;
            btn50.Location = new Point(435, 106);
            btn50.Name = "btn50";
            btn50.Size = new Size(54, 55);
            btn50.TabIndex = 67;
            btn50.UseVisualStyleBackColor = true;
            // 
            // btn60
            // 
            btn60.Enabled = false;
            btn60.Location = new Point(495, 106);
            btn60.Name = "btn60";
            btn60.Size = new Size(54, 55);
            btn60.TabIndex = 68;
            btn60.UseVisualStyleBackColor = true;
            // 
            // btn61
            // 
            btn61.Enabled = false;
            btn61.Location = new Point(495, 167);
            btn61.Name = "btn61";
            btn61.Size = new Size(54, 55);
            btn61.TabIndex = 75;
            btn61.UseVisualStyleBackColor = true;
            // 
            // btn51
            // 
            btn51.Enabled = false;
            btn51.Location = new Point(435, 167);
            btn51.Name = "btn51";
            btn51.Size = new Size(54, 55);
            btn51.TabIndex = 74;
            btn51.UseVisualStyleBackColor = true;
            // 
            // btn41
            // 
            btn41.Enabled = false;
            btn41.Location = new Point(375, 167);
            btn41.Name = "btn41";
            btn41.Size = new Size(54, 55);
            btn41.TabIndex = 73;
            btn41.UseVisualStyleBackColor = true;
            // 
            // btn31
            // 
            btn31.Enabled = false;
            btn31.Location = new Point(315, 167);
            btn31.Name = "btn31";
            btn31.Size = new Size(54, 55);
            btn31.TabIndex = 72;
            btn31.UseVisualStyleBackColor = true;
            // 
            // btn21
            // 
            btn21.Enabled = false;
            btn21.Location = new Point(255, 167);
            btn21.Name = "btn21";
            btn21.Size = new Size(54, 55);
            btn21.TabIndex = 71;
            btn21.UseVisualStyleBackColor = true;
            // 
            // btn11
            // 
            btn11.Enabled = false;
            btn11.Location = new Point(195, 167);
            btn11.Name = "btn11";
            btn11.Size = new Size(54, 55);
            btn11.TabIndex = 70;
            btn11.UseVisualStyleBackColor = true;
            // 
            // btn01
            // 
            btn01.Enabled = false;
            btn01.Location = new Point(135, 167);
            btn01.Name = "btn01";
            btn01.Size = new Size(54, 55);
            btn01.TabIndex = 69;
            btn01.UseVisualStyleBackColor = true;
            // 
            // btn62
            // 
            btn62.Enabled = false;
            btn62.Location = new Point(495, 228);
            btn62.Name = "btn62";
            btn62.Size = new Size(54, 55);
            btn62.TabIndex = 82;
            btn62.UseVisualStyleBackColor = true;
            // 
            // btn52
            // 
            btn52.Enabled = false;
            btn52.Location = new Point(435, 228);
            btn52.Name = "btn52";
            btn52.Size = new Size(54, 55);
            btn52.TabIndex = 81;
            btn52.UseVisualStyleBackColor = true;
            // 
            // btn42
            // 
            btn42.Enabled = false;
            btn42.Location = new Point(375, 228);
            btn42.Name = "btn42";
            btn42.Size = new Size(54, 55);
            btn42.TabIndex = 80;
            btn42.UseVisualStyleBackColor = true;
            // 
            // btn32
            // 
            btn32.Enabled = false;
            btn32.Location = new Point(315, 228);
            btn32.Name = "btn32";
            btn32.Size = new Size(54, 55);
            btn32.TabIndex = 79;
            btn32.UseVisualStyleBackColor = true;
            // 
            // btn22
            // 
            btn22.Enabled = false;
            btn22.Location = new Point(255, 228);
            btn22.Name = "btn22";
            btn22.Size = new Size(54, 55);
            btn22.TabIndex = 78;
            btn22.UseVisualStyleBackColor = true;
            // 
            // btn12
            // 
            btn12.Enabled = false;
            btn12.Location = new Point(195, 228);
            btn12.Name = "btn12";
            btn12.Size = new Size(54, 55);
            btn12.TabIndex = 77;
            btn12.UseVisualStyleBackColor = true;
            // 
            // btn02
            // 
            btn02.Enabled = false;
            btn02.Location = new Point(135, 228);
            btn02.Name = "btn02";
            btn02.Size = new Size(54, 55);
            btn02.TabIndex = 76;
            btn02.UseVisualStyleBackColor = true;
            // 
            // btn63
            // 
            btn63.Enabled = false;
            btn63.Location = new Point(495, 289);
            btn63.Name = "btn63";
            btn63.Size = new Size(54, 55);
            btn63.TabIndex = 89;
            btn63.UseVisualStyleBackColor = true;
            // 
            // btn53
            // 
            btn53.Enabled = false;
            btn53.Location = new Point(435, 289);
            btn53.Name = "btn53";
            btn53.Size = new Size(54, 55);
            btn53.TabIndex = 88;
            btn53.UseVisualStyleBackColor = true;
            // 
            // btn43
            // 
            btn43.Enabled = false;
            btn43.Location = new Point(375, 289);
            btn43.Name = "btn43";
            btn43.Size = new Size(54, 55);
            btn43.TabIndex = 87;
            btn43.UseVisualStyleBackColor = true;
            // 
            // btn33
            // 
            btn33.Enabled = false;
            btn33.Location = new Point(315, 289);
            btn33.Name = "btn33";
            btn33.Size = new Size(54, 55);
            btn33.TabIndex = 86;
            btn33.UseVisualStyleBackColor = true;
            // 
            // btn23
            // 
            btn23.Enabled = false;
            btn23.Location = new Point(255, 289);
            btn23.Name = "btn23";
            btn23.Size = new Size(54, 55);
            btn23.TabIndex = 85;
            btn23.UseVisualStyleBackColor = true;
            // 
            // btn13
            // 
            btn13.Enabled = false;
            btn13.Location = new Point(195, 289);
            btn13.Name = "btn13";
            btn13.Size = new Size(54, 55);
            btn13.TabIndex = 84;
            btn13.UseVisualStyleBackColor = true;
            // 
            // btn03
            // 
            btn03.Enabled = false;
            btn03.Location = new Point(135, 289);
            btn03.Name = "btn03";
            btn03.Size = new Size(54, 55);
            btn03.TabIndex = 83;
            btn03.UseVisualStyleBackColor = true;
            // 
            // btn64
            // 
            btn64.Enabled = false;
            btn64.Location = new Point(495, 350);
            btn64.Name = "btn64";
            btn64.Size = new Size(54, 55);
            btn64.TabIndex = 96;
            btn64.UseVisualStyleBackColor = true;
            // 
            // btn54
            // 
            btn54.Enabled = false;
            btn54.Location = new Point(435, 350);
            btn54.Name = "btn54";
            btn54.Size = new Size(54, 55);
            btn54.TabIndex = 95;
            btn54.UseVisualStyleBackColor = true;
            // 
            // btn44
            // 
            btn44.Enabled = false;
            btn44.Location = new Point(375, 350);
            btn44.Name = "btn44";
            btn44.Size = new Size(54, 55);
            btn44.TabIndex = 94;
            btn44.UseVisualStyleBackColor = true;
            // 
            // btn34
            // 
            btn34.Enabled = false;
            btn34.Location = new Point(315, 350);
            btn34.Name = "btn34";
            btn34.Size = new Size(54, 55);
            btn34.TabIndex = 93;
            btn34.UseVisualStyleBackColor = true;
            // 
            // btn24
            // 
            btn24.Enabled = false;
            btn24.Location = new Point(255, 350);
            btn24.Name = "btn24";
            btn24.Size = new Size(54, 55);
            btn24.TabIndex = 92;
            btn24.UseVisualStyleBackColor = true;
            // 
            // btn14
            // 
            btn14.Enabled = false;
            btn14.Location = new Point(195, 350);
            btn14.Name = "btn14";
            btn14.Size = new Size(54, 55);
            btn14.TabIndex = 91;
            btn14.UseVisualStyleBackColor = true;
            // 
            // btn04
            // 
            btn04.Enabled = false;
            btn04.Location = new Point(135, 350);
            btn04.Name = "btn04";
            btn04.Size = new Size(54, 55);
            btn04.TabIndex = 90;
            btn04.UseVisualStyleBackColor = true;
            // 
            // btn65
            // 
            btn65.Enabled = false;
            btn65.Location = new Point(495, 411);
            btn65.Name = "btn65";
            btn65.Size = new Size(54, 55);
            btn65.TabIndex = 103;
            btn65.UseVisualStyleBackColor = true;
            // 
            // btn55
            // 
            btn55.Enabled = false;
            btn55.Location = new Point(435, 411);
            btn55.Name = "btn55";
            btn55.Size = new Size(54, 55);
            btn55.TabIndex = 102;
            btn55.UseVisualStyleBackColor = true;
            // 
            // btn45
            // 
            btn45.Enabled = false;
            btn45.Location = new Point(375, 411);
            btn45.Name = "btn45";
            btn45.Size = new Size(54, 55);
            btn45.TabIndex = 101;
            btn45.UseVisualStyleBackColor = true;
            // 
            // btn35
            // 
            btn35.Enabled = false;
            btn35.Location = new Point(315, 411);
            btn35.Name = "btn35";
            btn35.Size = new Size(54, 55);
            btn35.TabIndex = 100;
            btn35.UseVisualStyleBackColor = true;
            // 
            // btn25
            // 
            btn25.Enabled = false;
            btn25.Location = new Point(255, 411);
            btn25.Name = "btn25";
            btn25.Size = new Size(54, 55);
            btn25.TabIndex = 99;
            btn25.UseVisualStyleBackColor = true;
            // 
            // btn15
            // 
            btn15.Enabled = false;
            btn15.Location = new Point(195, 411);
            btn15.Name = "btn15";
            btn15.Size = new Size(54, 55);
            btn15.TabIndex = 98;
            btn15.UseVisualStyleBackColor = true;
            // 
            // btn05
            // 
            btn05.Enabled = false;
            btn05.Location = new Point(135, 411);
            btn05.Name = "btn05";
            btn05.Size = new Size(54, 55);
            btn05.TabIndex = 97;
            btn05.UseVisualStyleBackColor = true;
            // 
            // btnControl6
            // 
            btnControl6.AllowDrop = true;
            btnControl6.Location = new Point(495, 12);
            btnControl6.Name = "btnControl6";
            btnControl6.Size = new Size(54, 55);
            btnControl6.TabIndex = 117;
            btnControl6.Text = "7";
            btnControl6.UseVisualStyleBackColor = true;
            btnControl6.DragDrop += btnControl6_DragDrop;
            btnControl6.DragEnter += btnControl6_DragEnter;
            // 
            // btnControl5
            // 
            btnControl5.AllowDrop = true;
            btnControl5.Location = new Point(435, 12);
            btnControl5.Name = "btnControl5";
            btnControl5.Size = new Size(54, 55);
            btnControl5.TabIndex = 116;
            btnControl5.Text = "6";
            btnControl5.UseVisualStyleBackColor = true;
            btnControl5.DragDrop += btnControl5_DragDrop;
            btnControl5.DragEnter += btnControl5_DragEnter;
            // 
            // btnControl4
            // 
            btnControl4.AllowDrop = true;
            btnControl4.Location = new Point(375, 12);
            btnControl4.Name = "btnControl4";
            btnControl4.Size = new Size(54, 55);
            btnControl4.TabIndex = 115;
            btnControl4.Text = "5";
            btnControl4.UseVisualStyleBackColor = true;
            btnControl4.DragDrop += btnControl4_DragDrop;
            btnControl4.DragEnter += btnControl4_DragEnter;
            // 
            // btnControl2
            // 
            btnControl2.AllowDrop = true;
            btnControl2.Location = new Point(255, 12);
            btnControl2.Name = "btnControl2";
            btnControl2.Size = new Size(54, 55);
            btnControl2.TabIndex = 113;
            btnControl2.Text = "3";
            btnControl2.UseVisualStyleBackColor = true;
            btnControl2.DragDrop += btnControl2_DragDrop;
            btnControl2.DragEnter += btnControl2_DragEnter;
            // 
            // btnControl1
            // 
            btnControl1.AllowDrop = true;
            btnControl1.Location = new Point(195, 12);
            btnControl1.Name = "btnControl1";
            btnControl1.Size = new Size(54, 55);
            btnControl1.TabIndex = 112;
            btnControl1.Text = "2";
            btnControl1.UseVisualStyleBackColor = true;
            btnControl1.DragDrop += btnControl1_DragDrop;
            btnControl1.DragEnter += btnControl1_DragEnter;
            // 
            // btnControl0
            // 
            btnControl0.AllowDrop = true;
            btnControl0.Location = new Point(135, 12);
            btnControl0.Name = "btnControl0";
            btnControl0.Size = new Size(54, 55);
            btnControl0.TabIndex = 111;
            btnControl0.Text = "1";
            btnControl0.UseVisualStyleBackColor = true;
            btnControl0.DragDrop += btnControl0_DragDrop;
            btnControl0.DragEnter += btnControl0_DragEnter;
            // 
            // btnP2
            // 
            btnP2.BackColor = Color.Blue;
            btnP2.Location = new Point(612, 106);
            btnP2.Name = "btnP2";
            btnP2.Size = new Size(54, 55);
            btnP2.TabIndex = 118;
            btnP2.Text = "P2";
            btnP2.UseVisualStyleBackColor = false;
            btnP2.Click += btn_Click;
            btnP2.MouseDown += btnDrag_MouseDown;
            // 
            // btnControl3
            // 
            btnControl3.AllowDrop = true;
            btnControl3.Location = new Point(315, 12);
            btnControl3.Name = "btnControl3";
            btnControl3.Size = new Size(54, 55);
            btnControl3.TabIndex = 114;
            btnControl3.Text = "4";
            btnControl3.UseVisualStyleBackColor = true;
            btnControl3.DragDrop += btnControl3_DragDrop;
            btnControl3.DragEnter += btnControl3_DragEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 546);
            Controls.Add(btnP2);
            Controls.Add(btnControl6);
            Controls.Add(btnControl5);
            Controls.Add(btnControl4);
            Controls.Add(btnControl3);
            Controls.Add(btnControl2);
            Controls.Add(btnControl1);
            Controls.Add(btnControl0);
            Controls.Add(btn65);
            Controls.Add(btn55);
            Controls.Add(btn45);
            Controls.Add(btn35);
            Controls.Add(btn25);
            Controls.Add(btn15);
            Controls.Add(btn05);
            Controls.Add(btn64);
            Controls.Add(btn54);
            Controls.Add(btn44);
            Controls.Add(btn34);
            Controls.Add(btn24);
            Controls.Add(btn14);
            Controls.Add(btn04);
            Controls.Add(btn63);
            Controls.Add(btn53);
            Controls.Add(btn43);
            Controls.Add(btn33);
            Controls.Add(btn23);
            Controls.Add(btn13);
            Controls.Add(btn03);
            Controls.Add(btn62);
            Controls.Add(btn52);
            Controls.Add(btn42);
            Controls.Add(btn32);
            Controls.Add(btn22);
            Controls.Add(btn12);
            Controls.Add(btn02);
            Controls.Add(btn61);
            Controls.Add(btn51);
            Controls.Add(btn41);
            Controls.Add(btn31);
            Controls.Add(btn21);
            Controls.Add(btn11);
            Controls.Add(btn01);
            Controls.Add(btn60);
            Controls.Add(btn50);
            Controls.Add(btn40);
            Controls.Add(btn30);
            Controls.Add(btn20);
            Controls.Add(btn10);
            Controls.Add(btn00);
            Controls.Add(btnP1);
            Controls.Add(btnReset);
            Controls.Add(lblDisplay);
            Name = "Form1";
            Text = "Drag 'n' Drop Connect Four";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDisplay;
        private Button btnReset;
        private Button btnP1;
        private Button btn00;
        private Button btn10;
        private Button btn20;
        private Button btn30;
        private Button btn40;
        private Button btn50;
        private Button btn60;
        private Button btn61;
        private Button btn51;
        private Button btn41;
        private Button btn31;
        private Button btn21;
        private Button btn11;
        private Button btn01;
        private Button btn62;
        private Button btn52;
        private Button btn42;
        private Button btn32;
        private Button btn22;
        private Button btn12;
        private Button btn02;
        private Button btn63;
        private Button btn53;
        private Button btn43;
        private Button btn33;
        private Button btn23;
        private Button btn13;
        private Button btn03;
        private Button btn64;
        private Button btn54;
        private Button btn44;
        private Button btn34;
        private Button btn24;
        private Button btn14;
        private Button btn04;
        private Button btn65;
        private Button btn55;
        private Button btn45;
        private Button btn35;
        private Button btn25;
        private Button btn15;
        private Button btn05;
        private Button btnControl6;
        private Button btnControl5;
        private Button btnControl4;
        private Button btnControl2;
        private Button btnControl1;
        private Button btnControl0;
        private Button btnP2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnControl3;
    }
}

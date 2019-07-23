namespace Lift_Assignment_1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_to_move_up = new System.Windows.Forms.Button();
            this.btn_to_move_down = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_G = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.lbl_display_floor = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.picBox_shaft = new System.Windows.Forms.PictureBox();
            this.picBox_cabin = new System.Windows.Forms.PictureBox();
            this.tmr_move_down_cabin = new System.Windows.Forms.Timer(this.components);
            this.tmr_move_up_cabin = new System.Windows.Forms.Timer(this.components);
            this.cabin_left_door = new System.Windows.Forms.PictureBox();
            this.cabin_right_door = new System.Windows.Forms.PictureBox();
            this.shaft_up_right_door = new System.Windows.Forms.PictureBox();
            this.shaft_up_left_door = new System.Windows.Forms.PictureBox();
            this.shaft_down_right_door = new System.Windows.Forms.PictureBox();
            this.shaft_down_left_door = new System.Windows.Forms.PictureBox();
            this.tmr_open_doors_G_floor = new System.Windows.Forms.Timer(this.components);
            this.tmr_close_doors_G_floor = new System.Windows.Forms.Timer(this.components);
            this.tmr_open_doors_1_floor = new System.Windows.Forms.Timer(this.components);
            this.tmr_close_doors_1_floor = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblExplain = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_delete_all = new System.Windows.Forms.Button();
            this.btn_display = new System.Windows.Forms.Button();
            this.lbl_action_display = new System.Windows.Forms.Label();
            this.lbl_user_guide = new System.Windows.Forms.Label();
            this.lbl_main = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_shaft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_cabin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabin_left_door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabin_right_door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shaft_up_right_door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shaft_up_left_door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shaft_down_right_door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shaft_down_left_door)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.btn_to_move_up);
            this.groupBox1.Controls.Add(this.btn_to_move_down);
            this.groupBox1.Location = new System.Drawing.Point(12, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(64, 137);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_to_move_up
            // 
            this.btn_to_move_up.BackColor = System.Drawing.Color.Transparent;
            this.btn_to_move_up.ForeColor = System.Drawing.Color.Black;
            this.btn_to_move_up.Image = ((System.Drawing.Image)(resources.GetObject("btn_to_move_up.Image")));
            this.btn_to_move_up.Location = new System.Drawing.Point(17, 19);
            this.btn_to_move_up.Name = "btn_to_move_up";
            this.btn_to_move_up.Size = new System.Drawing.Size(31, 30);
            this.btn_to_move_up.TabIndex = 1;
            this.btn_to_move_up.UseVisualStyleBackColor = false;
            this.btn_to_move_up.Click += new System.EventHandler(this.btn_to_moveUP_Click);
            // 
            // btn_to_move_down
            // 
            this.btn_to_move_down.BackColor = System.Drawing.Color.Transparent;
            this.btn_to_move_down.Image = ((System.Drawing.Image)(resources.GetObject("btn_to_move_down.Image")));
            this.btn_to_move_down.Location = new System.Drawing.Point(17, 73);
            this.btn_to_move_down.Name = "btn_to_move_down";
            this.btn_to_move_down.Size = new System.Drawing.Size(31, 32);
            this.btn_to_move_down.TabIndex = 0;
            this.btn_to_move_down.UseVisualStyleBackColor = false;
            this.btn_to_move_down.Click += new System.EventHandler(this.btn_to_moveDown_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.btn_G);
            this.groupBox2.Controls.Add(this.btn_1);
            this.groupBox2.Controls.Add(this.lbl_display_floor);
            this.groupBox2.Location = new System.Drawing.Point(581, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(61, 153);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_G
            // 
            this.btn_G.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_G.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_G.Location = new System.Drawing.Point(16, 97);
            this.btn_G.Name = "btn_G";
            this.btn_G.Size = new System.Drawing.Size(32, 23);
            this.btn_G.TabIndex = 2;
            this.btn_G.Text = "G";
            this.btn_G.UseVisualStyleBackColor = false;
            this.btn_G.Click += new System.EventHandler(this.btn_G_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(16, 57);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(31, 23);
            this.btn_1.TabIndex = 1;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // lbl_display_floor
            // 
            this.lbl_display_floor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_display_floor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_display_floor.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_display_floor.ForeColor = System.Drawing.Color.Lime;
            this.lbl_display_floor.Location = new System.Drawing.Point(12, 16);
            this.lbl_display_floor.Name = "lbl_display_floor";
            this.lbl_display_floor.Size = new System.Drawing.Size(35, 26);
            this.lbl_display_floor.TabIndex = 0;
            this.lbl_display_floor.Click += new System.EventHandler(this.lbl_display_floor_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBox1.Location = new System.Drawing.Point(648, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(325, 355);
            this.listBox1.TabIndex = 11;
            // 
            // picBox_shaft
            // 
            this.picBox_shaft.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.picBox_shaft.Location = new System.Drawing.Point(224, 12);
            this.picBox_shaft.Name = "picBox_shaft";
            this.picBox_shaft.Size = new System.Drawing.Size(224, 510);
            this.picBox_shaft.TabIndex = 12;
            this.picBox_shaft.TabStop = false;
            this.picBox_shaft.Click += new System.EventHandler(this.picBox_shaft_Click);
            // 
            // picBox_cabin
            // 
            this.picBox_cabin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.picBox_cabin.Location = new System.Drawing.Point(224, 12);
            this.picBox_cabin.Name = "picBox_cabin";
            this.picBox_cabin.Size = new System.Drawing.Size(224, 250);
            this.picBox_cabin.TabIndex = 13;
            this.picBox_cabin.TabStop = false;
            this.picBox_cabin.Click += new System.EventHandler(this.picBox_cabin_Click);
            // 
            // tmr_move_down_cabin
            // 
            this.tmr_move_down_cabin.Interval = 15;
            this.tmr_move_down_cabin.Tick += new System.EventHandler(this.tmr_move_down_cabin_Tick);
            // 
            // tmr_move_up_cabin
            // 
            this.tmr_move_up_cabin.Interval = 15;
            this.tmr_move_up_cabin.Tick += new System.EventHandler(this.tmr_move_up_cabin_Tick);
            // 
            // cabin_left_door
            // 
            this.cabin_left_door.BackColor = System.Drawing.Color.Yellow;
            this.cabin_left_door.Location = new System.Drawing.Point(224, 12);
            this.cabin_left_door.Name = "cabin_left_door";
            this.cabin_left_door.Size = new System.Drawing.Size(112, 250);
            this.cabin_left_door.TabIndex = 14;
            this.cabin_left_door.TabStop = false;
            this.cabin_left_door.Click += new System.EventHandler(this.cabin_left_door_Click);
            // 
            // cabin_right_door
            // 
            this.cabin_right_door.BackColor = System.Drawing.Color.Yellow;
            this.cabin_right_door.Location = new System.Drawing.Point(336, 12);
            this.cabin_right_door.Name = "cabin_right_door";
            this.cabin_right_door.Size = new System.Drawing.Size(112, 250);
            this.cabin_right_door.TabIndex = 15;
            this.cabin_right_door.TabStop = false;
            this.cabin_right_door.Click += new System.EventHandler(this.cabin_right_door_Click);
            // 
            // shaft_up_right_door
            // 
            this.shaft_up_right_door.BackColor = System.Drawing.SystemColors.Highlight;
            this.shaft_up_right_door.Location = new System.Drawing.Point(338, 12);
            this.shaft_up_right_door.Name = "shaft_up_right_door";
            this.shaft_up_right_door.Size = new System.Drawing.Size(110, 250);
            this.shaft_up_right_door.TabIndex = 17;
            this.shaft_up_right_door.TabStop = false;
            this.shaft_up_right_door.Click += new System.EventHandler(this.shaft_up_right_door_Click);
            // 
            // shaft_up_left_door
            // 
            this.shaft_up_left_door.BackColor = System.Drawing.SystemColors.Highlight;
            this.shaft_up_left_door.Location = new System.Drawing.Point(224, 12);
            this.shaft_up_left_door.Name = "shaft_up_left_door";
            this.shaft_up_left_door.Size = new System.Drawing.Size(110, 250);
            this.shaft_up_left_door.TabIndex = 18;
            this.shaft_up_left_door.TabStop = false;
            this.shaft_up_left_door.Click += new System.EventHandler(this.shaft_up_left_door_Click);
            // 
            // shaft_down_right_door
            // 
            this.shaft_down_right_door.BackColor = System.Drawing.SystemColors.Highlight;
            this.shaft_down_right_door.Location = new System.Drawing.Point(338, 272);
            this.shaft_down_right_door.Name = "shaft_down_right_door";
            this.shaft_down_right_door.Size = new System.Drawing.Size(110, 250);
            this.shaft_down_right_door.TabIndex = 19;
            this.shaft_down_right_door.TabStop = false;
            this.shaft_down_right_door.Click += new System.EventHandler(this.shaft_down_right_door_Click);
            // 
            // shaft_down_left_door
            // 
            this.shaft_down_left_door.BackColor = System.Drawing.SystemColors.Highlight;
            this.shaft_down_left_door.Location = new System.Drawing.Point(224, 272);
            this.shaft_down_left_door.Name = "shaft_down_left_door";
            this.shaft_down_left_door.Size = new System.Drawing.Size(110, 250);
            this.shaft_down_left_door.TabIndex = 20;
            this.shaft_down_left_door.TabStop = false;
            this.shaft_down_left_door.Click += new System.EventHandler(this.shaft_down_left_door_Click);
            // 
            // tmr_open_doors_G_floor
            // 
            this.tmr_open_doors_G_floor.Interval = 15;
            this.tmr_open_doors_G_floor.Tick += new System.EventHandler(this.tmr_open_doors_G_floor_Tick);
            // 
            // tmr_close_doors_G_floor
            // 
            this.tmr_close_doors_G_floor.Interval = 15;
            this.tmr_close_doors_G_floor.Tick += new System.EventHandler(this.tmr_close_doors_G_floor_Tick);
            // 
            // tmr_open_doors_1_floor
            // 
            this.tmr_open_doors_1_floor.Interval = 15;
            this.tmr_open_doors_1_floor.Tick += new System.EventHandler(this.tmr_open_doors_1_floor_Tick);
            // 
            // tmr_close_doors_1_floor
            // 
            this.tmr_close_doors_1_floor.Interval = 15;
            this.tmr_close_doors_1_floor.Tick += new System.EventHandler(this.tmr_close_doors_1_floor_Tick);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Tomato;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(895, 440);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 32);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(748, 12);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(34, 13);
            this.lblTime.TabIndex = 23;
            this.lblTime.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(660, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(873, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Action";
            // 
            // lblExplain
            // 
            this.lblExplain.AutoSize = true;
            this.lblExplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplain.Location = new System.Drawing.Point(578, 443);
            this.lblExplain.Name = "lblExplain";
            this.lblExplain.Size = new System.Drawing.Size(145, 15);
            this.lblExplain.TabIndex = 26;
            this.lblExplain.Text = "Proceed with caution:";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(554, 38);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 27;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.Reset_Record);
            // 
            // btn_delete_all
            // 
            this.btn_delete_all.Location = new System.Drawing.Point(731, 440);
            this.btn_delete_all.Name = "btn_delete_all";
            this.btn_delete_all.Size = new System.Drawing.Size(75, 23);
            this.btn_delete_all.TabIndex = 28;
            this.btn_delete_all.Text = "Delete";
            this.btn_delete_all.UseVisualStyleBackColor = true;
            this.btn_delete_all.Click += new System.EventHandler(this.Delete_All_Records);
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(557, 97);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(75, 23);
            this.btn_display.TabIndex = 29;
            this.btn_display.Text = "Display";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.Display);
            // 
            // lbl_action_display
            // 
            this.lbl_action_display.AutoSize = true;
            this.lbl_action_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_action_display.Location = new System.Drawing.Point(519, 132);
            this.lbl_action_display.Name = "lbl_action_display";
            this.lbl_action_display.Size = new System.Drawing.Size(124, 13);
            this.lbl_action_display.TabIndex = 30;
            this.lbl_action_display.Text = "All records displayed";
            this.lbl_action_display.Click += new System.EventHandler(this.lbl_action_display_Click);
            // 
            // lbl_user_guide
            // 
            this.lbl_user_guide.AutoSize = true;
            this.lbl_user_guide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_guide.Location = new System.Drawing.Point(9, 41);
            this.lbl_user_guide.Name = "lbl_user_guide";
            this.lbl_user_guide.Size = new System.Drawing.Size(204, 120);
            this.lbl_user_guide.TabIndex = 31;
            this.lbl_user_guide.Text = "To display current records, press\r\nReset, then press any elevator\r\nbutton.\r\n\r\nTo " +
    "display all records, press Display.\r\n\r\nTo delete all records from database,\r\npre" +
    "ss Delete (not recommended).";
            // 
            // lbl_main
            // 
            this.lbl_main.AutoSize = true;
            this.lbl_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_main.Location = new System.Drawing.Point(9, 12);
            this.lbl_main.Name = "lbl_main";
            this.lbl_main.Size = new System.Drawing.Size(77, 15);
            this.lbl_main.TabIndex = 32;
            this.lbl_main.Text = "User guide";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1007, 534);
            this.Controls.Add(this.lbl_main);
            this.Controls.Add(this.lbl_user_guide);
            this.Controls.Add(this.lbl_action_display);
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.btn_delete_all);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lblExplain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.shaft_down_left_door);
            this.Controls.Add(this.shaft_down_right_door);
            this.Controls.Add(this.shaft_up_left_door);
            this.Controls.Add(this.shaft_up_right_door);
            this.Controls.Add(this.cabin_right_door);
            this.Controls.Add(this.cabin_left_door);
            this.Controls.Add(this.picBox_cabin);
            this.Controls.Add(this.picBox_shaft);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_shaft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_cabin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabin_left_door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabin_right_door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shaft_up_right_door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shaft_up_left_door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shaft_down_right_door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shaft_down_left_door)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_display_floor;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox picBox_shaft;
        private System.Windows.Forms.PictureBox picBox_cabin;
        private System.Windows.Forms.Timer tmr_move_down_cabin;
        private System.Windows.Forms.Timer tmr_move_up_cabin;
        private System.Windows.Forms.PictureBox cabin_left_door;
        private System.Windows.Forms.PictureBox cabin_right_door;
        private System.Windows.Forms.Button btn_to_move_up;
        private System.Windows.Forms.Button btn_to_move_down;
        private System.Windows.Forms.Button btn_G;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.PictureBox shaft_up_right_door;
        private System.Windows.Forms.PictureBox shaft_up_left_door;
        private System.Windows.Forms.PictureBox shaft_down_right_door;
        private System.Windows.Forms.PictureBox shaft_down_left_door;
        private System.Windows.Forms.Timer tmr_open_doors_G_floor;
        private System.Windows.Forms.Timer tmr_close_doors_G_floor;
        private System.Windows.Forms.Timer tmr_open_doors_1_floor;
        private System.Windows.Forms.Timer tmr_close_doors_1_floor;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblExplain;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_delete_all;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.Label lbl_action_display;
        private System.Windows.Forms.Label lbl_user_guide;
        private System.Windows.Forms.Label lbl_main;
    }
}


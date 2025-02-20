namespace Talon_Bot
{
    partial class MainDisplay
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
            this.btn_set_next_day_position = new System.Windows.Forms.Button();
            this.btn_set_city_position = new System.Windows.Forms.Button();
            this.list_next_day_positions = new System.Windows.Forms.ListBox();
            this.label_city_position = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_set_ticket_button_position = new System.Windows.Forms.Button();
            this.label_ticket_button_position = new System.Windows.Forms.Label();
            this.label_confirm_button_position = new System.Windows.Forms.Label();
            this.btn_confirm_ticket_postion = new System.Windows.Forms.Button();
            this.label_reload_page_position = new System.Windows.Forms.Label();
            this.btn_reload_page_position = new System.Windows.Forms.Button();
            this.speed_textbox = new System.Windows.Forms.TextBox();
            this.btn_set_speed = new System.Windows.Forms.Button();
            this.label_additional_check_position = new System.Windows.Forms.Label();
            this.btn_Addcheck_position = new System.Windows.Forms.Button();
            this.btn_manual_enter = new System.Windows.Forms.Button();
            this.manual_textBox = new System.Windows.Forms.TextBox();
            this.btn_save_config = new System.Windows.Forms.Button();
            this.btn_load_config = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_set_next_day_position
            // 
            this.btn_set_next_day_position.Location = new System.Drawing.Point(454, 20);
            this.btn_set_next_day_position.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_set_next_day_position.Name = "btn_set_next_day_position";
            this.btn_set_next_day_position.Size = new System.Drawing.Size(149, 35);
            this.btn_set_next_day_position.TabIndex = 1;
            this.btn_set_next_day_position.Text = "Set next day point";
            this.btn_set_next_day_position.UseVisualStyleBackColor = true;
            this.btn_set_next_day_position.Click += new System.EventHandler(this.btn_set_next_day_position_Click);
            // 
            // btn_set_city_position
            // 
            this.btn_set_city_position.Location = new System.Drawing.Point(454, 163);
            this.btn_set_city_position.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_set_city_position.Name = "btn_set_city_position";
            this.btn_set_city_position.Size = new System.Drawing.Size(149, 35);
            this.btn_set_city_position.TabIndex = 2;
            this.btn_set_city_position.Text = "City point";
            this.btn_set_city_position.UseVisualStyleBackColor = true;
            this.btn_set_city_position.Click += new System.EventHandler(this.btn_set_city_position_Click);
            // 
            // list_next_day_positions
            // 
            this.list_next_day_positions.FormattingEnabled = true;
            this.list_next_day_positions.ItemHeight = 20;
            this.list_next_day_positions.Location = new System.Drawing.Point(18, 20);
            this.list_next_day_positions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.list_next_day_positions.Name = "list_next_day_positions";
            this.list_next_day_positions.Size = new System.Drawing.Size(413, 484);
            this.list_next_day_positions.TabIndex = 3;
            // 
            // label_city_position
            // 
            this.label_city_position.AutoSize = true;
            this.label_city_position.Location = new System.Drawing.Point(459, 204);
            this.label_city_position.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_city_position.Name = "label_city_position";
            this.label_city_position.Size = new System.Drawing.Size(74, 20);
            this.label_city_position.TabIndex = 4;
            this.label_city_position.Text = "City point";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(454, 471);
            this.btn_start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(149, 35);
            this.btn_start.TabIndex = 5;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(621, 20);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(158, 35);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Delete day point";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_set_ticket_button_position
            // 
            this.btn_set_ticket_button_position.Location = new System.Drawing.Point(621, 163);
            this.btn_set_ticket_button_position.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_set_ticket_button_position.Name = "btn_set_ticket_button_position";
            this.btn_set_ticket_button_position.Size = new System.Drawing.Size(158, 35);
            this.btn_set_ticket_button_position.TabIndex = 7;
            this.btn_set_ticket_button_position.Text = "Get ticket";
            this.btn_set_ticket_button_position.UseVisualStyleBackColor = true;
            this.btn_set_ticket_button_position.Click += new System.EventHandler(this.btn_set_ticket_button_position_Click);
            // 
            // label_ticket_button_position
            // 
            this.label_ticket_button_position.AutoSize = true;
            this.label_ticket_button_position.Location = new System.Drawing.Point(629, 204);
            this.label_ticket_button_position.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ticket_button_position.Name = "label_ticket_button_position";
            this.label_ticket_button_position.Size = new System.Drawing.Size(78, 20);
            this.label_ticket_button_position.TabIndex = 8;
            this.label_ticket_button_position.Text = "Get ticket";
            // 
            // label_confirm_button_position
            // 
            this.label_confirm_button_position.AutoSize = true;
            this.label_confirm_button_position.Location = new System.Drawing.Point(629, 269);
            this.label_confirm_button_position.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_confirm_button_position.Name = "label_confirm_button_position";
            this.label_confirm_button_position.Size = new System.Drawing.Size(106, 20);
            this.label_confirm_button_position.TabIndex = 10;
            this.label_confirm_button_position.Text = "Confirm ticket";
            // 
            // btn_confirm_ticket_postion
            // 
            this.btn_confirm_ticket_postion.Location = new System.Drawing.Point(621, 229);
            this.btn_confirm_ticket_postion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_confirm_ticket_postion.Name = "btn_confirm_ticket_postion";
            this.btn_confirm_ticket_postion.Size = new System.Drawing.Size(158, 35);
            this.btn_confirm_ticket_postion.TabIndex = 9;
            this.btn_confirm_ticket_postion.Text = "Confirm ticket";
            this.btn_confirm_ticket_postion.UseVisualStyleBackColor = true;
            this.btn_confirm_ticket_postion.Click += new System.EventHandler(this.btn_confirm_ticket_postion_Click);
            // 
            // label_reload_page_position
            // 
            this.label_reload_page_position.AutoSize = true;
            this.label_reload_page_position.Location = new System.Drawing.Point(460, 269);
            this.label_reload_page_position.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_reload_page_position.Name = "label_reload_page_position";
            this.label_reload_page_position.Size = new System.Drawing.Size(130, 20);
            this.label_reload_page_position.TabIndex = 12;
            this.label_reload_page_position.Text = "Reload page pos";
            // 
            // btn_reload_page_position
            // 
            this.btn_reload_page_position.Location = new System.Drawing.Point(454, 229);
            this.btn_reload_page_position.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_reload_page_position.Name = "btn_reload_page_position";
            this.btn_reload_page_position.Size = new System.Drawing.Size(149, 35);
            this.btn_reload_page_position.TabIndex = 11;
            this.btn_reload_page_position.Text = "Reload page";
            this.btn_reload_page_position.UseVisualStyleBackColor = true;
            this.btn_reload_page_position.Click += new System.EventHandler(this.btn_refresh_page_position_Click);
            // 
            // speed_textbox
            // 
            this.speed_textbox.Location = new System.Drawing.Point(457, 114);
            this.speed_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.speed_textbox.Name = "speed_textbox";
            this.speed_textbox.Size = new System.Drawing.Size(80, 26);
            this.speed_textbox.TabIndex = 13;
            this.speed_textbox.Text = "300";
            // 
            // btn_set_speed
            // 
            this.btn_set_speed.Location = new System.Drawing.Point(621, 110);
            this.btn_set_speed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_set_speed.Name = "btn_set_speed";
            this.btn_set_speed.Size = new System.Drawing.Size(156, 35);
            this.btn_set_speed.TabIndex = 14;
            this.btn_set_speed.Text = "Set speed";
            this.btn_set_speed.UseVisualStyleBackColor = true;
            this.btn_set_speed.Click += new System.EventHandler(this.btn_set_speed_Click);
            // 
            // label_additional_check_position
            // 
            this.label_additional_check_position.AutoSize = true;
            this.label_additional_check_position.Location = new System.Drawing.Point(460, 342);
            this.label_additional_check_position.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_additional_check_position.Name = "label_additional_check_position";
            this.label_additional_check_position.Size = new System.Drawing.Size(125, 20);
            this.label_additional_check_position.TabIndex = 16;
            this.label_additional_check_position.Text = "Background pos";
            // 
            // btn_Addcheck_position
            // 
            this.btn_Addcheck_position.Location = new System.Drawing.Point(454, 301);
            this.btn_Addcheck_position.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Addcheck_position.Name = "btn_Addcheck_position";
            this.btn_Addcheck_position.Size = new System.Drawing.Size(149, 35);
            this.btn_Addcheck_position.TabIndex = 15;
            this.btn_Addcheck_position.Text = "Background";
            this.btn_Addcheck_position.UseVisualStyleBackColor = true;
            this.btn_Addcheck_position.Click += new System.EventHandler(this.btn_Addcheck_position_Click);
            // 
            // btn_manual_enter
            // 
            this.btn_manual_enter.Location = new System.Drawing.Point(621, 65);
            this.btn_manual_enter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_manual_enter.Name = "btn_manual_enter";
            this.btn_manual_enter.Size = new System.Drawing.Size(158, 35);
            this.btn_manual_enter.TabIndex = 18;
            this.btn_manual_enter.Text = "Manual enter";
            this.btn_manual_enter.UseVisualStyleBackColor = true;
            this.btn_manual_enter.Click += new System.EventHandler(this.btn_manual_enter_Click);
            // 
            // manual_textBox
            // 
            this.manual_textBox.Location = new System.Drawing.Point(457, 70);
            this.manual_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.manual_textBox.Name = "manual_textBox";
            this.manual_textBox.Size = new System.Drawing.Size(108, 26);
            this.manual_textBox.TabIndex = 17;
            this.manual_textBox.Text = "0, 0";
            // 
            // btn_save_config
            // 
            this.btn_save_config.Location = new System.Drawing.Point(621, 424);
            this.btn_save_config.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_save_config.Name = "btn_save_config";
            this.btn_save_config.Size = new System.Drawing.Size(156, 35);
            this.btn_save_config.TabIndex = 19;
            this.btn_save_config.Text = "Save config";
            this.btn_save_config.UseVisualStyleBackColor = true;
            this.btn_save_config.Click += new System.EventHandler(this.btn_save_config_Click);
            // 
            // btn_load_config
            // 
            this.btn_load_config.Location = new System.Drawing.Point(621, 469);
            this.btn_load_config.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_load_config.Name = "btn_load_config";
            this.btn_load_config.Size = new System.Drawing.Size(156, 35);
            this.btn_load_config.TabIndex = 20;
            this.btn_load_config.Text = "Load config";
            this.btn_load_config.UseVisualStyleBackColor = true;
            this.btn_load_config.Click += new System.EventHandler(this.btn_load_config_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "millisec";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "x, y";
            // 
            // MainDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 526);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_load_config);
            this.Controls.Add(this.btn_save_config);
            this.Controls.Add(this.btn_manual_enter);
            this.Controls.Add(this.manual_textBox);
            this.Controls.Add(this.label_additional_check_position);
            this.Controls.Add(this.btn_Addcheck_position);
            this.Controls.Add(this.btn_set_speed);
            this.Controls.Add(this.speed_textbox);
            this.Controls.Add(this.label_reload_page_position);
            this.Controls.Add(this.btn_reload_page_position);
            this.Controls.Add(this.label_confirm_button_position);
            this.Controls.Add(this.btn_confirm_ticket_postion);
            this.Controls.Add(this.label_ticket_button_position);
            this.Controls.Add(this.btn_set_ticket_button_position);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label_city_position);
            this.Controls.Add(this.list_next_day_positions);
            this.Controls.Add(this.btn_set_city_position);
            this.Controls.Add(this.btn_set_next_day_position);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainDisplay";
            this.ShowIcon = false;
            this.Text = "Talon Fisher v1";
            this.Load += new System.EventHandler(this.MainDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_set_next_day_position;
        private System.Windows.Forms.Button btn_set_city_position;
        private System.Windows.Forms.ListBox list_next_day_positions;
        private System.Windows.Forms.Label label_city_position;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_set_ticket_button_position;
        private System.Windows.Forms.Label label_ticket_button_position;
        private System.Windows.Forms.Label label_confirm_button_position;
        private System.Windows.Forms.Button btn_confirm_ticket_postion;
        private System.Windows.Forms.Label label_reload_page_position;
        private System.Windows.Forms.Button btn_reload_page_position;
        private System.Windows.Forms.TextBox speed_textbox;
        private System.Windows.Forms.Button btn_set_speed;
        private System.Windows.Forms.Label label_additional_check_position;
        private System.Windows.Forms.Button btn_Addcheck_position;
        private System.Windows.Forms.Button btn_manual_enter;
        private System.Windows.Forms.TextBox manual_textBox;
        private System.Windows.Forms.Button btn_save_config;
        private System.Windows.Forms.Button btn_load_config;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


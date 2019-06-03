namespace CloakaControllerApp
{
    partial class RulesController
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
            this.MSQLBoxAdress = new System.Windows.Forms.TextBox();
            this.LableServerAdress = new System.Windows.Forms.Label();
            this.DataBaseNameBox = new System.Windows.Forms.TextBox();
            this.LableDataBaseName = new System.Windows.Forms.Label();
            this.DataBaseUser = new System.Windows.Forms.TextBox();
            this.LableDataBaseUser = new System.Windows.Forms.Label();
            this.DataBasePassword = new System.Windows.Forms.TextBox();
            this.LableDataBasePassword = new System.Windows.Forms.Label();
            this.ConnectToMySql = new System.Windows.Forms.Button();
            this.ConnMessage = new System.Windows.Forms.TextBox();
            this.groupIpAdressFiller = new System.Windows.Forms.GroupBox();
            this.BadIpsHelpButton = new System.Windows.Forms.Button();
            this.AddIPsToDB = new System.Windows.Forms.Button();
            this.BoxOfIPs = new System.Windows.Forms.TextBox();
            this.RulesGroupBox = new System.Windows.Forms.GroupBox();
            this.SellLableText = new System.Windows.Forms.Label();
            this.SellPagesTxBox = new System.Windows.Forms.TextBox();
            this.PageForBotsLable = new System.Windows.Forms.Label();
            this.PageForBotsTxBox = new System.Windows.Forms.TextBox();
            this.AddRulesToDataBase = new System.Windows.Forms.Button();
            this.RulesHelpButton = new System.Windows.Forms.Button();
            this.RuleNameLable = new System.Windows.Forms.Label();
            this.RuleNameTxBox = new System.Windows.Forms.TextBox();
            this.Statistic = new System.Windows.Forms.DataGridView();
            this.StatisticTakeButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GenerateScripts = new System.Windows.Forms.Button();
            this.DropScriptTables = new System.Windows.Forms.Button();
            this.groupIpAdressFiller.SuspendLayout();
            this.RulesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Statistic)).BeginInit();
            this.SuspendLayout();
            // 
            // MSQLBoxAdress
            // 
            this.MSQLBoxAdress.Location = new System.Drawing.Point(12, 24);
            this.MSQLBoxAdress.MaxLength = 100;
            this.MSQLBoxAdress.Name = "MSQLBoxAdress";
            this.MSQLBoxAdress.Size = new System.Drawing.Size(100, 20);
            this.MSQLBoxAdress.TabIndex = 0;
            // 
            // LableServerAdress
            // 
            this.LableServerAdress.AutoSize = true;
            this.LableServerAdress.Location = new System.Drawing.Point(12, 5);
            this.LableServerAdress.Name = "LableServerAdress";
            this.LableServerAdress.Size = new System.Drawing.Size(69, 13);
            this.LableServerAdress.TabIndex = 1;
            this.LableServerAdress.Text = "IP адрес БД";
            // 
            // DataBaseNameBox
            // 
            this.DataBaseNameBox.Location = new System.Drawing.Point(118, 24);
            this.DataBaseNameBox.Name = "DataBaseNameBox";
            this.DataBaseNameBox.Size = new System.Drawing.Size(100, 20);
            this.DataBaseNameBox.TabIndex = 2;
            // 
            // LableDataBaseName
            // 
            this.LableDataBaseName.AutoSize = true;
            this.LableDataBaseName.Location = new System.Drawing.Point(118, 5);
            this.LableDataBaseName.Name = "LableDataBaseName";
            this.LableDataBaseName.Size = new System.Drawing.Size(48, 13);
            this.LableDataBaseName.TabIndex = 3;
            this.LableDataBaseName.Text = "Имя БД";
            // 
            // DataBaseUser
            // 
            this.DataBaseUser.Location = new System.Drawing.Point(225, 23);
            this.DataBaseUser.Name = "DataBaseUser";
            this.DataBaseUser.Size = new System.Drawing.Size(100, 20);
            this.DataBaseUser.TabIndex = 4;
            // 
            // LableDataBaseUser
            // 
            this.LableDataBaseUser.AutoSize = true;
            this.LableDataBaseUser.Location = new System.Drawing.Point(225, 5);
            this.LableDataBaseUser.Name = "LableDataBaseUser";
            this.LableDataBaseUser.Size = new System.Drawing.Size(99, 13);
            this.LableDataBaseUser.TabIndex = 5;
            this.LableDataBaseUser.Text = "Пользователь БД";
            // 
            // DataBasePassword
            // 
            this.DataBasePassword.Location = new System.Drawing.Point(332, 23);
            this.DataBasePassword.Name = "DataBasePassword";
            this.DataBasePassword.Size = new System.Drawing.Size(100, 20);
            this.DataBasePassword.TabIndex = 6;
            // 
            // LableDataBasePassword
            // 
            this.LableDataBasePassword.AutoSize = true;
            this.LableDataBasePassword.Location = new System.Drawing.Point(332, 5);
            this.LableDataBasePassword.Name = "LableDataBasePassword";
            this.LableDataBasePassword.Size = new System.Drawing.Size(78, 13);
            this.LableDataBasePassword.TabIndex = 7;
            this.LableDataBasePassword.Text = "Пароль от БД";
            // 
            // ConnectToMySql
            // 
            this.ConnectToMySql.Location = new System.Drawing.Point(438, 20);
            this.ConnectToMySql.Name = "ConnectToMySql";
            this.ConnectToMySql.Size = new System.Drawing.Size(75, 23);
            this.ConnectToMySql.TabIndex = 8;
            this.ConnectToMySql.Text = "Conn";
            this.ConnectToMySql.UseVisualStyleBackColor = true;
            this.ConnectToMySql.Click += new System.EventHandler(this.ConnectToMySql_Click);
            // 
            // ConnMessage
            // 
            this.ConnMessage.Location = new System.Drawing.Point(519, 20);
            this.ConnMessage.Name = "ConnMessage";
            this.ConnMessage.ReadOnly = true;
            this.ConnMessage.Size = new System.Drawing.Size(176, 20);
            this.ConnMessage.TabIndex = 9;
            // 
            // groupIpAdressFiller
            // 
            this.groupIpAdressFiller.Controls.Add(this.BadIpsHelpButton);
            this.groupIpAdressFiller.Controls.Add(this.AddIPsToDB);
            this.groupIpAdressFiller.Controls.Add(this.BoxOfIPs);
            this.groupIpAdressFiller.Location = new System.Drawing.Point(12, 51);
            this.groupIpAdressFiller.Name = "groupIpAdressFiller";
            this.groupIpAdressFiller.Size = new System.Drawing.Size(190, 100);
            this.groupIpAdressFiller.TabIndex = 10;
            this.groupIpAdressFiller.TabStop = false;
            this.groupIpAdressFiller.Text = "Задать нежелательные IP";
            // 
            // BadIpsHelpButton
            // 
            this.BadIpsHelpButton.Location = new System.Drawing.Point(160, 20);
            this.BadIpsHelpButton.Name = "BadIpsHelpButton";
            this.BadIpsHelpButton.Size = new System.Drawing.Size(26, 24);
            this.BadIpsHelpButton.TabIndex = 2;
            this.BadIpsHelpButton.Text = "?";
            this.BadIpsHelpButton.UseVisualStyleBackColor = true;
            this.BadIpsHelpButton.Click += new System.EventHandler(this.BadIpsHelpButton_Click);
            // 
            // AddIPsToDB
            // 
            this.AddIPsToDB.Location = new System.Drawing.Point(7, 71);
            this.AddIPsToDB.Name = "AddIPsToDB";
            this.AddIPsToDB.Size = new System.Drawing.Size(147, 23);
            this.AddIPsToDB.TabIndex = 1;
            this.AddIPsToDB.Text = "Добавить IP";
            this.AddIPsToDB.UseVisualStyleBackColor = true;
            this.AddIPsToDB.Click += new System.EventHandler(this.AddIPsToDB_Click);
            // 
            // BoxOfIPs
            // 
            this.BoxOfIPs.Location = new System.Drawing.Point(7, 20);
            this.BoxOfIPs.Multiline = true;
            this.BoxOfIPs.Name = "BoxOfIPs";
            this.BoxOfIPs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BoxOfIPs.Size = new System.Drawing.Size(147, 45);
            this.BoxOfIPs.TabIndex = 0;
            // 
            // RulesGroupBox
            // 
            this.RulesGroupBox.Controls.Add(this.SellLableText);
            this.RulesGroupBox.Controls.Add(this.SellPagesTxBox);
            this.RulesGroupBox.Controls.Add(this.PageForBotsLable);
            this.RulesGroupBox.Controls.Add(this.PageForBotsTxBox);
            this.RulesGroupBox.Controls.Add(this.AddRulesToDataBase);
            this.RulesGroupBox.Controls.Add(this.RulesHelpButton);
            this.RulesGroupBox.Controls.Add(this.RuleNameLable);
            this.RulesGroupBox.Controls.Add(this.RuleNameTxBox);
            this.RulesGroupBox.Location = new System.Drawing.Point(209, 51);
            this.RulesGroupBox.Name = "RulesGroupBox";
            this.RulesGroupBox.Size = new System.Drawing.Size(486, 133);
            this.RulesGroupBox.TabIndex = 11;
            this.RulesGroupBox.TabStop = false;
            this.RulesGroupBox.Text = "Назначение правил";
            // 
            // SellLableText
            // 
            this.SellLableText.AutoSize = true;
            this.SellLableText.Location = new System.Drawing.Point(332, 11);
            this.SellLableText.Name = "SellLableText";
            this.SellLableText.Size = new System.Drawing.Size(131, 13);
            this.SellLableText.TabIndex = 7;
            this.SellLableText.Text = "Странницы для продажи";
            // 
            // SellPagesTxBox
            // 
            this.SellPagesTxBox.Location = new System.Drawing.Point(331, 30);
            this.SellPagesTxBox.Multiline = true;
            this.SellPagesTxBox.Name = "SellPagesTxBox";
            this.SellPagesTxBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SellPagesTxBox.Size = new System.Drawing.Size(149, 35);
            this.SellPagesTxBox.TabIndex = 6;
            // 
            // PageForBotsLable
            // 
            this.PageForBotsLable.AutoSize = true;
            this.PageForBotsLable.Location = new System.Drawing.Point(175, 11);
            this.PageForBotsLable.Name = "PageForBotsLable";
            this.PageForBotsLable.Size = new System.Drawing.Size(110, 13);
            this.PageForBotsLable.TabIndex = 5;
            this.PageForBotsLable.Text = "Страницы для ботов";
            // 
            // PageForBotsTxBox
            // 
            this.PageForBotsTxBox.Location = new System.Drawing.Point(168, 30);
            this.PageForBotsTxBox.Multiline = true;
            this.PageForBotsTxBox.Name = "PageForBotsTxBox";
            this.PageForBotsTxBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PageForBotsTxBox.Size = new System.Drawing.Size(157, 35);
            this.PageForBotsTxBox.TabIndex = 4;
            // 
            // AddRulesToDataBase
            // 
            this.AddRulesToDataBase.Location = new System.Drawing.Point(7, 100);
            this.AddRulesToDataBase.Name = "AddRulesToDataBase";
            this.AddRulesToDataBase.Size = new System.Drawing.Size(473, 27);
            this.AddRulesToDataBase.TabIndex = 3;
            this.AddRulesToDataBase.Text = "Добавить правила в Базу Данных";
            this.AddRulesToDataBase.UseVisualStyleBackColor = true;
            this.AddRulesToDataBase.Click += new System.EventHandler(this.AddRulesToDataBase_Click);
            // 
            // RulesHelpButton
            // 
            this.RulesHelpButton.Location = new System.Drawing.Point(7, 71);
            this.RulesHelpButton.Name = "RulesHelpButton";
            this.RulesHelpButton.Size = new System.Drawing.Size(473, 23);
            this.RulesHelpButton.TabIndex = 2;
            this.RulesHelpButton.Text = "Помощь";
            this.RulesHelpButton.UseVisualStyleBackColor = true;
            this.RulesHelpButton.Click += new System.EventHandler(this.RulesHelpButton_Click);
            // 
            // RuleNameLable
            // 
            this.RuleNameLable.AutoSize = true;
            this.RuleNameLable.Location = new System.Drawing.Point(16, 11);
            this.RuleNameLable.Name = "RuleNameLable";
            this.RuleNameLable.Size = new System.Drawing.Size(82, 13);
            this.RuleNameLable.TabIndex = 1;
            this.RuleNameLable.Text = "Имена ссылок";
            // 
            // RuleNameTxBox
            // 
            this.RuleNameTxBox.Location = new System.Drawing.Point(7, 30);
            this.RuleNameTxBox.Multiline = true;
            this.RuleNameTxBox.Name = "RuleNameTxBox";
            this.RuleNameTxBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RuleNameTxBox.Size = new System.Drawing.Size(155, 35);
            this.RuleNameTxBox.TabIndex = 0;
            // 
            // Statistic
            // 
            this.Statistic.AllowUserToAddRows = false;
            this.Statistic.AllowUserToDeleteRows = false;
            this.Statistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Statistic.Location = new System.Drawing.Point(209, 184);
            this.Statistic.Name = "Statistic";
            this.Statistic.ReadOnly = true;
            this.Statistic.Size = new System.Drawing.Size(486, 119);
            this.Statistic.TabIndex = 12;
            // 
            // StatisticTakeButton
            // 
            this.StatisticTakeButton.Location = new System.Drawing.Point(209, 309);
            this.StatisticTakeButton.Name = "StatisticTakeButton";
            this.StatisticTakeButton.Size = new System.Drawing.Size(382, 23);
            this.StatisticTakeButton.TabIndex = 13;
            this.StatisticTakeButton.Text = "Получить статистику переходов";
            this.StatisticTakeButton.UseVisualStyleBackColor = true;
            this.StatisticTakeButton.Click += new System.EventHandler(this.StatisticTakeButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(597, 308);
            this.dateTimePicker.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker.TabIndex = 14;
            // 
            // GenerateScripts
            // 
            this.GenerateScripts.Location = new System.Drawing.Point(19, 184);
            this.GenerateScripts.Name = "GenerateScripts";
            this.GenerateScripts.Size = new System.Drawing.Size(167, 119);
            this.GenerateScripts.TabIndex = 15;
            this.GenerateScripts.Text = "Сгенерировать скрипты";
            this.GenerateScripts.UseVisualStyleBackColor = true;
            this.GenerateScripts.Click += new System.EventHandler(this.GenerateScripts_Click);
            // 
            // DropScriptTables
            // 
            this.DropScriptTables.Location = new System.Drawing.Point(19, 309);
            this.DropScriptTables.Name = "DropScriptTables";
            this.DropScriptTables.Size = new System.Drawing.Size(167, 23);
            this.DropScriptTables.TabIndex = 16;
            this.DropScriptTables.Text = "Очистить Базу данных";
            this.DropScriptTables.UseVisualStyleBackColor = true;
            this.DropScriptTables.Click += new System.EventHandler(this.DropScriptTables_Click);
            // 
            // RulesController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 340);
            this.Controls.Add(this.DropScriptTables);
            this.Controls.Add(this.GenerateScripts);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.StatisticTakeButton);
            this.Controls.Add(this.Statistic);
            this.Controls.Add(this.RulesGroupBox);
            this.Controls.Add(this.groupIpAdressFiller);
            this.Controls.Add(this.ConnMessage);
            this.Controls.Add(this.ConnectToMySql);
            this.Controls.Add(this.LableDataBasePassword);
            this.Controls.Add(this.DataBasePassword);
            this.Controls.Add(this.LableDataBaseUser);
            this.Controls.Add(this.DataBaseUser);
            this.Controls.Add(this.LableDataBaseName);
            this.Controls.Add(this.DataBaseNameBox);
            this.Controls.Add(this.LableServerAdress);
            this.Controls.Add(this.MSQLBoxAdress);
            this.Name = "RulesController";
            this.Text = "Rules Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RulesController_FormClosing);
            this.groupIpAdressFiller.ResumeLayout(false);
            this.groupIpAdressFiller.PerformLayout();
            this.RulesGroupBox.ResumeLayout(false);
            this.RulesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Statistic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MSQLBoxAdress;
        private System.Windows.Forms.Label LableServerAdress;
        private System.Windows.Forms.TextBox DataBaseNameBox;
        private System.Windows.Forms.Label LableDataBaseName;
        private System.Windows.Forms.TextBox DataBaseUser;
        private System.Windows.Forms.Label LableDataBaseUser;
        private System.Windows.Forms.TextBox DataBasePassword;
        private System.Windows.Forms.Label LableDataBasePassword;
        private System.Windows.Forms.Button ConnectToMySql;
        private System.Windows.Forms.TextBox ConnMessage;
        private System.Windows.Forms.GroupBox groupIpAdressFiller;
        private System.Windows.Forms.TextBox BoxOfIPs;
        private System.Windows.Forms.Button AddIPsToDB;
        private System.Windows.Forms.Button BadIpsHelpButton;
        private System.Windows.Forms.GroupBox RulesGroupBox;
        private System.Windows.Forms.Button RulesHelpButton;
        private System.Windows.Forms.Label RuleNameLable;
        private System.Windows.Forms.TextBox RuleNameTxBox;
        private System.Windows.Forms.Button AddRulesToDataBase;
        private System.Windows.Forms.TextBox PageForBotsTxBox;
        private System.Windows.Forms.Label PageForBotsLable;
        private System.Windows.Forms.TextBox SellPagesTxBox;
        private System.Windows.Forms.Label SellLableText;
        private System.Windows.Forms.DataGridView Statistic;
        private System.Windows.Forms.Button StatisticTakeButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button GenerateScripts;
        private System.Windows.Forms.Button DropScriptTables;
    }
}


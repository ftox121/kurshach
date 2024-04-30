namespace Cafe.All
{
    partial class remove
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            listik = new ListBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            lastupdate = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(301, 26);
            label1.Name = "label1";
            label1.Size = new Size(157, 27);
            label1.TabIndex = 0;
            label1.Text = "Удалить блюда";
            // 
            // guna2Button1
            // 
            guna2Button1.BorderColor = Color.White;
            guna2Button1.BorderRadius = 25;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(0, 118, 225);
            guna2Button1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(492, 253);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(180, 45);
            guna2Button1.TabIndex = 1;
            guna2Button1.Text = "Удалить";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // listik
            // 
            listik.FormattingEnabled = true;
            listik.ItemHeight = 15;
            listik.Location = new Point(26, 118);
            listik.Name = "listik";
            listik.Size = new Size(432, 349);
            listik.TabIndex = 2;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 25;
            guna2Elipse1.TargetControl = this;
            // 
            // lastupdate
            // 
            lastupdate.BorderColor = Color.White;
            lastupdate.BorderRadius = 25;
            lastupdate.CustomizableEdges = customizableEdges3;
            lastupdate.DisabledState.BorderColor = Color.DarkGray;
            lastupdate.DisabledState.CustomBorderColor = Color.DarkGray;
            lastupdate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            lastupdate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            lastupdate.FillColor = Color.FromArgb(0, 118, 225);
            lastupdate.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lastupdate.ForeColor = Color.White;
            lastupdate.Location = new Point(492, 331);
            lastupdate.Name = "lastupdate";
            lastupdate.ShadowDecoration.CustomizableEdges = customizableEdges4;
            lastupdate.Size = new Size(180, 45);
            lastupdate.TabIndex = 3;
            lastupdate.Text = "Обновить";
            lastupdate.Click += lastupdate_Click;
            // 
            // remove
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lastupdate);
            Controls.Add(listik);
            Controls.Add(guna2Button1);
            Controls.Add(label1);
            Name = "remove";
            Size = new Size(781, 514);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private ListBox listik;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button lastupdate;
    }
}

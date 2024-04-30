namespace Cafe.All
{
    partial class UC_Additems2
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAdditem = new Guna.UI2.WinForms.Guna2Button();
            CafeLogger = new Guna.UI2.WinForms.Guna2TextBox();
            txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            txtCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            label4 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(328, 49);
            label1.Name = "label1";
            label1.Size = new Size(139, 23);
            label1.TabIndex = 0;
            label1.Text = "Добавить блюдо";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(148, 221);
            label2.Name = "label2";
            label2.Size = new Size(140, 23);
            label2.TabIndex = 1;
            label2.Text = "Название блюда";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(148, 103);
            label3.Name = "label3";
            label3.Size = new Size(92, 23);
            label3.TabIndex = 2;
            label3.Text = "Категории";
            // 
            // btnAdditem
            // 
            btnAdditem.BorderColor = Color.White;
            btnAdditem.BorderRadius = 26;
            btnAdditem.CustomizableEdges = customizableEdges1;
            btnAdditem.DisabledState.BorderColor = Color.DarkGray;
            btnAdditem.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdditem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdditem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdditem.FillColor = Color.FromArgb(0, 118, 225);
            btnAdditem.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdditem.ForeColor = Color.White;
            btnAdditem.Location = new Point(287, 440);
            btnAdditem.Name = "btnAdditem";
            btnAdditem.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAdditem.Size = new Size(180, 45);
            btnAdditem.TabIndex = 3;
            btnAdditem.Text = "Добавить блюдо";
            btnAdditem.Click += btnAdditem_Click;
            // 
            // CafeLogger
            // 
            CafeLogger.CustomizableEdges = customizableEdges3;
            CafeLogger.DefaultText = "";
            CafeLogger.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            CafeLogger.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            CafeLogger.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            CafeLogger.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            CafeLogger.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            CafeLogger.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CafeLogger.ForeColor = Color.Black;
            CafeLogger.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            CafeLogger.Location = new Point(148, 265);
            CafeLogger.Name = "CafeLogger";
            CafeLogger.PasswordChar = '\0';
            CafeLogger.PlaceholderText = "";
            CafeLogger.SelectedText = "";
            CafeLogger.ShadowDecoration.CustomizableEdges = customizableEdges4;
            CafeLogger.Size = new Size(395, 36);
            CafeLogger.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            CafeLogger.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.CustomizableEdges = customizableEdges5;
            txtPrice.DefaultText = "";
            txtPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.ForeColor = Color.Black;
            txtPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrice.Location = new Point(148, 362);
            txtPrice.Name = "txtPrice";
            txtPrice.PasswordChar = '\0';
            txtPrice.PlaceholderText = "";
            txtPrice.SelectedText = "";
            txtPrice.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtPrice.Size = new Size(395, 36);
            txtPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtPrice.TabIndex = 5;
            // 
            // txtCategory
            // 
            txtCategory.BackColor = Color.Transparent;
            txtCategory.CustomizableEdges = customizableEdges7;
            txtCategory.DrawMode = DrawMode.OwnerDrawFixed;
            txtCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            txtCategory.FocusedColor = Color.FromArgb(94, 148, 255);
            txtCategory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCategory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategory.ForeColor = Color.Black;
            txtCategory.ItemHeight = 30;
            txtCategory.Location = new Point(148, 142);
            txtCategory.Name = "txtCategory";
            txtCategory.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtCategory.Size = new Size(395, 36);
            txtCategory.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtCategory.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(148, 321);
            label4.Name = "label4";
            label4.Size = new Size(92, 23);
            label4.TabIndex = 7;
            label4.Text = "Стоимость";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // UC_Additems2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label4);
            Controls.Add(txtCategory);
            Controls.Add(txtPrice);
            Controls.Add(CafeLogger);
            Controls.Add(btnAdditem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_Additems2";
            Size = new Size(781, 514);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button btnAdditem;
        private Guna.UI2.WinForms.Guna2TextBox CafeLogger;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2ComboBox txtCategory;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}

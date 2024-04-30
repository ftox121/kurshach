namespace Cafe
{
    partial class Dashboaard
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboaard));
            panel1 = new Panel();
            btnLogout = new LinkLabel();
            btnExit = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            btnRemoveItems = new Guna.UI2.WinForms.Guna2Button();
            btnAddItems = new Guna.UI2.WinForms.Guna2Button();
            btnPlaceOrder = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new Panel();
            remove1 = new All.remove();
            uC_PlaceOrder1 = new All.UC_PlaceOrder();
            uC_Additems21 = new All.UC_Additems2();
            uC_Welcome1 = new All.UC_Welcome();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse7 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse8 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            guna2Elipse9 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse10 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse11 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 118, 225);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnRemoveItems);
            panel1.Controls.Add(btnAddItems);
            panel1.Controls.Add(btnPlaceOrder);
            guna2Transition1.SetDecoration(panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            panel1.Location = new Point(41, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 514);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.AutoSize = true;
            guna2Transition1.SetDecoration(btnLogout, Guna.UI2.AnimatorNS.DecorationType.None);
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.Cyan;
            btnLogout.LinkColor = Color.Cyan;
            btnLogout.Location = new Point(65, 475);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(60, 21);
            btnLogout.TabIndex = 5;
            btnLogout.TabStop = true;
            btnLogout.Text = "Выйти";
            btnLogout.LinkClicked += btnLogout_LinkClicked;
            // 
            // btnExit
            // 
            guna2Transition1.SetDecoration(btnExit, Guna.UI2.AnimatorNS.DecorationType.None);
            btnExit.DisabledState.BorderColor = Color.DarkGray;
            btnExit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExit.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(3, 3);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnExit.Size = new Size(35, 35);
            btnExit.TabIndex = 4;
            btnExit.Text = "x";
            btnExit.Click += btnExit_Click;
            // 
            // btnRemoveItems
            // 
            btnRemoveItems.BorderRadius = 14;
            btnRemoveItems.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnRemoveItems.CheckedState.FillColor = Color.White;
            btnRemoveItems.CheckedState.ForeColor = Color.FromArgb(0, 118, 225);
            btnRemoveItems.CustomizableEdges = customizableEdges2;
            guna2Transition1.SetDecoration(btnRemoveItems, Guna.UI2.AnimatorNS.DecorationType.None);
            btnRemoveItems.DisabledState.BorderColor = Color.DarkGray;
            btnRemoveItems.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRemoveItems.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRemoveItems.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRemoveItems.FillColor = Color.FromArgb(0, 118, 225);
            btnRemoveItems.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemoveItems.ForeColor = Color.White;
            btnRemoveItems.Location = new Point(16, 217);
            btnRemoveItems.Name = "btnRemoveItems";
            btnRemoveItems.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnRemoveItems.Size = new Size(202, 41);
            btnRemoveItems.TabIndex = 3;
            btnRemoveItems.Text = "Удалить блюда";
            btnRemoveItems.Click += btnRemoveItems_Click;
            // 
            // btnAddItems
            // 
            btnAddItems.BorderRadius = 14;
            btnAddItems.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnAddItems.CheckedState.FillColor = Color.White;
            btnAddItems.CheckedState.ForeColor = Color.FromArgb(0, 118, 225);
            btnAddItems.CustomizableEdges = customizableEdges4;
            guna2Transition1.SetDecoration(btnAddItems, Guna.UI2.AnimatorNS.DecorationType.None);
            btnAddItems.DisabledState.BorderColor = Color.DarkGray;
            btnAddItems.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddItems.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddItems.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddItems.FillColor = Color.FromArgb(0, 118, 225);
            btnAddItems.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddItems.ForeColor = Color.White;
            btnAddItems.Location = new Point(16, 154);
            btnAddItems.Name = "btnAddItems";
            btnAddItems.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnAddItems.Size = new Size(202, 41);
            btnAddItems.TabIndex = 1;
            btnAddItems.Text = "Добавить блюда";
            btnAddItems.Click += btnAddItems_Click;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.BorderRadius = 14;
            btnPlaceOrder.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnPlaceOrder.CheckedState.FillColor = Color.White;
            btnPlaceOrder.CheckedState.ForeColor = Color.FromArgb(0, 118, 225);
            btnPlaceOrder.CustomizableEdges = customizableEdges6;
            guna2Transition1.SetDecoration(btnPlaceOrder, Guna.UI2.AnimatorNS.DecorationType.None);
            btnPlaceOrder.DisabledState.BorderColor = Color.DarkGray;
            btnPlaceOrder.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPlaceOrder.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPlaceOrder.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPlaceOrder.FillColor = Color.FromArgb(0, 118, 225);
            btnPlaceOrder.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnPlaceOrder.ForeColor = Color.White;
            btnPlaceOrder.Location = new Point(16, 93);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnPlaceOrder.Size = new Size(202, 41);
            btnPlaceOrder.TabIndex = 0;
            btnPlaceOrder.Text = "Сделать заказ";
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(remove1);
            panel2.Controls.Add(uC_PlaceOrder1);
            panel2.Controls.Add(uC_Additems21);
            panel2.Controls.Add(uC_Welcome1);
            guna2Transition1.SetDecoration(panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            panel2.Location = new Point(236, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(756, 511);
            panel2.TabIndex = 1;
            // 
            // remove1
            // 
            guna2Transition1.SetDecoration(remove1, Guna.UI2.AnimatorNS.DecorationType.None);
            remove1.Location = new Point(0, -4);
            remove1.Name = "remove1";
            remove1.Size = new Size(781, 514);
            remove1.TabIndex = 3;
            // 
            // uC_PlaceOrder1
            // 
            uC_PlaceOrder1.BackColor = Color.White;
            guna2Transition1.SetDecoration(uC_PlaceOrder1, Guna.UI2.AnimatorNS.DecorationType.None);
            uC_PlaceOrder1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            uC_PlaceOrder1.Location = new Point(0, -3);
            uC_PlaceOrder1.Margin = new Padding(3, 4, 3, 4);
            uC_PlaceOrder1.Name = "uC_PlaceOrder1";
            uC_PlaceOrder1.Size = new Size(756, 513);
            uC_PlaceOrder1.TabIndex = 2;
            // 
            // uC_Additems21
            // 
            uC_Additems21.BackColor = Color.White;
            guna2Transition1.SetDecoration(uC_Additems21, Guna.UI2.AnimatorNS.DecorationType.None);
            uC_Additems21.Location = new Point(0, 3);
            uC_Additems21.Name = "uC_Additems21";
            uC_Additems21.Size = new Size(781, 514);
            uC_Additems21.TabIndex = 2;
            // 
            // uC_Welcome1
            // 
            uC_Welcome1.BackColor = Color.White;
            guna2Transition1.SetDecoration(uC_Welcome1, Guna.UI2.AnimatorNS.DecorationType.None);
            uC_Welcome1.Location = new Point(0, 3);
            uC_Welcome1.Name = "uC_Welcome1";
            uC_Welcome1.Size = new Size(781, 514);
            uC_Welcome1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = panel2;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 30;
            guna2Elipse2.TargetControl = panel2;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 30;
            guna2Elipse3.TargetControl = panel2;
            // 
            // guna2Elipse4
            // 
            guna2Elipse4.TargetControl = panel2;
            // 
            // guna2Elipse5
            // 
            guna2Elipse5.BorderRadius = 30;
            // 
            // guna2Elipse6
            // 
            guna2Elipse6.BorderRadius = 30;
            // 
            // guna2Elipse7
            // 
            guna2Elipse7.BorderRadius = 30;
            guna2Elipse7.TargetControl = panel2;
            // 
            // guna2Elipse8
            // 
            guna2Elipse8.BorderRadius = 30;
            guna2Elipse8.TargetControl = this;
            // 
            // guna2Transition1
            // 
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = (PointF)resources.GetObject("animation1.BlindCoeff");
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = (PointF)resources.GetObject("animation1.MosaicCoeff");
            animation1.MosaicShift = (PointF)resources.GetObject("animation1.MosaicShift");
            animation1.MosaicSize = 0;
            animation1.Padding = new Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = (PointF)resources.GetObject("animation1.ScaleCoeff");
            animation1.SlideCoeff = (PointF)resources.GetObject("animation1.SlideCoeff");
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            guna2Transition1.DefaultAnimation = animation1;
            // 
            // guna2Elipse9
            // 
            guna2Elipse9.TargetControl = panel2;
            // 
            // guna2Elipse10
            // 
            guna2Elipse10.BorderRadius = 25;
            // 
            // guna2Elipse11
            // 
            guna2Elipse11.BorderRadius = 25;
            guna2Elipse11.TargetControl = panel2;
            // 
            // Dashboaard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 118, 225);
            ClientSize = new Size(1004, 538);
            Controls.Add(panel2);
            Controls.Add(panel1);
            guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboaard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboaard";
            Load += Dashboaard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnPlaceOrder;
        private Guna.UI2.WinForms.Guna2Button btnRemoveItems;
        private Guna.UI2.WinForms.Guna2Button btnAddItems;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnExit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private LinkLabel btnLogout;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private All.UC_Welcome uC_Welcome1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private All.UC_Additems2 uC_Additems21;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse7;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse8;
        private All.UC_PlaceOrder uC_PlaceOrder1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse9;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse10;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse11;
        private All.remove remove1;
    }
}

namespace bibloteka
{
    partial class Ballina
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
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.lexuesit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.librat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.dheniaelibrit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.lexuesit,
            this.librat,
            this.dheniaelibrit});
            this.accordionControl1.Location = new System.Drawing.Point(0, 30);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.True;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Fluent;
            this.accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            this.accordionControl1.Size = new System.Drawing.Size(172, 566);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // lexuesit
            // 
            this.lexuesit.Expanded = true;
            this.lexuesit.ImageOptions.Image = global::bibloteka.Properties.Resources.icons8_readers_16;
            this.lexuesit.Name = "lexuesit";
            this.lexuesit.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.lexuesit.Text = "Lexuesit";
            this.lexuesit.Click += new System.EventHandler(this.lexuesit_Click);
            // 
            // librat
            // 
            this.librat.ImageOptions.Image = global::bibloteka.Properties.Resources.icons8_ibooks_16;
            this.librat.Name = "librat";
            this.librat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.librat.Text = "Librat";
            this.librat.Click += new System.EventHandler(this.librat_Click);
            // 
            // dheniaelibrit
            // 
            this.dheniaelibrit.ImageOptions.Image = global::bibloteka.Properties.Resources.icons8_address_book_2_16;
            this.dheniaelibrit.Name = "dheniaelibrit";
            this.dheniaelibrit.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.dheniaelibrit.Text = "Dhënia dhe kthimi librit";
            this.dheniaelibrit.Click += new System.EventHandler(this.dheniaelibrit_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(946, 30);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Bibloteka";
            this.barStaticItem1.Id = 2;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.DockingEnabled = false;
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1});
            this.fluentFormDefaultManager1.MaxItemId = 3;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(172, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 566);
            this.panel1.TabIndex = 3;
            // 
            // Ballina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 596);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.IconOptions.Image = global::bibloteka.Properties.Resources.icons8_control_panel_48;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Ballina";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Paneli i administratorit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement lexuesit;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement librat;
        private DevExpress.XtraBars.Navigation.AccordionControlElement dheniaelibrit;
    }
}
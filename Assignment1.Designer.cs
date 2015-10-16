namespace COMP1004_Assignment1
{
    partial class Assignment1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assignment1));
            this.modelBox = new System.Windows.Forms.GroupBox();
            this.radioButtonIP6s = new System.Windows.Forms.RadioButton();
            this.radioButtonIP6 = new System.Windows.Forms.RadioButton();
            this.colorBox = new System.Windows.Forms.GroupBox();
            this.radioButtonSilver = new System.Windows.Forms.RadioButton();
            this.radioButtonGold = new System.Windows.Forms.RadioButton();
            this.radioButtonGrey = new System.Windows.Forms.RadioButton();
            this.capacityBox = new System.Windows.Forms.GroupBox();
            this.radioButtonLarge = new System.Windows.Forms.RadioButton();
            this.radioButtonMed = new System.Windows.Forms.RadioButton();
            this.radioButtonSmall = new System.Windows.Forms.RadioButton();
            this.leftMainBox = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.accessoryBox = new System.Windows.Forms.GroupBox();
            this.checkBoxSP = new System.Windows.Forms.CheckBox();
            this.checkBoxLC = new System.Windows.Forms.CheckBox();
            this.checkBoxAPP = new System.Windows.Forms.CheckBox();
            this.costBox = new System.Windows.Forms.GroupBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxTax = new System.Windows.Forms.TextBox();
            this.textBoxSubtotal = new System.Windows.Forms.TextBox();
            this.textBoxTrade = new System.Windows.Forms.TextBox();
            this.textBoxAccessory = new System.Windows.Forms.TextBox();
            this.textBoxBP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCal = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.modelBox.SuspendLayout();
            this.colorBox.SuspendLayout();
            this.capacityBox.SuspendLayout();
            this.leftMainBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.accessoryBox.SuspendLayout();
            this.costBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // modelBox
            // 
            this.modelBox.Controls.Add(this.radioButtonIP6s);
            this.modelBox.Controls.Add(this.radioButtonIP6);
            resources.ApplyResources(this.modelBox, "modelBox");
            this.modelBox.Name = "modelBox";
            this.modelBox.TabStop = false;
            // 
            // radioButtonIP6s
            // 
            resources.ApplyResources(this.radioButtonIP6s, "radioButtonIP6s");
            this.radioButtonIP6s.Name = "radioButtonIP6s";
            this.radioButtonIP6s.UseVisualStyleBackColor = true;
            this.radioButtonIP6s.CheckedChanged += new System.EventHandler(this.radioButtonModel_CheckedChanged);
            // 
            // radioButtonIP6
            // 
            resources.ApplyResources(this.radioButtonIP6, "radioButtonIP6");
            this.radioButtonIP6.Name = "radioButtonIP6";
            this.radioButtonIP6.UseVisualStyleBackColor = true;
            this.radioButtonIP6.CheckedChanged += new System.EventHandler(this.radioButtonModel_CheckedChanged);
            // 
            // colorBox
            // 
            this.colorBox.Controls.Add(this.radioButtonSilver);
            this.colorBox.Controls.Add(this.radioButtonGold);
            this.colorBox.Controls.Add(this.radioButtonGrey);
            resources.ApplyResources(this.colorBox, "colorBox");
            this.colorBox.Name = "colorBox";
            this.colorBox.TabStop = false;
            // 
            // radioButtonSilver
            // 
            resources.ApplyResources(this.radioButtonSilver, "radioButtonSilver");
            this.radioButtonSilver.Name = "radioButtonSilver";
            this.radioButtonSilver.UseVisualStyleBackColor = true;
            this.radioButtonSilver.CheckedChanged += new System.EventHandler(this.radioButtonColor_CheckedChanged);
            // 
            // radioButtonGold
            // 
            resources.ApplyResources(this.radioButtonGold, "radioButtonGold");
            this.radioButtonGold.Name = "radioButtonGold";
            this.radioButtonGold.UseVisualStyleBackColor = true;
            this.radioButtonGold.CheckedChanged += new System.EventHandler(this.radioButtonColor_CheckedChanged);
            // 
            // radioButtonGrey
            // 
            resources.ApplyResources(this.radioButtonGrey, "radioButtonGrey");
            this.radioButtonGrey.Name = "radioButtonGrey";
            this.radioButtonGrey.UseVisualStyleBackColor = true;
            this.radioButtonGrey.CheckedChanged += new System.EventHandler(this.radioButtonColor_CheckedChanged);
            // 
            // capacityBox
            // 
            this.capacityBox.Controls.Add(this.radioButtonLarge);
            this.capacityBox.Controls.Add(this.radioButtonMed);
            this.capacityBox.Controls.Add(this.radioButtonSmall);
            resources.ApplyResources(this.capacityBox, "capacityBox");
            this.capacityBox.Name = "capacityBox";
            this.capacityBox.TabStop = false;
            // 
            // radioButtonLarge
            // 
            resources.ApplyResources(this.radioButtonLarge, "radioButtonLarge");
            this.radioButtonLarge.Name = "radioButtonLarge";
            this.radioButtonLarge.UseVisualStyleBackColor = true;
            this.radioButtonLarge.CheckedChanged += new System.EventHandler(this.radioButtonCapacity_CheckedChanged);
            // 
            // radioButtonMed
            // 
            resources.ApplyResources(this.radioButtonMed, "radioButtonMed");
            this.radioButtonMed.Name = "radioButtonMed";
            this.radioButtonMed.UseVisualStyleBackColor = true;
            this.radioButtonMed.CheckedChanged += new System.EventHandler(this.radioButtonCapacity_CheckedChanged);
            // 
            // radioButtonSmall
            // 
            resources.ApplyResources(this.radioButtonSmall, "radioButtonSmall");
            this.radioButtonSmall.Name = "radioButtonSmall";
            this.radioButtonSmall.UseVisualStyleBackColor = true;
            this.radioButtonSmall.CheckedChanged += new System.EventHandler(this.radioButtonCapacity_CheckedChanged);
            // 
            // leftMainBox
            // 
            this.leftMainBox.Controls.Add(this.pictureBox);
            this.leftMainBox.Controls.Add(this.modelBox);
            this.leftMainBox.Controls.Add(this.capacityBox);
            this.leftMainBox.Controls.Add(this.colorBox);
            resources.ApplyResources(this.leftMainBox, "leftMainBox");
            this.leftMainBox.Name = "leftMainBox";
            this.leftMainBox.TabStop = false;
            // 
            // pictureBox
            // 
            resources.ApplyResources(this.pictureBox, "pictureBox");
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.TabStop = false;
            // 
            // accessoryBox
            // 
            this.accessoryBox.Controls.Add(this.checkBoxSP);
            this.accessoryBox.Controls.Add(this.checkBoxLC);
            this.accessoryBox.Controls.Add(this.checkBoxAPP);
            resources.ApplyResources(this.accessoryBox, "accessoryBox");
            this.accessoryBox.Name = "accessoryBox";
            this.accessoryBox.TabStop = false;
            // 
            // checkBoxSP
            // 
            resources.ApplyResources(this.checkBoxSP, "checkBoxSP");
            this.checkBoxSP.Name = "checkBoxSP";
            this.checkBoxSP.UseVisualStyleBackColor = true;
            this.checkBoxSP.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxLC
            // 
            resources.ApplyResources(this.checkBoxLC, "checkBoxLC");
            this.checkBoxLC.Name = "checkBoxLC";
            this.checkBoxLC.UseVisualStyleBackColor = true;
            this.checkBoxLC.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxAPP
            // 
            resources.ApplyResources(this.checkBoxAPP, "checkBoxAPP");
            this.checkBoxAPP.Name = "checkBoxAPP";
            this.checkBoxAPP.UseVisualStyleBackColor = true;
            this.checkBoxAPP.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // costBox
            // 
            this.costBox.Controls.Add(this.label9);
            this.costBox.Controls.Add(this.label8);
            this.costBox.Controls.Add(this.textBoxTotal);
            this.costBox.Controls.Add(this.textBoxTax);
            this.costBox.Controls.Add(this.textBoxSubtotal);
            this.costBox.Controls.Add(this.textBoxTrade);
            this.costBox.Controls.Add(this.textBoxAccessory);
            this.costBox.Controls.Add(this.textBoxBP);
            this.costBox.Controls.Add(this.label6);
            this.costBox.Controls.Add(this.label5);
            this.costBox.Controls.Add(this.label4);
            this.costBox.Controls.Add(this.label3);
            this.costBox.Controls.Add(this.label2);
            this.costBox.Controls.Add(this.label1);
            resources.ApplyResources(this.costBox, "costBox");
            this.costBox.Name = "costBox";
            this.costBox.TabStop = false;
            // 
            // textBoxTotal
            // 
            resources.ApplyResources(this.textBoxTotal, "textBoxTotal");
            this.textBoxTotal.Name = "textBoxTotal";
            // 
            // textBoxTax
            // 
            resources.ApplyResources(this.textBoxTax, "textBoxTax");
            this.textBoxTax.Name = "textBoxTax";
            // 
            // textBoxSubtotal
            // 
            resources.ApplyResources(this.textBoxSubtotal, "textBoxSubtotal");
            this.textBoxSubtotal.Name = "textBoxSubtotal";
            // 
            // textBoxTrade
            // 
            resources.ApplyResources(this.textBoxTrade, "textBoxTrade");
            this.textBoxTrade.Name = "textBoxTrade";
            this.toolTip1.SetToolTip(this.textBoxTrade, resources.GetString("textBoxTrade.ToolTip"));
            // 
            // textBoxAccessory
            // 
            resources.ApplyResources(this.textBoxAccessory, "textBoxAccessory");
            this.textBoxAccessory.Name = "textBoxAccessory";
            // 
            // textBoxBP
            // 
            resources.ApplyResources(this.textBoxBP, "textBoxBP");
            this.textBoxBP.Name = "textBoxBP";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // buttonCal
            // 
            resources.ApplyResources(this.buttonCal, "buttonCal");
            this.buttonCal.Name = "buttonCal";
            this.buttonCal.UseVisualStyleBackColor = true;
            this.buttonCal.Click += new System.EventHandler(this.buttonCal_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.buttonClear, "buttonClear");
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            resources.ApplyResources(this.buttonExit, "buttonExit");
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // Assignment1
            // 
            this.AcceptButton = this.buttonCal;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClear;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCal);
            this.Controls.Add(this.costBox);
            this.Controls.Add(this.accessoryBox);
            this.Controls.Add(this.leftMainBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Assignment1";
            this.Load += new System.EventHandler(this.Form_Load);
            this.modelBox.ResumeLayout(false);
            this.modelBox.PerformLayout();
            this.colorBox.ResumeLayout(false);
            this.colorBox.PerformLayout();
            this.capacityBox.ResumeLayout(false);
            this.capacityBox.PerformLayout();
            this.leftMainBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.accessoryBox.ResumeLayout(false);
            this.accessoryBox.PerformLayout();
            this.costBox.ResumeLayout(false);
            this.costBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox modelBox;
        private System.Windows.Forms.GroupBox colorBox;
        private System.Windows.Forms.GroupBox capacityBox;
        private System.Windows.Forms.GroupBox leftMainBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox accessoryBox;
        private System.Windows.Forms.GroupBox costBox;
        private System.Windows.Forms.RadioButton radioButtonIP6s;
        private System.Windows.Forms.RadioButton radioButtonIP6;
        private System.Windows.Forms.RadioButton radioButtonSilver;
        private System.Windows.Forms.RadioButton radioButtonGold;
        private System.Windows.Forms.RadioButton radioButtonGrey;
        private System.Windows.Forms.RadioButton radioButtonLarge;
        private System.Windows.Forms.RadioButton radioButtonMed;
        private System.Windows.Forms.RadioButton radioButtonSmall;
        private System.Windows.Forms.Button buttonCal;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.CheckBox checkBoxSP;
        private System.Windows.Forms.CheckBox checkBoxLC;
        private System.Windows.Forms.CheckBox checkBoxAPP;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxTax;
        private System.Windows.Forms.TextBox textBoxSubtotal;
        private System.Windows.Forms.TextBox textBoxTrade;
        private System.Windows.Forms.TextBox textBoxAccessory;
        private System.Windows.Forms.TextBox textBoxBP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}


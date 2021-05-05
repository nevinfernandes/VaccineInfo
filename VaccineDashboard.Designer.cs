namespace VaccineInfo
{
    partial class VaccineDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VaccineDashboard));
            this.pincode = new System.Windows.Forms.TextBox();
            this.label_pincode = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.RichTextBox();
            this.label_vaccineinfo = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pincode
            // 
            this.pincode.AllowDrop = true;
            resources.ApplyResources(this.pincode, "pincode");
            this.pincode.Name = "pincode";
            this.pincode.TextChanged += new System.EventHandler(this.pincode_TextChanged);
            this.pincode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pincode_KeyPress);
            this.pincode.Validating += new System.ComponentModel.CancelEventHandler(this.pincode_Validating);
            // 
            // label_pincode
            // 
            resources.ApplyResources(this.label_pincode, "label_pincode");
            this.label_pincode.Name = "label_pincode";
            // 
            // label_date
            // 
            resources.ApplyResources(this.label_date, "label_date");
            this.label_date.Name = "label_date";
            // 
            // submit
            // 
            resources.ApplyResources(this.submit, "submit");
            this.submit.Name = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Result
            // 
            resources.ApplyResources(this.Result, "Result");
            this.Result.Name = "Result";
            // 
            // label_vaccineinfo
            // 
            resources.ApplyResources(this.label_vaccineinfo, "label_vaccineinfo");
            this.label_vaccineinfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_vaccineinfo.Name = "label_vaccineinfo";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dateTimePicker
            // 
            resources.ApplyResources(this.dateTimePicker, "dateTimePicker");
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Value = new System.DateTime(2021, 5, 5, 0, 0, 0, 0);
            // 
            // Form1
            // 
            this.AcceptButton = this.submit;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label_vaccineinfo);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_pincode);
            this.Controls.Add(this.pincode);
            this.KeyPreview = true;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pincode;
        private System.Windows.Forms.Label label_pincode;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.RichTextBox Result;
        private System.Windows.Forms.Label label_vaccineinfo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}


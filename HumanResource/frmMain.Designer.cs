
namespace HumanResource
{
    partial class frmShowEmployees
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowEmployees));
            this.listEmployees = new System.Windows.Forms.ListView();
            this.colID = new System.Windows.Forms.ColumnHeader();
            this.colFName = new System.Windows.Forms.ColumnHeader();
            this.colLName = new System.Windows.Forms.ColumnHeader();
            this.colMName = new System.Windows.Forms.ColumnHeader();
            this.colPosition = new System.Windows.Forms.ColumnHeader();
            this.colGender = new System.Windows.Forms.ColumnHeader();
            this.colBDate = new System.Windows.Forms.ColumnHeader();
            this.colAddress = new System.Windows.Forms.ColumnHeader();
            this.colTelNo = new System.Windows.Forms.ColumnHeader();
            this.colMobNo = new System.Windows.Forms.ColumnHeader();
            this.colEmailAddress = new System.Windows.Forms.ColumnHeader();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listEmployees
            // 
            this.listEmployees.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listEmployees.AllowColumnReorder = true;
            this.listEmployees.AutoArrange = false;
            this.listEmployees.BackColor = System.Drawing.SystemColors.Window;
            this.listEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colFName,
            this.colLName,
            this.colMName,
            this.colPosition,
            this.colGender,
            this.colBDate,
            this.colAddress,
            this.colTelNo,
            this.colMobNo,
            this.colEmailAddress});
            this.listEmployees.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listEmployees.GridLines = true;
            this.listEmployees.HideSelection = false;
            this.listEmployees.HotTracking = true;
            this.listEmployees.HoverSelection = true;
            this.listEmployees.LabelEdit = true;
            this.listEmployees.Location = new System.Drawing.Point(27, 42);
            this.listEmployees.MultiSelect = false;
            this.listEmployees.Name = "listEmployees";
            this.listEmployees.Size = new System.Drawing.Size(1104, 387);
            this.listEmployees.TabIndex = 0;
            this.listEmployees.UseCompatibleStateImageBehavior = false;
            this.listEmployees.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 30;
            // 
            // colFName
            // 
            this.colFName.Text = "First Name";
            this.colFName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colFName.Width = 95;
            // 
            // colLName
            // 
            this.colLName.Text = "Last Name";
            this.colLName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colLName.Width = 95;
            // 
            // colMName
            // 
            this.colMName.Text = "Middle Name";
            this.colMName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMName.Width = 120;
            // 
            // colPosition
            // 
            this.colPosition.Text = "Position";
            this.colPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPosition.Width = 75;
            // 
            // colGender
            // 
            this.colGender.Text = "Gender";
            this.colGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colGender.Width = 80;
            // 
            // colBDate
            // 
            this.colBDate.Text = "Birth Date";
            this.colBDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colBDate.Width = 90;
            // 
            // colAddress
            // 
            this.colAddress.Text = "Address";
            this.colAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colAddress.Width = 120;
            // 
            // colTelNo
            // 
            this.colTelNo.Text = "Tel Number";
            this.colTelNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTelNo.Width = 120;
            // 
            // colMobNo
            // 
            this.colMobNo.Text = "Mobile No";
            this.colMobNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMobNo.Width = 120;
            // 
            // colEmailAddress
            // 
            this.colEmailAddress.Text = "Email Address";
            this.colEmailAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colEmailAddress.Width = 130;
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Enabled = true;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // frmShowEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1171, 473);
            this.Controls.Add(this.listEmployees);
            this.Name = "frmShowEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Employees";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listEmployees;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colFName;
        private System.Windows.Forms.ColumnHeader colLName;
        private System.Windows.Forms.ColumnHeader colMName;
        private System.Windows.Forms.ColumnHeader colPosition;
        private System.Windows.Forms.ColumnHeader colGender;
        private System.Windows.Forms.ColumnHeader colBDate;
        private System.Windows.Forms.ColumnHeader colAddress;
        private System.Windows.Forms.ColumnHeader colTelNo;
        private System.Windows.Forms.ColumnHeader colMobNo;
        private System.Windows.Forms.ColumnHeader colEmailAddress;
        private System.Windows.Forms.Timer tmrUpdate;
    }
}

